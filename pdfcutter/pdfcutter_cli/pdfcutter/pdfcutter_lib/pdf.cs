using System;
using System.Collections.Generic;
using System.Linq;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace pdfcutter_lib
{
    public class pdf
    {
        private int[] getPagesFromString(string pages)
        {
            var result = new List<int>();
            pages = pages.Trim();
            var comma_splitted_pageGroups = pages.Split(',');
            foreach (var pageGroup in comma_splitted_pageGroups)
            {
                if (!pageGroup.Contains('-'))
                {
                    if (int.TryParse(pageGroup, out var val))
                    {
                        result.Add(val);
                    }
                    continue;
                }

                var minus_splitted_pageGroups = pageGroup.Split('-');
                int startPage = int.Parse(minus_splitted_pageGroups[0]);
                int endPage = int.Parse(minus_splitted_pageGroups[1]);
                if (startPage > endPage)
                {
                    //MessageBox.Show("Wrong formula entered");
                    return result.ToArray();
                }

                for (var i = startPage; i <= endPage; i++)
                {
                    if (i != 0)
                    {
                        result.Add(i - 1);
                    }
                }
            }

            return result.ToArray();
        }

        public bool exportSelectedPages(string inputFile, string pages, string outputFile)
        {
            var path = inputFile;

            if (!System.IO.File.Exists(path))
            {
                return false;
            }

            PdfDocument inputDocument = PdfReader.Open(path, PdfDocumentOpenMode.Import);
            int pageCount = inputDocument.PageCount;

            pages = pages.Trim();
            if (pages.Length == 0)
            {
                return false;
            }

            var pagesNeeded = this.getPagesFromString(pages);
            if (pagesNeeded.Length > pageCount)
            {
                //MessageBox.Show($"Wrong number of pages expected! max: {pageCount}");
                return false;
            }

            PdfDocument outputDocument = new PdfDocument();
            foreach (var pageNumber in pagesNeeded)
            {
                PdfPage page = inputDocument.Pages[pageNumber];
                outputDocument.AddPage(page);
            }

            outputDocument.Save(outputFile);

            return System.IO.File.Exists(outputFile);
        }

    }
}

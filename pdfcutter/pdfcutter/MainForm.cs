using System.IO;
using System.Text;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace pdfcutter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Load pdf file 
            var path = @"D:\BOOK.pdf";

            if (System.IO.File.Exists(path))
            {
                MessageBox.Show("Exists");
            }

            PdfDocument inputDocument=PdfReader.Open(path, PdfDocumentOpenMode.Import);
            int pageCount = inputDocument.PageCount;

            Console.WriteLine($"Splitting pdf with {pageCount} pages");

            var extractcount = 10;

            PdfDocument outputDocument = new PdfDocument();

            for (int i = 0; i < extractcount; i++)
            {

                PdfPage page = inputDocument.Pages[i];
                outputDocument.AddPage(page);
            }

            outputDocument.Save(@"D:\BOOK_new.pdf");
        }
    }
}

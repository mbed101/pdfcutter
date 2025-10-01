using pdfcutter_lib;

namespace pdfcutter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = string.Empty;
            string pages = string.Empty;

            // Process command line args
            try
            {
                for (int i = 0; i < args.Length - 1; i++)
                {
                    string arg = args[i];
                    if (arg == "--help" || arg == "-h")
                    {
                        Console.WriteLine("""
                            
                            -f = file name
                            -p = pages string for example: 1-2,4,5,6-8
                            
                            """);
                        return;
                    }
                    else if (arg == "-f")
                    {
                        fileName = args[i + 1];
                    }
                    else if(arg == "-p")
                    {
                        pages = args[i + 1];
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }
            var fullpath = System.IO.Path.GetFullPath(fileName);
            Console.WriteLine($"Fullpath {fullpath}");

            Console.WriteLine($"filename: {fileName} pages: {pages}");

            pdfcutter_lib.pdf pdf = new pdfcutter_lib.pdf();
            pdf.exportSelectedPages(fileName, pages,fileName+"_out.pdf");
                
        }
    }
}

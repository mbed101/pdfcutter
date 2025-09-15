using System.IO;
using System.Text;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using pdfcutter.src;

namespace pdfcutter
{
    public partial class MainForm : Form
    {
        private string selectedFile="";
        public MainForm()
        {
            InitializeComponent();
            label_splitResult.Text = string.Empty;
        }

        private void btn_fileopen_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog(this);
            var filename = "";
            if (result == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                if (!System.IO.File.Exists(filename))
                {
                    MessageBox.Show($"File {filename} does not exist");
                    return;
                }

                textBox_file.Text = filename;
                this.selectedFile= filename;

                panel_split.Enabled = true;
            }
        }

        private void button_split_Click(object sender, EventArgs e)
        {
            var pdf = new Pdf();
            var newFileName = Path.Combine(Path.GetDirectoryName(this.selectedFile) , Path.GetFileNameWithoutExtension(this.selectedFile))+ "_new.pdf";

            var result = pdf.exportSelectedPages(this.selectedFile, textBox_splitFormula.Text, newFileName);
            if (result)
            {
                MessageBox.Show("Successful");
            }

        }
    }
}

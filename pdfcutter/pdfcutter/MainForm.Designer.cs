namespace pdfcutter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            tabControl1 = new TabControl();
            tabPage_split = new TabPage();
            panel_split = new Panel();
            label_splitResult = new Label();
            button_split = new Button();
            label_splitText = new Label();
            textBox_splitFormula = new TextBox();
            btn_fileopen = new Button();
            label_file = new Label();
            textBox_file = new TextBox();
            tabPage_merge = new TabPage();
            tabControl1.SuspendLayout();
            tabPage_split.SuspendLayout();
            panel_split.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_split);
            tabControl1.Controls.Add(tabPage_merge);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 245);
            tabControl1.TabIndex = 0;
            // 
            // tabPage_split
            // 
            tabPage_split.Controls.Add(panel_split);
            tabPage_split.Controls.Add(btn_fileopen);
            tabPage_split.Controls.Add(label_file);
            tabPage_split.Controls.Add(textBox_file);
            tabPage_split.Location = new Point(4, 24);
            tabPage_split.Name = "tabPage_split";
            tabPage_split.Padding = new Padding(3);
            tabPage_split.Size = new Size(792, 217);
            tabPage_split.TabIndex = 0;
            tabPage_split.Text = "Split";
            tabPage_split.UseVisualStyleBackColor = true;
            // 
            // panel_split
            // 
            panel_split.Controls.Add(label_splitResult);
            panel_split.Controls.Add(button_split);
            panel_split.Controls.Add(label_splitText);
            panel_split.Controls.Add(textBox_splitFormula);
            panel_split.Enabled = false;
            panel_split.Location = new Point(32, 75);
            panel_split.Name = "panel_split";
            panel_split.Size = new Size(701, 98);
            panel_split.TabIndex = 3;
            // 
            // label_splitResult
            // 
            label_splitResult.AutoSize = true;
            label_splitResult.Location = new Point(76, 66);
            label_splitResult.Name = "label_splitResult";
            label_splitResult.Size = new Size(91, 15);
            label_splitResult.TabIndex = 3;
            label_splitResult.Text = "label_splitResult";
            // 
            // button_split
            // 
            button_split.Location = new Point(590, 11);
            button_split.Name = "button_split";
            button_split.Size = new Size(104, 26);
            button_split.TabIndex = 2;
            button_split.Text = "Split";
            button_split.UseVisualStyleBackColor = true;
            button_split.Click += button_split_Click;
            // 
            // label_splitText
            // 
            label_splitText.AutoSize = true;
            label_splitText.Location = new Point(3, 22);
            label_splitText.Name = "label_splitText";
            label_splitText.Size = new Size(51, 15);
            label_splitText.TabIndex = 1;
            label_splitText.Text = "Formula";
            // 
            // textBox_splitFormula
            // 
            textBox_splitFormula.Location = new Point(76, 14);
            textBox_splitFormula.Name = "textBox_splitFormula";
            textBox_splitFormula.PlaceholderText = "Example: 1-10,12-14";
            textBox_splitFormula.Size = new Size(498, 23);
            textBox_splitFormula.TabIndex = 0;
            // 
            // btn_fileopen
            // 
            btn_fileopen.Location = new Point(622, 31);
            btn_fileopen.Name = "btn_fileopen";
            btn_fileopen.Size = new Size(104, 26);
            btn_fileopen.TabIndex = 2;
            btn_fileopen.Text = "Select file";
            btn_fileopen.UseVisualStyleBackColor = true;
            btn_fileopen.Click += btn_fileopen_Click;
            // 
            // label_file
            // 
            label_file.AutoSize = true;
            label_file.Location = new Point(32, 36);
            label_file.Name = "label_file";
            label_file.Size = new Size(25, 15);
            label_file.TabIndex = 1;
            label_file.Text = "File";
            // 
            // textBox_file
            // 
            textBox_file.Location = new Point(108, 31);
            textBox_file.Name = "textBox_file";
            textBox_file.ReadOnly = true;
            textBox_file.Size = new Size(498, 23);
            textBox_file.TabIndex = 0;
            // 
            // tabPage_merge
            // 
            tabPage_merge.Location = new Point(4, 24);
            tabPage_merge.Name = "tabPage_merge";
            tabPage_merge.Padding = new Padding(3);
            tabPage_merge.Size = new Size(792, 217);
            tabPage_merge.TabIndex = 1;
            tabPage_merge.Text = "Merge";
            tabPage_merge.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 245);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Pdfcutter";
            tabControl1.ResumeLayout(false);
            tabPage_split.ResumeLayout(false);
            tabPage_split.PerformLayout();
            panel_split.ResumeLayout(false);
            panel_split.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TabControl tabControl1;
        private TabPage tabPage_split;
        private TabPage tabPage_merge;
        private Label label_file;
        private TextBox textBox_file;
        private Button btn_fileopen;
        private Panel panel_split;
        private Button button_split;
        private Label label_splitText;
        private TextBox textBox_splitFormula;
        private Label label_splitResult;
    }
}

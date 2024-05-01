using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Windows.Forms;
namespace TextToWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string content = txtInput.Text;

            
            if (string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Please enter some content to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Enter the device path
            string filePath = @"C:\Users\Jjav2\OneDrive\Documentos\A. Universidad\2 Semestre\Practicas\TextToWord\dcm.word";

            try
            {
                
                using (WordprocessingDocument wordDocument =
                       WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                {
                    
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    Body body = new Body();

                    
                    Paragraph paragraph = new Paragraph(new Run(new Text(content)));
                    body.Append(paragraph);

                    
                    mainPart.Document.Append(body);
                    mainPart.Document.Save();
                }

                MessageBox.Show("Word file created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

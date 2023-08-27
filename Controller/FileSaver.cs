using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Reflection.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using Document = DocumentFormat.OpenXml.Wordprocessing.Document;
using Body = DocumentFormat.OpenXml.Wordprocessing.Body;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;

namespace OCRFeiraDeCiencias.Controller
{
    internal class FileSaver
    {
        public static void SaveTextToFile(string text)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Word Documents (*.docx)|*.docx";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    if (filePath.EndsWith(".txt"))
                    {
                        System.IO.File.WriteAllText(filePath, text);
                    }
                    else if (filePath.EndsWith(".docx"))
                    {
                        using (WordprocessingDocument document = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                        {
                            MainDocumentPart mainPart = document.AddMainDocumentPart();
                            mainPart.Document = new Document(new Body(new Paragraph(new Run(new Text(text)))));
                            mainPart.Document.Save();
                        }
                    }
                    Console.WriteLine("Arquivo salvo com sucesso em: " + filePath);
                }
            }
        }
    }
}

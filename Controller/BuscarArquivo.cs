using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCRFeiraDeCiencias.Controller
{
    internal class BuscarArquivo
    {
        public string SelectFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JPEG Files (*.jpeg;*.jpg)|*.jpeg;*.jpg|DOCX Files (*.docx)|*.docx|PDF Files (*.pdf)|*.pdf";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    return selectedFilePath;
                }
            }

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace OCRFeiraDeCiencias.Controller
{
    internal class OCRTesseract
    {

        
        public static string PerformOCR(string imagePath, string tessDataPath, string language)
        {
            using (var engine = new TesseractEngine(tessDataPath, language, EngineMode.Default))
            {
                using (var img = Pix.LoadFromFile(imagePath))
                {
                    using (var page = engine.Process(img))
                    {
                        var text = page.GetText();
                        return text;
                    }
                }
            }
        }
    }
}

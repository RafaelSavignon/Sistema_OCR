using OCRFeiraDeCiencias.Controller;

namespace OCRFeiraDeCiencias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string trainerFolderPath = Path.Combine(currentDirectory, "treiner");


            String arquivo;

            BuscarArquivo ba = new BuscarArquivo();
            arquivo = ba.SelectFile();

            pictureBox1.Image = Image.FromFile(arquivo);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            String resultado = OCRTesseract.PerformOCR(arquivo, trainerFolderPath, "por");

            textBox1.Text = resultado;

            //MessageBox.Show(resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String texto = textBox1.Text;

            FileSaver.SaveTextToFile(texto);
        }
    }
}
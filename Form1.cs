using System.Diagnostics;

namespace FirstCNN
{
    public partial class Form1 : Form
    {
        private string MainPathCNN = "C:\\Users\\Desenvolvedor\\Documents\\dev\\C#\\dataset";
        private string CurrentPathImage = "";
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void btnRecognizer_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Carregando...";
            await Task.Delay(300);
            var result = startModelCNN();
            lblResult.Text = result.PredictedLabel;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp|Todos os Arquivos|*.*";
            openFileDialog.Title = "Selecione uma Imagem";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CurrentPathImage = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(CurrentPathImage);
                }
                catch (Exception exc)
                {
                }
            }
        }

        private MLModel1.ModelOutput startModelCNN()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            //Load sample data
            var imageBytes = File.ReadAllBytes(CurrentPathImage);
            MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
            {
                ImageSource = imageBytes,
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);
            watch.Stop();

            System.Diagnostics.Debug.WriteLine(result.PredictedLabel);
            System.Diagnostics.Debug.WriteLine(watch.ElapsedMilliseconds + " ms");

            return result;
        }
    }
}

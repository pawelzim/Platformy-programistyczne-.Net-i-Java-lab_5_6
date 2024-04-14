using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace ImageOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap? originalImg;

        private async void startButton_Click(object sender, EventArgs e)
        {
            if (originalImg == null)
            {
                MessageBox.Show("Nie za³adowano zdjêcia");
                return;
            }

            var actions = new Action[]
            {
                () =>
                {
                    if (grayscaleCheckBox.Checked)
                    {
                        Bitmap img = new Bitmap(originalImg);
                        grayscalePictureBox.Image = ImageProcess.createGrayscale(img);
                    }
                },
                () =>
                {
                    if (negativeCheckBox.Checked)
                    {
                        Bitmap img = new Bitmap(originalImg);
                        negativePictureBox.Image = ImageProcess.createNegative(img);
                    }
                },
                () =>
                {
                    if (mirrorCheckBox.Checked)
                    {
                        Bitmap img = new Bitmap(originalImg);
                        mirrorPictureBox.Image = ImageProcess.createMirror(img);
                    }
                },
                () =>
                {
                    if (threshholdCheckBox.Checked)
                    {
                        Bitmap img = new Bitmap(originalImg);
                        threshholdPictureBox.Image = ImageProcess.createThreshold(img);
                    }
                }
            };

            Parallel.Invoke(actions);
        }

        private void pickFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var file = openFileDialog1.FileName;
            openFileDialog1.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.FilterIndex = 1;
            if (file != null)
            {
                originalImg = new Bitmap(file);
                originalPictureBox.Image = originalImg;

                grayscalePictureBox.Image = null;
                negativePictureBox.Image = null;
                mirrorPictureBox.Image = null;
                threshholdPictureBox.Image = null;
            }
        }
    }
}

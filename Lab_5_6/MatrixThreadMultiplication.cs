using System;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lab_5_6
{
    public partial class MatrixThreadMultiplication : Form
    {
        int counter = 0;
        private int[,]? matrixA;
        private int[,]? matrixB;
        private int[,]? matrixResult;
        public MatrixParallelMultiplication NextForm { get; set; } = null;
        public MatrixThreadMultiplication()
        {
            InitializeComponent();

            startButton.Enabled = false;
            printMatrixButton.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void UpdateTimeTextBox(int size, int nrOfThreads, Stopwatch time)
        {
            timeTextBox.Text += $"{++counter}: rozmiar: {size}, w¹tków: {nrOfThreads}, czas: {time.ElapsedMilliseconds} ms" + Environment.NewLine;
        }

        private void printMatrixButton_Click(object sender, EventArgs e)
        {
            string matricesOutput = Matrix.PrintAllMatrix(matrixA, matrixB, matrixResult);
            if (matricesOutput == null)
            {
                MessageBox.Show("Jedna z macierzy jest pusta");
            }
            else
            {
                outputTextBox.Clear();
                outputTextBox.Text = matricesOutput;
            }
        }
        private async void startButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sizeTextBox.Text) || string.IsNullOrEmpty(threadsTextBox.Text))
            {
                MessageBox.Show("Pusta wartoœæ rozmiaru lub w¹tków");
                return;
            }
            int size = int.Parse(sizeTextBox.Text);
            int threads = int.Parse(threadsTextBox.Text);
            Stopwatch time = new Stopwatch();

            time.Start();

            await Task.Run(() =>
            {
                Matrix matrix = new Matrix(size, threads);
                matrixA = matrix.getMatrixA();
                matrixB = matrix.getMatrixB();
                matrix.StartThread();
                matrixResult = matrix.getResultThread();
            });

            time.Stop();

            UpdateTimeTextBox(size, threads, time);
            printMatrixButton.Enabled = true;
        }

        private void sizeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(sizeTextBox.Text, out int a) && a > 0)
            {
                sizeTextBox.ForeColor = Color.Black;

                startButton.Enabled = true;
            }
            else if (string.IsNullOrEmpty(sizeTextBox.Text) || string.IsNullOrEmpty(threadsTextBox.Text))
            {
                startButton.Enabled = false;
            }
            else
            {
                sizeTextBox.ForeColor = Color.Red;

                startButton.Enabled = false;
            }
        }

        private void threadsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(threadsTextBox.Text, out int liczba) && liczba > 0)
            {
                threadsTextBox.ForeColor = Color.Black;

                startButton.Enabled = true;
            }
            else if (string.IsNullOrEmpty(threadsTextBox.Text))
            {
                startButton.Enabled = false;
            }
            else
            {
                threadsTextBox.ForeColor = Color.Red;

                startButton.Enabled = false;
            }
        }


        private void secondExercise_Click(object sender, EventArgs e)
        {
            this.NextForm = new MatrixParallelMultiplication();
            this.Close();
        }
    }
}

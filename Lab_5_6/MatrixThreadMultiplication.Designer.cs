
namespace Lab_5_6
{
    partial class MatrixThreadMultiplication
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
            sizeTextBox = new TextBox();
            outputTextBox = new TextBox();
            startButton = new Button();
            timeTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            threadsTextBox = new TextBox();
            label3 = new Label();
            printMatrixButton = new Button();
            secondExercise = new Button();
            SuspendLayout();
            // 
            // sizeTextBox
            // 
            sizeTextBox.Font = new Font("Segoe UI", 11F);
            sizeTextBox.Location = new Point(65, 43);
            sizeTextBox.Name = "sizeTextBox";
            sizeTextBox.Size = new Size(84, 32);
            sizeTextBox.TabIndex = 0;
            sizeTextBox.TextChanged += sizeTextBox_TextChanged;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(392, 21);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ReadOnly = true;
            outputTextBox.ScrollBars = ScrollBars.Both;
            outputTextBox.Size = new Size(492, 417);
            outputTextBox.TabIndex = 6;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 11F);
            startButton.Location = new Point(29, 99);
            startButton.Name = "startButton";
            startButton.Size = new Size(143, 65);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click_1;
            // 
            // timeTextBox
            // 
            timeTextBox.Location = new Point(39, 214);
            timeTextBox.Multiline = true;
            timeTextBox.Name = "timeTextBox";
            timeTextBox.ReadOnly = true;
            timeTextBox.ScrollBars = ScrollBars.Vertical;
            timeTextBox.Size = new Size(319, 307);
            timeTextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 4;
            label1.Text = "Rozmiar macierzy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(225, 9);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 5;
            label2.Text = "Ilość wątków";
            // 
            // threadsTextBox
            // 
            threadsTextBox.Font = new Font("Segoe UI", 11F);
            threadsTextBox.Location = new Point(243, 43);
            threadsTextBox.Name = "threadsTextBox";
            threadsTextBox.Size = new Size(84, 32);
            threadsTextBox.TabIndex = 1;
            threadsTextBox.TextChanged += threadsTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(141, 177);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 7;
            label3.Text = "Tabela czasów";
            // 
            // printMatrixButton
            // 
            printMatrixButton.Font = new Font("Segoe UI", 11F);
            printMatrixButton.Location = new Point(215, 99);
            printMatrixButton.Name = "printMatrixButton";
            printMatrixButton.Size = new Size(143, 65);
            printMatrixButton.TabIndex = 3;
            printMatrixButton.Text = "Wyświetl macierze";
            printMatrixButton.UseVisualStyleBackColor = true;
            printMatrixButton.Click += printMatrixButton_Click;
            // 
            // secondExercise
            // 
            secondExercise.Font = new Font("Segoe UI", 11F);
            secondExercise.Location = new Point(709, 466);
            secondExercise.Name = "secondExercise";
            secondExercise.Size = new Size(162, 55);
            secondExercise.TabIndex = 9;
            secondExercise.Text = "Zadanie 2";
            secondExercise.UseVisualStyleBackColor = true;
            secondExercise.Click += secondExercise_Click;
            // 
            // MatrixThreadMultiplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 543);
            Controls.Add(secondExercise);
            Controls.Add(printMatrixButton);
            Controls.Add(label3);
            Controls.Add(threadsTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(timeTextBox);
            Controls.Add(startButton);
            Controls.Add(outputTextBox);
            Controls.Add(sizeTextBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MatrixThreadMultiplication";
            Text = "MatrixThreadMultiplication";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sizeTextBox;
        private TextBox outputTextBox;
        private Button startButton;
        private TextBox timeTextBox;
        private Label label1;
        private Label label2;
        private TextBox threadsTextBox;
        private Label label3;
        private Button printMatrixButton;
        private Button secondExercise;
    }
}

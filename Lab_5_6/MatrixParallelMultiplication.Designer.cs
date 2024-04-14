namespace Lab_5_6
{
    partial class MatrixParallelMultiplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            startButton = new Button();
            sizeTextBox = new TextBox();
            threadsTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            threadTimeTextBox = new TextBox();
            parallelTimeTextBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label6 = new Label();
            label7 = new Label();
            averageTimeThreadTextBox = new TextBox();
            averageTimeParallelTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 5;
            label1.Text = "Rozmiar macierzy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(204, 18);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 6;
            label2.Text = "Ilość wątków";
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 11F);
            startButton.Location = new Point(93, 110);
            startButton.Name = "startButton";
            startButton.Size = new Size(180, 65);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // sizeTextBox
            // 
            sizeTextBox.Font = new Font("Segoe UI", 11F);
            sizeTextBox.Location = new Point(58, 55);
            sizeTextBox.Name = "sizeTextBox";
            sizeTextBox.Size = new Size(84, 32);
            sizeTextBox.TabIndex = 0;
            sizeTextBox.TextChanged += sizeTextBox_TextChanged;
            // 
            // threadsTextBox
            // 
            threadsTextBox.Font = new Font("Segoe UI", 11F);
            threadsTextBox.Location = new Point(217, 55);
            threadsTextBox.Name = "threadsTextBox";
            threadsTextBox.Size = new Size(84, 32);
            threadsTextBox.TabIndex = 1;
            threadsTextBox.TextChanged += threadsTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(367, 18);
            label3.Name = "label3";
            label3.Size = new Size(182, 25);
            label3.TabIndex = 10;
            label3.Text = "Tabela czasu Thread";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(723, 18);
            label4.Name = "label4";
            label4.Size = new Size(185, 25);
            label4.TabIndex = 11;
            label4.Text = "Tabela czasu Parallel";
            // 
            // threadTimeTextBox
            // 
            threadTimeTextBox.Location = new Point(367, 55);
            threadTimeTextBox.Multiline = true;
            threadTimeTextBox.Name = "threadTimeTextBox";
            threadTimeTextBox.ReadOnly = true;
            threadTimeTextBox.ScrollBars = ScrollBars.Vertical;
            threadTimeTextBox.Size = new Size(280, 351);
            threadTimeTextBox.TabIndex = 12;
            // 
            // parallelTimeTextBox
            // 
            parallelTimeTextBox.Location = new Point(723, 55);
            parallelTimeTextBox.Multiline = true;
            parallelTimeTextBox.Name = "parallelTimeTextBox";
            parallelTimeTextBox.ReadOnly = true;
            parallelTimeTextBox.ScrollBars = ScrollBars.Vertical;
            parallelTimeTextBox.Size = new Size(280, 351);
            parallelTimeTextBox.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(84, 204);
            label6.Name = "label6";
            label6.Size = new Size(202, 25);
            label6.TabIndex = 18;
            label6.Text = "Średni czas dla Thread";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(84, 324);
            label7.Name = "label7";
            label7.Size = new Size(205, 25);
            label7.TabIndex = 19;
            label7.Text = "Średni czas dla Parallel";
            // 
            // averageTimeThreadTextBox
            // 
            averageTimeThreadTextBox.Font = new Font("Segoe UI", 11F);
            averageTimeThreadTextBox.Location = new Point(121, 249);
            averageTimeThreadTextBox.Name = "averageTimeThreadTextBox";
            averageTimeThreadTextBox.ReadOnly = true;
            averageTimeThreadTextBox.Size = new Size(125, 32);
            averageTimeThreadTextBox.TabIndex = 20;
            averageTimeThreadTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // averageTimeParallelTextBox
            // 
            averageTimeParallelTextBox.Font = new Font("Segoe UI", 11F);
            averageTimeParallelTextBox.Location = new Point(121, 374);
            averageTimeParallelTextBox.Name = "averageTimeParallelTextBox";
            averageTimeParallelTextBox.ReadOnly = true;
            averageTimeParallelTextBox.Size = new Size(125, 32);
            averageTimeParallelTextBox.TabIndex = 21;
            averageTimeParallelTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // MatrixParallelMultiplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 435);
            Controls.Add(averageTimeParallelTextBox);
            Controls.Add(averageTimeThreadTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(parallelTimeTextBox);
            Controls.Add(threadTimeTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(threadsTextBox);
            Controls.Add(sizeTextBox);
            Controls.Add(startButton);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MatrixParallelMultiplication";
            Text = "MatrixParallelMultiplication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button startButton;
        private TextBox sizeTextBox;
        private TextBox threadsTextBox;
        private Label label3;
        private Label label4;
        private TextBox threadTimeTextBox;
        private TextBox parallelTimeTextBox;
        private ContextMenuStrip contextMenuStrip1;
        private Label label6;
        private Label label7;
        private TextBox averageTimeThreadTextBox;
        private TextBox averageTimeParallelTextBox;
    }
}
namespace ImageOperations
{
    partial class Form1
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
            threshholdPictureBox = new PictureBox();
            grayscalePictureBox = new PictureBox();
            mirrorPictureBox = new PictureBox();
            negativePictureBox = new PictureBox();
            originalPictureBox = new PictureBox();
            startButton = new Button();
            threshholdCheckBox = new CheckBox();
            grayscaleCheckBox = new CheckBox();
            mirrorCheckBox = new CheckBox();
            negativeCheckBox = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            pickFileButton = new Button();
            ((System.ComponentModel.ISupportInitialize)threshholdPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grayscalePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mirrorPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)negativePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).BeginInit();
            SuspendLayout();
            // 
            // threshholdPictureBox
            // 
            threshholdPictureBox.Location = new Point(664, 268);
            threshholdPictureBox.Name = "threshholdPictureBox";
            threshholdPictureBox.Size = new Size(230, 230);
            threshholdPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            threshholdPictureBox.TabIndex = 21;
            threshholdPictureBox.TabStop = false;
            // 
            // grayscalePictureBox
            // 
            grayscalePictureBox.Location = new Point(416, 268);
            grayscalePictureBox.Name = "grayscalePictureBox";
            grayscalePictureBox.Size = new Size(230, 230);
            grayscalePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            grayscalePictureBox.TabIndex = 20;
            grayscalePictureBox.TabStop = false;
            // 
            // mirrorPictureBox
            // 
            mirrorPictureBox.Location = new Point(664, 20);
            mirrorPictureBox.Name = "mirrorPictureBox";
            mirrorPictureBox.Size = new Size(230, 230);
            mirrorPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            mirrorPictureBox.TabIndex = 19;
            mirrorPictureBox.TabStop = false;
            // 
            // negativePictureBox
            // 
            negativePictureBox.Location = new Point(416, 20);
            negativePictureBox.Name = "negativePictureBox";
            negativePictureBox.Size = new Size(230, 230);
            negativePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            negativePictureBox.TabIndex = 18;
            negativePictureBox.TabStop = false;
            // 
            // originalPictureBox
            // 
            originalPictureBox.Location = new Point(12, 72);
            originalPictureBox.Name = "originalPictureBox";
            originalPictureBox.Size = new Size(380, 380);
            originalPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            originalPictureBox.TabIndex = 17;
            originalPictureBox.TabStop = false;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 11F);
            startButton.Location = new Point(714, 536);
            startButton.Name = "startButton";
            startButton.Size = new Size(127, 69);
            startButton.TabIndex = 16;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // threshholdCheckBox
            // 
            threshholdCheckBox.AutoSize = true;
            threshholdCheckBox.Font = new Font("Segoe UI", 11F);
            threshholdCheckBox.Location = new Point(444, 572);
            threshholdCheckBox.Name = "threshholdCheckBox";
            threshholdCheckBox.Size = new Size(135, 29);
            threshholdCheckBox.TabIndex = 15;
            threshholdCheckBox.Text = "Progowanie";
            threshholdCheckBox.UseVisualStyleBackColor = true;
            // 
            // grayscaleCheckBox
            // 
            grayscaleCheckBox.AutoSize = true;
            grayscaleCheckBox.Font = new Font("Segoe UI", 11F);
            grayscaleCheckBox.Location = new Point(217, 572);
            grayscaleCheckBox.Name = "grayscaleCheckBox";
            grayscaleCheckBox.Size = new Size(143, 29);
            grayscaleCheckBox.TabIndex = 14;
            grayscaleCheckBox.Text = "Czarno-białe";
            grayscaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // mirrorCheckBox
            // 
            mirrorCheckBox.AutoSize = true;
            mirrorCheckBox.Font = new Font("Segoe UI", 11F);
            mirrorCheckBox.Location = new Point(444, 526);
            mirrorCheckBox.Name = "mirrorCheckBox";
            mirrorCheckBox.Size = new Size(181, 29);
            mirrorCheckBox.TabIndex = 13;
            mirrorCheckBox.Text = "Odbicie lustrzane";
            mirrorCheckBox.UseVisualStyleBackColor = true;
            // 
            // negativeCheckBox
            // 
            negativeCheckBox.AutoSize = true;
            negativeCheckBox.Font = new Font("Segoe UI", 11F);
            negativeCheckBox.Location = new Point(217, 526);
            negativeCheckBox.Name = "negativeCheckBox";
            negativeCheckBox.Size = new Size(108, 29);
            negativeCheckBox.TabIndex = 12;
            negativeCheckBox.Text = "Negatyw";
            negativeCheckBox.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pickFileButton
            // 
            pickFileButton.Font = new Font("Segoe UI", 11F);
            pickFileButton.Location = new Point(29, 532);
            pickFileButton.Name = "pickFileButton";
            pickFileButton.Size = new Size(127, 69);
            pickFileButton.TabIndex = 22;
            pickFileButton.Text = "Wybierz ";
            pickFileButton.UseVisualStyleBackColor = true;
            pickFileButton.Click += pickFileButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 623);
            Controls.Add(pickFileButton);
            Controls.Add(threshholdPictureBox);
            Controls.Add(grayscalePictureBox);
            Controls.Add(mirrorPictureBox);
            Controls.Add(negativePictureBox);
            Controls.Add(originalPictureBox);
            Controls.Add(startButton);
            Controls.Add(threshholdCheckBox);
            Controls.Add(grayscaleCheckBox);
            Controls.Add(mirrorCheckBox);
            Controls.Add(negativeCheckBox);
            Name = "Form1";
            Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)threshholdPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)grayscalePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mirrorPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)negativePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox threshholdPictureBox;
        private PictureBox grayscalePictureBox;
        private PictureBox mirrorPictureBox;
        private PictureBox negativePictureBox;
        private PictureBox originalPictureBox;
        private Button startButton;
        private CheckBox threshholdCheckBox;
        private CheckBox grayscaleCheckBox;
        private CheckBox mirrorCheckBox;
        private CheckBox negativeCheckBox;
        private OpenFileDialog openFileDialog1;
        private Button pickFileButton;
    }
}

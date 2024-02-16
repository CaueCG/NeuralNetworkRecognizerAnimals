namespace FirstCNN
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnRecognizer = new Button();
            lblResult = new Label();
            btnSelectImage = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(38, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(407, 250);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(541, 12);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 1;
            label1.Text = "Resultado:";
            // 
            // btnRecognizer
            // 
            btnRecognizer.Location = new Point(38, 297);
            btnRecognizer.Name = "btnRecognizer";
            btnRecognizer.Size = new Size(407, 23);
            btnRecognizer.TabIndex = 2;
            btnRecognizer.Text = "Reconhecer animal";
            btnRecognizer.UseVisualStyleBackColor = true;
            btnRecognizer.Click += btnRecognizer_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(541, 63);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 25);
            lblResult.TabIndex = 3;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(38, 268);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(188, 23);
            btnSelectImage.TabIndex = 4;
            btnSelectImage.Text = "Escolher imagem...";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 338);
            Controls.Add(btnSelectImage);
            Controls.Add(lblResult);
            Controls.Add(btnRecognizer);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnRecognizer;
        private Label lblResult;
        private Button btnSelectImage;
        private OpenFileDialog openFileDialog1;
    }
}

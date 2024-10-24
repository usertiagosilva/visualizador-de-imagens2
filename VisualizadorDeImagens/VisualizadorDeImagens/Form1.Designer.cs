namespace VisualizadorDeImagens
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
            btnCarregar = new Button();
            pictureBox = new PictureBox();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(52, 381);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(94, 29);
            btnCarregar.TabIndex = 0;
            btnCarregar.Text = "Carregar";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(508, 333);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(379, 381);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 454);
            Controls.Add(btnLimpar);
            Controls.Add(pictureBox);
            Controls.Add(btnCarregar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCarregar;
        private PictureBox pictureBox;
        private Button btnLimpar;
    }
}

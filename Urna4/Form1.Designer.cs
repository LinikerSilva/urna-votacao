namespace Urna4
{
    partial class Urna
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urna));
            this.statusLabel = new System.Windows.Forms.Label();
            this.whiteButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.nullButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.candidateLabel = new System.Windows.Forms.Label();
            this.candidatePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.statusLabel.Location = new System.Drawing.Point(343, 312);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(437, 75);
            this.statusLabel.TabIndex = 20;
            this.statusLabel.Text = "Insira o Número e Confirme Seu Candidato";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.White;
            this.whiteButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteButton.Location = new System.Drawing.Point(587, 238);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(111, 49);
            this.whiteButton.TabIndex = 19;
            this.whiteButton.Text = "Branco";
            this.whiteButton.UseVisualStyleBackColor = false;
            this.whiteButton.Click += new System.EventHandler(this.whiteButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.LimeGreen;
            this.confirmButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(460, 144);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(189, 60);
            this.confirmButton.TabIndex = 18;
            this.confirmButton.Text = "Confirmar";
            this.confirmButton.UseVisualStyleBackColor = false;
            // 
            // nullButton
            // 
            this.nullButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.nullButton.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nullButton.Location = new System.Drawing.Point(397, 238);
            this.nullButton.Name = "nullButton";
            this.nullButton.Size = new System.Drawing.Size(118, 49);
            this.nullButton.TabIndex = 17;
            this.nullButton.Text = "Nulo";
            this.nullButton.UseVisualStyleBackColor = false;
            this.nullButton.Click += new System.EventHandler(this.nullButton_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextBox.Location = new System.Drawing.Point(383, 34);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(355, 62);
            this.numberTextBox.TabIndex = 16;
            this.numberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
            this.numberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberTextBox_KeyPress);
            // 
            // candidateLabel
            // 
            this.candidateLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidateLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.candidateLabel.Location = new System.Drawing.Point(21, 374);
            this.candidateLabel.Name = "candidateLabel";
            this.candidateLabel.Size = new System.Drawing.Size(303, 43);
            this.candidateLabel.TabIndex = 15;
            this.candidateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // candidatePictureBox
            // 
            this.candidatePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("candidatePictureBox.InitialImage")));
            this.candidatePictureBox.Location = new System.Drawing.Point(21, 34);
            this.candidatePictureBox.Name = "candidatePictureBox";
            this.candidatePictureBox.Size = new System.Drawing.Size(303, 337);
            this.candidatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.candidatePictureBox.TabIndex = 14;
            this.candidatePictureBox.TabStop = false;
            // 
            // Urna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.whiteButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.nullButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.candidateLabel);
            this.Controls.Add(this.candidatePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Urna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urna";
            this.Load += new System.EventHandler(this.Urna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidatePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button nullButton;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label candidateLabel;
        private System.Windows.Forms.PictureBox candidatePictureBox;
    }
}


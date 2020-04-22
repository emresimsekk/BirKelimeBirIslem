namespace word.page
{
    partial class select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(select));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnMySelf = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pcbPowerOff = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPowerOff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(131, 279);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 28);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "SEÇİM YAPINIZ";
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRandom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRandom.Location = new System.Drawing.Point(37, 449);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(336, 50);
            this.btnRandom.TabIndex = 6;
            this.btnRandom.Text = "Sayı ve Kelimeleri Rastgele Belirleyeceğim";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnMySelf
            // 
            this.btnMySelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.btnMySelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMySelf.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMySelf.Location = new System.Drawing.Point(37, 369);
            this.btnMySelf.Name = "btnMySelf";
            this.btnMySelf.Size = new System.Drawing.Size(336, 50);
            this.btnMySelf.TabIndex = 5;
            this.btnMySelf.Text = "Sayı ve Kelimeleri Kendim Belirleyeceğim";
            this.btnMySelf.UseVisualStyleBackColor = false;
            this.btnMySelf.Click += new System.EventHandler(this.btnMySelf_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(168)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Controls.Add(this.pcbPowerOff);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 258);
            this.panel1.TabIndex = 8;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Sitka Text", 20F);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(146, 102);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(114, 49);
            this.lblLogo.TabIndex = 5;
            this.lblLogo.Text = "LOGO";
            // 
            // pcbPowerOff
            // 
            this.pcbPowerOff.Image = ((System.Drawing.Image)(resources.GetObject("pcbPowerOff.Image")));
            this.pcbPowerOff.Location = new System.Drawing.Point(371, 7);
            this.pcbPowerOff.Name = "pcbPowerOff";
            this.pcbPowerOff.Size = new System.Drawing.Size(32, 32);
            this.pcbPowerOff.TabIndex = 2;
            this.pcbPowerOff.TabStop = false;
            // 
            // select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnMySelf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "select";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPowerOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnMySelf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pcbPowerOff;
    }
}
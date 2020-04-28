namespace word.page
{
    partial class randomNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(randomNumber));
            this.lblMySelfResult = new System.Windows.Forms.Label();
            this.btnRandomStart = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblRandomTitle = new System.Windows.Forms.Label();
            this.lwNumberList = new System.Windows.Forms.ListView();
            this.lblJokerTitle = new System.Windows.Forms.Label();
            this.islem1 = new System.Windows.Forms.Label();
            this.islem2 = new System.Windows.Forms.Label();
            this.islem3 = new System.Windows.Forms.Label();
            this.islem4 = new System.Windows.Forms.Label();
            this.islem5 = new System.Windows.Forms.Label();
            this.pcbPowerOff = new System.Windows.Forms.PictureBox();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPowerOff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMySelfResult
            // 
            this.lblMySelfResult.AutoSize = true;
            this.lblMySelfResult.Font = new System.Drawing.Font("Sitka Text", 9F);
            this.lblMySelfResult.ForeColor = System.Drawing.Color.DimGray;
            this.lblMySelfResult.Location = new System.Drawing.Point(589, 105);
            this.lblMySelfResult.Name = "lblMySelfResult";
            this.lblMySelfResult.Size = new System.Drawing.Size(60, 21);
            this.lblMySelfResult.TabIndex = 31;
            this.lblMySelfResult.Text = "Sonuç :";
            // 
            // btnRandomStart
            // 
            this.btnRandomStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.btnRandomStart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRandomStart.Location = new System.Drawing.Point(83, 334);
            this.btnRandomStart.Name = "btnRandomStart";
            this.btnRandomStart.Size = new System.Drawing.Size(157, 60);
            this.btnRandomStart.TabIndex = 30;
            this.btnRandomStart.Text = "Sonuç Bul";
            this.btnRandomStart.UseVisualStyleBackColor = false;
            this.btnRandomStart.Click += new System.EventHandler(this.btnRandomStart_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(168)))), ((int)(((byte)(218)))));
            this.panel13.Controls.Add(this.pcbPowerOff);
            this.panel13.Controls.Add(this.lblRandomTitle);
            this.panel13.Controls.Add(this.lblMySelfResult);
            this.panel13.Controls.Add(this.lwNumberList);
            this.panel13.Controls.Add(this.lblJokerTitle);
            this.panel13.ForeColor = System.Drawing.Color.DimGray;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(800, 255);
            this.panel13.TabIndex = 29;
            // 
            // lblRandomTitle
            // 
            this.lblRandomTitle.AutoSize = true;
            this.lblRandomTitle.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRandomTitle.Location = new System.Drawing.Point(100, 55);
            this.lblRandomTitle.Name = "lblRandomTitle";
            this.lblRandomTitle.Size = new System.Drawing.Size(79, 24);
            this.lblRandomTitle.TabIndex = 1;
            this.lblRandomTitle.Text = "SAYILAR";
            // 
            // lwNumberList
            // 
            this.lwNumberList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(168)))), ((int)(((byte)(218)))));
            this.lwNumberList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lwNumberList.ForeColor = System.Drawing.Color.White;
            this.lwNumberList.HideSelection = false;
            this.lwNumberList.Location = new System.Drawing.Point(83, 105);
            this.lwNumberList.Name = "lwNumberList";
            this.lwNumberList.Size = new System.Drawing.Size(469, 47);
            this.lwNumberList.TabIndex = 0;
            this.lwNumberList.UseCompatibleStateImageBehavior = false;
            // 
            // lblJokerTitle
            // 
            this.lblJokerTitle.AutoSize = true;
            this.lblJokerTitle.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblJokerTitle.Location = new System.Drawing.Point(589, 55);
            this.lblJokerTitle.Name = "lblJokerTitle";
            this.lblJokerTitle.Size = new System.Drawing.Size(68, 24);
            this.lblJokerTitle.TabIndex = 2;
            this.lblJokerTitle.Text = "SONUÇ";
            // 
            // islem1
            // 
            this.islem1.AutoSize = true;
            this.islem1.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islem1.ForeColor = System.Drawing.Color.DimGray;
            this.islem1.Location = new System.Drawing.Point(452, 325);
            this.islem1.Name = "islem1";
            this.islem1.Size = new System.Drawing.Size(64, 21);
            this.islem1.TabIndex = 33;
            this.islem1.Text = "1.İşlem ";
            this.islem1.Visible = false;
            // 
            // islem2
            // 
            this.islem2.AutoSize = true;
            this.islem2.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islem2.ForeColor = System.Drawing.Color.DimGray;
            this.islem2.Location = new System.Drawing.Point(452, 363);
            this.islem2.Name = "islem2";
            this.islem2.Size = new System.Drawing.Size(66, 21);
            this.islem2.TabIndex = 34;
            this.islem2.Text = "2.İşlem ";
            this.islem2.Visible = false;
            // 
            // islem3
            // 
            this.islem3.AutoSize = true;
            this.islem3.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islem3.ForeColor = System.Drawing.Color.DimGray;
            this.islem3.Location = new System.Drawing.Point(452, 403);
            this.islem3.Name = "islem3";
            this.islem3.Size = new System.Drawing.Size(65, 21);
            this.islem3.TabIndex = 35;
            this.islem3.Text = "3.İşlem ";
            this.islem3.Visible = false;
            // 
            // islem4
            // 
            this.islem4.AutoSize = true;
            this.islem4.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islem4.ForeColor = System.Drawing.Color.DimGray;
            this.islem4.Location = new System.Drawing.Point(452, 447);
            this.islem4.Name = "islem4";
            this.islem4.Size = new System.Drawing.Size(66, 21);
            this.islem4.TabIndex = 36;
            this.islem4.Text = "4.İşlem ";
            this.islem4.Visible = false;
            // 
            // islem5
            // 
            this.islem5.AutoSize = true;
            this.islem5.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islem5.ForeColor = System.Drawing.Color.DimGray;
            this.islem5.Location = new System.Drawing.Point(452, 486);
            this.islem5.Name = "islem5";
            this.islem5.Size = new System.Drawing.Size(65, 21);
            this.islem5.TabIndex = 37;
            this.islem5.Text = "5.İşlem ";
            this.islem5.Visible = false;
            // 
            // pcbPowerOff
            // 
            this.pcbPowerOff.Image = ((System.Drawing.Image)(resources.GetObject("pcbPowerOff.Image")));
            this.pcbPowerOff.Location = new System.Drawing.Point(763, 3);
            this.pcbPowerOff.Name = "pcbPowerOff";
            this.pcbPowerOff.Size = new System.Drawing.Size(32, 32);
            this.pcbPowerOff.TabIndex = 38;
            this.pcbPowerOff.TabStop = false;
            this.pcbPowerOff.Click += new System.EventHandler(this.pcbPowerOff_Click);
            // 
            // randomNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.islem5);
            this.Controls.Add(this.islem4);
            this.Controls.Add(this.islem3);
            this.Controls.Add(this.islem2);
            this.Controls.Add(this.islem1);
            this.Controls.Add(this.btnRandomStart);
            this.Controls.Add(this.panel13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "randomNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "randomNumber";
            this.Load += new System.EventHandler(this.randomNumber_Load);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPowerOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMySelfResult;
        private System.Windows.Forms.Button btnRandomStart;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblRandomTitle;
        private System.Windows.Forms.ListView lwNumberList;
        private System.Windows.Forms.Label lblJokerTitle;
        private System.Windows.Forms.Label islem1;
        private System.Windows.Forms.Label islem2;
        private System.Windows.Forms.Label islem3;
        private System.Windows.Forms.Label islem4;
        private System.Windows.Forms.Label islem5;
        private System.Windows.Forms.PictureBox pcbPowerOff;
    }
}
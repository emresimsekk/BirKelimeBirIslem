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
            this.lblMySelfPoint = new System.Windows.Forms.Label();
            this.lblMySelfResult = new System.Windows.Forms.Label();
            this.btnRandomStart = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblRandomTitle = new System.Windows.Forms.Label();
            this.lwNumberList = new System.Windows.Forms.ListView();
            this.lblJokerTitle = new System.Windows.Forms.Label();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMySelfPoint
            // 
            this.lblMySelfPoint.AutoSize = true;
            this.lblMySelfPoint.Font = new System.Drawing.Font("Sitka Text", 9F);
            this.lblMySelfPoint.ForeColor = System.Drawing.Color.DimGray;
            this.lblMySelfPoint.Location = new System.Drawing.Point(457, 373);
            this.lblMySelfPoint.Name = "lblMySelfPoint";
            this.lblMySelfPoint.Size = new System.Drawing.Size(54, 21);
            this.lblMySelfPoint.TabIndex = 32;
            this.lblMySelfPoint.Text = "Puan :";
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
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(168)))), ((int)(((byte)(218)))));
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
            // randomNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.lblMySelfPoint);
            this.Controls.Add(this.btnRandomStart);
            this.Controls.Add(this.panel13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "randomNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "randomNumber";
            this.Load += new System.EventHandler(this.randomNumber_Load);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMySelfPoint;
        private System.Windows.Forms.Label lblMySelfResult;
        private System.Windows.Forms.Button btnRandomStart;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblRandomTitle;
        private System.Windows.Forms.ListView lwNumberList;
        private System.Windows.Forms.Label lblJokerTitle;
    }
}
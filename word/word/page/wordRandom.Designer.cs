namespace word.page
{
    partial class wordRandom
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
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblRandomTitle = new System.Windows.Forms.Label();
            this.txtJokerWord = new System.Windows.Forms.TextBox();
            this.lwWordList = new System.Windows.Forms.ListView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblJokerTitle = new System.Windows.Forms.Label();
            this.lblMySelfPoint = new System.Windows.Forms.Label();
            this.lblMySelfResult = new System.Windows.Forms.Label();
            this.btnRandomStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(168)))), ((int)(((byte)(218)))));
            this.panel13.Controls.Add(this.lblRandomTitle);
            this.panel13.Controls.Add(this.txtJokerWord);
            this.panel13.Controls.Add(this.lwWordList);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Controls.Add(this.lblJokerTitle);
            this.panel13.ForeColor = System.Drawing.Color.DimGray;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(800, 255);
            this.panel13.TabIndex = 8;
            // 
            // lblRandomTitle
            // 
            this.lblRandomTitle.AutoSize = true;
            this.lblRandomTitle.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRandomTitle.Location = new System.Drawing.Point(100, 55);
            this.lblRandomTitle.Name = "lblRandomTitle";
            this.lblRandomTitle.Size = new System.Drawing.Size(87, 24);
            this.lblRandomTitle.TabIndex = 1;
            this.lblRandomTitle.Text = "HARFLER";
            // 
            // txtJokerWord
            // 
            this.txtJokerWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(168)))), ((int)(((byte)(218)))));
            this.txtJokerWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJokerWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJokerWord.ForeColor = System.Drawing.Color.White;
            this.txtJokerWord.Location = new System.Drawing.Point(618, 106);
            this.txtJokerWord.MaxLength = 1;
            this.txtJokerWord.Name = "txtJokerWord";
            this.txtJokerWord.Size = new System.Drawing.Size(22, 15);
            this.txtJokerWord.TabIndex = 6;
            this.txtJokerWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lwWordList
            // 
            this.lwWordList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(168)))), ((int)(((byte)(218)))));
            this.lwWordList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lwWordList.ForeColor = System.Drawing.Color.White;
            this.lwWordList.HideSelection = false;
            this.lwWordList.Location = new System.Drawing.Point(83, 105);
            this.lwWordList.Name = "lwWordList";
            this.lwWordList.Size = new System.Drawing.Size(469, 47);
            this.lwWordList.TabIndex = 0;
            this.lwWordList.UseCompatibleStateImageBehavior = false;
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Location = new System.Drawing.Point(618, 124);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(22, 1);
            this.panel14.TabIndex = 5;
            // 
            // lblJokerTitle
            // 
            this.lblJokerTitle.AutoSize = true;
            this.lblJokerTitle.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblJokerTitle.Location = new System.Drawing.Point(589, 55);
            this.lblJokerTitle.Name = "lblJokerTitle";
            this.lblJokerTitle.Size = new System.Drawing.Size(111, 24);
            this.lblJokerTitle.TabIndex = 2;
            this.lblJokerTitle.Text = "JOKER HARF";
            // 
            // lblMySelfPoint
            // 
            this.lblMySelfPoint.AutoSize = true;
            this.lblMySelfPoint.Font = new System.Drawing.Font("Sitka Text", 9F);
            this.lblMySelfPoint.ForeColor = System.Drawing.Color.DimGray;
            this.lblMySelfPoint.Location = new System.Drawing.Point(457, 371);
            this.lblMySelfPoint.Name = "lblMySelfPoint";
            this.lblMySelfPoint.Size = new System.Drawing.Size(54, 21);
            this.lblMySelfPoint.TabIndex = 27;
            this.lblMySelfPoint.Text = "Puan :";
            // 
            // lblMySelfResult
            // 
            this.lblMySelfResult.AutoSize = true;
            this.lblMySelfResult.Font = new System.Drawing.Font("Sitka Text", 9F);
            this.lblMySelfResult.ForeColor = System.Drawing.Color.DimGray;
            this.lblMySelfResult.Location = new System.Drawing.Point(457, 332);
            this.lblMySelfResult.Name = "lblMySelfResult";
            this.lblMySelfResult.Size = new System.Drawing.Size(125, 21);
            this.lblMySelfResult.TabIndex = 26;
            this.lblMySelfResult.Text = "Eşleşen Kelime :";
            // 
            // btnRandomStart
            // 
            this.btnRandomStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.btnRandomStart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRandomStart.Location = new System.Drawing.Point(83, 332);
            this.btnRandomStart.Name = "btnRandomStart";
            this.btnRandomStart.Size = new System.Drawing.Size(157, 60);
            this.btnRandomStart.TabIndex = 25;
            this.btnRandomStart.Text = "Kelime Bul";
            this.btnRandomStart.UseVisualStyleBackColor = false;
            this.btnRandomStart.Click += new System.EventHandler(this.btnRandomStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(663, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 28;
            this.textBox1.Visible = false;
            // 
            // wordRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMySelfPoint);
            this.Controls.Add(this.lblMySelfResult);
            this.Controls.Add(this.btnRandomStart);
            this.Controls.Add(this.panel13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "wordRandom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wordRandom";
            this.Load += new System.EventHandler(this.wordRandom_Load);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblRandomTitle;
        private System.Windows.Forms.TextBox txtJokerWord;
        private System.Windows.Forms.ListView lwWordList;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblJokerTitle;
        private System.Windows.Forms.Label lblMySelfPoint;
        private System.Windows.Forms.Label lblMySelfResult;
        private System.Windows.Forms.Button btnRandomStart;
        private System.Windows.Forms.TextBox textBox1;
    }
}
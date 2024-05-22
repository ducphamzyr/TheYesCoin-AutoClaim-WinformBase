namespace theYesCoinClaim
{
    partial class AddingForm
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
            this.idTxt = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.tokenLabel = new System.Windows.Forms.Label();
            this.tokenTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idTxt
            // 
            this.idTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTxt.Location = new System.Drawing.Point(55, 12);
            this.idTxt.MaxLength = 5;
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(245, 22);
            this.idTxt.TabIndex = 0;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(29, 15);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(20, 16);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên";
            // 
            // nameTxt
            // 
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTxt.Location = new System.Drawing.Point(55, 62);
            this.nameTxt.MaxLength = 37280;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(245, 22);
            this.nameTxt.TabIndex = 2;
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.Location = new System.Drawing.Point(3, 109);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(46, 16);
            this.tokenLabel.TabIndex = 5;
            this.tokenLabel.Text = "Token";
            // 
            // tokenTxt
            // 
            this.tokenTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tokenTxt.Location = new System.Drawing.Point(55, 103);
            this.tokenTxt.MaxLength = 37280;
            this.tokenTxt.Multiline = true;
            this.tokenTxt.Name = "tokenTxt";
            this.tokenTxt.Size = new System.Drawing.Size(245, 131);
            this.tokenTxt.TabIndex = 4;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(103, 250);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(131, 47);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Thêm tài khoản";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(322, 314);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.tokenLabel);
            this.Controls.Add(this.tokenTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label tokenLabel;
        private System.Windows.Forms.TextBox tokenTxt;
        private System.Windows.Forms.Button addBtn;
    }
}
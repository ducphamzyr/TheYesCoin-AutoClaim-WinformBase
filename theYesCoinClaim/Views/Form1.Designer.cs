namespace theYesCoinClaim
{
    partial class Main
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
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.runAllBtn = new System.Windows.Forms.Button();
            this.stopAllBtn = new System.Windows.Forms.Button();
            this.dataShow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataShow)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(657, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(131, 47);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Thêm tài khoản";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(657, 79);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(131, 47);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Xoá tài khoản";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // runAllBtn
            // 
            this.runAllBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.runAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runAllBtn.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runAllBtn.Location = new System.Drawing.Point(657, 143);
            this.runAllBtn.Name = "runAllBtn";
            this.runAllBtn.Size = new System.Drawing.Size(131, 47);
            this.runAllBtn.TabIndex = 3;
            this.runAllBtn.Text = "Chạy toàn bộ";
            this.runAllBtn.UseVisualStyleBackColor = false;
            this.runAllBtn.Click += new System.EventHandler(this.runAllBtn_Click);
            // 
            // stopAllBtn
            // 
            this.stopAllBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.stopAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopAllBtn.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopAllBtn.Location = new System.Drawing.Point(657, 208);
            this.stopAllBtn.Name = "stopAllBtn";
            this.stopAllBtn.Size = new System.Drawing.Size(131, 47);
            this.stopAllBtn.TabIndex = 4;
            this.stopAllBtn.Text = "Dừng toàn bộ";
            this.stopAllBtn.UseVisualStyleBackColor = false;
            // 
            // dataShow
            // 
            this.dataShow.AllowUserToAddRows = false;
            this.dataShow.AllowUserToDeleteRows = false;
            this.dataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShow.Location = new System.Drawing.Point(12, 12);
            this.dataShow.Name = "dataShow";
            this.dataShow.ReadOnly = true;
            this.dataShow.RowHeadersWidth = 51;
            this.dataShow.RowTemplate.Height = 24;
            this.dataShow.Size = new System.Drawing.Size(627, 426);
            this.dataShow.TabIndex = 5;
            this.dataShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataShow_CellClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataShow);
            this.Controls.Add(this.stopAllBtn);
            this.Controls.Add(this.runAllBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "theYesCoin";
            ((System.ComponentModel.ISupportInitialize)(this.dataShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button runAllBtn;
        private System.Windows.Forms.Button stopAllBtn;
        private System.Windows.Forms.DataGridView dataShow;
    }
}


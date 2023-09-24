namespace WF_H_004_DBMS
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.formBody = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.ListBox();
            this.leftMenu = new System.Windows.Forms.Panel();
            this.leftMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // formBody
            // 
            this.formBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.formBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formBody.Location = new System.Drawing.Point(203, 12);
            this.formBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formBody.Name = "formBody";
            this.formBody.Size = new System.Drawing.Size(1193, 678);
            this.formBody.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.FormattingEnabled = true;
            this.menu.ItemHeight = 25;
            this.menu.Items.AddRange(new object[] {
            "Booth",
            "Member",
            "SalesOrder",
            "SalesOrderDetail",
            "Product",
            "Staff"});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(176, 690);
            this.menu.TabIndex = 0;
            this.menu.SelectedIndexChanged += new System.EventHandler(this.menu_SelectedIndexChanged);
            // 
            // leftMenu
            // 
            this.leftMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftMenu.Controls.Add(this.menu);
            this.leftMenu.Location = new System.Drawing.Point(12, 12);
            this.leftMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftMenu.Name = "leftMenu";
            this.leftMenu.Size = new System.Drawing.Size(178, 692);
            this.leftMenu.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1432, 703);
            this.Controls.Add(this.formBody);
            this.Controls.Add(this.leftMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1091, 586);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "資料庫管理系統";
            this.leftMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel formBody;
        private System.Windows.Forms.ListBox menu;
        private System.Windows.Forms.Panel leftMenu;
    }
}


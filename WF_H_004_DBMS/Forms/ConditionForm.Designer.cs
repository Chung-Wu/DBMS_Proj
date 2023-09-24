namespace WF_H_004_DBMS.Forms
{
    partial class ConditionForm
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
            this.cbbAction = new System.Windows.Forms.ComboBox();
            this.gridSql = new System.Windows.Forms.DataGridView();
            this.SIsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SColFunc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridWhere = new System.Windows.Forms.DataGridView();
            this.WIsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WColCond = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.WColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridGroupBy = new System.Windows.Forms.DataGridView();
            this.GIsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridHaving = new System.Windows.Forms.DataGridView();
            this.HIsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HColFunc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HColCond = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblWhere = new System.Windows.Forms.Label();
            this.lblGroupBy = new System.Windows.Forms.Label();
            this.lblHaving = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSql = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSql = new System.Windows.Forms.Panel();
            this.pnlWhere = new System.Windows.Forms.Panel();
            this.pnlGroupBy = new System.Windows.Forms.Panel();
            this.pnlHaving = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridSql)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWhere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHaving)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlSql.SuspendLayout();
            this.pnlWhere.SuspendLayout();
            this.pnlGroupBy.SuspendLayout();
            this.pnlHaving.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbAction
            // 
            this.cbbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAction.FormattingEnabled = true;
            this.cbbAction.Items.AddRange(new object[] {
            "SELECT",
            "DELETE",
            "INSERT",
            "UPDATE",
            "EXISTS",
            "NOT EXISTS"});
            this.cbbAction.Location = new System.Drawing.Point(190, 32);
            this.cbbAction.Name = "cbbAction";
            this.cbbAction.Size = new System.Drawing.Size(121, 23);
            this.cbbAction.TabIndex = 0;
            this.cbbAction.SelectedIndexChanged += new System.EventHandler(this.cbbAction_SelectedIndexChanged);
            // 
            // gridSql
            // 
            this.gridSql.AllowUserToAddRows = false;
            this.gridSql.AllowUserToDeleteRows = false;
            this.gridSql.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridSql.ColumnHeadersHeight = 26;
            this.gridSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSql.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SIsChecked,
            this.SColFunc,
            this.SColName,
            this.SColValue});
            this.gridSql.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridSql.Location = new System.Drawing.Point(190, 11);
            this.gridSql.Name = "gridSql";
            this.gridSql.RowHeadersWidth = 5;
            this.gridSql.RowTemplate.Height = 27;
            this.gridSql.Size = new System.Drawing.Size(673, 170);
            this.gridSql.TabIndex = 17;
            this.gridSql.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSql_CellClick);
            this.gridSql.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSql_CellEndEdit);
            // 
            // SIsChecked
            // 
            this.SIsChecked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SIsChecked.FalseValue = "false";
            this.SIsChecked.HeaderText = "";
            this.SIsChecked.MinimumWidth = 25;
            this.SIsChecked.Name = "SIsChecked";
            this.SIsChecked.TrueValue = "true";
            this.SIsChecked.Visible = false;
            this.SIsChecked.Width = 25;
            // 
            // SColFunc
            // 
            this.SColFunc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SColFunc.HeaderText = "函式";
            this.SColFunc.Items.AddRange(new object[] {
            "",
            "COUNT",
            "SUM",
            "MAX",
            "MIN",
            "AVG"});
            this.SColFunc.MinimumWidth = 100;
            this.SColFunc.Name = "SColFunc";
            this.SColFunc.Visible = false;
            this.SColFunc.Width = 150;
            // 
            // SColName
            // 
            this.SColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SColName.HeaderText = "欄位";
            this.SColName.MinimumWidth = 150;
            this.SColName.Name = "SColName";
            this.SColName.ReadOnly = true;
            this.SColName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SColName.Visible = false;
            this.SColName.Width = 150;
            // 
            // SColValue
            // 
            this.SColValue.HeaderText = "值";
            this.SColValue.MinimumWidth = 250;
            this.SColValue.Name = "SColValue";
            this.SColValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SColValue.Visible = false;
            this.SColValue.Width = 250;
            // 
            // gridWhere
            // 
            this.gridWhere.AllowUserToAddRows = false;
            this.gridWhere.AllowUserToDeleteRows = false;
            this.gridWhere.ColumnHeadersHeight = 26;
            this.gridWhere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridWhere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WIsChecked,
            this.WColName,
            this.WColCond,
            this.WColValue});
            this.gridWhere.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridWhere.Location = new System.Drawing.Point(190, 3);
            this.gridWhere.Name = "gridWhere";
            this.gridWhere.RowHeadersWidth = 5;
            this.gridWhere.RowTemplate.Height = 27;
            this.gridWhere.Size = new System.Drawing.Size(673, 168);
            this.gridWhere.TabIndex = 18;
            this.gridWhere.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridWhere_CellClick);
            // 
            // WIsChecked
            // 
            this.WIsChecked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WIsChecked.FalseValue = "false";
            this.WIsChecked.HeaderText = "";
            this.WIsChecked.MinimumWidth = 25;
            this.WIsChecked.Name = "WIsChecked";
            this.WIsChecked.TrueValue = "true";
            this.WIsChecked.Visible = false;
            this.WIsChecked.Width = 25;
            // 
            // WColName
            // 
            this.WColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WColName.HeaderText = "欄位";
            this.WColName.MinimumWidth = 150;
            this.WColName.Name = "WColName";
            this.WColName.ReadOnly = true;
            this.WColName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WColName.Visible = false;
            this.WColName.Width = 150;
            // 
            // WColCond
            // 
            this.WColCond.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WColCond.HeaderText = "條件";
            this.WColCond.Items.AddRange(new object[] {
            "=",
            ">",
            ">=",
            "<",
            "<=",
            "<>",
            "IN",
            "NOT IN"});
            this.WColCond.MinimumWidth = 80;
            this.WColCond.Name = "WColCond";
            this.WColCond.Visible = false;
            this.WColCond.Width = 80;
            // 
            // WColValue
            // 
            this.WColValue.HeaderText = "值";
            this.WColValue.MinimumWidth = 250;
            this.WColValue.Name = "WColValue";
            this.WColValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WColValue.Visible = false;
            this.WColValue.Width = 250;
            // 
            // gridGroupBy
            // 
            this.gridGroupBy.AllowUserToAddRows = false;
            this.gridGroupBy.AllowUserToDeleteRows = false;
            this.gridGroupBy.ColumnHeadersHeight = 26;
            this.gridGroupBy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridGroupBy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GIsChecked,
            this.GColName});
            this.gridGroupBy.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridGroupBy.Location = new System.Drawing.Point(190, 2);
            this.gridGroupBy.Name = "gridGroupBy";
            this.gridGroupBy.RowHeadersWidth = 5;
            this.gridGroupBy.RowTemplate.Height = 27;
            this.gridGroupBy.Size = new System.Drawing.Size(298, 152);
            this.gridGroupBy.TabIndex = 19;
            this.gridGroupBy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridGroupBy_CellClick);
            // 
            // GIsChecked
            // 
            this.GIsChecked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GIsChecked.FalseValue = "false";
            this.GIsChecked.HeaderText = "";
            this.GIsChecked.MinimumWidth = 25;
            this.GIsChecked.Name = "GIsChecked";
            this.GIsChecked.TrueValue = "true";
            this.GIsChecked.Visible = false;
            this.GIsChecked.Width = 25;
            // 
            // GColName
            // 
            this.GColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GColName.HeaderText = "欄位";
            this.GColName.MinimumWidth = 150;
            this.GColName.Name = "GColName";
            this.GColName.ReadOnly = true;
            this.GColName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GColName.Visible = false;
            this.GColName.Width = 150;
            // 
            // gridHaving
            // 
            this.gridHaving.AllowUserToAddRows = false;
            this.gridHaving.AllowUserToDeleteRows = false;
            this.gridHaving.ColumnHeadersHeight = 26;
            this.gridHaving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridHaving.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HIsChecked,
            this.HColFunc,
            this.HColName,
            this.HColCond,
            this.HColValue});
            this.gridHaving.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridHaving.Location = new System.Drawing.Point(190, 6);
            this.gridHaving.Name = "gridHaving";
            this.gridHaving.RowHeadersWidth = 5;
            this.gridHaving.RowTemplate.Height = 27;
            this.gridHaving.Size = new System.Drawing.Size(797, 180);
            this.gridHaving.TabIndex = 20;
            this.gridHaving.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHaving_CellClick);
            // 
            // HIsChecked
            // 
            this.HIsChecked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HIsChecked.FalseValue = "false";
            this.HIsChecked.HeaderText = "";
            this.HIsChecked.MinimumWidth = 25;
            this.HIsChecked.Name = "HIsChecked";
            this.HIsChecked.TrueValue = "true";
            this.HIsChecked.Visible = false;
            this.HIsChecked.Width = 25;
            // 
            // HColFunc
            // 
            this.HColFunc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HColFunc.HeaderText = "函式";
            this.HColFunc.Items.AddRange(new object[] {
            "COUNT",
            "SUM",
            "MAX",
            "MIN",
            "AVG"});
            this.HColFunc.MinimumWidth = 100;
            this.HColFunc.Name = "HColFunc";
            this.HColFunc.Visible = false;
            // 
            // HColName
            // 
            this.HColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HColName.HeaderText = "欄位";
            this.HColName.MinimumWidth = 150;
            this.HColName.Name = "HColName";
            this.HColName.ReadOnly = true;
            this.HColName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HColName.Visible = false;
            this.HColName.Width = 150;
            // 
            // HColCond
            // 
            this.HColCond.HeaderText = "條件";
            this.HColCond.Items.AddRange(new object[] {
            "=",
            ">",
            ">=",
            "<",
            "<=",
            "<>",
            "IN",
            "NOT IN"});
            this.HColCond.MinimumWidth = 80;
            this.HColCond.Name = "HColCond";
            this.HColCond.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HColCond.Visible = false;
            this.HColCond.Width = 80;
            // 
            // HColValue
            // 
            this.HColValue.HeaderText = "值";
            this.HColValue.MinimumWidth = 250;
            this.HColValue.Name = "HColValue";
            this.HColValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HColValue.Visible = false;
            this.HColValue.Width = 250;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(190, 788);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 43);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Text = "確認";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(308, 788);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 43);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblWhere
            // 
            this.lblWhere.AutoSize = true;
            this.lblWhere.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWhere.Location = new System.Drawing.Point(118, 3);
            this.lblWhere.Name = "lblWhere";
            this.lblWhere.Size = new System.Drawing.Size(63, 19);
            this.lblWhere.TabIndex = 23;
            this.lblWhere.Text = "WHERE";
            // 
            // lblGroupBy
            // 
            this.lblGroupBy.AutoSize = true;
            this.lblGroupBy.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGroupBy.Location = new System.Drawing.Point(92, 2);
            this.lblGroupBy.Name = "lblGroupBy";
            this.lblGroupBy.Size = new System.Drawing.Size(85, 19);
            this.lblGroupBy.TabIndex = 24;
            this.lblGroupBy.Text = "GROUP BY";
            // 
            // lblHaving
            // 
            this.lblHaving.AutoSize = true;
            this.lblHaving.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHaving.Location = new System.Drawing.Point(110, 6);
            this.lblHaving.Name = "lblHaving";
            this.lblHaving.Size = new System.Drawing.Size(70, 19);
            this.lblHaving.TabIndex = 25;
            this.lblHaving.Text = "HAVING";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(144, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "語法";
            // 
            // lblSql
            // 
            this.lblSql.AutoSize = true;
            this.lblSql.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSql.Location = new System.Drawing.Point(144, 11);
            this.lblSql.Name = "lblSql";
            this.lblSql.Size = new System.Drawing.Size(39, 19);
            this.lblSql.TabIndex = 27;
            this.lblSql.Text = "欄位";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(449, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "資料表名稱";
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTableName.Location = new System.Drawing.Point(543, 34);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(0, 19);
            this.lblTableName.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbAction);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTableName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 66);
            this.panel1.TabIndex = 30;
            // 
            // pnlSql
            // 
            this.pnlSql.Controls.Add(this.gridSql);
            this.pnlSql.Controls.Add(this.lblSql);
            this.pnlSql.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSql.Location = new System.Drawing.Point(0, 66);
            this.pnlSql.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSql.Name = "pnlSql";
            this.pnlSql.Size = new System.Drawing.Size(1011, 187);
            this.pnlSql.TabIndex = 31;
            // 
            // pnlWhere
            // 
            this.pnlWhere.Controls.Add(this.lblWhere);
            this.pnlWhere.Controls.Add(this.gridWhere);
            this.pnlWhere.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWhere.Location = new System.Drawing.Point(0, 253);
            this.pnlWhere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlWhere.Name = "pnlWhere";
            this.pnlWhere.Size = new System.Drawing.Size(1011, 174);
            this.pnlWhere.TabIndex = 32;
            // 
            // pnlGroupBy
            // 
            this.pnlGroupBy.Controls.Add(this.lblGroupBy);
            this.pnlGroupBy.Controls.Add(this.gridGroupBy);
            this.pnlGroupBy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGroupBy.Location = new System.Drawing.Point(0, 427);
            this.pnlGroupBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGroupBy.Name = "pnlGroupBy";
            this.pnlGroupBy.Size = new System.Drawing.Size(1011, 160);
            this.pnlGroupBy.TabIndex = 33;
            // 
            // pnlHaving
            // 
            this.pnlHaving.Controls.Add(this.lblHaving);
            this.pnlHaving.Controls.Add(this.gridHaving);
            this.pnlHaving.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHaving.Location = new System.Drawing.Point(0, 587);
            this.pnlHaving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHaving.Name = "pnlHaving";
            this.pnlHaving.Size = new System.Drawing.Size(1011, 195);
            this.pnlHaving.TabIndex = 34;
            // 
            // ConditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1011, 862);
            this.Controls.Add(this.pnlHaving);
            this.Controls.Add(this.pnlGroupBy);
            this.Controls.Add(this.pnlWhere);
            this.Controls.Add(this.pnlSql);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Name = "ConditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "設定查詢條件";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConditionForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridSql)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWhere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHaving)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSql.ResumeLayout(false);
            this.pnlSql.PerformLayout();
            this.pnlWhere.ResumeLayout(false);
            this.pnlWhere.PerformLayout();
            this.pnlGroupBy.ResumeLayout(false);
            this.pnlGroupBy.PerformLayout();
            this.pnlHaving.ResumeLayout(false);
            this.pnlHaving.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbAction;
        private System.Windows.Forms.DataGridView gridSql;
        private System.Windows.Forms.DataGridView gridWhere;
        private System.Windows.Forms.DataGridView gridGroupBy;
        private System.Windows.Forms.DataGridView gridHaving;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblWhere;
        private System.Windows.Forms.Label lblGroupBy;
        private System.Windows.Forms.Label lblHaving;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSql;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSql;
        private System.Windows.Forms.Panel pnlWhere;
        private System.Windows.Forms.Panel pnlGroupBy;
        private System.Windows.Forms.Panel pnlHaving;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GIsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn GColName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SIsChecked;
        private System.Windows.Forms.DataGridViewComboBoxColumn SColFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SColValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn WIsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn WColName;
        private System.Windows.Forms.DataGridViewComboBoxColumn WColCond;
        private System.Windows.Forms.DataGridViewTextBoxColumn WColValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HIsChecked;
        private System.Windows.Forms.DataGridViewComboBoxColumn HColFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HColName;
        private System.Windows.Forms.DataGridViewComboBoxColumn HColCond;
        private System.Windows.Forms.DataGridViewTextBoxColumn HColValue;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WF_H_004_DBMS.Models;

namespace WF_H_004_DBMS.Forms
{
    public partial class ConditionForm : Form
    {
        SqlQueryForm sqlQueryForm;
        string tableName;

        class SqlTable
        {
            public string Name { get; set; }

            public List<SqlColumn> Columns { get; set; }
        }

        class SqlColumn
        {
            public string Name { get; set; }

            public string Type { get; set; }

            public SqlColumn(string name, string type)
            {
                Name = name;
                Type = type;
            }
        }


        List<SqlTable> tables = new List<SqlTable>();


        public ConditionForm(SqlQueryForm sqlQueryForm)
        {
            InitializeComponent();

            this.sqlQueryForm = sqlQueryForm;

            // 定義Table結構
            SqlTable tb = new SqlTable();
            tb.Name = "Booth";
            tb.Columns = new List<SqlColumn>();
            tb.Columns.Add(new SqlColumn("Id", "int"));
            tb.Columns.Add(new SqlColumn("Name", "string"));
            tb.Columns.Add(new SqlColumn("Phone", "string"));
            tb.Columns.Add(new SqlColumn("LineId", "string"));
            tables.Add(tb);

            tb = new SqlTable();
            tb.Name = "Member";
            tb.Columns = new List<SqlColumn>();
            tb.Columns.Add(new SqlColumn("Id", "int"));
            tb.Columns.Add(new SqlColumn("Name", "string"));
            tb.Columns.Add(new SqlColumn("Phone", "string"));
            tb.Columns.Add(new SqlColumn("LineId", "string"));
            tables.Add(tb);

            tb = new SqlTable();
            tb.Name = "SalesOrder";
            tb.Columns = new List<SqlColumn>();
            tb.Columns.Add(new SqlColumn("Id", "int"));
            tb.Columns.Add(new SqlColumn("BoothId", "int"));
            tb.Columns.Add(new SqlColumn("MemberId", "int"));
            tb.Columns.Add(new SqlColumn("StaffId", "int"));
            tb.Columns.Add(new SqlColumn("DeliveryPhone", "string"));
            tables.Add(tb);

            tb = new SqlTable();
            tb.Name = "SalesOrderDetail";
            tb.Columns = new List<SqlColumn>();
            tb.Columns.Add(new SqlColumn("OrderId", "int"));
            tb.Columns.Add(new SqlColumn("ProductId", "int"));
            tb.Columns.Add(new SqlColumn("UnitPrice", "int"));
            tb.Columns.Add(new SqlColumn("Quantity", "int"));
            tables.Add(tb);

            tb = new SqlTable();
            tb.Name = "Product";
            tb.Columns = new List<SqlColumn>();
            tb.Columns.Add(new SqlColumn("Id", "int"));
            tb.Columns.Add(new SqlColumn("Name", "string"));
            tb.Columns.Add(new SqlColumn("UnitPrice", "int"));
            tables.Add(tb);

            tb = new SqlTable();
            tb.Name = "Staff";
            tb.Columns = new List<SqlColumn>();
            tb.Columns.Add(new SqlColumn("Id", "int"));
            tb.Columns.Add(new SqlColumn("Name", "string"));
            tb.Columns.Add(new SqlColumn("Phone", "string"));
            tb.Columns.Add(new SqlColumn("IsAdmin", "int"));
            tb.Columns.Add(new SqlColumn("IsDriver", "int"));
            tables.Add(tb);
        }

        public void Start(string tableName)
        {
            this.tableName = tableName;
            this.lblTableName.Text = tableName;

            this.cbbAction.SelectedIndex = -1;

            // 找到對應的Table
            SqlTable table = new SqlTable();
            for (int i = 0; i < tables.Count; i++)
            {
                if (tables[i].Name == tableName)
                {
                    table = tables[i];
                }
            }

            // 顯示第一個DataGridView
            gridSql.Rows.Clear();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                int row = gridSql.Rows.Add();
                gridSql.Rows[row].Cells["SColName"].Value = table.Columns[i].Name;
            }

            // 顯示第二個DataGridView
            gridWhere.Rows.Clear();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                int row = gridWhere.Rows.Add();
                gridWhere.Rows[row].Cells["WColName"].Value = table.Columns[i].Name;
            }

            // 顯示第三個DataGridView
            gridGroupBy.Rows.Clear();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                int row = gridGroupBy.Rows.Add();
                gridGroupBy.Rows[row].Cells["GColName"].Value = table.Columns[i].Name;
            }

            // 顯示第四個DataGridView
            gridHaving.Rows.Clear();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                int row = gridHaving.Rows.Add();
                gridHaving.Rows[row].Cells["HColName"].Value = table.Columns[i].Name;
            }
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // 取得Select、Insert、Delete、Update
            if (cbbAction.SelectedItem == null)
            {
                MessageBox.Show("請先選擇【語法】", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbAction.Focus();
                return;
            }
            string action = cbbAction.SelectedItem.ToString();


            if (action == "EXISTS")
            {
                string sql = "";
                if (tableName == "Booth")
                {
                    sql = "--查詢有賣出商品的攤位\r\n";
                    sql += "SELECT *\r\n";
                    sql += "FROM Booth\r\n";
                    sql += "WHERE EXISTS (SELECT * FROM SalesOrder WHERE SalesOrder.BoothId = Booth.Id)";
                }
                else if (tableName == "Member")
                {
                    sql = "--查詢有下訂商品的客人\r\n";
                    sql += "SELECT *\r\n";
                    sql += "FROM Member\r\n";
                    sql += "WHERE EXISTS (SELECT * FROM SalesOrder WHERE SalesOrder.MemberId = Member.Id)";
                }
                else if (tableName == "SalesOrder")
                {
                    MessageBox.Show("很抱歉，資料表SalesOrder沒有提供EXISTS語法，請選擇其他語法查詢。");
                    return;
                }
                else if (tableName == "SalesOrderDetail")
                {
                    MessageBox.Show("很抱歉，資料表SalesOrderDetail沒有提供EXISTS語法，請選擇其他語法查詢。");
                    return;
                }
                else if (tableName == "Product")
                {
                    sql = "--查詢有被下訂過的商品\r\n";
                    sql += "SELECT *\r\n";
                    sql += "FROM Product\r\n";
                    sql += "WHERE EXISTS (SELECT * FROM SalesOrderDetail WHERE SalesOrderDetail.ProductId = Product.Id)";
                }
                else if (tableName == "Staff")
                {
                    sql = "--查詢有配送訂單的員工\r\n";
                    sql += "SELECT *\r\n";
                    sql += "FROM Staff\r\n";
                    sql += "WHERE EXISTS (SELECT * FROM SalesOrder WHERE SalesOrder.StaffId = Staff.Id)";
                }

                sqlQueryForm.SetSql(sql);
                sqlQueryForm.Focus();
            }
            else if (action == "NOT EXISTS")
            {
                string sql = "";
                if (tableName == "Booth")
                {
                    sql = "--查詢沒有賣出商品的攤位\r\n";
                    sql += "SELECT *\r\n";
                    sql += "FROM Booth\r\n";
                    sql += "WHERE NOT EXISTS (SELECT * FROM SalesOrder WHERE SalesOrder.BoothId = Booth.Id)";
                }
                else if (tableName == "Member")
                {
                    sql = "--查詢沒有下訂商品的客人\r\n";
                    sql += "SELECT *\r\n";
                    sql += "FROM Member\r\n";
                    sql += "WHERE NOT EXISTS (SELECT * FROM SalesOrder WHERE SalesOrder.MemberId = Member.Id)";
                }
                else if (tableName == "SalesOrder")
                {
                    MessageBox.Show("很抱歉，資料表SalesOrder沒有提供EXISTS語法，請選擇其他語法查詢。");
                    return;
                }
                else if (tableName == "SalesOrderDetail")
                {
                    MessageBox.Show("很抱歉，資料表SalesOrderDetail沒有提供EXISTS語法，請選擇其他語法查詢。");
                    return;
                }
                else if (tableName == "Product")
                {
                    sql = "--查詢沒有被下訂過的商品\r\n";
                    sql += "SELECT *\r\n";
                    sql += "FROM Product\r\n";
                    sql += "WHERE NOT EXISTS (SELECT * FROM SalesOrderDetail WHERE SalesOrderDetail.ProductId = Product.Id)";
                }
                else if (tableName == "Staff")
                {
                    sql = "--查詢沒有配送訂單的員工\r\n";
                    sql += "SELECT *\r\n";
                    sql += "FROM Staff\r\n";
                    sql += "WHERE NOT EXISTS (SELECT * FROM SalesOrder WHERE SalesOrder.StaffId = Staff.Id)";
                }

                sqlQueryForm.SetSql(sql);
                sqlQueryForm.Focus();
            }
            else
            {
                // 取得SQL區塊
                List<SqlOption> sqlOptions = new List<SqlOption>();
                for (int i = 0; i < gridSql.RowCount; i++)
                {
                    if (gridSql.Rows[i].Cells["SIsChecked"].Value != null && Convert.ToBoolean(gridSql.Rows[i].Cells["SIsChecked"].Value))
                    {
                        SqlOption opt = new SqlOption();
                        if (gridSql.Rows[i].Cells["SColFunc"].Value != null)
                        {
                            opt.ColFunc = gridSql.Rows[i].Cells["SColFunc"].Value.ToString();
                        }
                        opt.ColName = gridSql.Rows[i].Cells["SColName"].Value.ToString();
                        if (gridSql.Rows[i].Cells["SColValue"].Value != null)
                        {
                            opt.ColValue = gridSql.Rows[i].Cells["SColValue"].Value.ToString();
                        }
                        else
                        {
                            if (gridSql.Rows[i].Cells["SColValue"].Visible)
                            {
                                MessageBox.Show("欄位 '" + gridSql.Rows[i].Cells["SColName"].Value + "' 必須給值", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                gridSql.CurrentCell = gridSql.Rows[i].Cells["SColValue"];
                                gridSql.BeginEdit(true);
                                return;
                            }
                        }
                        sqlOptions.Add(opt);
                    }
                }

                // 取得WHERE區塊
                List<WhereOption> whereOptions = new List<WhereOption>();
                for (int i = 0; i < gridWhere.RowCount; i++)
                {
                    if (gridWhere.Rows[i].Cells["WIsChecked"].Value != null && Convert.ToBoolean(gridWhere.Rows[i].Cells["WIsChecked"].Value))
                    {
                        WhereOption opt = new WhereOption();
                        opt.ColName = gridWhere.Rows[i].Cells["WColName"].Value.ToString();
                        if (gridWhere.Rows[i].Cells["WColCond"].Value != null)
                        {
                            opt.ColCond = gridWhere.Rows[i].Cells["WColCond"].Value.ToString();
                        }
                        else
                        {
                            MessageBox.Show("WHERE '" + gridWhere.Rows[i].Cells["WColName"].Value + "' 必須選擇條件", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            gridWhere.CurrentCell = gridWhere.Rows[i].Cells["WColCond"];
                            gridWhere.BeginEdit(true);
                            ((ComboBox)gridWhere.EditingControl).DroppedDown = true;
                            return;
                        }
                        if (gridWhere.Rows[i].Cells["WColValue"].Value != null)
                        {
                            opt.ColValue = gridWhere.Rows[i].Cells["WColValue"].Value.ToString();
                        }
                        else
                        {
                            MessageBox.Show("WHERE '" + gridWhere.Rows[i].Cells["WColName"].Value + "' 必須輸入值", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            gridWhere.CurrentCell = gridWhere.Rows[i].Cells["WColValue"];
                            gridWhere.BeginEdit(true);
                            return;
                        }
                        whereOptions.Add(opt);
                    }
                }

                // 取得GROUP BY區塊
                List<GroupByOption> groupByOptions = new List<GroupByOption>();
                for (int i = 0; i < gridGroupBy.RowCount; i++)
                {
                    if (gridGroupBy.Rows[i].Cells["GIsChecked"].Value != null && Convert.ToBoolean(gridGroupBy.Rows[i].Cells["GIsChecked"].Value))
                    {
                        GroupByOption opt = new GroupByOption();
                        opt.ColName = gridGroupBy.Rows[i].Cells["GColName"].Value.ToString();
                        groupByOptions.Add(opt);
                    }
                }

                // 取得HAVING區塊
                List<HavingOption> havingOptions = new List<HavingOption>();
                for (int i = 0; i < gridHaving.RowCount; i++)
                {
                    if (gridHaving.Rows[i].Cells["HIsChecked"].Value != null && Convert.ToBoolean(gridHaving.Rows[i].Cells["HIsChecked"].Value))
                    {
                        HavingOption opt = new HavingOption();
                        if (gridHaving.Rows[i].Cells["HColFunc"].Value != null)
                        {
                            opt.ColFunc = gridHaving.Rows[i].Cells["HColFunc"].Value.ToString();
                        }
                        else
                        {
                            MessageBox.Show("HAVING '" + gridHaving.Rows[i].Cells["HColName"].Value + "' 必須選擇函式", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            gridHaving.CurrentCell = gridHaving.Rows[i].Cells["HColFunc"];
                            gridHaving.BeginEdit(true);
                            ((ComboBox)gridHaving.EditingControl).DroppedDown = true;
                            return;
                        }
                        opt.ColName = gridHaving.Rows[i].Cells["HColName"].Value.ToString();
                        if (gridHaving.Rows[i].Cells["HColCond"].Value != null)
                        {
                            opt.ColCond = gridHaving.Rows[i].Cells["HColCond"].Value.ToString();
                        }
                        else
                        {
                            MessageBox.Show("HAVING '" + gridHaving.Rows[i].Cells["HColName"].Value + "' 必須選擇條件", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            gridHaving.CurrentCell = gridHaving.Rows[i].Cells["HColCond"];
                            gridHaving.BeginEdit(true);
                            ((ComboBox)gridHaving.EditingControl).DroppedDown = true;
                            return;
                        }
                        if (gridHaving.Rows[i].Cells["HColValue"].Value != null)
                        {
                            opt.ColValue = gridHaving.Rows[i].Cells["HColValue"].Value.ToString();
                        }
                        else
                        {
                            MessageBox.Show("HAVING '" + gridHaving.Rows[i].Cells["HColName"].Value + "' 必須選擇值", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            gridHaving.CurrentCell = gridHaving.Rows[i].Cells["HColValue"];
                            gridHaving.BeginEdit(true);
                            return;
                        }

                        havingOptions.Add(opt);
                    }
                }

                // 組合SQL語法
                sqlQueryForm.SetSql(GetSqlScript(tableName, action, sqlOptions, whereOptions, groupByOptions, havingOptions));

                sqlQueryForm.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConditionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 因為外面的視窗可能重複打開此視窗，所以關閉改成用隱藏的，不然會Error
            e.Cancel = true;
            this.Hide();
        }

        /// <summary>
        /// 讓GridView點一下就可以編輯
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridSql_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridSql.BeginEdit(true);

            if (e.ColumnIndex == 1)
            {
                ComboBox cb = (ComboBox)gridSql.EditingControl;
                cb.DroppedDown = true;
            }
        }

        /// <summary>
        /// 讓GridView點一下就可以編輯
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridWhere_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridWhere.BeginEdit(true);

            if (e.ColumnIndex == 2)
            {
                ComboBox cb = (ComboBox)gridWhere.EditingControl;
                cb.DroppedDown = true;
            }
        }

        /// <summary>
        /// 讓GridView點一下就可以編輯
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridGroupBy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridGroupBy.BeginEdit(true);
        }

        /// <summary>
        /// 讓GridView點一下就可以編輯
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridHaving_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridHaving.BeginEdit(true);

            if (e.ColumnIndex == 1 || e.ColumnIndex == 3)
            {
                ComboBox cb = (ComboBox)gridHaving.EditingControl;
                cb.DroppedDown = true;
            }
        }


        private void cbbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbAction.SelectedItem != null && cbbAction.SelectedItem.ToString() == "SELECT")
            {
                // 欄位GridView
                gridSql.Columns[0].Visible = true;
                gridSql.Columns[1].Visible = true;
                gridSql.Columns[2].Visible = true;
                gridSql.Columns[3].Visible = false;
                gridSql.Visible = true;
                pnlSql.Visible = true;
                gridSql.Rows[0].Visible = true;

                // WHERE GridView
                gridWhere.Columns[0].Visible = true;
                gridWhere.Columns[1].Visible = true;
                gridWhere.Columns[2].Visible = true;
                gridWhere.Columns[3].Visible = true;
                gridWhere.Visible = true;
                pnlWhere.Visible = true;

                // GROUP BY
                gridGroupBy.Columns[0].Visible = true;
                gridGroupBy.Columns[1].Visible = true;
                gridGroupBy.Visible = true;
                pnlGroupBy.Visible = true;

                // HAVING
                gridHaving.Columns[0].Visible = true;
                gridHaving.Columns[1].Visible = true;
                gridHaving.Columns[2].Visible = true;
                gridHaving.Columns[3].Visible = true;
                gridHaving.Columns[4].Visible = true;
                gridHaving.Visible = true;
                pnlHaving.Visible = true;
            }
            else if (cbbAction.SelectedItem != null && cbbAction.SelectedItem.ToString() == "DELETE")
            {
                // 欄位GridView
                gridSql.Columns[0].Visible = false;
                gridSql.Columns[1].Visible = false;
                gridSql.Columns[2].Visible = false;
                gridSql.Columns[3].Visible = false;
                gridSql.Visible = false;
                pnlSql.Visible = false;

                // WHERE GridView
                gridWhere.Columns[0].Visible = true;
                gridWhere.Columns[1].Visible = true;
                gridWhere.Columns[2].Visible = true;
                gridWhere.Columns[3].Visible = true;
                gridWhere.Visible = true;
                pnlWhere.Visible = true;

                // GROUP BY
                gridGroupBy.Columns[0].Visible = false;
                gridGroupBy.Columns[1].Visible = false;
                gridGroupBy.Visible = false;
                pnlGroupBy.Visible = false;

                // HAVING
                gridHaving.Columns[0].Visible = false;
                gridHaving.Columns[1].Visible = false;
                gridHaving.Columns[2].Visible = false;
                gridHaving.Columns[3].Visible = false;
                gridHaving.Columns[4].Visible = false;
                gridHaving.Visible = false;
                pnlHaving.Visible = false;
            }
            else if (cbbAction.SelectedItem != null && cbbAction.SelectedItem.ToString() == "INSERT")
            {
                // 欄位GridView
                gridSql.Columns[0].Visible = true;
                gridSql.Columns[1].Visible = false;
                gridSql.Columns[2].Visible = true;
                gridSql.Columns[3].Visible = true;
                gridSql.Visible = true;
                pnlSql.Visible = true;
                // Id是PK不可INSERT
                gridSql.Rows[0].Cells[0].Value = false;
                gridSql.Rows[0].Visible = false;

                // WHERE GridView
                gridWhere.Columns[0].Visible = false;
                gridWhere.Columns[1].Visible = false;
                gridWhere.Columns[2].Visible = false;
                gridWhere.Columns[3].Visible = false;
                gridWhere.Visible = false;
                pnlWhere.Visible = false;

                // GROUP BY
                gridGroupBy.Columns[0].Visible = false;
                gridGroupBy.Columns[1].Visible = false;
                gridGroupBy.Visible = false;
                pnlGroupBy.Visible = false;

                // HAVING
                gridHaving.Columns[0].Visible = false;
                gridHaving.Columns[1].Visible = false;
                gridHaving.Columns[2].Visible = false;
                gridHaving.Columns[3].Visible = false;
                gridHaving.Columns[4].Visible = false;
                gridHaving.Visible = false;
                pnlHaving.Visible = false;
            }
            else if (cbbAction.SelectedItem != null && cbbAction.SelectedItem.ToString() == "UPDATE")
            {
                // 欄位GridView
                gridSql.Columns[0].Visible = true;
                gridSql.Columns[1].Visible = false;
                gridSql.Columns[2].Visible = true;
                gridSql.Columns[3].Visible = true;
                gridSql.Visible = true;
                pnlSql.Visible = true;
                // Id是PK不可UPDATE
                gridSql.Rows[0].Cells[0].Value = false;
                gridSql.Rows[0].Visible = false;

                // WHERE GridView
                gridWhere.Columns[0].Visible = true;
                gridWhere.Columns[1].Visible = true;
                gridWhere.Columns[2].Visible = true;
                gridWhere.Columns[3].Visible = true;
                gridWhere.Visible = true;
                pnlWhere.Visible = true;

                // GROUP BY
                gridGroupBy.Columns[0].Visible = false;
                gridGroupBy.Columns[1].Visible = false;
                gridGroupBy.Visible = false;
                pnlGroupBy.Visible = false;

                // HAVING
                gridHaving.Columns[0].Visible = false;
                gridHaving.Columns[1].Visible = false;
                gridHaving.Columns[2].Visible = false;
                gridHaving.Columns[3].Visible = false;
                gridHaving.Columns[4].Visible = false;
                gridHaving.Visible = false;
                pnlHaving.Visible = false;
            }
            else
            {
                // 欄位GridView
                gridSql.Columns[0].Visible = false;
                gridSql.Columns[1].Visible = false;
                gridSql.Columns[2].Visible = false;
                gridSql.Columns[3].Visible = false;
                gridSql.Visible = false;
                pnlSql.Visible = false;
                // Id是PK不可UPDATE
                gridSql.Rows[0].Cells[0].Value = false;
                gridSql.Rows[0].Visible = false;

                // WHERE GridView
                gridWhere.Columns[0].Visible = false;
                gridWhere.Columns[1].Visible = false;
                gridWhere.Columns[2].Visible = false;
                gridWhere.Columns[3].Visible = false;
                gridWhere.Visible = false;
                pnlWhere.Visible = false;

                // GROUP BY
                gridGroupBy.Columns[0].Visible = false;
                gridGroupBy.Columns[1].Visible = false;
                gridGroupBy.Visible = false;
                pnlGroupBy.Visible = false;

                // HAVING
                gridHaving.Columns[0].Visible = false;
                gridHaving.Columns[1].Visible = false;
                gridHaving.Columns[2].Visible = false;
                gridHaving.Columns[3].Visible = false;
                gridHaving.Columns[4].Visible = false;
                gridHaving.Visible = false;
                pnlHaving.Visible = false;
            }
        }

        /// <summary>
        /// 編輯欄位DataGridView時，自動勾選Checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridSql_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gridSql.CurrentCell != gridSql.CurrentRow.Cells[0] && gridSql.CurrentCell.Value != null)
            {
                gridSql.CurrentRow.Cells[0].Value = true;
            }
        }

        /// <summary>
        /// 取得Sql Script
        /// </summary>
        /// <param name="action">Sql操作種類</param>
        /// <param name="sqlOption">Sql操作選項模型</param>
        /// <param name="whereOption">Where選項模型</param>
        /// <param name="groupByOption">Group By選項模型</param>
        /// <param name="havingOption">Having選項模型</param>
        /// <returns></returns>
        private string GetSqlScript(
            string tableName,
            string action,
            IEnumerable<SqlOption> sqlOption,
            IEnumerable<WhereOption> whereOption,
            IEnumerable<GroupByOption> groupByOption,
            IEnumerable<HavingOption> havingOption)
        {
            tableName = tableName.ToUpper();
            action = action.ToUpper();

            string sql = "";

            #region 操作種類、欄位
            if (action == "SELECT")
            {
                List<string> fields = new List<string>();
                foreach (SqlOption item in sqlOption)
                {
                    if (item.ColFunc == null)
                    {
                        fields.Add(item.ColName);
                    }
                    else if (item.ColFunc.ToUpper() == "COUNT")
                    {
                        fields.Add("COUNT(" + item.ColName + ")");
                    }
                    else if (item.ColFunc.ToUpper() == "SUM")
                    {
                        fields.Add("SUM(" + item.ColName + ")");
                    }
                    else if (item.ColFunc.ToUpper() == "MAX")
                    {
                        fields.Add("MAX(" + item.ColName + ")");
                    }
                    else if (item.ColFunc.ToUpper() == "MIN")
                    {
                        fields.Add("MIN(" + item.ColName + ")");
                    }
                    else if (item.ColFunc.ToUpper() == "AVG")
                    {
                        fields.Add("AVG(" + item.ColName + ")");
                    }
                    else
                    {
                        fields.Add(item.ColName);
                    }
                }
                string fieldsStr = string.Join(",\r\n        ", fields);

                sql += "SELECT\r\n        " + fieldsStr + "\r\nFROM " + tableName + "\r\n";
            }
            else if (action == "DELETE")
            {
                sql += "DELETE " + tableName + "\r\n";
            }
            else if (action == "INSERT")
            {
                List<string> fields = new List<string>();
                List<string> values = new List<string>();
                foreach (SqlOption item in sqlOption)
                {
                    fields.Add(item.ColName);
                    values.Add("'" + item.ColValue + "' ");
                }
                string fieldsStr = string.Join(",\r\n        ", fields);
                string valuesStr = string.Join(",\r\n        ", values);

                sql += "INSERT INTO " + tableName + "\r\n       (" + fieldsStr + ")\r\nVALUES\r\n       (" + valuesStr + ") \r\n";
            }
            else if (action == "UPDATE")
            {
                List<string> fieldValues = new List<string>();
                List<string> values = new List<string>();
                foreach (SqlOption item in sqlOption)
                {
                    fieldValues.Add(item.ColName + " = '" + item.ColValue + "' ");
                }
                string fieldValuesStr = string.Join(",\r\n", fieldValues);

                sql += "UPDATE " + tableName + " SET \r\n" + fieldValuesStr + "\r\n";
            }
            #endregion

            #region Where
            List<string> whereConds = new List<string>();
            foreach (WhereOption item in whereOption)
            {
                if (item.ColCond == "=" || item.ColCond == "<>" ||
                    item.ColCond == ">" || item.ColCond == ">=" ||
                    item.ColCond == "<" || item.ColCond == "<=")
                {
                    whereConds.Add(item.ColName + " " + item.ColCond + " '" + item.ColValue + "'");
                }
                else if (item.ColCond.ToUpper() == "IN" || item.ColCond.ToUpper() == "NOT IN")
                {
                    List<string> whereValues = new List<string>();
                    foreach (var itemVal in item.ColValue.Split(','))
                    {
                        whereValues.Add("'" + itemVal + "'");
                    }
                    string whereValuesStr = string.Join(", ", whereValues);

                    whereConds.Add(item.ColName + " " + item.ColCond.ToUpper() + " (" + whereValuesStr + ")");
                }
            }
            string whereCondsStr = string.Join("\r\n and ", whereConds);
            if (!string.IsNullOrEmpty(whereCondsStr))
            {
                sql += "WHERE " + whereCondsStr + " \r\n";
            }

            #endregion

            #region Group By
            string groupCondsStr = string.Join(",", groupByOption.Select(x => x.ColName));
            if (!string.IsNullOrEmpty(groupCondsStr))
            {
                sql += "GROUP BY " + groupCondsStr + " \r\n";
            }
            #endregion

            #region Having
            List<string> havingConds = new List<string>();
            foreach (HavingOption item in havingOption)
            {
                string havingfield = "";
                if (item.ColFunc.ToUpper() == "COUNT")
                {
                    havingfield = "COUNT(" + item.ColName + ")";
                }
                else if (item.ColFunc.ToUpper() == "SUM")
                {
                    havingfield = "SUM(" + item.ColName + ")";
                }
                else if (item.ColFunc.ToUpper() == "MAX")
                {
                    havingfield = "MAX(" + item.ColName + ")";
                }
                else if (item.ColFunc.ToUpper() == "MIN")
                {
                    havingfield = "MIN(" + item.ColName + ")";
                }
                else if (item.ColFunc.ToUpper() == "AVG")
                {
                    havingfield = "AVG(" + item.ColName + ")";
                }
                else
                {
                    havingfield = item.ColName;
                }

                if (item.ColCond == "=" || item.ColCond == "<>" ||
                    item.ColCond == ">" || item.ColCond == ">=" ||
                    item.ColCond == "<" || item.ColCond == "<=")
                {
                    havingConds.Add(havingfield + " " + item.ColCond + " '" + item.ColValue + "'");
                }
                else if (item.ColCond.ToUpper() == "IN" || item.ColCond.ToUpper() == "NOT IN")
                {
                    List<string> havingValues = new List<string>();
                    foreach (var itemVal in item.ColValue.Split(','))
                    {
                        havingValues.Add("'" + itemVal + "'");
                    }
                    string havingValuesStr = string.Join(", ", havingValues);

                    havingConds.Add(havingfield + " " + item.ColCond.ToUpper() + " (" + havingValuesStr + ")");
                }
            }
            string havingCondsStr = string.Join("\r\n and ", havingConds);
            if (!string.IsNullOrEmpty(havingCondsStr))
            {
                sql += "HAVING " + havingCondsStr + " \r\n";
            }
            #endregion
            return sql;
        }
    }
}

using System;
using System.Windows.Forms;

namespace WF_H_004_DBMS.Forms
{
    public partial class SqlQueryForm : Form
    {
        private string tableName;

        private ConditionForm conditionForm;
        private ResultForm resultForm;


        public SqlQueryForm()
        {
            InitializeComponent();
        }

        public void SetTable(string tableName)
        {
            this.tableName = tableName;
            this.lblTableName.Text = this.tableName;
        }


        public void SetSql(string sql)
        {
            this.txtSQL.Text = sql;
        }

        /// <summary>
        /// 查詢按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sql = txtSQL.Text.Trim();

            if (resultForm == null)
            {
                resultForm = new ResultForm();
            }

            resultForm.QuerySQL(sql);
            resultForm.Show();
            resultForm.Focus();
        }

        /// <summary>
        /// 設定查詢條件按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetCondition_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblTableName.Text))
            {
                MessageBox.Show("請先選擇資料表", "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (conditionForm == null)
            {
                conditionForm = new ConditionForm(this);
            }

            conditionForm.Start(lblTableName.Text);
            conditionForm.Show();
            conditionForm.Focus();
        }
    }
}

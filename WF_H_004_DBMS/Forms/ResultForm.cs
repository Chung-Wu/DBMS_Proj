using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WF_H_004_DBMS.Forms
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        public void QuerySQL(string sql)
        {
            try
            {
                string connString = "Server=.;Initial Catalog=MyDBMS;Persist Security Info=False;Integrated Security=true;";
                string query = sql.Trim();

                // 執行SELECT
                if (query.ToLower().Contains("select"))
                {
                    // 開啟SQL連接
                    SqlConnection conn = new SqlConnection(connString);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    // 把資料撈進DataTable
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conn.Close();
                    da.Dispose();

                    ShowData(dt);
                }
                else // 執行INSERT UPDATE DELETE
                {
                    string action = "異動";
                    if (query.ToLower().Contains("insert"))
                    {
                        action = "新增";
                    }
                    else if (query.ToLower().Contains("update"))
                    {
                        action = "修改";
                    }
                    else if (query.ToLower().Contains("delete"))
                    {
                        action = "刪除";
                    }


                    // 開啟SQL連接
                    SqlConnection conn = new SqlConnection(connString);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    conn.Close();

                    lblErrorMessage.Text = "執行結果: 總共" + action + count + "筆資料";
                    lblErrorMessage.Visible = true;

                    gridResult.DataSource = null;
                    lblMessage.Text = "執行結果: 總共" + action + count + "筆資料";

                }
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
                lblErrorMessage.Visible = true;

                gridResult.DataSource = null;
                lblMessage.Text = "發生錯誤";
            }
        }

        /// <summary>
        /// 將資料顯示在DataGridView
        /// </summary>
        public void ShowData(DataTable dt)
        {
            lblErrorMessage.Text = "";
            lblErrorMessage.Visible = false;

            gridResult.DataSource = dt;
            lblMessage.Text = "執行結果: 總共查詢" + dt.Rows.Count + "筆資料";
        }

        /// <summary>
        /// 當視窗正在關閉時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 因為外面的視窗可能重複打開此視窗，所以關閉改成用隱藏的，不然會Error
            e.Cancel = true;
            this.Hide();
        }
    }
}

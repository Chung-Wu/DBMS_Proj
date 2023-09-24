using System;
using System.Windows.Forms;
using WF_H_004_DBMS.Forms;

namespace WF_H_004_DBMS
{
    public partial class MainForm : Form
    {
        SqlQueryForm sqlForm;

        public MainForm()
        {
            InitializeComponent();

            sqlForm = new SqlQueryForm();
            sqlForm.TopLevel = false;
            sqlForm.Dock = DockStyle.Fill;
            this.formBody.Controls.Add(sqlForm);
            sqlForm.Show();
        }

        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = this.menu.SelectedItem.ToString();
            sqlForm.SetTable(tableName);
        }
    }
}

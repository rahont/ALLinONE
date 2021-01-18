using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ALLinONE
{
    public partial class RequestPrinters : Form
    {
        UseDB usedb = new UseDB();

        public RequestPrinters()
        {
            InitializeComponent();
        }

        private void btnAddRequestPrint_Click(object sender, EventArgs e)
        {
            if (dgvRequestPrint.SelectedRows.Count > 0)
            {
                tmrComm5555.Enabled = false;

                string str = RequestString();

                //UseDB usedb = new UseDB("RequestList", "Value", "User", "DateCreate", str, Environment.UserName, DateTime.Now.ToString());
                usedb.table = "RequestList";
                usedb.col1 = "Value";
                usedb.col2 = "User";
                usedb.col3 = "DateCreate";
                usedb.str1 = str;
                usedb.str2 = Environment.UserName;
                usedb.str3 = DateTime.Now.ToString();
                usedb.numbCol = 3;
                usedb.InsertDB();

                lblRequestPrint.Text = "Улетело в БД: " + str;
                tmrComm5555.Enabled = true;
            }
            else MessageBox.Show("Что забыл?", "Атата...", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void tmrComm5555_Tick(object sender, EventArgs e)
        {
            lblRequestPrint.Text = "";
            tmrComm5555.Enabled = false;
        }

        private string RequestString()
        {
            string str = null;
            string colorCart = null;

            if (chckbColor.Checked)
            {
                if (rdbtnBlack.Checked) colorCart = " черный";
                if (rdbtnRed.Checked) colorCart = " красный";
                if (rdbtnBlue.Checked) colorCart = " синий";
                if (rdbtnYellow.Checked) colorCart = " желтый";
            }

            if (rdbtnReplace.Checked) str = "Заменить" + colorCart + " картридж в ";
            if (rdbtnPaper.Checked) str = "Устранить замятие в ";
            if (rdbtnPaperRoll.Checked) str = "Заменить рулон бумаги в ";

            str += dgvRequestPrint.SelectedCells[1].Value.ToString() + " распологающийся в " + dgvRequestPrint.SelectedCells[3].Value.ToString();

            return str;
        }

        private void RefreshDBPrinters()
        {
            MainForm mf = new MainForm();
            usedb.connectDB.Open();
            var sqlCommand = new SQLiteCommand("select * from Printers", usedb.connectDB);
            sqlCommand.ExecuteNonQuery();

            var dataTable = new DataTable("Printers");
            var sqlAdapter = new SQLiteDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataTable);

            dgvRequestPrint.DataSource = dataTable.DefaultView;
            sqlAdapter.Update(dataTable);

            usedb.connectDB.Close();

            dgvRequestPrint.Columns["id"].Visible = false;
            //Переименовка колонок в DataGridView
            dgvRequestPrint.Columns["Name"].HeaderText = "Наименование";
            dgvRequestPrint.Columns["NetName"].HeaderText = "Сет. имя";
            dgvRequestPrint.Columns["Location"].HeaderText = "Расположение";
            dgvRequestPrint.Columns["InvNumber"].HeaderText = "Инвентарный";

            //Длина колонок в DataGridView
            dgvRequestPrint.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRequestPrint.Columns[2].Width = 87;
            dgvRequestPrint.Columns[3].Width = 91;
            dgvRequestPrint.Columns[4].Width = 82;

            dgvRequestPrint.ClearSelection();
        }

        private void RequestPrinters_Load(object sender, EventArgs e)
        {
            RefreshDBPrinters();
        }

        private void dgvRequestPrint_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddRequestPrint.PerformClick();
        }
    }
}

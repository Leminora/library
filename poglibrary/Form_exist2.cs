using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace poglibrary
{
    public partial class Form_exist2 : Form
    {
        Form_add_rf a;
        Database database = new Database();
        public Form_exist2(Form_add_rf a)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.a = a;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Rid", String.Empty);
            dataGridView1.Columns["Rid"].Visible = false;
            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("Patronymic", "Отчество");
            dataGridView1.Columns.Add("Surname", "Фамилия");
            dataGridView1.Columns.Add("Birthday", "Год рождения");
            dataGridView1.Columns.Add("Email", "Электронная почта");
            dataGridView1.Columns.Add("Phone", "Номер телефона");
        }
        private void ReadSingleRow(DataGridView wha, IDataRecord record)
        {
            wha.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetString(5), record.GetString(6), Rowstate.ModifiedNew);

        }
        private void RefreshDataGrid(DataGridView wha)
        {
            wha.Rows.Clear();
            string queryString = $"select Readers.Readerid, RName.RName, Patronymic.Patronymic, Surname.Surname, Yearofbirth.Birthyear, Email.Email, Phonenumber.Number FROM Readers, RName, Patronymic, Surname, Yearofbirth, Email, Phonenumber WHERE Readers.Nid = RName.Nid AND Readers.Pid = Patronymic.Pid AND Readers.Surid = Surname.Sid AND Readers.YOBid = Yearofbirth.YOBid AND Readers.Eid = Email.Eid AND Readers.PNid = Phonenumber.PNid and not exists (select * from Readerforms where RTid = Readers.Readerid and Date_E < getdate() and Statusid = 4)";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(wha, reader);
            }
            reader.Close();
        }
        private void Search(DataGridView wha)
        {
            wha.Rows.Clear();
            string searchString = $"select Readers.Readerid, RName.RName, Patronymic.Patronymic, Surname.Surname, Yearofbirth.Birthyear, Email.Email, Phonenumber.Number FROM Readers, RName, Patronymic, Surname, Yearofbirth, Email, Phonenumber WHERE Readers.Nid = RName.Nid AND Readers.Pid = Patronymic.Pid AND Readers.Surid = Surname.Sid AND Readers.YOBid = Yearofbirth.YOBid AND Readers.Eid = Email.Eid AND Readers.PNid = Phonenumber.PNid and not exists (select * from Readerforms where RTid = Readers.Readerid and Date_E < getdate() and Statusid = 4) AND concat (RName, Patronymic, Surname, Birthyear, Email, Number) like '%" + textBox_search.Text + "%'";
            SqlCommand comm = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader red = comm.ExecuteReader();
            while (red.Read())
            {
                ReadSingleRow(wha, red);
            }
            red.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[Index];
                a.textBox_reader.Text = row.Cells[0].Value.ToString();

            }
            this.Hide();
        }

        private void Form_exist2_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
    }
}

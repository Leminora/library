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
  
    public partial class Form_reader : Form
    {

        Database database = new Database();
        public Form_reader()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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
            dataGridView1.Columns.Add("Isnew", String.Empty);
            dataGridView1.Columns["Isnew"].Visible = false;
        }
        private void ReadSingleRow(DataGridView wha, IDataRecord record)
        {
            wha.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetString(5), record.GetString(6), Rowstate.ModifiedNew);

        }
        private void RefreshDataGrid(DataGridView wha)
        {
            wha.Rows.Clear();
            string queryString = $"select Readers.Readerid, RName.RName, Patronymic.Patronymic, Surname.Surname, Yearofbirth.Birthyear, Email.Email, Phonenumber.Number FROM Readers, RName, Patronymic, Surname, Yearofbirth, Email, Phonenumber WHERE Readers.Nid = RName.Nid AND Readers.Pid = Patronymic.Pid AND Readers.Surid = Surname.Sid AND Readers.YOBid = Yearofbirth.YOBid AND Readers.Eid = Email.Eid AND Readers.PNid = Phonenumber.PNid";
            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(wha, reader);
            }
            reader.Close();
        }
        private void deleteRow()
        {
            int Index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[Index].Visible = false;
            if (dataGridView1.Rows[Index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[Index].Cells[7].Value = Rowstate.Deleted;
                return;
            }
            dataGridView1.Rows[Index].Cells[7].Value = Rowstate.Deleted;

        }
        private void Update()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (Rowstate)dataGridView1.Rows[index].Cells[7].Value;
                if (rowState == Rowstate.Existed)
                    continue;
                if (rowState == Rowstate.Deleted)
                {
                    var id = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Readers where Readerid = '{id}'";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == Rowstate.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var patronymic = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var surname = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var birthday = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var email = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var phone = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var editQuery =
                    $"insert RName (RName) select '{name}' where not exists (select 1 from RName where RName = '{name}') \n" +
                    $"insert Patronymic (Patronymic) select '{patronymic}' where not exists (select 1 from Patronymic where Patronymic = '{patronymic}') \n" +
                    $"insert Surname (Surname) select '{surname}' where not exists (select 1 from Surname where Surname = '{surname}') \n" +
                    $"insert Yearofbirth (Birthyear) select '{birthday}' where not exists (select 1 from Yearofbirth where Birthyear = '{birthday}') \n" +
                    $"insert Email (Email) select '{email}' where not exists (select 1 from Email where Email = '{email}') \n" +
                    $"insert Phonenumber (Number) select '{phone}' where not exists (select 1 from Phonenumber where Number = '{phone}') \n" +
                    $"update Readers set Nid = (select Nid from RName where RName = '{name}'), Pid = (select Pid from Patronymic where Patronymic = '{patronymic}'), Surid = (select Sid from Surname where Surname = '{surname}'), YOBid = (select YOBid from Yearofbirth where Birthyear = '{birthday}'), Eid = (select Eid from Email where Email = '{email}'), PNid = (select PNid from Phonenumber where Number = '{phone}') where Readerid = '{id}'";

                    var command = new SqlCommand(editQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }
        private void Search(DataGridView wha)
        {
            wha.Rows.Clear();
            string searchString = $"select Readers.Readerid, RName.RName, Patronymic.Patronymic, Surname.Surname, Yearofbirth.Birthyear, Email.Email, Phonenumber.Number FROM Readers, RName, Patronymic, Surname, Yearofbirth, Email, Phonenumber WHERE Readers.Nid = RName.Nid AND Readers.Pid = Patronymic.Pid AND Readers.Surid = Surname.Sid AND Readers.YOBid = Yearofbirth.YOBid AND Readers.Eid = Email.Eid AND Readers.PNid = Phonenumber.PNid AND concat (RName, Patronymic, Surname, Birthyear, Email, Number) like '%" + textBox_search.Text + "%'";
            SqlCommand comm = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader red = comm.ExecuteReader();
            while (red.Read())
            {
                ReadSingleRow(wha, red);
            }
            red.Close();
        }
        private void Form_reader_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void new_reader_Click(object sender, EventArgs e)
        {
            Form_add_r addform = new Form_add_r();
            addform.Show();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button_main_Click(object sender, EventArgs e)
        {
            Form_main mainform = new Form_main();
            mainform.Show();
            this.Hide();
        }

        private void delete_reader_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void Change_reader_Click(object sender, EventArgs e)
        {
            Form_edit_r editform = new Form_edit_r(this);
            editform.ShowDialog();
        }

    }
}

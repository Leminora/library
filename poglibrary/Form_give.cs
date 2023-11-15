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
    public partial class Form_give : Form
    {
        Database database = new Database();
        public Form_give()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("RFid", String.Empty);
            dataGridView1.Columns["RFid"].Visible = false;
            dataGridView1.Columns.Add("Reader", "Читатель");
            dataGridView1.Columns.Add("Email", "Электронная почта");
            dataGridView1.Columns.Add("Phone", "Номер телефона");
            dataGridView1.Columns.Add("Title", "Название книги");
            dataGridView1.Columns.Add("Author", "Автор/-ка");
            dataGridView1.Columns.Add("Pyear", "Год издания");
            dataGridView1.Columns.Add("Phouse", "Издательство");
            dataGridView1.Columns.Add("Typ", "Тип услуги");
            dataGridView1.Columns.Add("Datestart", "Дата выдачи/оформления заказа");
            dataGridView1.Columns.Add("Dateend", "Дата возврата/прибытия заказа");
            dataGridView1.Columns.Add("Statuses", "Статус");
            dataGridView1.Columns.Add("Isnew", String.Empty);
            dataGridView1.Columns["Isnew"].Visible = false;
        }
        private void ReadSingleRow(DataGridView wha, IDataRecord record)
        {
            wha.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetInt32(6), record.GetString(7), record.GetString(8), record.GetDateTime(9), record.GetDateTime(10), record.GetString(11), Rowstate.ModifiedNew);

        }
        private void RefreshDataGrid(DataGridView wha)
        {
            wha.Rows.Clear();
            string queryString =
                $"select Readerforms.RFid, RName.RName + ' ' + Patronymic.Patronymic + ' ' + Surname.Surname as Reader, Email.Email, Phonenumber.Number, Titles.Title, Nameofauthor.Authorsname + ' ' + Patronymicofauthor.Apatronymic + ' ' + Surnameofauthor.Asurname as Author, Yearofpublishing.Pyear, Publishinghouse.Phouse, Tip.Typ, Readerforms.Date_S, Readerforms.Date_E, Status.Statuses from Readerforms, Readers, RName, Patronymic, Surname, Email, Phonenumber, Books, Titles, Nameofauthor, Patronymicofauthor, Surnameofauthor, Yearofpublishing, Publishinghouse, Tip, Status where Readerforms.RTid = Readers.Readerid and Readers.Nid = RName.Nid and Readers.Pid = Patronymic.Pid AND Readers.Surid = Surname.Sid and Readers.Eid = Email.Eid AND Readers.PNid = Phonenumber.PNid and Readerforms.Bookid = Books.Bid and Books.Titleid = Titles.Tid AND Books.YOPid = Yearofpublishing.YOPid AND Books.PHid = Publishinghouse.PHid and Books.NOAid = Nameofauthor.NOAid AND Books.POAid = Patronymicofauthor.POAid AND Books.SOAid = Surnameofauthor.SOAid and Readerforms.Typeid = Tip.Tid and Readerforms.Statusid = Status.Stid";
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
                dataGridView1.Rows[Index].Cells[12].Value = Rowstate.Deleted;
                return;
            }
            dataGridView1.Rows[Index].Cells[12].Value = Rowstate.Deleted;

        }
        private void Update()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (Rowstate)dataGridView1.Rows[index].Cells[12].Value;
                if (rowState == Rowstate.Existed)
                    continue;
                if (rowState == Rowstate.Deleted)
                {
                    var id = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Readerforms where RFid = '{id}'";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == Rowstate.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var type = dataGridView1.Rows[index].Cells[8].Value.ToString();
                    var date = dataGridView1.Rows[index].Cells[9].Value.ToString();
                    var date_e = dataGridView1.Rows[index].Cells[10].Value.ToString();
                    var status = dataGridView1.Rows[index].Cells[11].Value.ToString();
                    var editQuery =
                    $"update Readerforms set Typeid = (select Tid from Tip where Typ = '{type}'), Date_S = '{date}', Date_E = '{date_e}', Statusid = (select Stid from Status where Statuses = '{status}') where RFid = '{id}'";

                    var command = new SqlCommand(editQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }
        private void Search(DataGridView wha)
        {
            wha.Rows.Clear();
            string searchString = $"select Readerforms.RFid, RName.RName + ' ' + Patronymic.Patronymic + ' ' + Surname.Surname as Reader, Email.Email, Phonenumber.Number, Titles.Title, Nameofauthor.Authorsname + ' ' + Patronymicofauthor.Apatronymic + ' ' + Surnameofauthor.Asurname as Author, Yearofpublishing.Pyear, Publishinghouse.Phouse, Tip.Typ, Readerforms.Date_S, Readerforms.Date_E, Status.Statuses from Readerforms, Readers, RName, Patronymic, Surname, Email, Phonenumber, Books, Titles, Nameofauthor, Patronymicofauthor, Surnameofauthor, Yearofpublishing, Publishinghouse, Tip, Status where Readerforms.RTid = Readers.Readerid and Readers.Nid = RName.Nid and Readers.Pid = Patronymic.Pid AND Readers.Surid = Surname.Sid and Readers.Eid = Email.Eid AND Readers.PNid = Phonenumber.PNid and Readerforms.Bookid = Books.Bid and Books.Titleid = Titles.Tid AND Books.YOPid = Yearofpublishing.YOPid AND Books.PHid = Publishinghouse.PHid and Books.NOAid = Nameofauthor.NOAid AND Books.POAid = Patronymicofauthor.POAid AND Books.SOAid = Surnameofauthor.SOAid and Readerforms.Typeid = Tip.Tid and Readerforms.Statusid = Status.Stid AND concat (RName, Patronymic, Surname, Email, Number, Title, Authorsname, Apatronymic, Asurname, Pyear, Phouse, Typ, Date_S, Date_E, Statuses) like '%" + textBox_search.Text + "%'";
            SqlCommand comm = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader red = comm.ExecuteReader();
            while (red.Read())
            {
                ReadSingleRow(wha, red);
            }
            red.Close();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
            DateTime time = DateTime.Now.Date;
            DateTime time_p = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
            string type = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
            if (type == "Сдано" || type == "Забрано")
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MediumSpringGreen;
            }
            else if ((type == "Взято" || type == "В пути") && time_p < time)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSalmon;
            }
        }
        private void Form_give_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_main mainform = new Form_main();
            mainform.Show();
            this.Hide();
        }

        private void new_write_Click(object sender, EventArgs e)
        {
            Form_add_rf addform = new Form_add_rf();
            addform.Show();
        }

        private void Change_write_Click(object sender, EventArgs e)
        {
            Form_edit_rf editform = new Form_edit_rf(this);
            editform.ShowDialog();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void delete_write_Click(object sender, EventArgs e)
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
    }
}

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
    enum Rowstate
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form1 : Form
    {
        Database database = new Database();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Bid", String.Empty);
            dataGridView1.Columns["Bid"].Visible = false;
            dataGridView1.Columns.Add("Title", "Название книги");
            dataGridView1.Columns.Add("Authorsname", "Имя автора/-ки");
            dataGridView1.Columns.Add("Apatronymic", "Отчество автора/-ки");
            dataGridView1.Columns.Add("Asurname", "Фамилия автора/-ки");
            dataGridView1.Columns.Add("Pyear", "Год издания");
            dataGridView1.Columns.Add("Phouse", "Издательство");
            dataGridView1.Columns.Add("Genre", "Жанр");
            dataGridView1.Columns.Add("Exist", "Наличие");
            dataGridView1.Columns.Add("Isnew", String.Empty);
            dataGridView1.Columns["Isnew"].Visible = false;
        }
        private void ReadSingleRow(DataGridView wha, IDataRecord record)
        {
            wha.Rows.Add(record.GetInt32(0), record.GetString(1),record.GetString(2),record.GetString(3),record.GetString(4), record.GetInt32(5), record.GetString(6), record.GetString(7), record.GetString(8), Rowstate.ModifiedNew);

        }
        private void RefreshDataGrid(DataGridView wha)
        {
            wha.Rows.Clear();
            string queryString = $"select Books.Bid, Titles.Title, Nameofauthor.Authorsname, Patronymicofauthor.Apatronymic, Surnameofauthor.Asurname, Yearofpublishing.Pyear, Publishinghouse.Phouse, Genre.Genre, Existing.Exist FROM Books, Titles, Nameofauthor, Patronymicofauthor, Surnameofauthor, Yearofpublishing, Publishinghouse, Genre, Existing WHERE Books.Titleid = Titles.Tid AND Books.NOAid = Nameofauthor.NOAid AND Books.POAid = Patronymicofauthor.POAid AND Books.SOAid = Surnameofauthor.SOAid AND Books.YOPid = Yearofpublishing.YOPid AND Books.PHid = Publishinghouse.PHid AND Books.Gid = Genre.Gid AND Books.Exid = Existing.Eid";
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
                dataGridView1.Rows[Index].Cells[9].Value = Rowstate.Deleted;
                return;
            }
            dataGridView1.Rows[Index].Cells[9].Value = Rowstate.Deleted;

        }
        private void Update()
        {
            database.openConnection();
            for (int index =0;index<dataGridView1.Rows.Count; index++)
            {
                var rowState = (Rowstate)dataGridView1.Rows[index].Cells[9].Value;
                if (rowState == Rowstate.Existed)
                    continue;
                if (rowState == Rowstate.Deleted)
                {
                    var id = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Books where Bid = '{id}'";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == Rowstate.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var title = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var patronymic = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var surname = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var year = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var phouse = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var genre = dataGridView1.Rows[index].Cells[7].Value.ToString();
                    var ex = dataGridView1.Rows[index].Cells[8].Value.ToString();
                    var editQuery =
                    $"insert Titles (Title) select '{title}' where not exists (select 1 from Titles where Title = '{title}') \n" +
                    $"insert Nameofauthor (Authorsname) select '{name}' where not exists (select 1 from Nameofauthor where Authorsname = '{name}') \n" +
                    $"insert Patronymicofauthor (Apatronymic) select '{patronymic}' where not exists (select 1 from Patronymicofauthor where Apatronymic = '{patronymic}') \n" +
                    $"insert Surnameofauthor (Asurname) select '{surname}' where not exists (select 1 from Surnameofauthor where Asurname = '{surname}') \n" +
                    $"insert Yearofpublishing (Pyear) select '{year}' where not exists (select 1 from Yearofpublishing where Pyear = '{year}') \n" +
                    $"insert Publishinghouse (Phouse) select '{phouse}' where not exists (select 1 from Publishinghouse where Phouse = '{phouse}') \n" +
                    $"insert Genre (Genre) select '{genre}' where not exists (select 1 from Genre where Genre = '{genre}') \n" +
                    $"update Books set Titleid = (select Tid from Titles where Title = '{title}'), NOAid = (select NOAid from Nameofauthor where Authorsname = '{name}'), POAid = (select POAid from Patronymicofauthor where Apatronymic = '{patronymic}'), SOAid = (select SOAid from Surnameofauthor where Asurname = '{surname}'), YOPid = (select YOPid from Yearofpublishing where Pyear = '{year}'), PHid = (select PHid from Publishinghouse where Phouse = '{phouse}'), Gid = (select Gid from Genre where Genre = '{genre}'), Exid = (select Eid from Existing where Exist = '{ex}') where Bid = '{id}'";

                    var command = new SqlCommand(editQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel_down_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void new_book_Click(object sender, EventArgs e)
        {
            Form_add addform = new Form_add();
            addform.Show();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
        public void Search(DataGridView wha)
        {
            wha.Rows.Clear();
            string searchString = $"select Books.Bid, Titles.Title, Nameofauthor.Authorsname, Patronymicofauthor.Apatronymic, Surnameofauthor.Asurname, Yearofpublishing.Pyear, Publishinghouse.Phouse, Genre.Genre, Existing.Exist FROM Books, Titles, Nameofauthor, Patronymicofauthor, Surnameofauthor, Yearofpublishing, Publishinghouse, Genre, Existing WHERE Books.Titleid = Titles.Tid AND Books.NOAid = Nameofauthor.NOAid AND Books.POAid = Patronymicofauthor.POAid AND Books.SOAid = Surnameofauthor.SOAid AND Books.YOPid = Yearofpublishing.YOPid AND Books.PHid = Publishinghouse.PHid AND Books.Gid = Genre.Gid AND Books.Exid = Existing.Eid AND concat (Title, Authorsname, Apatronymic, Asurname, Pyear, Phouse, Genre, Exist) like '%" + textBox_search.Text + "%'";
            SqlCommand comm = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader red = comm.ExecuteReader();
            while (red.Read())
            {
                ReadSingleRow(wha, red);
            }
            red.Close();
        }
        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void delete_book_Click(object sender, EventArgs e)
        {
            deleteRow();
            
        }

        private void Change_book_Click(object sender, EventArgs e)
        {
            
            Form_edit editform = new Form_edit(this);
            editform.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_main mainform = new Form_main();
            mainform.Show();
            this.Hide();
        }
    }
}

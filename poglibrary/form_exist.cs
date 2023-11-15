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
    public partial class form_exist : Form
    {
        Form_add_rf a;
        Database database = new Database();
        public form_exist(Form_add_rf a)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.a = a;
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
        }
        private void ReadSingleRow(DataGridView wha, IDataRecord record)
        {
            wha.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetInt32(5), record.GetString(6), record.GetString(7), record.GetString(8), Rowstate.ModifiedNew);

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
        private void Search(DataGridView wha)
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void form_exist_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[Index];
                a.textBox_book.Text = row.Cells[0].Value.ToString();

            }
            this.Hide();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
    }
}

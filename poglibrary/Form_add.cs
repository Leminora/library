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
    public partial class Form_add : Form
    {
        Database database = new Database();
        public Form_add()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var title = textBox_title.Text;
            var name = textBox_name.Text;
            var patronymic = textBox_patronymic.Text;
            var surname = textBox_surname.Text;
            int year;
            var phouse = textBox_publish.Text;
            var genre = textBox_genre.Text;
            var ex = comboBox1.Text;
            if ( int.TryParse(textBox_year.Text, out year))
            {
                var addQuery =
                    $"insert Titles (Title) select '{title}' where not exists (select 1 from Titles where Title = '{title}') \n" +
                    $"insert Nameofauthor (Authorsname) select '{name}' where not exists (select 1 from Nameofauthor where Authorsname = '{name}') \n" +
                    $"insert Patronymicofauthor (Apatronymic) select '{patronymic}' where not exists (select 1 from Patronymicofauthor where Apatronymic = '{patronymic}') \n" +
                    $"insert Surnameofauthor (Asurname) select '{surname}' where not exists (select 1 from Surnameofauthor where Asurname = '{surname}') \n" +
                    $"insert Yearofpublishing (Pyear) select '{year}' where not exists (select 1 from Yearofpublishing where Pyear = '{year}') \n" +
                    $"insert Publishinghouse (Phouse) select '{phouse}' where not exists (select 1 from Publishinghouse where Phouse = '{phouse}') \n" +
                    $"insert Genre (Genre) select '{genre}' where not exists (select 1 from Genre where Genre = '{genre}') \n" +
                    $"insert into Books (Titleid, NOAid, POAid, SOAid, YOPid, PHid, Gid, Exid) values ((select Tid from Titles where Title = '{title}'), (select NOAid from Nameofauthor where Authorsname='{name}'), (select POAid from Patronymicofauthor where Apatronymic='{patronymic}'), (select SOAid from Surnameofauthor where Asurname='{surname}'), (select YOPid from Yearofpublishing where Pyear='{year}'), (select PHid from Publishinghouse where Phouse='{phouse}'), (select Gid from Genre where Genre='{genre}'), (select Eid from Existing where Exist='{ex}'))";
               
                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Использовался не числовой формат для года!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }             
    }
}

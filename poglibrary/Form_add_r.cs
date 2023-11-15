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
    public partial class Form_add_r : Form
    {
        Database database = new Database();
        public Form_add_r()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var name = textBox_name.Text;
            var patronymic = textBox_patronymic.Text;
            var surname = textBox_surname.Text;
            int year;
            var email = textBox_email.Text;
            double phone;
            if (double.TryParse(textBox_phone.Text, out phone))
            {
                if (int.TryParse(textBox_birthday.Text, out year))
                {
                    var addQuery =
                        $"insert RName (RName) select '{name}' where not exists (select 1 from RName where RName = '{name}') \n" +
                        $"insert Patronymic (Patronymic) select '{patronymic}' where not exists (select 1 from Patronymic where Patronymic = '{patronymic}') \n" +
                        $"insert Surname (Surname) select '{surname}' where not exists (select 1 from Surname where Surname = '{surname}') \n" +
                        $"insert Yearofbirth (Birthyear) select '{year}' where not exists (select 1 from Yearofbirth where Birthyear = '{year}') \n" +
                        $"insert Email (Email) select '{email}' where not exists (select 1 from Email where Email = '{email}') \n" +
                        $"insert Phonenumber (Number) select '{phone}' where not exists (select 1 from Phonenumber where Number = '{phone}') \n" +
                        $"insert into Readers (Nid, Pid, Surid, YOBid, Eid, PNid) values ((select Nid from RName where RName='{name}'), (select Pid from Patronymic where Patronymic='{patronymic}'), (select Sid from Surname where Surname='{surname}'), (select YOBid from Yearofbirth where Birthyear='{year}'), (select Eid from Email where Email='{email}'), (select PNid from Phonenumber where Number='{phone}'))";

                    var command = new SqlCommand(addQuery, database.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Использовался не числовой формат для года!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("Использовался не числовой формат для номера телефона!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }
    }
}

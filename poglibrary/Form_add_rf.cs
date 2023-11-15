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
    public partial class Form_add_rf : Form
    {
        Database database = new Database();
        public Form_add_rf()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_reader_Click(object sender, EventArgs e)
        {
            form_exist list = new form_exist(this);
            list.ShowDialog();
        }

        private void button_book_Click(object sender, EventArgs e)
        {
            Form_exist2 list = new Form_exist2(this);
            list.ShowDialog();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var reader = textBox_reader.Text;
            var book = textBox_book.Text;
            var type = comboBox1.Text;
            DateTime date;
            DateTime datee;
            var status = comboBox2.Text;
            var now = Convert.ToDateTime(textBox_date_e.Text);
            var time = DateTime.Now.Date;
            if (DateTime.TryParse(textBox_date.Text, out date) && DateTime.TryParse(textBox_date_e.Text, out datee))
            {
                if (date <= time)
                {
                    if (((status == "В пути" || status == "Доставлено" || status == "Забрано") && type == "Взять на время") || ((status == "Взято" || status == "Сдано") && type == "Заказ") )
                    {
                        MessageBox.Show("Пожалуйста, введите статус, подходящий типу выбранной услуги", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else
                    {
                        var addQuery =
                            $"insert into Readerforms (RTid, Bookid, Typeid, Date_S, Date_E, Statusid) values ((select Readerid from Readers where Readerid = '{reader}'), (select Bid from Books where Bid='{book}'), (select Tid from Tip where Typ='{type}'), '{date}', '{now}', (select Stid from Status where Statuses='{status}'))";

                        var command = new SqlCommand(addQuery, database.getConnection());
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите дату, не превышающую текущую", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Не введён правильно формат даты в поля дат, попробуйте ГГГГ-ММ-ДД", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }
    }
}

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
    public partial class Form_edit_rf : Form
    {
        Form_give form;
        public Form_edit_rf(Form_give form)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.form = form;
        }
        private void Showdata()
        {

            int Index = form.dataGridView1.CurrentCell.RowIndex;

            if (Index >= 0)
            {
                DataGridViewRow row = form.dataGridView1.Rows[Index];
                comboBox1.Text = row.Cells[8].Value.ToString();
                textBox_date.Text = row.Cells[9].Value.ToString();
                textBox_date_e.Text = row.Cells[10].Value.ToString();
                comboBox2.Text = row.Cells[11].Value.ToString();
            }

        }
        public void Change()
        {

            int Index = form.dataGridView1.CurrentCell.RowIndex;
            var id = form.dataGridView1.Rows[Index].Cells[0].Value.ToString();
            var reader = form.dataGridView1.Rows[Index].Cells[1].Value.ToString();
            var email = form.dataGridView1.Rows[Index].Cells[2].Value.ToString();
            var phone = form.dataGridView1.Rows[Index].Cells[3].Value.ToString();
            var title = form.dataGridView1.Rows[Index].Cells[4].Value.ToString();
            var author = form.dataGridView1.Rows[Index].Cells[5].Value.ToString();
            var year = form.dataGridView1.Rows[Index].Cells[6].Value.ToString();
            var house = form.dataGridView1.Rows[Index].Cells[7].Value.ToString();
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
                    if (((status == "В пути" || status == "Доставлено" || status == "Забрано") && type == "Взять на время") || ((status == "Взято" || status == "Сдано") && type == "Заказ"))
                    {
                        MessageBox.Show("Пожалуйста, введите статус, подходящий типу выбранной услуги", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        form.dataGridView1.Rows[Index].SetValues(id, reader, email, phone, title, author, year, house, type, date, now, status);
                        form.dataGridView1.Rows[Index].Cells[12].Value = Rowstate.Modified;
                        MessageBox.Show("Запись отредактирована!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

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

        }

        private void Form_edit_rf_Load(object sender, EventArgs e)
        {
            Showdata();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Change();
        }
    }
}

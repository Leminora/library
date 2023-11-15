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
    public partial class Form_edit_r : Form
    {
        Form_reader form;
        public Form_edit_r(Form_reader form)
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
                textBox_name.Text = row.Cells[1].Value.ToString();
                textBox_patronymic.Text = row.Cells[2].Value.ToString();
                textBox_surname.Text = row.Cells[3].Value.ToString();
                textBox_birthday.Text = row.Cells[4].Value.ToString();
                textBox_email.Text = row.Cells[5].Value.ToString();
                textBox_phone.Text = row.Cells[6].Value.ToString();
            }
        }
        public void Change()
        {

            int Index = form.dataGridView1.CurrentCell.RowIndex;
            var id = form.dataGridView1.Rows[Index].Cells[0].Value.ToString();
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
                    form.dataGridView1.Rows[Index].SetValues(id, name, patronymic, surname, year, email);
                    form.dataGridView1.Rows[Index].Cells[7].Value = Rowstate.Modified;
                    MessageBox.Show("Запись отредактирована!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Использовался не числовой формат для года!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Использовался не числовой формат для номера телефона!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void Form_edit_r_Load(object sender, EventArgs e)
        {
            Showdata();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Change();
        }
    }
}

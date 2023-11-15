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
    public partial class Form_edit : Form
    {
        Form1 form;
        public Form_edit(Form1 ff)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.form = ff;
            
        }
        private void Showdata()
        {
            
            int Index = form.dataGridView1.CurrentCell.RowIndex;
            
            if (Index >= 0)
            {
                DataGridViewRow row = form.dataGridView1.Rows[Index];
                textBox_title.Text = row.Cells[1].Value.ToString();
                textBox_name.Text = row.Cells[2].Value.ToString();
                textBox_patronymic.Text = row.Cells[3].Value.ToString();
                textBox_surname.Text = row.Cells[4].Value.ToString();
                textBox_year.Text = row.Cells[5].Value.ToString();
                textBox_publish.Text = row.Cells[6].Value.ToString();
                textBox_genre.Text = row.Cells[7].Value.ToString();
                comboBox1.Text = row.Cells[8].Value.ToString();
            }
        }
        
        public void Change()
        {
             
            int Index = form.dataGridView1.CurrentCell.RowIndex;
            var id = form.dataGridView1.Rows[Index].Cells[0].Value.ToString();
            var title = textBox_title.Text;
            var name = textBox_name.Text;
            var patronymic = textBox_patronymic.Text;
            var surname = textBox_surname.Text;
            int year;
            var phouse = textBox_publish.Text;
            var genre = textBox_genre.Text;
            var ex = comboBox1.Text;
            if (int.TryParse(textBox_year.Text, out year))
            {
                form.dataGridView1.Rows[Index].SetValues(id, title, name, patronymic, surname, year, phouse, genre, ex);
                form.dataGridView1.Rows[Index].Cells[9].Value = Rowstate.Modified;
                MessageBox.Show("Запись отредактирована!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Использовался не числовой формат для года!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Change();
        }


        private void Form_edit_Load(object sender, EventArgs e)
        {
            Showdata();
        }

        private void textBox_title_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

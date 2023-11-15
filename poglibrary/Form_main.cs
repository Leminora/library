using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poglibrary
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_books_Click(object sender, EventArgs e)
        {
            Form1 bookform = new Form1();
            bookform.Show();
            this.Hide();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }

        private void button_reader_Click(object sender, EventArgs e)
        {
            Form_reader raederform = new Form_reader();
            raederform.Show();
            this.Hide();
        }

        private void button_dolg_Click(object sender, EventArgs e)
        {
            Form_give giveform = new Form_give();
            giveform.Show();
            this.Hide();
        }
    }
}

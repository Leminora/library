namespace poglibrary
{
    partial class Form_add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_patronymic = new System.Windows.Forms.TextBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_publish = new System.Windows.Forms.TextBox();
            this.panel_up = new System.Windows.Forms.Panel();
            this.label_add = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_genre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel_up.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(152, 76);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(421, 20);
            this.textBox_title.TabIndex = 1;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(152, 102);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(421, 20);
            this.textBox_name.TabIndex = 2;
            // 
            // textBox_patronymic
            // 
            this.textBox_patronymic.Location = new System.Drawing.Point(152, 128);
            this.textBox_patronymic.Name = "textBox_patronymic";
            this.textBox_patronymic.Size = new System.Drawing.Size(420, 20);
            this.textBox_patronymic.TabIndex = 3;
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(152, 179);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(421, 20);
            this.textBox_year.TabIndex = 4;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(152, 153);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(421, 20);
            this.textBox_surname.TabIndex = 5;
            // 
            // textBox_publish
            // 
            this.textBox_publish.Location = new System.Drawing.Point(152, 205);
            this.textBox_publish.Name = "textBox_publish";
            this.textBox_publish.Size = new System.Drawing.Size(421, 20);
            this.textBox_publish.TabIndex = 6;
            this.textBox_publish.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // panel_up
            // 
            this.panel_up.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_up.Controls.Add(this.label_add);
            this.panel_up.Location = new System.Drawing.Point(12, 12);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(562, 58);
            this.panel_up.TabIndex = 7;
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add.Location = new System.Drawing.Point(136, 17);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(312, 25);
            this.label_add.TabIndex = 16;
            this.label_add.Text = "Создание новой записи книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя автора/-ки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Отчество автора/-ки";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Фамилия автора/-ки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Название книги";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Год издания";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Издательство";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Жанр";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Thistle;
            this.button_save.Location = new System.Drawing.Point(252, 300);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 16;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_genre
            // 
            this.textBox_genre.Location = new System.Drawing.Point(152, 231);
            this.textBox_genre.Name = "textBox_genre";
            this.textBox_genre.Size = new System.Drawing.Size(420, 20);
            this.textBox_genre.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Наличие";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "В наличии",
            "Нет в наличии"});
            this.comboBox1.Location = new System.Drawing.Point(152, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(420, 21);
            this.comboBox1.TabIndex = 39;
            // 
            // Form_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 335);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_genre);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_up);
            this.Controls.Add(this.textBox_publish);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.textBox_patronymic);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_title);
            this.Name = "Form_add";
            this.Text = "Form_add";
            this.panel_up.ResumeLayout(false);
            this.panel_up.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_patronymic;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_publish;
        private System.Windows.Forms.Panel panel_up;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_genre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
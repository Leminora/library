namespace poglibrary
{
    partial class Form_add_rf
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
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_book = new System.Windows.Forms.TextBox();
            this.textBox_reader = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_up = new System.Windows.Forms.Panel();
            this.label_add = new System.Windows.Forms.Label();
            this.button_reader = new System.Windows.Forms.Button();
            this.button_book = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_date_e = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_up.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(208, 154);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(330, 20);
            this.textBox_date.TabIndex = 72;
            // 
            // textBox_book
            // 
            this.textBox_book.Location = new System.Drawing.Point(208, 102);
            this.textBox_book.Name = "textBox_book";
            this.textBox_book.Size = new System.Drawing.Size(330, 20);
            this.textBox_book.TabIndex = 69;
            // 
            // textBox_reader
            // 
            this.textBox_reader.Location = new System.Drawing.Point(208, 76);
            this.textBox_reader.Name = "textBox_reader";
            this.textBox_reader.Size = new System.Drawing.Size(330, 20);
            this.textBox_reader.TabIndex = 68;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Thistle;
            this.button_save.Location = new System.Drawing.Point(260, 233);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 67;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Читатель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Дата выдачи/оформления заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Тип услуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Книга";
            // 
            // panel_up
            // 
            this.panel_up.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_up.Controls.Add(this.label_add);
            this.panel_up.Location = new System.Drawing.Point(12, 12);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(562, 58);
            this.panel_up.TabIndex = 60;
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add.Location = new System.Drawing.Point(166, 16);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(251, 25);
            this.label_add.TabIndex = 16;
            this.label_add.Text = "Создание новой записи";
            // 
            // button_reader
            // 
            this.button_reader.Location = new System.Drawing.Point(543, 102);
            this.button_reader.Name = "button_reader";
            this.button_reader.Size = new System.Drawing.Size(30, 20);
            this.button_reader.TabIndex = 74;
            this.button_reader.Text = "...";
            this.button_reader.UseVisualStyleBackColor = true;
            this.button_reader.Click += new System.EventHandler(this.button_reader_Click);
            // 
            // button_book
            // 
            this.button_book.Location = new System.Drawing.Point(543, 76);
            this.button_book.Name = "button_book";
            this.button_book.Size = new System.Drawing.Size(30, 20);
            this.button_book.TabIndex = 75;
            this.button_book.Text = "...";
            this.button_book.UseVisualStyleBackColor = true;
            this.button_book.Click += new System.EventHandler(this.button_book_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Заказ",
            "Взять на время"});
            this.comboBox1.Location = new System.Drawing.Point(208, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(330, 21);
            this.comboBox1.TabIndex = 76;
            // 
            // textBox_date_e
            // 
            this.textBox_date_e.Location = new System.Drawing.Point(208, 180);
            this.textBox_date_e.Name = "textBox_date_e";
            this.textBox_date_e.Size = new System.Drawing.Size(330, 20);
            this.textBox_date_e.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Дата возрата/выдачи заказа";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "В пути",
            "Доставлено",
            "Забрано",
            "Взято",
            "Сдано"});
            this.comboBox2.Location = new System.Drawing.Point(208, 206);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(330, 21);
            this.comboBox2.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Статус";
            // 
            // Form_add_rf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 260);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_date_e);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_book);
            this.Controls.Add(this.button_reader);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_book);
            this.Controls.Add(this.textBox_reader);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_up);
            this.Name = "Form_add_rf";
            this.Text = "Form_add_rf";
            this.panel_up.ResumeLayout(false);
            this.panel_up.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_up;
        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.Button button_reader;
        public System.Windows.Forms.TextBox textBox_reader;
        public System.Windows.Forms.TextBox textBox_book;
        private System.Windows.Forms.Button button_book;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_date_e;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
    }
}
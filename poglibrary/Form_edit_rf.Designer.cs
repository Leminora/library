namespace poglibrary
{
    partial class Form_edit_rf
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_date_e = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_up = new System.Windows.Forms.Panel();
            this.label_add = new System.Windows.Forms.Label();
            this.panel_up.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "Статус";
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
            this.comboBox2.Location = new System.Drawing.Point(208, 157);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(330, 21);
            this.comboBox2.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Дата возрата/выдачи заказа";
            // 
            // textBox_date_e
            // 
            this.textBox_date_e.Location = new System.Drawing.Point(208, 131);
            this.textBox_date_e.Name = "textBox_date_e";
            this.textBox_date_e.Size = new System.Drawing.Size(330, 20);
            this.textBox_date_e.TabIndex = 93;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Заказ",
            "Взять на время"});
            this.comboBox1.Location = new System.Drawing.Point(208, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(330, 21);
            this.comboBox1.TabIndex = 92;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(208, 103);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(330, 20);
            this.textBox_date.TabIndex = 89;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Thistle;
            this.button_save.Location = new System.Drawing.Point(252, 184);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 86;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Дата выдачи/оформления заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Тип услуги";
            // 
            // panel_up
            // 
            this.panel_up.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_up.Controls.Add(this.label_add);
            this.panel_up.Location = new System.Drawing.Point(12, 12);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(562, 58);
            this.panel_up.TabIndex = 81;
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
            // Form_edit_rf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 216);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_date_e);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_up);
            this.Name = "Form_edit_rf";
            this.Text = "Form_edit_rf";
            this.Load += new System.EventHandler(this.Form_edit_rf_Load);
            this.panel_up.ResumeLayout(false);
            this.panel_up.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_date_e;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_up;
        private System.Windows.Forms.Label label_add;
    }
}
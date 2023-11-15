namespace poglibrary
{
    partial class Form_give
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
            this.panel_down = new System.Windows.Forms.Panel();
            this.delete_write = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Change_write = new System.Windows.Forms.Button();
            this.new_write = new System.Windows.Forms.Button();
            this.panel_up = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_down.SuspendLayout();
            this.panel_up.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_down
            // 
            this.panel_down.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_down.Controls.Add(this.delete_write);
            this.panel_down.Controls.Add(this.button_refresh);
            this.panel_down.Controls.Add(this.button_search);
            this.panel_down.Controls.Add(this.label2);
            this.panel_down.Controls.Add(this.Change_write);
            this.panel_down.Controls.Add(this.new_write);
            this.panel_down.Location = new System.Drawing.Point(2, 348);
            this.panel_down.Name = "panel_down";
            this.panel_down.Size = new System.Drawing.Size(998, 100);
            this.panel_down.TabIndex = 18;
            // 
            // delete_write
            // 
            this.delete_write.BackColor = System.Drawing.Color.Thistle;
            this.delete_write.Location = new System.Drawing.Point(431, 45);
            this.delete_write.Name = "delete_write";
            this.delete_write.Size = new System.Drawing.Size(146, 24);
            this.delete_write.TabIndex = 14;
            this.delete_write.Text = "Удаление записи";
            this.delete_write.UseVisualStyleBackColor = false;
            this.delete_write.Click += new System.EventHandler(this.delete_write_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.Thistle;
            this.button_refresh.Location = new System.Drawing.Point(818, 45);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(155, 23);
            this.button_refresh.TabIndex = 14;
            this.button_refresh.Text = "Обновление базы данных";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.Thistle;
            this.button_search.Location = new System.Drawing.Point(626, 45);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(142, 23);
            this.button_search.TabIndex = 13;
            this.button_search.Text = "Сохранить изменения";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(427, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Управление записями";
            // 
            // Change_write
            // 
            this.Change_write.BackColor = System.Drawing.Color.Thistle;
            this.Change_write.Location = new System.Drawing.Point(216, 46);
            this.Change_write.Name = "Change_write";
            this.Change_write.Size = new System.Drawing.Size(146, 23);
            this.Change_write.TabIndex = 2;
            this.Change_write.Text = "Изменение записи";
            this.Change_write.UseVisualStyleBackColor = false;
            this.Change_write.Click += new System.EventHandler(this.Change_write_Click);
            // 
            // new_write
            // 
            this.new_write.BackColor = System.Drawing.Color.Thistle;
            this.new_write.Location = new System.Drawing.Point(25, 46);
            this.new_write.Name = "new_write";
            this.new_write.Size = new System.Drawing.Size(141, 23);
            this.new_write.TabIndex = 0;
            this.new_write.Text = "Новая запись";
            this.new_write.UseVisualStyleBackColor = false;
            this.new_write.Click += new System.EventHandler(this.new_write_Click);
            // 
            // panel_up
            // 
            this.panel_up.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_up.Controls.Add(this.button1);
            this.panel_up.Controls.Add(this.textBox_search);
            this.panel_up.Controls.Add(this.label1);
            this.panel_up.Location = new System.Drawing.Point(2, 3);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(998, 62);
            this.panel_up.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Location = new System.Drawing.Point(898, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(664, 21);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(180, 20);
            this.textBox_search.TabIndex = 1;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "База данных библиотеки";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(998, 271);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // Form_give
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.panel_down);
            this.Controls.Add(this.panel_up);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_give";
            this.Text = "Form_give";
            this.Load += new System.EventHandler(this.Form_give_Load);
            this.panel_down.ResumeLayout(false);
            this.panel_down.PerformLayout();
            this.panel_up.ResumeLayout(false);
            this.panel_up.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_down;
        private System.Windows.Forms.Button delete_write;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Change_write;
        private System.Windows.Forms.Button new_write;
        private System.Windows.Forms.Panel panel_up;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}
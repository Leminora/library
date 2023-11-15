namespace poglibrary
{
    partial class Form_main
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_books = new System.Windows.Forms.Button();
            this.button_reader = new System.Windows.Forms.Button();
            this.button_dolg = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "База данных библиотеки";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 79);
            this.panel1.TabIndex = 1;
            // 
            // button_books
            // 
            this.button_books.BackColor = System.Drawing.Color.Thistle;
            this.button_books.Location = new System.Drawing.Point(148, 104);
            this.button_books.Name = "button_books";
            this.button_books.Size = new System.Drawing.Size(169, 36);
            this.button_books.TabIndex = 2;
            this.button_books.Text = "База данных книг";
            this.button_books.UseVisualStyleBackColor = false;
            this.button_books.Click += new System.EventHandler(this.button_books_Click);
            // 
            // button_reader
            // 
            this.button_reader.BackColor = System.Drawing.Color.Thistle;
            this.button_reader.Location = new System.Drawing.Point(148, 155);
            this.button_reader.Name = "button_reader";
            this.button_reader.Size = new System.Drawing.Size(169, 36);
            this.button_reader.TabIndex = 5;
            this.button_reader.Text = "База данных читательских билетов";
            this.button_reader.UseVisualStyleBackColor = false;
            this.button_reader.Click += new System.EventHandler(this.button_reader_Click);
            // 
            // button_dolg
            // 
            this.button_dolg.BackColor = System.Drawing.Color.Thistle;
            this.button_dolg.Location = new System.Drawing.Point(148, 208);
            this.button_dolg.Name = "button_dolg";
            this.button_dolg.Size = new System.Drawing.Size(169, 36);
            this.button_dolg.TabIndex = 6;
            this.button_dolg.Text = "База данных формуляров";
            this.button_dolg.UseVisualStyleBackColor = false;
            this.button_dolg.Click += new System.EventHandler(this.button_dolg_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 265);
            this.Controls.Add(this.button_dolg);
            this.Controls.Add(this.button_reader);
            this.Controls.Add(this.button_books);
            this.Controls.Add(this.panel1);
            this.Name = "Form_main";
            this.Text = "Form_main";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_books;
        private System.Windows.Forms.Button button_reader;
        private System.Windows.Forms.Button button_dolg;
    }
}
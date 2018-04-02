namespace BooksStorage
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AuthorList = new System.Windows.Forms.ListBox();
            this.BookList = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbFilterName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbFilterBook = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb2BookList = new System.Windows.Forms.ListBox();
            this.tb2AuthorList = new System.Windows.Forms.ListBox();
            this.tbPriceBegin = new System.Windows.Forms.TextBox();
            this.tbPriceEnd = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthorList
            // 
            this.AuthorList.DisplayMember = "Name";
            this.AuthorList.FormattingEnabled = true;
            this.AuthorList.ItemHeight = 16;
            this.AuthorList.Location = new System.Drawing.Point(22, 54);
            this.AuthorList.Name = "AuthorList";
            this.AuthorList.Size = new System.Drawing.Size(324, 356);
            this.AuthorList.TabIndex = 0;
            this.AuthorList.Click += new System.EventHandler(this.AuthorList_Click);
            // 
            // BookList
            // 
            this.BookList.DisplayMember = "Name";
            this.BookList.FormattingEnabled = true;
            this.BookList.ItemHeight = 16;
            this.BookList.Location = new System.Drawing.Point(361, 118);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(324, 292);
            this.BookList.TabIndex = 1;
            this.BookList.ValueMember = "Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 514);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbFilterName);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AuthorList);
            this.tabPage1.Controls.Add(this.BookList);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Авторы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbFilterName
            // 
            this.tbFilterName.Location = new System.Drawing.Point(143, 26);
            this.tbFilterName.Name = "tbFilterName";
            this.tbFilterName.Size = new System.Drawing.Size(203, 22);
            this.tbFilterName.TabIndex = 13;
            this.tbFilterName.TextChanged += new System.EventHandler(this.tbFilterName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Поиск по имени:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Список авторов:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "Удалить автора";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 416);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 40);
            this.button4.TabIndex = 9;
            this.button4.Text = "Добавить автора";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Удалить книгу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить книгу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(352, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Список написанных книг:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(412, 49);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(273, 22);
            this.tbName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbPriceEnd);
            this.tabPage2.Controls.Add(this.tbPriceBegin);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tbFilterBook);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tbPrice);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbBookName);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tb2BookList);
            this.tabPage2.Controls.Add(this.tb2AuthorList);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(801, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Книги";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(153, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 17);
            this.label14.TabIndex = 36;
            this.label14.Text = "До";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(162, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "С";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Цена:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tbFilterBook
            // 
            this.tbFilterBook.Location = new System.Drawing.Point(156, 27);
            this.tbFilterBook.Name = "tbFilterBook";
            this.tbFilterBook.Size = new System.Drawing.Size(194, 22);
            this.tbFilterBook.TabIndex = 31;
            this.tbFilterBook.TextChanged += new System.EventHandler(this.tbFilterBook_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Поиск по названию:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(497, 90);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(273, 22);
            this.tbPrice.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Цена:";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(497, 55);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(273, 22);
            this.tbBookName.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Название:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Список книг:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(179, 417);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 40);
            this.button5.TabIndex = 22;
            this.button5.Text = "Удалить книгу";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(26, 417);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 40);
            this.button6.TabIndex = 21;
            this.button6.Text = "Добавить книгу";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(518, 417);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 40);
            this.button7.TabIndex = 20;
            this.button7.Text = "Удалить автора";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(365, 417);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(147, 40);
            this.button8.TabIndex = 19;
            this.button8.Text = "Добавить автора";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(360, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Список авторов:";
            // 
            // tb2BookList
            // 
            this.tb2BookList.DisplayMember = "Name";
            this.tb2BookList.FormattingEnabled = true;
            this.tb2BookList.ItemHeight = 16;
            this.tb2BookList.Location = new System.Drawing.Point(26, 119);
            this.tb2BookList.Name = "tb2BookList";
            this.tb2BookList.Size = new System.Drawing.Size(324, 292);
            this.tb2BookList.TabIndex = 12;
            this.tb2BookList.ValueMember = "Name";
            this.tb2BookList.Click += new System.EventHandler(this.tb2BookList_Click);
            // 
            // tb2AuthorList
            // 
            this.tb2AuthorList.DisplayMember = "Name";
            this.tb2AuthorList.FormattingEnabled = true;
            this.tb2AuthorList.ItemHeight = 16;
            this.tb2AuthorList.Location = new System.Drawing.Point(365, 167);
            this.tb2AuthorList.Name = "tb2AuthorList";
            this.tb2AuthorList.Size = new System.Drawing.Size(324, 244);
            this.tb2AuthorList.TabIndex = 13;
            this.tb2AuthorList.ValueMember = "Name";
            // 
            // tbPriceBegin
            // 
            this.tbPriceBegin.Location = new System.Drawing.Point(195, 55);
            this.tbPriceBegin.Name = "tbPriceBegin";
            this.tbPriceBegin.Size = new System.Drawing.Size(155, 22);
            this.tbPriceBegin.TabIndex = 37;
            this.tbPriceBegin.TextChanged += new System.EventHandler(this.tbFilterBook_TextChanged);
            // 
            // tbPriceEnd
            // 
            this.tbPriceEnd.Location = new System.Drawing.Point(195, 83);
            this.tbPriceEnd.Name = "tbPriceEnd";
            this.tbPriceEnd.Size = new System.Drawing.Size(155, 22);
            this.tbPriceEnd.TabIndex = 38;
            this.tbPriceEnd.TextChanged += new System.EventHandler(this.tbFilterBook_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 512);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Книжный каталог";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AuthorList;
        private System.Windows.Forms.ListBox BookList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox tb2BookList;
        private System.Windows.Forms.ListBox tb2AuthorList;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFilterName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbFilterBook;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbPriceEnd;
        private System.Windows.Forms.TextBox tbPriceBegin;
    }
}


namespace BooksStorage.Windows
{
    partial class AddBookJob
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
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.AuthorList = new System.Windows.Forms.ComboBox();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Имя автора:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(289, 21);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.Text = "Добавить информацию о новом авторе";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // AuthorList
            // 
            this.AuthorList.DisplayMember = "Name";
            this.AuthorList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorList.FormattingEnabled = true;
            this.AuthorList.Location = new System.Drawing.Point(165, 40);
            this.AuthorList.Name = "AuthorList";
            this.AuthorList.Size = new System.Drawing.Size(274, 24);
            this.AuthorList.TabIndex = 33;
            this.AuthorList.ValueMember = "Name";
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Checked = true;
            this.rbAdd.Location = new System.Drawing.Point(22, 13);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(164, 21);
            this.rbAdd.TabIndex = 32;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Добавить авторство";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 28);
            this.button2.TabIndex = 29;
            this.button2.Text = "Добавить информацию о авторе";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 28);
            this.button1.TabIndex = 28;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(165, 120);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(273, 22);
            this.tbName.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Имя:";
            // 
            // AddBookJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 203);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.AuthorList);
            this.Controls.Add(this.rbAdd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AddBookJob";
            this.Text = "Добавить информацию об авторе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox AuthorList;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
    }
}
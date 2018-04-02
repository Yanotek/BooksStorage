using BooksStorage.AppData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksStorage.Windows
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbName.Text != null && tbName.Text != "")
            {
                Book book = new Book()
                {
                    Name = tbName.Text,
                    Price = int.Parse(tbPrice.Text)
                };
                Program.DbHelper.Books.Add(book);
                Program.DbHelper.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Проверьте правильность введённых данных");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

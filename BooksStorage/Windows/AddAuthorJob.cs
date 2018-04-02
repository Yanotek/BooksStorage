using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksStorage.AppData.Models;

namespace BooksStorage.Windows
{
    public partial class AddAuthorJob : Form
    {
        Author Author;

        public AddAuthorJob(Author Author)
        {
            InitializeComponent();
            var Books = Program.DbHelper.Books;
            foreach(var b in Books)
            {
                BooksList.Items.Add(b);
            }
            this.Author = Author;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!rbAdd.Checked && (tbName.Text!= null || tbName.Text!= "") 
                || rbAdd.Checked && BooksList.SelectedItem!= null)
            {
                Job job = new Job();
                job.Author = Author;

                if (rbAdd.Checked)
                {
                    job.Book = (Book)BooksList.SelectedItem;
                }
                else
                {
                    job.Book = new Book()
                    {
                        Name = tbName.Text,
                        Price = int.Parse(tbPrice.Text)
                    };
                }
                Program.DbHelper.Jobs.Add(job);
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

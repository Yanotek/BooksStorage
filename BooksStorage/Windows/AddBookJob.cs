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
    public partial class AddBookJob : Form
    {
        Book Book;
        public AddBookJob(Book Book)
        {
            InitializeComponent();
            this.Book = Book;
            var Authors = Program.DbHelper.Authors;
            foreach(var b in Authors)
            {
                AuthorList.Items.Add(b);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!rbAdd.Checked && (tbName.Text != null || tbName.Text != "")
                || rbAdd.Checked && AuthorList.SelectedItem != null)
            {
                Job job = new Job();
                job.Book = Book;
                if (rbAdd.Checked)
                {
                    job.Author = (Author)AuthorList.SelectedItem;
                }
                else
                {
                    job.Author = new Author()
                    {
                        Name = tbName.Text
                    };
                }
                Program.DbHelper.Jobs.Add(job);
                Program.DbHelper.SaveChanges();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

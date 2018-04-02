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

namespace BooksStorage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Program.DbHelper.Database.CreateIfNotExists();
            }
            catch { }
            UpdateAuthorList();
            UpdateBookList2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Windows.AddAuthor add = new Windows.AddAuthor();
            add.ShowDialog();
            UpdateAuthorList();
        }

        public void UpdateAuthorList()
        {
            AuthorList.Items.Clear();
            var b = Program.DbHelper.Authors.Where(x=> tbFilterName.Text == "" || x.Name.Contains(tbFilterName.Text)).ToList();
            foreach(var c in b)
            {
                AuthorList.Items.Add(c);
            }
        }

        public void UpdateSelectedAuthor()
        {
            if (AuthorList.SelectedItem != null)
            {
                Author author =(Author)AuthorList.SelectedItem;
                BookList.Items.Clear();
                var Books = Program.DbHelper.Jobs.Where(x => x.Author.Id == author.Id).Select(x=> x.Book).ToList();
                    foreach (var b in Books)
                    {
                    if(b != null)
                        BookList.Items.Add(b);
                    }
                tbName.Text = author.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AuthorList.SelectedItem != null)
            {
                Windows.AddAuthorJob add = new Windows.AddAuthorJob((Author)AuthorList.SelectedItem);
                add.ShowDialog();
                UpdateSelectedAuthor();
                UpdateBookList2();
            }
        }

        private void AuthorList_Click(object sender, EventArgs e)
        {
            UpdateSelectedAuthor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(AuthorList.SelectedItem != null)
            {
                var Books = Program.DbHelper.Jobs.Where(x => x.Author.Id == ((Author)AuthorList.SelectedItem).Id).Select(x => x.Book);
                Program.DbHelper.Jobs.RemoveRange(Program.DbHelper.Jobs.Where(x => x.Author.Id == ((Author)AuthorList.SelectedItem).Id));
                foreach(var b in Books)
                {
                    if (Program.DbHelper.Jobs.Count(x => x.Book.Id == b.Id) - 1 == 0)
                    {
                        Program.DbHelper.Books.Remove(b);
                    }
                }
                Program.DbHelper.Authors.Remove(((Author)AuthorList.SelectedItem));
                Program.DbHelper.SaveChanges();
                AuthorList.Items.Remove(AuthorList.SelectedItem);
                UpdateAuthorList();
                UpdateSelectedAuthor();
                UpdateAuthorList2();
                UpdateBookList2();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(BookList.SelectedItem != null)
            {
                Program.DbHelper.Jobs.RemoveRange(Program.DbHelper.Jobs.Where(x =>x.Author.Id == ((Author)AuthorList.SelectedItem).Id && x.Book.Id == ((Book)BookList.SelectedItem).Id));
                if (Program.DbHelper.Jobs.Count(x => x.Book.Id == ((Book)BookList.SelectedItem).Id) - 1 == 0)
                {
                    Program.DbHelper.Books.Remove((Book)BookList.SelectedItem);
                }
                Program.DbHelper.SaveChanges();
                BookList.Items.Remove(BookList.SelectedItem);
                UpdateBookList2();
                UpdateSelectedAuthor();
                UpdateAuthorList2();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Windows.AddBook add = new Windows.AddBook();
            add.ShowDialog();
            UpdateBookList2();
            UpdateAuthorList2();
        }

        public void UpdateBookList2()
        {
            tb2BookList.Items.Clear();
            int startPrice = 0;
            int endPrice = 0;
            try
            {
                startPrice = Convert.ToInt32(tbPriceBegin.Text);
            }
            catch { }
            try
            {
                endPrice = Convert.ToInt32(tbPriceEnd.Text);
            }
            catch { }
            var Books = Program.DbHelper.Books.Where(x => (tbFilterBook.Text == "" || x.Name.Contains(tbFilterBook.Text))
                                                            && (tbPriceBegin.Text == "" || x.Price >= startPrice)
                                                            && (tbPriceEnd.Text == "" || x.Price <= endPrice)
            );
            foreach(var b in Books)
            {
                tb2BookList.Items.Add(b);
            }
        }

        public void UpdateAuthorList2()
        {
            if (tb2BookList.SelectedItem != null)
            {
                Book book = (Book)tb2BookList.SelectedItem;
                tb2AuthorList.Items.Clear();
                var Authors = Program.DbHelper.Jobs.Where(x => x.Book.Id == book.Id).Select(x => x.Author).ToList();
                foreach (var b in Authors)
                {
                    if(b != null)
                    tb2AuthorList.Items.Add(b);
                }
                tbBookName.Text = book.Name;
                tbPrice.Text = book.Price.ToString();
            }
        }

        private void tb2BookList_Click(object sender, EventArgs e)
        {
            UpdateAuthorList2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tb2BookList.SelectedItem != null)
            {
                Program.DbHelper.Jobs.RemoveRange(Program.DbHelper.Jobs.Where(x => x.Book.Id == ((Book)tb2BookList.SelectedItem).Id));
                Program.DbHelper.Books.Remove((Book)tb2BookList.SelectedItem);
                Program.DbHelper.SaveChanges();
                tb2BookList.Items.Remove(tb2BookList.SelectedItem);
                UpdateBookList2();
                UpdateSelectedAuthor();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tb2BookList.SelectedItem != null)
            {
                Windows.AddBookJob add = new Windows.AddBookJob((Book)tb2BookList.SelectedItem);
                add.ShowDialog();
                UpdateAuthorList2();
                UpdateAuthorList();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(tb2AuthorList.SelectedItem != null)
            {
                Program.DbHelper.Jobs.RemoveRange(Program.DbHelper.Jobs.Where(x => x.Book.Id == ((Book)tb2BookList.SelectedItem).Id && x.Author.Id == ((Author)tb2AuthorList.SelectedItem).Id));
                Program.DbHelper.SaveChanges();
                tb2AuthorList.Items.Remove(tb2AuthorList.SelectedItem);
                UpdateSelectedAuthor();
            }
        }

        private void tbFilterName_TextChanged(object sender, EventArgs e)
        {
            UpdateAuthorList();
        }

        private void tbFilterBook_TextChanged(object sender, EventArgs e)
        {
            UpdateBookList2();
        }

        private void dtBegin_ValueChanged(object sender, EventArgs e)
        {
            UpdateBookList2();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

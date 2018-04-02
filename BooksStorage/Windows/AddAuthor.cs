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
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void AddAuthor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tbName.Text != "" && tbName.Text != null)
            {
                Author author = new Author()
                {
                    Name = tbName.Text
                };
                Program.DbHelper.Authors.Add(author);
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

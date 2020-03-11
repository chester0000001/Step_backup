using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCinema
{
    public partial class formFilmDel : Form
    {
        DataManager dm = new DataManager();

        public string Name { get; set; }
        public formFilmDel()
        {
            InitializeComponent();
            displaylist();
        }

        private void displaylist()
        {
            listView1.Items.Clear();
            foreach(var i in dm.films)
            {
                var item = listView1.Items.Add(i.Name);
                item.SubItems.Add(i.CategoryId.ToString());
                item.SubItems.Add(i.AgeId.ToString());
            }
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            if(name != String.Empty)
            {
                Name = name;
                this.DialogResult = DialogResult.OK;
               
                }
            else
            {
                MessageBox.Show("Пустая строка!");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displaylist();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formFilms fm = new formFilms();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                dm.AddFilm(new Film(fm.Name, fm.CategoryId, fm.AgeCategoryId));
            }
            displaylist();
        }
    }
}

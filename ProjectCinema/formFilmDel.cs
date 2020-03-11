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
                foreach (var c in dm.categories)
                {
                    if(i.CategoryId == c.Id)
                    { item.SubItems.Add(c.Name); }
                }

                foreach (var a in dm.ageRestrictions)
                {
                    if (i.AgeId == a.Id)
                    { item.SubItems.Add(a.Age.ToString()); }
                }
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
                dm.AddFilm(fm.Name, fm.CategoryId, fm.AgeCategoryId);
            }
            displaylist();
        }
    }
}

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
    public partial class Form1 : Form
    {
        DataManager dm = new DataManager();
        public Form1()
        {
            InitializeComponent();
            Display();
        }


        /// <summary>
        /// добавления фильма (Игорь)
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            formFilms fm = new formFilms();
            if( fm.ShowDialog()== DialogResult.OK)
            {
                dm.AddFilm(new Film(fm.Name, fm.CategoryId, fm.AgeCategoryId));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formFilmDel fmd = new formFilmDel();
            if (fmd.ShowDialog() == DialogResult.OK)
            {
                dm.DelFilm(fmd.Name);
            }
        }

        public void Display()
        {
            foreach(var i in dm.films)
            {
                listBox1.Items.Add(i.Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

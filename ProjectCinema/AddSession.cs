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
    public partial class AddSession : Form
    {
        DataManager dm = new DataManager();

        public int NewHallId { get; set; }

        public int NewFilmId { get; set; }

        public DateTime Newdate { get; set; }

        int hallboxid = 0;
        int filmboxid = 0;

        public AddSession()
        {
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            foreach (var item in dm.halls)
            {
                comboBox1.Items.Add(item.Name);
            }

            foreach (var item2 in dm.films)
            {
                comboBox2.Items.Add(item2.Name);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                NewHallId = dm.halls.ElementAt(hallboxid).Id;
                NewFilmId = dm.films.ElementAt(filmboxid).Id;
                Newdate = Convert.ToDateTime(textBox1.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Пустая строка!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hallboxid = comboBox1.SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmboxid = comboBox2.SelectedIndex;
        }
    }
}

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
        public string Name { get; set; }
        public formFilmDel()
        {
            InitializeComponent();
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
    }
}

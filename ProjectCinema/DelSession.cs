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
    public partial class DelSession : Form
    {
        DataManager dm = new DataManager();
        int sessinoId = 0;

        public int DelId { get; set; }

        public DelSession()
        {
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            foreach(var item in dm.sessions)
            {
                comboBox1.Items.Add(item.Id);
            }
        }


        private void okbutton_Click(object sender, EventArgs e)
        {
            if (sessinoId != -1)
            {
                DelId = dm.sessions.ElementAt(sessinoId).Id;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Не выбрано!");
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sessinoId = comboBox1.SelectedIndex;
        }
    }
}

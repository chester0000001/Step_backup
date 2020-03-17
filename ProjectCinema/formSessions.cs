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
    public partial class formSessions : Form
    {
        DataManager dm = null;
        public formSessions()
        {
            InitializeComponent();
            dm = new DataManager();
            LoadSessions();
        }

        private void LoadSessions()
        {
            listView1.Items.Clear();
            foreach (var s in dm.sessions)
            {
                var item = listView1.Items.Add(s.DateTime.ToString());
                foreach(var f in dm.films)
                {
                    if (f.Id == s.FilmId)
                        item.SubItems.Add(f.Name);
                }

                foreach(var h in dm.halls)
                {
                    if (h.Id == s.HallId)
                        item.SubItems.Add(h.Name);
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                DateTime dateTime = Convert.ToDateTime( listView1.FocusedItem.SubItems[0].Text);
                string hallName = listView1.FocusedItem.SubItems[2].Text;
                int hallId = dm.halls.FirstOrDefault(h => h.Name == hallName).Id;
                dm.DelSession(dateTime, hallId);
                LoadSessions();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            formSessionAdd form = new formSessionAdd();
            if(form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadSessions();
        }
    }
}

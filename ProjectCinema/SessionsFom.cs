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
    public partial class SessionsFom : Form
    {
        DataManager dm = new DataManager();
        DataManagerSecond dms = new DataManagerSecond();
        public SessionsFom()
        {
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            dm.LoadData();
            listView1.Items.Clear();
            foreach (var s in dm.sessions)
            {
                var item = listView1.Items.Add(s.Id.ToString());
                foreach (var h in dm.halls)
                {
                    if (h.Id == s.HallId)
                    { 
                        item.SubItems.Add(h.Name); 
                    }
                }

                item.SubItems.Add(s.DateTime.ToString());

                foreach (var f in dm.films)
                {
                    if (f.Id == s.FilmId)
                    { 
                        item.SubItems.Add(f.Name); 
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//добавить
        {
            AddSession ads = new AddSession();
            if(ads.ShowDialog() == DialogResult.OK)
            {
                dms.AddSession(ads.NewHallId, ads.NewFilmId, ads.Newdate);
                Display();
            }

        }

        private void button2_Click(object sender, EventArgs e)//удалить
        {
            DelSession ds = new DelSession();
            if (ds.ShowDialog() == DialogResult.OK)
            {
                dms.DelSession(ds.DelId);
                Display();
            }
        }

        private void button3_Click(object sender, EventArgs e) //обновить
        {
            Display();
        }
    }
}

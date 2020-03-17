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
    public partial class formSessionAdd : Form
    {
        DataManager dm = null;
        public formSessionAdd()
        {
            InitializeComponent();
            dm = new DataManager();
            LoadData();
        }

        private void LoadData()
        {

            foreach(var f in dm.films.ToList())
            {
                filmsBox.Items.Add(f.Name);
            }

            foreach(var h in dm.halls.ToList())
            {
                hallsBox.Items.Add(h.Name);
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        { 
            var d = dateTimePicker1.Value.Date;
            int hour =  Convert.ToInt32(hoursNum.Value);
            int minutes = Convert.ToInt32(minNum.Value);

            DateTime date = new DateTime(d.Year,d.Month,d.Day, hour, minutes, 0);
            int hallId = dm.halls.FirstOrDefault(h => h.Name == hallsBox.Text).Id;
            int filmId = dm.films.FirstOrDefault(f => f.Name == filmsBox.Text).Id;
            dm.AddSession(date, filmId, hallId);

        }
    }
}

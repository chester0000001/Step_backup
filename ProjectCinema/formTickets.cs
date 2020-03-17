using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data;

namespace ProjectCinema
{
    public partial class formTickets : Form
    {
        DataManager dm = new DataManager();
        public formTickets()
        {
            InitializeComponent();
            LoadSessions();
        }

        public void LoadSessions()
        {
            foreach (var s in dm.sessions)
            {
                boxSessions.Items.Add(s.DateTime);
            }
        }


        private void boxSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxFilmName.Text = "";
            boxHallName.Text = "";
            boxRow.Text = "";
            numPlace.Value = 0;

            foreach (var s in dm.sessions)
            {
                if (s.DateTime == Convert.ToDateTime(boxSessions.SelectedItem))
                {
                    string filmName = dm.films.FirstOrDefault(p => p.Id == s.FilmId).Name;
                    boxFilmName.Text = filmName;

                    string hallName = dm.halls.FirstOrDefault(p => p.Id == s.HallId).Name;
                    boxHallName.Text = hallName;

                    lvPlaces.Items.Clear();
                    List<int> denyTickets = new List<int>();
                    foreach (var t in dm.tickets)
                    {
                        denyTickets.Add(t.PlaceId);
                    }

                    foreach (var p in dm.places)
                    {
                        if (p.HallId == s.HallId)
                        {
                            if (dm.tickets.Where(t => t.PlaceId == p.Id 
                                                 && t.SessionId == s.Id)
                                                 .ToList().Count == 0)
                            {
                                lvPlaces.Items.Add(Convert.ToString(p.Id));
                            }
                          
                        }
                    }
                }
            }
        }

        private void фильмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFilmDel formFilm = new formFilmDel();
            if(formFilm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void lvPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var p in dm.places)
            {
                if(p.Id == Convert.ToInt32(lvPlaces.FocusedItem.Text))
                {
                    boxRow.Text = p.Row.ToString();
                    numPlace.Value = p.Id;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int placeId = Convert.ToInt32(numPlace.Value);
            
            foreach(var s in dm.sessions.ToList())
            {
                DateTime dateTime = Convert.ToDateTime(boxSessions.SelectedItem.ToString());
                int filmId = dm.films.FirstOrDefault(p => p.Name == boxFilmName.Text).Id;

                if (s.DateTime == dateTime && s.FilmId == filmId)
                {
                    int sessionId = s.Id;
                    dm.AddTicket(placeId, sessionId);
                }
            }
        }

        private void сессииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSessions form = new formSessions();
            if(form.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}

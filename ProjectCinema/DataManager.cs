using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using ProjectCinema.Models;

namespace ProjectCinema
{
    class DataManager : DbProvider
    {
        public List<Category> categories;
        public List<AgeRestriction> ageRestrictions;
        public List<Film> films;
        public List<Hall> halls;
        public List<Session> sessions;
        public List<Place> places;
        public List<Ticket> tickets;
        public List<User> users;



        public DataManager()
        {
            categories = new List<Category>();
            ageRestrictions = new List<AgeRestriction>();
            films = new List<Film>();
            halls = new List<Hall>();
            sessions = new List<Session>();
            places = new List<Place>();
            tickets = new List<Ticket>();
            users = new List<User>();
            LoadData();
        }

        public void LoadData()
        {
            string queryCategories = "SELECT * FROM Category";
            string queryaAgeRestriction = "SELECT * FROM AgeRestriction";
            string queryFilm = "SELECT * FROM Films";
            string queryHall = "SELECT * FROM Halls";
            string querySession = "SELECT * FROM Session";
            string queryPlace = "SELECT * FROM Plases";
            string queryTicket = "SELECT * FROM Tickets";
            string queryUser = "SELECT * FROM Users";
            connection.Open();
            SqlCommand cmd;
            SqlDataReader reader;



            //queryCategories
            cmd = new SqlCommand(queryCategories, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Category c = new Category(
                    reader["Name"].ToString()
                    );
                categories.Add(c);
            }
            connection.Close();
            //AgeRestriction
            connection.Open();
            cmd = new SqlCommand(queryaAgeRestriction, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                AgeRestriction ar = new AgeRestriction(
                    (int)reader["Age"]
                    );
                ageRestrictions.Add(ar);
            }
            connection.Close();
            //queryFilm
            connection.Open();
            cmd = new SqlCommand(queryFilm, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Film f = new Film(
                    reader["Name"].ToString(),
                    (int)reader["CategoryId"],
                    (int)reader["AgeId"]
                    );
                films.Add(f);
            }
            connection.Close();
            //queryHall
            connection.Open();
            cmd = new SqlCommand(queryHall, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Hall h = new Hall(
                    reader["Name"].ToString()
                    );
                halls.Add(h);
            }
            connection.Close();
            //querySession
            connection.Open();
            cmd = new SqlCommand(querySession, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Session s = new Session(
                    (int)reader["HallId"],
                    (DateTime)reader["DateTime"],
                    (int)reader["FilmId"]
                    );
                sessions.Add(s);
            }
            connection.Close();
            //queryPlace
            connection.Open();
            cmd = new SqlCommand(queryPlace, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Place p = new Place(
                    (int)reader["HallId"],
                    (int)reader["Row"]
                    );
                places.Add(p);
            }
            connection.Close();
            //queryTicket
            connection.Open();
            cmd = new SqlCommand(queryTicket, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Ticket t = new Ticket(
                    (int)reader["PlaceId"],
                    (int)reader["SessionId"],
                    (DateTime)reader["DateTime"]
                    );
                tickets.Add(t);
            }
            connection.Close();
            //queryUser
            connection.Open();
            cmd = new SqlCommand(queryUser, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User u = new User(
                    reader["UserLogin"].ToString(),
                    (string)reader["UserPass"],
                    (string)reader["Question"],
                    (string)reader["Answer"]
                    );
                users.Add(u);
            }
            connection.Close();

        }


    }
}

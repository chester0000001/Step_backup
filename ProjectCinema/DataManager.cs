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
            categories.Clear();
            ageRestrictions.Clear();
            films.Clear();
            halls.Clear();
            sessions.Clear();
            places.Clear();
            tickets.Clear();
            users.Clear();

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
                    (int)reader["Id"],
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
                    (int)reader["Id"],
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
                    (int)reader["Id"],
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
                    (int)reader["Id"],
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
                    (int)reader["Id"],
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
                    (int)reader["Id"],
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
                    (int)reader["Id"],
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
        /// <summary>
        /// добавления фильма (Игорь)
        /// </summary>
        public void AddFilm(string Name, int CategoryId,int AgeId)
        {
            string query = "insert into Films (Name, CategoryId, AgeId) values (@Name, @CategoryId,@AgeId) ";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = Name;
            cmd.Parameters.Add("@CategoryId", SqlDbType.Int, 10).Value = CategoryId;
            cmd.Parameters.Add("@AgeId", SqlDbType.Int, 10).Value = AgeId;
            cmd.ExecuteNonQuery();
            connection.Close();

            LoadData();

            
            //int FilmId=0;
            //foreach(var i in films )
            //{
            //    if(i.Name == Name)
            //    {
            //        FilmId = i.Id;
            //    }
            //}


            //films.Add(new Film(FilmId,Name,CategoryId,AgeId));
        }

        /// <summary>
        /// Удаление фильма (Игорь)
        /// </summary>
        public void DelFilm(string name)
        {
            int t = 0;
            int k = 0;
            foreach (var f in films)
            {
                if (f.Name == name)
                {
                    k = t;
                }
                t++;
            }

            string query = "DELETE FROM Films WHERE Name = name";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            films.RemoveAt(k);
        }

        //Степан
        public void AddTicket(int placeId, int sessionId)
        {
            string queryInsert = "INSERT INTO Tickets(PlaceId,SessionId,DateTime) " +
                                 "VALUES (@placeId,@sessionId,GETDATE())";
            connection.Open();
            SqlCommand cmd = new SqlCommand(queryInsert,connection);
            cmd.Parameters.Add("@placeId", SqlDbType.Int).Value = placeId;
            cmd.Parameters.Add("@sessionId", SqlDbType.Int).Value = sessionId;
            cmd.ExecuteNonQuery();
            connection.Close();
            LoadData();
        }

        public void AddSession(DateTime dateTime,int filmId, int hallId)
        {
            string queryInsert = "INSERT INTO Session " +
                                 "VALUES (@hallId,@dateTime,@filmId)";
            connection.Open();
            SqlCommand cmd = new SqlCommand(queryInsert, connection);
            cmd.Parameters.Add("@hallId", SqlDbType.Int).Value = hallId;
            cmd.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = dateTime;
            cmd.Parameters.Add("@filmId", SqlDbType.Int).Value = filmId;
            cmd.ExecuteNonQuery();
            connection.Close();
            LoadData();
        }

        public void DelSession(DateTime dateTime, int hallId)
        {
            int sessionId = sessions.FirstOrDefault(s => s.DateTime == dateTime && s.HallId == hallId).Id;
            string queryDelete = "DELETE FROM Tickets WHERE SessionId = @sessionId; " +
                                 "DELETE FROM Session WHERE DateTime = @dateTime and FilmId = @filmId";
            connection.Open();
            SqlCommand cmd = new SqlCommand(queryDelete, connection);
            cmd.Parameters.Add("@sessionId", SqlDbType.Int).Value = sessionId;
            cmd.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = dateTime;
            cmd.Parameters.Add("@filmId", SqlDbType.Int).Value = hallId;
            cmd.ExecuteNonQuery();
            connection.Close();
            LoadData();
        }
    }
}

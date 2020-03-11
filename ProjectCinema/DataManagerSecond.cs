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
    class DataManagerSecond : DbProvider
    {

        /// <summary>
        /// Новый датаменеджер для листов сессий и т.д.
        /// ИГОРЬ
        /// </summary>
        DataManager dm = new DataManager();
        public DataManagerSecond()
        {
        }


        /// <summary>
        /// добавления сессии (Игорь)
        /// </summary>
        public void AddSession(int HallId, int FilmId, DateTime date)
        {
            string query = "insert into Session (HallId, DateTime, FilmId) values (@HallId, @date,@FilmId) ";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@HallId", SqlDbType.Int, 50).Value = HallId;
            cmd.Parameters.Add("@FilmId", SqlDbType.Int, 10).Value = FilmId;
            cmd.Parameters.Add("@date", SqlDbType.DateTime, 10).Value = date;
            cmd.ExecuteNonQuery();
            connection.Close();


            dm.LoadData();
        }

        /// <summary>
        /// Удаление сессии (Игорь)
        /// </summary>
        public void DelSession(int SessionId)
        {
            int t = 0;
            int k = 0;
            foreach (var s in dm.sessions)
            {
                if (s.Id == SessionId)
                {
                    k = t;
                }
                t++;
            }

            string query = "DELETE FROM Session WHERE Id = @SessionId";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@SessionId", SqlDbType.Int, 50).Value = SessionId;
            cmd.ExecuteNonQuery();
            connection.Close();
            dm.sessions.RemoveAt(k);
            
        }

    }
}

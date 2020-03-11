using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema
{
    class Session
    {
        public int Id { get; set; }
        public int HallId { get; set; }
        public DateTime DateTime { get; set; }
        public int FilmId { get; set; }

        public Session(int id,int hallId, DateTime dateTime, int filmId)
        {
            this.Id = id;
            this.HallId = hallId;
            this.DateTime = dateTime;
            this.FilmId = filmId;
        }
    }
}

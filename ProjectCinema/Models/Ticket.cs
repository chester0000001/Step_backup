using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema
{
    class Ticket
    {
        public int Id { get; set; }
        public int PlaceId { get; set; }
        public int SessionId { get; set; }
        public DateTime DateTime { get; set; }

        public Ticket (int id,int placeId, int sessionId,DateTime dateTime)
        {
            this.Id = id;
            this.PlaceId = placeId;
            this.SessionId = sessionId;
            this.DateTime = dateTime;
        }

    }
}

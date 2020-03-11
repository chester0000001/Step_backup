using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema
{
    class Place
    {
        public int Id { get; set; }
        public int HallId { get; set; }

        public int Row { get; set; }

        public Place(int id,int hallId, int row)
        {
            this.Id = id;
            this.HallId = hallId;
            this.Row = row;
        }
    }
}

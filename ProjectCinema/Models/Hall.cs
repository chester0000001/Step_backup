using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema
{
    class Hall
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Hall(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}

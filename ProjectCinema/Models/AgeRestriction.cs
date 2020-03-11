using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema
{
    class AgeRestriction
    {
        public int Id { get; set; }
        public int Age { get; set; }

        public AgeRestriction(int id,int age)
        {
            this.Id = id;
            this.Age = age;
        }
    }
}

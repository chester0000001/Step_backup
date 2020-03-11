using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema
{
    class Film 
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int AgeId { get; set; }

        public Film(string name,int categoryId,int ageId)
        {
            this.Name = name;
            this.CategoryId = categoryId;
            this.AgeId = ageId;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCinema.Models
{
    class User
    {
        public string UserLogin { get; set; }
        public string UserPass { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public User(string login, string password, string question, string answer)
        {
            this.UserLogin = login;
            this.UserPass = password;
            this.Question = question;
            this.Answer = answer;
        }
    }
}



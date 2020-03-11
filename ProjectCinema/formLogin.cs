using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjectCinema.Models;
using ProjectCinema.Properties;

namespace ProjectCinema
{
    public partial class formLogin : Form
    {
        DataManager dm = new DataManager();
       
        public formLogin()
        {
            InitializeComponent();
            dm.LoadData();

        }


        //Clear
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }


        //Enter
        private void button1_Click(object sender, EventArgs e)
        {
            List<User> check = dm.users;

            var qw = new User("", "", "", "");
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Вы не ввели логин или пароль !", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int x = 0;  //совапдение по логину
                int y = 0;  //совпадение по паролю
                foreach (var s in dm.users)
                {
                   if (textBox1.Text == s.UserLogin)
                   {
                        x = 1;
                        qw = dm.users.First((z => z.UserLogin == textBox1.Text));
                       // MessageBox.Show(qw.ToString());

                   }
                    if (textBox2.Text == qw.UserPass)
                    {
                        y = 1;
                    }

                }
                if (x ==1 && y ==1)
                {
                     MessageBox.Show("Вход осуществлён !", "Успешно !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Введены неверный логин или пароль", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forgot newForm = new Forgot();
            newForm.Show();
        }
    }
}

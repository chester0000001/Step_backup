using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectCinema.Models;

namespace ProjectCinema
{
    public partial class Forgot : Form
    {
        DataManager dm = new DataManager();
        string password;
        string answer;
        public Forgot()
        {
            InitializeComponent();
            dm.LoadData();
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            List<User> check = dm.users;

            var qw = new User("", "", "", "");
            foreach (var s in dm.users)
            {
                if (textBox1.Text == s.UserLogin)
                {
                    x = 1;
                    qw = dm.users.First((z => z.UserLogin == textBox1.Text));
                    label4.Text = qw.Question;
                    password = qw.UserPass;
                    answer = qw.Answer;
                    button2.Visible = true;
                }

            }
            if (textBox1.Text == "" || x == 0)
            {
                label4.Text = "";
                button2.Visible = false;
                MessageBox.Show("Проверьте правильность введения логина !", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            answer = answer.Replace(" ", "");
            if (textBox2.Text == answer)
            {
                MessageBox.Show("Ваш пароль : " + password, "Успешно !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Ответ на контрольный вопрос неверный !", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

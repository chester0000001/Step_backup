using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCinema
{
    public partial class formFilms : Form
    {
        DataManager dm = new DataManager();

        int c, a;

        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int AgeCategoryId { get; set; }

        public formFilms()
        {
            InitializeComponent();
           
            Display();
        }
        
        private void Display()
        {
            foreach(var c in dm.categories)
            {
                categoriesBox.Items.Add(c.Name);
            }

            foreach (var a in dm.ageRestrictions)
            {
                agecategoriesBox.Items.Add(a.Age);
            }
        }
    
        private void okBtn_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            
            if (name != String.Empty)
            {
                Name = name;
                CategoryId = c+1;
                AgeCategoryId = a+1;
            }
            else
            {
                MessageBox.Show("Поля не заполнены!");
            }

            this.DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void categoriesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            c = categoriesBox.SelectedIndex;
        }

        private void agecategoriesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = agecategoriesBox.SelectedIndex;
        }
    }
}

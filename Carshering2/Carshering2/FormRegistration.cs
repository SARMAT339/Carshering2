using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carshering2
{
    public partial class FormRegistration : Form
    {

        public FormRegistration()
        {
            InitializeComponent();
        }

        public event Action<User> user1;

        private void buttonEntr_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string MiddleName = textBox3.Text;
            int Age = Convert.ToInt32(textBox4.Text);
            int PasSeries = Convert.ToInt32(textBox5.Text);
            int PasNumber = Convert.ToInt32(textBox6.Text);
            string Password = textBox7.Text;
            user1 = new User(name, surname, MiddleName, Age, PasSeries, PasNumber, Password);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

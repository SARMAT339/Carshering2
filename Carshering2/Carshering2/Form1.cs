using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carshering2
{
    public partial class FormCatalog : Form
    {

        Catalog catalog = new Catalog();
        public User user1;

        public FormCatalog()
        {
            InitializeComponent();
        }

        private void FormCatalog_Load(object sender, EventArgs e)
        {
            catalog.LoadFromFile();
            listViewCatalog.Items.AddRange(catalog.ConvertToListView());
        }

        private void FormCatalog_Activated(object sender, EventArgs e)
        {
            //listViewCatalog.Items.AddRange(catalog.ConvertToListView());
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            try
            {
                string number = listViewCatalog.SelectedItems[0].SubItems[3].Text;
                Car car = catalog.FindCarNumber(number);
                FormTime formTime = new FormTime(car);
                formTime.Show();
            }
            catch 
            {
                MessageBox.Show("Выберите автомобиль!");
            }
        }

        private void buttonEntr_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.Show();
        }
    }
}

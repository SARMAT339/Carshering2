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
    public partial class FormTime : Form
    {
        private Timer timer;
        private int seconds;
        private int minutes;

        public decimal price;
        public decimal priceCount = 0;
        

        public FormTime(Car activeCar)
        {
            InitializeComponent();
            InitializeTimer();
            labelCarName.Text += activeCar.Name;
            this.price = activeCar.Price;
            priceCount += price;
            labelPrice.Text = priceCount.ToString();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // Интервал 1 секунда
            timer.Tick += Timer_Tick;

            seconds = 0;
            minutes = 0;

            UpdateLabel();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds++;

            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
                priceCount += price;
                labelPrice.Text = priceCount.ToString();
            }

            UpdateLabel();
        }

        private void UpdateLabel()
        {
            labelTimer.Text = minutes.ToString("D2") + ":" + seconds.ToString("D2");
        }

        private void FormTime_Activated(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void FormTime_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }
    }
}

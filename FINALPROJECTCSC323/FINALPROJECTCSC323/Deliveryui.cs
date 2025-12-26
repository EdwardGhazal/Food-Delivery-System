using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALPROJECTCSC323
{
    public partial class Deliveryui : Form
    {
        private bool firstTick = true;
        public Deliveryui()
        {
            InitializeComponent();
            timerDelivery.Start();
        }

        private void timerDelivery_Tick(object sender, EventArgs e)
        {
            if (firstTick)
            {
                lblStatus.Text = "Order Delivered!";
                timerDelivery.Interval = 1500; // Show this message for 1.5 seconds
                firstTick = false;
            }
            else
            {
                timerDelivery.Stop();
                this.Close(); // Automatically close the form
            }
        }
    }
}

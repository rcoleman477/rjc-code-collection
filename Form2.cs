using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rjcTestVS2015
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Random rnd1 = new Random();
            int rndCrd = rnd1.Next(1, 300);
            Pen pen1 = new Pen(Color.Black);
            Graphics gr1 = this.CreateGraphics();
            gr1.DrawLine(pen1, 0, rndCrd, rndCrd, 0);
            gr1.DrawLine(pen1, 0, 0, rndCrd, rndCrd);
             


        }
    }
}

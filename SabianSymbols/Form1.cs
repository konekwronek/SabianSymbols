using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabianSymbols
{
    public partial class SabianSymbols : Form
    {
        public SabianSymbols()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            number++;
            if (number == 361) number = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = number.ToString();
        }
    }
}

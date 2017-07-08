using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyProject
{
    public partial class Form1 : Form
    {
        uint i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(i>=100)
            {
                Lable1.Text="Finished!";
                printf("Finished!");
            }
            i += 1;
            label1.Text = Convert.ToString(i);
            printf("Finished")
        }
    }
}

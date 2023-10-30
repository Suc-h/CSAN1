using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool PrimeNumber(int x)
        {
            int number=x;
            if(number == 2 || number == 3)return true;
            if (number % 2 == 0 || number == 1) return false;
            for(int i = 3;i<=Math.Sqrt(number);i+=2)
            {
                if(number%i==0)
                {
                    return false;
                }

            }
            return true;
        }
            
            
        
        private void button1_Click(object sender, EventArgs e)
        {
            int number = (int)numericUpDown1.Value;
            if (PrimeNumber(number))
            {
                label1.Text = "Prime";
            }
            else
            {
                label1.Text = "Non Prime";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuvHensu
{
    public partial class Form1 : Form
    {

        int vx = -30;
        int vy = -10;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if(label1.Left<0)
            {
                vx = Math.Abs(vx);
            }
            if(label1.Top<0)
            {
                vy = -Math.Abs(vy);
            }
            if(label1.Right> ClientSize.Width)
            {
                vx = Math.Abs(vx);
            }
            if(label1.Bottom> ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = -5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = -5;
            vy = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vx = 5; 
            vy = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(""+ ClientSize.Width);
            //MessageBox.Show(""+ ClientSize.Height);
        }
    }
}

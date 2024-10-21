using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = ":(";
            if (!label2.Visible) 
            {
                label2.Visible = true;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = ":)";
            if (!label2.Visible)
            {
                label2.Visible = true;
            }
        }
        int money = 10000;
        private void button3_Click(object sender, EventArgs e)
        {
            
            
            Random random = new Random();
            int a=random.Next(1,8);
            int b=random.Next(1,8);
            int c=random.Next(1,8);
            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label6.Text = c.ToString();
            if (a == b && b == c)
            {
                MessageBox.Show("JAKCPOT!");
                money=money+500;
                label7.Text=money.ToString();
            }
            else
            {
                money = money - 50;
                label7.Text=money.ToString();
            }
            if (money <= 0)
            {
                MessageBox.Show("Nie masz więcej hajsu :(");
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessFistDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private User _user = new User();
        private Computer _computer = new Computer();

        
        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void button4_Click(object sender, EventArgs e)
        {
            int computerChoice = _computer.Computer_choice(3);
            int userChoice = _user.UserChoice;
            switch (computerChoice)
            {
                case 0:
                    textBox2.Text = @"石头";
                    break;
                case 1:
                    textBox2.Text = @"剪刀";
                    break;
                case 2:
                    textBox2.Text = @"布";
                    break;
            }

            switch (userChoice)
            {
                case 0:
                    textBox1.Text = @"石头";
                    break;
                case 1:
                    textBox1.Text = @"剪刀";
                    break;
                case 2:
                    textBox1.Text = @"布";
                    break;
            }

            if (computerChoice == userChoice)
            {
                textBox3.Text = "平局";
            }
            else if ((computerChoice == 0 && userChoice == 1) || (computerChoice == 1 && userChoice == 2) || (computerChoice == 2 && userChoice == 0))
            {
                textBox3.Text = "电脑胜";
            }
            else 
            {
                textBox3.Text = "你胜";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _user.UserChoice = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _user.UserChoice = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _user.UserChoice = 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salsalslaflds
{
    public partial class Form2 : Form
    {
        private int secretNumber;
        private int attempts;
        public Form2()
        {
            InitializeComponent();
            InitializeGame();
        }
        private void InitializeGame()
        {
            Random random = new Random();
            secretNumber = random.Next(1, 1001);
            attempts = 0;
            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int userNumber))
            {
                textBox1.Focus();
                return;
            }
            attempts++;

            if (userNumber < secretNumber)
            {
                label4.Text = "больше как будто надо!";
            }
            else if (userNumber > secretNumber)
            {
                label4.Text = "трайни поменьше число!";
            }
            else if (userNumber == secretNumber)
            {
                label3.Text = "ВЫ УГАДАЛИ!!!!";
            }
            {
                counter++;
                label5.Text = counter.ToString();
            }
        }
        private int counter = 0;
    }
}

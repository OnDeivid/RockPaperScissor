using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissor
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        
        private int player;
        private int bot;


        public Form1()
        {
            InitializeComponent();
        }

        public string CheckWin(int player)
        {
            bot = random.Next(1, 4);

            Dictionary<int, string> images = new Dictionary<int, string>
            {
                { 1, "rock" },   
                { 2, "paper" },  
                { 3, "scissor" }
            };

            string img = images[bot];
            pictureBox5.Image =(Image)Properties.Resources.ResourceManager.GetObject(img);

            if (player == bot)
            {
                this.BackColor = Color.Gray;

                return "Draw";
            }

            if ((player == 1 && bot == 3) || (player == 2 && bot == 1) || (player == 3 && bot == 2))   
            {
                this.BackColor = Color.Green;

                return "Win";
            }

            this.BackColor = Color.Red;
            return "Lose";

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            player = 1;
            label1.Text = CheckWin(player);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            player = 2;
            label1.Text = CheckWin(player);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            player = 3;
            label1.Text = CheckWin(player);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}

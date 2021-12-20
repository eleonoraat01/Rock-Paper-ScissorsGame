using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_ScissorsGame
{
    public partial class MainForm : Form
    {
        const int rock = 1;
        const int paper = 2;
        const int scissors = 3;
        int userPoints = 0;
        int computerPoints = 0;
        
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                MessageBox.Show("First enter your Username!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                lblUser.Text = tbUserName.Text;
                lblUser.Visible = true;
                pbUser.Visible = true;
                lblComputer.Visible = true;
                pbComputer.Visible = true;
                lblTextResult.Visible = true;
                lblResult.Visible = true;
                lblChoose.Visible = true;
                pbRock.Visible = true;
                pbPaper.Visible = true;
                pbScissors.Visible = true;
                btnReset.Visible = true;
            }
        }

        private void pbRock_Click(object sender, EventArgs e)
        {
            pbUser.Image = pbRock.Image;

            Random rnd = new Random();
            int num = rnd.Next(1, 4);
            if (num == rock)
            {
                pbComputer.Image = pbRock.Image;
                lblResult.Text= userPoints + ":" + computerPoints;
                MessageBox.Show("Even!");
            }
            else if(num == paper)
            {
                pbComputer.Image = pbPaper.Image;
                computerPoints++;
                lblResult.Text= userPoints + ":" + computerPoints;
                MessageBox.Show("Lost :( !");
            }else if(num == scissors)
            {
                pbComputer.Image = pbScissors.Image;
                userPoints++;
                lblResult.Text = userPoints + ":" + computerPoints;
                MessageBox.Show("Win :) !");
            }
        }

        private void pbPaper_Click(object sender, EventArgs e)
        {
            pbUser.Image = pbPaper.Image;

            Random rnd = new Random();
            int num = rnd.Next(1, 4);
            if (num == rock)
            {
                pbComputer.Image = pbRock.Image;
                userPoints++; 
                lblResult.Text = userPoints + ":" + computerPoints;
                MessageBox.Show("Win :) !");
            }
            else if (num == paper)
            {
                pbComputer.Image = pbPaper.Image;
                lblResult.Text = userPoints + ":" + computerPoints;
                MessageBox.Show("Even!");
            }
            else if (num == scissors)
            {
                pbComputer.Image = pbScissors.Image;
                computerPoints++;
                lblResult.Text = userPoints + ":" + computerPoints;
                MessageBox.Show("Lost :( !");
            }
        }

        private void pbScissors_Click(object sender, EventArgs e)
        {
            pbUser.Image = pbScissors.Image;

            Random rnd = new Random();
            int num = rnd.Next(1, 4);
            if (num == rock)
            {
                pbComputer.Image = pbRock.Image;
                computerPoints++;
                lblResult.Text = userPoints + ":" + computerPoints;
                MessageBox.Show("Lost :( ");
            }
            else if (num == paper)
            {
                pbComputer.Image = pbPaper.Image;
                userPoints++;
                lblResult.Text = userPoints + ":" + computerPoints;
                MessageBox.Show("Win :) !");
            }
            else if (num == scissors)
            {
                pbComputer.Image = pbScissors.Image;
                lblResult.Text = userPoints + ":" + computerPoints;
                MessageBox.Show("Even!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            userPoints = 0;
            computerPoints = 0;
            pbUser.Image = default;
            pbComputer.Image = default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

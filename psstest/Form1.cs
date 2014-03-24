using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psstest
{
    public partial class Form1 : Form
    {
        public Controller control = null;
        public Form1()
        {
            control = new Controller();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Paper";
            play(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Scissor";
            play(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Stone";
            play(3);
        }

        private void play(int i)
        {
            Hand player = control.getPlayerHand(i);
            Hand cpu = control.getCpuHand();
            label1.Text = cpu.getName();
            int winner = control.match(player.getID(), cpu.getID());
            printResult(winner);
        }

        private void printResult(int i)
        {
            switch (i)
            {
                case 0:
                    label2.Text = "draw";
                    break;
                case 1:
                    label2.Text = "win";
                    break;
                case 2:
                    label2.Text = "lose";
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "computer input";
            label2.Text = "outcome";
            label3.Text = "Your input";
        }
    }
}

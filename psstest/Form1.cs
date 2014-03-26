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
        //controller handels the execution of the game
        public Controller control = null;

        /// <summary>
        /// constructor for Form1 class
        /// </summary>
        public Form1()
        {
            control = new Controller();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            
        }

        /// <summary>
        /// button1 press starts the game with player choosing paper
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Paper";
            play(1);
        }

        /// <summary>
        /// button2 press starts the game with player choosing scissor
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Scissor";
            play(2);
        }

        /// <summary>
        /// button3 press starts the game with player choosing stone
        /// </summary>
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

        /// <summary>
        /// prints the result in label2
        /// </summary>
        /// <param name="i">int containing the outcome of the match. 1-3</param>
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

        /// <summary>
        /// resets labels to original text
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "computer input";
            label2.Text = "outcome";
            label3.Text = "Your input";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool turn = true; //If true x turn 
                          // If false 0 turn
        int turn_count = 0;
        //varile for both player
        static string p1, p2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if(turn)
            {
                bt.Text = "X";
            }
            else
            {
                bt.Text = "0";
            }
            turn_count++;
            turn = !turn;
            bt.Enabled = false;
            Check_Winner();
            if(turn_count==9)
            {
                MessageBox.Show("Game is Draw", "Draw");
                draw_count.Text=(Int32.Parse(draw_count.Text)+1).ToString();
            }
        }
        private void Check_Winner()
        {
            bool winner = false;
            if((A1.Text==A2.Text)&&(A2.Text==A3.Text)&&(!A1.Enabled))
                {
                winner = true;
            }
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                winner = true;
            }
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                winner = true;
            }
            //End of the row check
            //Start of the column check
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                winner = true;
            }
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                winner = true;
            }
            //End of the Column  check
            //Start of the diagonal check
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                winner = true;
            }
            //End of the diagonal check
            if (winner)
            {
                if(turn)
                {
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                    MessageBox.Show("0 is Winner", "Winner");
                }
                else
                {
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                    MessageBox.Show("X is Winner", "Winner");
                }
                
                    foreach (Control item in Controls)
                    {
                    try
                    {
                        Button bt = (Button)item;
                        bt.Enabled = false;
                        // bt.Text = "";
                    }
                    catch (Exception)
                    { }
                }
                
            }
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic Tac Toe is under construction", "Help Documentation");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    Form2 f2 = new Form2();
        //    f2.ShowDialog();
        //}

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            
                foreach (Control item in Controls)
                {
                try
                {
                    Button bt = (Button)item;
                    bt.Enabled = true;
                    bt.Text = "";
                }
                catch (Exception)
                { }
            }
           
        }
    }
}

using System.Collections.Generic;
using System.Windows.Forms;

namespace CW3
{
    public partial class Form1 : Form
    {
       

        public enum Player
        {
            X, O
        }

        Player CurrentPlayer;
 
        int Player1_score = 0;
        int Player2_score = 0;
        int turns = 1;
        List<Button> buttons;
        List<String> history = new List<String>();
     

        public Form1()
        {
            InitializeComponent();
            Clear();
            
        }

        public class GameHistory
        {
            public string Player { get; set; }
            public string value { get; set; }
        }

        private void ClickButton(object sender, EventArgs e)
        {
           
            
            var button = (Button)sender;
            if (turns % 2 == 0)
            {
               
                CurrentPlayer = Player.X;
                button.Text = CurrentPlayer.ToString();
                button.Enabled = false;
                button.BackColor = Color.Crimson;
                buttons.Remove(button);
                label6.ForeColor = System.Drawing.Color.Green;
                label6.Text = Convert.ToString("Player 2");
              

            }
            else
            {
               
                CurrentPlayer = Player.O;
                button.Text = CurrentPlayer.ToString();
                button.Enabled = false;
                button.BackColor = Color.LightGreen;
                buttons.Remove(button);
                label6.ForeColor = System.Drawing.Color.Red;
                label6.Text = Convert.ToString("Player 1");
             


            }
            
            CheckGame();
            turns++;
           
        }
        
        private void Clear()
        {
            buttons = new List<Button> { B1, B2, B3, B4, B5, B6, B7, B8, B9 };

        

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = " ";
                x.BackColor = DefaultBackColor;
                label6.ForeColor = System.Drawing.Color.Red;
                label6.Text = Convert.ToString("Player 1");
                turns = 0;
            }
        }
        

        private void StartGame(object sender, EventArgs e)
        {
            Clear();
        }

        private void CheckGame()
        {
            if (turns % 2 == 0) {
                if (B1.Text == "X" && B2.Text == "X" && B3.Text == "X"
                || B4.Text == "X" && B5.Text == "X" && B6.Text == "X"
                || B7.Text == "X" && B8.Text == "X" && B9.Text == "X"
                || B1.Text == "X" && B4.Text == "X" && B7.Text == "X"
                || B2.Text == "X" && B5.Text == "X" && B8.Text == "X"
                || B3.Text == "X" && B6.Text == "X" && B9.Text == "X"
                || B1.Text == "X" && B5.Text == "X" && B9.Text == "X"
                || B3.Text == "X" && B5.Text == "X" && B7.Text == "X")
                {
                    MessageBox.Show("Player 1 Won!");
                    Player1_score++;
                    label3.Text = Convert.ToString(Player1_score);
                    history.Add("Player 1 Won");
                    Clear();

                }

                }
            else
            {
                if (B1.Text == "O" && B2.Text == "O" && B3.Text == "O"
                || B4.Text == "O" && B5.Text == "O" && B6.Text == "O"
                || B7.Text == "O" && B8.Text == "O" && B9.Text == "O"
                || B1.Text == "O" && B4.Text == "O" && B7.Text == "O"
                || B2.Text == "O" && B5.Text == "O" && B8.Text == "O"
                || B3.Text == "O" && B6.Text == "O" && B9.Text == "O"
                || B1.Text == "O" && B5.Text == "O" && B9.Text == "O"
                || B3.Text == "O" && B5.Text == "O" && B7.Text == "O")
                {
                    MessageBox.Show("Player 2 Won!");
                    Player2_score++;
                    label4.Text = Convert.ToString(Player2_score);
                    history.Add("Player 2 Won");
                    Clear();
                }
                

            }
            if (turns == 9)
            {
                MessageBox.Show("Draw!");
                history.Add("DRAW");
                Clear();
                label6.Text = Convert.ToString(1);
            }
        }

        
        private void History(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (string o in history)
            {
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText("*" + o + Environment.NewLine);
              
                    
            }


        }
    }
}
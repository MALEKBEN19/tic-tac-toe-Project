using System;
using System.Drawing;
using System.Windows.Forms;
using tic_Tac_To_Prjt.Properties;

namespace tic_Tac_To_Prjt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }
        enum enPlayer { Player1 = 1, Player2 = 2 };
        enPlayer PlayerTurn = enPlayer.Player1;

        byte counter1 = 0;
        byte counter2 = 0;
        byte counter3 = 0;
        byte counter4 = 0;
        byte counter5 = 0;
        byte counter6 = 0;
        byte counter7 = 0;
        byte counter8 = 0;
        byte counter9 = 0;

 

        void InsertPicToPb()
        {
            pb1.Image = Resources.question_mark_96;
            pb2.Image = Resources.question_mark_96;
            pb3.Image = Resources.question_mark_96;
            pb4.Image = Resources.question_mark_96;
            pb5.Image = Resources.question_mark_96;
            pb6.Image = Resources.question_mark_96;
            pb7.Image = Resources.question_mark_96;
            pb8.Image = Resources.question_mark_96;
            pb9.Image = Resources.question_mark_96;

            pb1.BackColor = Color.Transparent;
            pb2.BackColor = Color.Transparent;
            pb3.BackColor = Color.Transparent;
            pb4.BackColor = Color.Transparent;
            pb5.BackColor = Color.Transparent;
            pb6.BackColor = Color.Transparent;
            pb7.BackColor = Color.Transparent;
            pb8.BackColor = Color.Transparent;
            pb9.BackColor = Color.Transparent;
        }
        void ResetCounters()
        {

            pb1.Tag = "0"; pb2.Tag = "0"; pb3.Tag = "0";
            pb4.Tag = "0"; pb5.Tag = "0"; pb6.Tag = "0";
            pb7.Tag = "0"; pb8.Tag = "0"; pb9.Tag = "0";
            counter1 = 0;
            counter2 = 0;
            counter3 = 0;
            counter4 = 0;
            counter5 = 0;
            counter6 = 0;
            counter7 = 0;
            counter8 = 0;
            counter9 = 0;
        }
        void RestartGame()
        {
            InsertPicToPb();
            PlayerTurn = enPlayer.Player1;
            lbPlayerTurn.Text = "Player 1";
            lbWhoIsTheWinner.Text = "In Progress";
            ResetCounters();
            DisabledOrEnabledALLPb(false);

        }
        void DisabledOrEnabledALLPb(bool disable=true)
        {

            bool state = !disable;
            pb1.Enabled = state;
            pb2.Enabled = state;
            pb3.Enabled = state;
            pb4.Enabled = state;
            pb5.Enabled = state;
            pb6.Enabled = state;
            pb7.Enabled = state;
            pb8.Enabled = state;
            pb9.Enabled = state;
        }

        int IfPlayer1Win()
        {

            if (pb1.Tag.ToString() == "1" && pb2.Tag.ToString() == "1" && pb3.Tag.ToString() == "1")
            {
                pb1.BackColor = Color.Green;
                pb2.BackColor = Color.Green;
                pb3.BackColor = Color.Green;
                return 1;
            }
            else if (pb4.Tag.ToString() == "1" && pb5.Tag.ToString() == "1" && pb6.Tag.ToString() == "1")
            {
                pb4.BackColor = Color.Green;
                pb5.BackColor = Color.Green;
                pb6.BackColor = Color.Green;
                return 1;
            }
            else if (pb7.Tag.ToString() == "1" && pb8.Tag.ToString() == "1" && pb9.Tag.ToString() == "1")
            {
                pb7.BackColor = Color.Green;
                pb8.BackColor = Color.Green;
                pb9.BackColor = Color.Green;
                return 1;
            }
            else if (pb1.Tag.ToString() == "1" && pb5.Tag.ToString() == "1" && pb9.Tag.ToString() == "1")
            {
                pb1.BackColor = Color.Green;
                pb5.BackColor = Color.Green;
                pb9.BackColor = Color.Green;
     
                return 1;
            }
            else if (pb2.Tag.ToString() == "1" && pb5.Tag.ToString() == "1" && pb8.Tag.ToString() == "1")
            {
                pb2.BackColor = Color.Green;
                pb5.BackColor = Color.Green;
                pb8.BackColor = Color.Green;
  
                return 1;
            }
            else if (pb3.Tag.ToString() == "1" && pb5.Tag.ToString() == "1" && pb7.Tag.ToString() == "1")
            {
                pb3.BackColor = Color.Green;
                pb5.BackColor = Color.Green;
                pb7.BackColor = Color.Green;
          
                return 1;
            }
            else if (pb1.Tag.ToString() == "1" && pb4.Tag.ToString() == "1" && pb7.Tag.ToString() == "1")
            {
                pb1.BackColor = Color.Green;
                pb4.BackColor = Color.Green;
                pb7.BackColor = Color.Green;
            
                return 1;
            }
            else if (pb3.Tag.ToString() == "1" && pb6.Tag.ToString() == "1" && pb9.Tag.ToString() == "1")
            {
                pb3.BackColor = Color.Green;
                pb6.BackColor = Color.Green;
                pb9.BackColor = Color.Green;

                return 1;
            }
            return 0;

        }
        int IfPlayer2Win()
        {
            if (pb1.Tag.ToString() == "2" && pb2.Tag.ToString() == "2" && pb3.Tag.ToString() == "2")
            {
                pb1.BackColor = Color.Green;
                pb2.BackColor = Color.Green;
                pb3.BackColor = Color.Green;
     
                return 2;
            }
            else if (pb4.Tag.ToString() == "2" && pb5.Tag.ToString() == "2" && pb6.Tag.ToString() == "2")
            {
                pb4.BackColor = Color.Green;
                pb5.BackColor = Color.Green;
                pb6.BackColor = Color.Green;

                return 2;
            }
            else if (pb7.Tag.ToString() == "2" && pb8.Tag.ToString() == "2" && pb9.Tag.ToString() == "2")
            {
                pb7.BackColor = Color.Green;
                pb8.BackColor = Color.Green;
                pb9.BackColor = Color.Green;

                return 2;
            }
            else if (pb1.Tag.ToString() == "2" && pb5.Tag.ToString() == "2" && pb9.Tag.ToString() == "2")
            {
                pb1.BackColor = Color.Green;
                pb5.BackColor = Color.Green;
                pb9.BackColor = Color.Green;

                return 2;
            }
            else if (pb2.Tag.ToString() == "2" && pb5.Tag.ToString() == "2" && pb8.Tag.ToString() == "2")
            {
                pb2.BackColor = Color.Green;
                pb5.BackColor = Color.Green;
                pb8.BackColor = Color.Green;
           
                return 2;
            }
            else if (pb3.Tag.ToString() == "2" && pb5.Tag.ToString() == "2" && pb7.Tag.ToString() == "2")
            {
                pb3.BackColor = Color.Green;
                pb5.BackColor = Color.Green;
                pb7.BackColor = Color.Green;
 
                return 2;
            }
            else if (pb1.Tag.ToString() == "2" && pb4.Tag.ToString() == "2" && pb7.Tag.ToString() == "2")
            {
                pb1.BackColor = Color.Green;
                pb4.BackColor = Color.Green;
                pb7.BackColor = Color.Green;

                return 2;
            }
            else if (pb3.Tag.ToString() == "2" && pb6.Tag.ToString() == "2" && pb9.Tag.ToString() == "2")
            {
                pb3.BackColor = Color.Green;
                pb6.BackColor = Color.Green;
                pb9.BackColor = Color.Green;
  
                return 2;
            }
            return 0;

        }

        void WhoIsTheWinner()
        {

            int Counter = counter1 + counter2 + counter3 + counter4 + counter5 + counter6 + counter7 + counter8 + counter9;
            if (IfPlayer1Win() == 1)
            {
                Console.WriteLine("\b");
                lbPlayerTurn.Text = "Game Over";
                lbWhoIsTheWinner.Text = "Player 1";
                MessageBox.Show("Player 1 Is The Winner", "Cheers We Have A Winner", MessageBoxButtons.OK, MessageBoxIcon.None);
                DisabledOrEnabledALLPb();
            }
            else if (IfPlayer2Win() == 2)
            {
                Console.WriteLine("\b");
                lbPlayerTurn.Text = "Game Over";
                lbWhoIsTheWinner.Text = "Player 2";
                MessageBox.Show("Player 2 Is The Winner", "Cheers We Have A Winner", MessageBoxButtons.OK, MessageBoxIcon.None);
                DisabledOrEnabledALLPb();
            }
       
            else if (Counter == 9)
            {
                Console.WriteLine("\b");
                lbPlayerTurn.Text = "Game Over";
                lbWhoIsTheWinner.Text = "Draw";
                MessageBox.Show("Draw", "Game Draw", MessageBoxButtons.OK, MessageBoxIcon.None);
                DisabledOrEnabledALLPb();

            }


        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color Mycolor = Color.White;
            Pen MyPen = new Pen(Mycolor);
            MyPen.Width = 20;
            MyPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            MyPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //Hight
            e.Graphics.DrawLine(MyPen, 720, 140, 720, 700);
            e.Graphics.DrawLine(MyPen, 990, 140, 990, 700);

            //width
            e.Graphics.DrawLine(MyPen, 500, 330, 1200, 330);
            e.Graphics.DrawLine(MyPen, 500, 520, 1200, 520);
            //e.Graphics.DrawLine(MyPen, 990, 100, 990, 550);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void pb1_Click_1(object sender, EventArgs e)
        {
            if (counter1 == 1)
            {

                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                counter1++;
                if (PlayerTurn == enPlayer.Player1)
                {
                    pb1.Tag = "1";
                    lbPlayerTurn.Text = "Player 2";
                    PlayerTurn = enPlayer.Player2;
                    pb1.Image = Resources.X;

                }
                else
                {
                    lbPlayerTurn.Text = "Player 1";
                    PlayerTurn = enPlayer.Player1;
                    pb1.Image = Resources.O;
                    pb1.Tag = "2";
                }

            }
            WhoIsTheWinner();
        }
        private void pb2_Click_1(object sender, EventArgs e)
        {
            if (counter2 == 1)
            {

                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                counter2++;
                if (PlayerTurn == enPlayer.Player1)
                {
                    pb2.Tag = "1";
                    lbPlayerTurn.Text = "Player 2";
                    PlayerTurn = enPlayer.Player2;
                    pb2.Image = Resources.X;

                }
                else
                {
                    lbPlayerTurn.Text = "Player 1";
                    PlayerTurn = enPlayer.Player1;
                    pb2.Image = Resources.O;
                    pb2.Tag = "2";
                }

            }
            WhoIsTheWinner();
        }
        private void pb3_Click_1(object sender, EventArgs e)
        {
            if (counter3 == 1)
            {

                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                counter3++;
                if (PlayerTurn == enPlayer.Player1)
                {
                    pb3.Tag = "1";
                    lbPlayerTurn.Text = "Player 2";
                    PlayerTurn = enPlayer.Player2;
                    pb3.Image = Resources.X;

                }
                else
                {
                    lbPlayerTurn.Text = "Player 1";
                    PlayerTurn = enPlayer.Player1;
                    pb3.Image = Resources.O;
                    pb3.Tag = "2";
                }

            }
            WhoIsTheWinner();
        }
        private void pb4_Click_1(object sender, EventArgs e)
        {
            if (counter4 == 1)
            {

                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                counter4++;
                if (PlayerTurn == enPlayer.Player1)
                {
                    pb4.Tag = "1";
                    lbPlayerTurn.Text = "Player 2";
                    PlayerTurn = enPlayer.Player2;
                    pb4.Image = Resources.X;

                }
                else
                {
                    lbPlayerTurn.Text = "Player 1";
                    PlayerTurn = enPlayer.Player1;
                    pb4.Image = Resources.O;
                    pb4.Tag = "2";
                }

            }
            WhoIsTheWinner();
        }
        private void pb5_Click_1(object sender, EventArgs e)
        {
            if (counter5 == 1)
            {

                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                counter5++;
                if (PlayerTurn == enPlayer.Player1)
                {
                    pb5.Tag = "1";
                    lbPlayerTurn.Text = "Player 2";
                    PlayerTurn = enPlayer.Player2;
                    pb5.Image = Resources.X;

                }
                else
                {
                    lbPlayerTurn.Text = "Player 1";
                    PlayerTurn = enPlayer.Player1;
                    pb5.Image = Resources.O;
                    pb5.Tag = "2";
                }

            }
            WhoIsTheWinner();
        }
        private void pb6_Click_1(object sender, EventArgs e)
        {
            if (counter6 == 1)
            {

                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                counter6++;
                if (PlayerTurn == enPlayer.Player1)
                {
                    pb6.Tag = "1";
                    lbPlayerTurn.Text = "Player 2";
                    PlayerTurn = enPlayer.Player2;
                    pb6.Image = Resources.X;

                }
                else
                {
                    lbPlayerTurn.Text = "Player 1";
                    PlayerTurn = enPlayer.Player1;
                    pb6.Image = Resources.O;
                    pb6.Tag = "2";

                }

            }
            WhoIsTheWinner();
        }
        private void pb7_Click_1(object sender, EventArgs e)
        {
            if (counter7 == 1)
            {

                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                counter7++;
                if (PlayerTurn == enPlayer.Player1)
                {
                    pb7.Tag = "1";

                    lbPlayerTurn.Text = "Player 2";
                    PlayerTurn = enPlayer.Player2;
                    pb7.Image = Resources.X;

                }
                else
                {
                    lbPlayerTurn.Text = "Player 1";
                    PlayerTurn = enPlayer.Player1;
                    pb7.Image = Resources.O;
                    pb7.Tag = "2";

                }

            }
            WhoIsTheWinner();
        }
        private void pb8_Click_1(object sender, EventArgs e)
        {
            if (counter8 == 1)
            {

                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                counter8++;
                if (PlayerTurn == enPlayer.Player1)
                {
                    pb8.Tag = "1";
                    lbPlayerTurn.Text = "Player 2";
                    PlayerTurn = enPlayer.Player2;
                    pb8.Image = Resources.X;

                }
                else
                {
                    lbPlayerTurn.Text = "Player 1";
                    PlayerTurn = enPlayer.Player1;
                    pb8.Image = Resources.O;
                    pb8.Tag = "2";
                }

            }
            WhoIsTheWinner();
        }
        private void pb9_Click(object sender, EventArgs e)
        {
            if (counter9 == 1)
            {

                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                counter9++;
                if (PlayerTurn == enPlayer.Player1)
                {
                    pb9.Tag = "1";
                    lbPlayerTurn.Text = "Player 2";
                    PlayerTurn = enPlayer.Player2;
                    pb9.Image = Resources.X;

                }
                else
                {
                    lbPlayerTurn.Text = "Player 1";
                    PlayerTurn = enPlayer.Player1;
                    pb9.Image = Resources.O;
                    pb9.Tag = "2";
                }

            }
            WhoIsTheWinner();
        }
    }
}
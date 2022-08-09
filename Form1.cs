using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Kurs_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();

            if (e.KeyCode == Keys.A)
                ispressedA = true;

            if (e.KeyCode == Keys.D)
                ispressedD = true;

            if (e.KeyCode == Keys.S && P1.BackColor == Color.Orange)
                if (P1MoveSpeed<14)
                    P1MoveSpeed *= 2;
            

            if (IIActive.Checked == false)
            {
                if (e.KeyCode == Keys.J)
                    ispressedL = true;

                if (e.KeyCode == Keys.L)
                    ispressedR = true;

                if (e.KeyCode == Keys.K && P2.BackColor == Color.Orange)
                    if (P2MoveSpeed < 14)
                        P2MoveSpeed *= 2;
            }

        }


        private void Game_Updater(object sender, EventArgs e)
        {
            if (IIActive.Checked == true)
            {
                if (YBallSpeed < 0)
                {

                    if ((this.Ball.Location.X >= this.P2.Location.X - this.Ball.Width + this.P2.Width / 2) && (this.Ball.Location.X <= this.P2.Location.X + this.Ball.Width + this.P2.Width / 2))
                    {
                        ispressedL = false;
                        ispressedR = false;
                    }
                    else
                        if (this.Ball.Location.X < this.P2.Location.X - this.Ball.Width + this.P2.Width / 2)
                    {
                        ispressedL = true;
                        ispressedR = false;

                    }

                    else
                    {
                        ispressedR = true;
                        ispressedL = false;

                    }
                }
                else
                {
                    ispressedL = false;
                    ispressedR = false;
                }

            }


            if (ispressedA == true)
                if (this.P1.Location.X > 0)
                    this.P1.Location = new Point(this.P1.Location.X - P1MoveSpeed, this.P1.Location.Y);
                else
                    this.P1.Location = new Point(0, this.P1.Location.Y);


            if (ispressedD == true)
                if (this.P1.Location.X + this.P1.Width < this.GameField.Width)
                    this.P1.Location = new Point(this.P1.Location.X + P1MoveSpeed, this.P1.Location.Y);
                else
                    this.P1.Location = new Point(this.GameField.Width - this.P1.Width, this.P1.Location.Y);


            if (ispressedL == true)
                if (this.P2.Location.X > 0)
                    this.P2.Location = new Point(this.P2.Location.X - P2MoveSpeed, this.P2.Location.Y);
                else
                    this.P2.Location = new Point(0, this.P2.Location.Y);


            if (ispressedR == true)
                if (this.P2.Location.X + this.P2.Width < this.GameField.Width)
                    this.P2.Location = new Point(this.P2.Location.X + P2MoveSpeed, this.P2.Location.Y);
                else
                    this.P2.Location = new Point(this.GameField.Width - this.P2.Width, this.P2.Location.Y);



            if (YBallSpeed < 0)
            {
                if (this.Ball.Location.Y < -30)
                {
                    this.P1SScore++;
                    this.P1SScoreBar.Text = P1SScore.ToString();
                    this.YBallSpeed = -this.YBallSpeed;
                    this.XBallSpeed = 0;
                    this.Ball.Location = new Point(this.GameField.Width / 2, this.GameField.Height / 2);

                }

                else
                if (timer3.Enabled == false)
                    if ((this.P2.Location.Y + this.P2.Height > this.Ball.Location.Y + YBallSpeed) && (this.Ball.Location.X >= this.P2.Location.X - this.Ball.Width + 1) && (this.Ball.Location.X <= this.P2.Location.X + this.P2.Width - 1))
                    {
                        this.Ball.Location = new Point(this.Ball.Location.X, this.P2.Location.Y + this.P2.Height);
                        this.YBallSpeed = -this.YBallSpeed;
                        Flag2 = false;
                        if (P2Counter < 10)
                        {
                           P2Counter++;  
                        }
                        else
                        {
                           P2BonusState = true;
                           P2Counter = 0;
                        }

                        if (this.XBallSpeed < 8 && this.XBallSpeed > -8)
                                if (this.ispressedR)

                                this.XBallSpeed += 2;

                            else
                                if (this.ispressedL)

                                this.XBallSpeed -= 2;



                    }

                if (this.Ball.Location.X <= 0 || this.Ball.Location.X >= this.GameField.Width - this.Ball.Width)
                    this.XBallSpeed = -this.XBallSpeed;

                this.Ball.Location = new Point(this.Ball.Location.X + XBallSpeed, this.Ball.Location.Y + YBallSpeed);
            }
            else
                if (YBallSpeed > 0)
            {
                if (this.Ball.Location.Y > this.GameField.Height + 30)
                {
                    this.P2SScore++;
                    this.P2SScoreBar.Text = P2SScore.ToString();
                    this.YBallSpeed = -this.YBallSpeed;
                    this.XBallSpeed = 0;
                    this.Ball.Location = new Point(this.GameField.Width / 2, this.GameField.Height / 2);

                }

                else
                if (timer2.Enabled == false)
                    if ((this.P1.Location.Y < this.Ball.Location.Y + this.Ball.Height + YBallSpeed) && (this.Ball.Location.X >= this.P1.Location.X - this.Ball.Width + 1) && (this.Ball.Location.X <= this.P1.Location.X + this.P1.Width - 1))
                    {
                        this.Ball.Location = new Point(this.Ball.Location.X, this.P1.Location.Y - this.Ball.Height + 1);
                        this.YBallSpeed = -this.YBallSpeed;

                        Flag1 = false;

                        if (P1Counter < 10)
                        {
                            P1Counter++;
                        }
                        else
                        {
                            P1BonusState = true;
                            P1Counter = 0;
                        }

                        if (this.XBallSpeed < 8 && this.XBallSpeed > -8)
                            if (this.ispressedD)

                                this.XBallSpeed += 2;

                        else

                            if (this.ispressedA)

                                this.XBallSpeed -= 2;


                    }

                if (this.Ball.Location.X <= 0 || this.Ball.Location.X >= this.GameField.Width - this.Ball.Width)
                    this.XBallSpeed = -this.XBallSpeed;

                this.Ball.Location = new Point(this.Ball.Location.X + XBallSpeed, this.Ball.Location.Y + YBallSpeed);
            }


            if (Math.Abs(P1SScore - P2SScore) == 2)
            {
                if (P1SScore > P2SScore)
                    P1Score += 1;
                else
                   if (this.IIActive.CheckState == CheckState.Checked)
                    ComScore += 1;
                else
                    P2Score += 1;


                this.IIActive.Visible = true;

                this.timer1.Enabled = false;

                this.button1.Text = "Start";

                P1SScore = 0;
                P2SScore = 0;

                

                this.P1ScoreBar.Text = P1Score.ToString();
                this.P2ScoreBar.Text = P2Score.ToString();
                this.ComScoreBar.Text = ComScore.ToString();
                this.P1SScoreBar.Text = "0";
                this.P2SScoreBar.Text = "0";

                this.P1.Location = new Point(265, this.P1.Location.Y);
                this.P2.Location = new Point(265, this.P2.Location.Y);

                P1BonusState = false;
                P2BonusState = false;


            }

            if (P1BonusState)
            {

                P1.BackColor = Color.Orange;

            }
            else
            {
                P1.BackColor = Color.Indigo;
            }

            if (P2BonusState)
            {
                P2.BackColor = Color.Orange;
            }
            else
            {
                P2.BackColor = Color.Indigo;
            }

            if (P1Counter % 3 == 0 && P1Counter != 0 && timer2.Enabled == false && Flag1 == false)
            {
                timer2.Enabled = true;
            }

            if (P2Counter % 3 == 0 && P2Counter != 0 && timer3.Enabled == false && Flag2 == false)
            {
                timer3.Enabled = true;
            }




        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A)
                this.ispressedA = false;

            if (e.KeyCode == Keys.D)
                this.ispressedD = false;

            if (e.KeyCode == Keys.S && P1.BackColor == Color.Orange)
                if(P1MoveSpeed == 14)
                   P1MoveSpeed /= 2;

            if (IIActive.Checked == false)
            {
                if (e.KeyCode == Keys.J)
                    this.ispressedL = false;

                if (e.KeyCode == Keys.L)
                    this.ispressedR = false;


                if (e.KeyCode == Keys.K && P2.BackColor == Color.Orange)
                    if (P2MoveSpeed == 14)
                        P2MoveSpeed /= 2;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.timer1.Enabled == false)
            {
                this.timer1.Enabled = true;

                this.button1.Text = "Pause";

                this.IIActive.Visible = false;
 

            }
            else
            {
                this.IIActive.Visible = true;

                this.timer1.Enabled = false;

                this.button1.Text = "Start";

            }

            if (this.IIActive.Checked == true)
                this.label7.Text = "Com";
            else
                this.label7.Text = "P2";
 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            Flag1 = true;
            this.P1.Location = new Point(265, this.P1.Location.Y);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            Flag2 = true;
            this.P2.Location = new Point(265, this.P2.Location.Y);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (timer2.Enabled)
            {
                this.P1.Visible = !this.P1.Visible;
            }
            else
                if (this.P1.Visible == false)
                    this.P1.Visible = true;

            if (timer3.Enabled)
            {

                this.P2.Visible = !this.P2.Visible;

            }
            else
                if (this.P2.Visible == false)
                    this.P2.Visible = true;

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace reaquect_ball
{//Creator of code:David 
    //date of this typing:Jan,21,2021
    //This is a recration of a airhockey game 
    public partial class Form1 : Form
    {
        
        //p1 paddle x&y axis & score
        int paddle1X = 400;
        int paddle1Y = 50;
        int player1Score = 0;
        
        //p2 paddle x&y axis & score
        int paddle2X = 400;
        int paddle2Y = 390;
        int player2Score = 0;

        int paddleWidth = 30;
        int paddleHeight = 30;
        int paddleSpeed1= 13;
        int paddleSpeed2 = 13;

        int ballX = 425;
        int ballY = 256;
        int ballXSpeed = 5;
        int ballYSpeed= -5;
        int ballWidth = 10;
        int ballHeight = 10;
        // p1
        bool dDown = false;
        bool aDown = false;
        bool wDown = false;
        bool sDown = false;
        // p2 
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftDown = false;
        bool rightDown = false;
        //sounds 
        SoundPlayer sound1 = new SoundPlayer(Properties.Resources.neck_snap_Vladimir_719669812);
        SoundPlayer sound2 = new SoundPlayer(Properties.Resources.Shotgun_SoundBible_com_862990674);
        //grapics 
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        Pen whitePen = new Pen(Color.White);
        Pen greenPen = new Pen(Color.DarkOliveGreen);
        public Form1()
        {
            InitializeComponent(); 

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;

                case Keys.Right:
                    rightDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;

                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }

        }
        private void Form1_Keyleft(object sender, KeyEventArgs e)//use for left key 
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }
        private void Form1_Keyright(object sender, KeyEventArgs e)//use for left key 
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;

                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }
        private void tick_Tick(object sender, EventArgs e)
        //To move ball 
        {
            ballX += ballXSpeed;
            ballY += ballYSpeed;

            //move player 1
            if (wDown == true && paddle1Y > 0)
            {
                paddle1Y -= paddleSpeed1;
            }
            if (sDown == true && paddle1Y < 225)
            {
            paddle1Y += paddleSpeed1;
            }
            if (dDown == true && paddle1X < 700- paddleWidth)
            {
                paddle1X += paddleSpeed1;
            }
            if (aDown == true && paddle1X > 200)
            {
                paddle1X -= paddleSpeed1;
            }
            //move player 2
            if (upArrowDown == true && paddle2Y >265)
            {
                paddle2Y -= paddleSpeed2;
            }

            if (downArrowDown == true && paddle2Y < this.Height - paddleHeight-47)
            {
                paddle2Y += paddleSpeed2;
            }
            if (rightDown == true && paddle2X < 700- paddleWidth)
            {
                paddle2X += paddleSpeed2;
            }
            if (leftDown == true && paddle2X > 200)
            {
                paddle2X -= paddleSpeed2;
            }
            //for collision with left & right wall for ball
            if (ballX > 700||ballX<200)
            {
                ballXSpeed *= -1;
            }
      
            Rectangle player1Rec = new Rectangle(paddle1X, paddle1Y, paddleWidth, paddleHeight);
            Rectangle player2Rec = new Rectangle(paddle2X, paddle2Y, paddleWidth, paddleHeight);
            Rectangle ballRec = new Rectangle(ballX, ballY, ballWidth, ballHeight);
            Rectangle bottomRetangle = new Rectangle(350, 490, 200, 0);
            Rectangle topRectangle = new Rectangle(350, 0, 200, 0);
            if (player1Rec.IntersectsWith(ballRec))
            {
                sound1.Play();
                ballYSpeed = 8;
        
                ballY = paddle1Y + paddleHeight+1;
            }
               if(player2Rec.IntersectsWith(ballRec))
            {
                sound1.Play();
                ballYSpeed = -8;
          
                ballY = paddle2Y-10;
            }
            // when p2 scores on p1 
           if (topRectangle.IntersectsWith(ballRec))
            {
                sound2.Play();
                player2Score += 1;
                p2Score.Text = $"{player2Score}";
                ballX = 425;
                ballY = 256;
      
            }
           //when player 1 scores on p2
           if(bottomRetangle.IntersectsWith(ballRec))
            {
                sound2.Play();
                player1Score += 1;
                p1Score.Text = $"{player1Score}";
                ballX=425;
                 ballY=256;
       
            }
            //ball collisions with the top & bottom wall 
            if(ballY>480)
            {
                ballYSpeed *= -1;
            }
            if(ballY<0)
            {
                ballYSpeed *= -1;
            }
          
                //when a player hits 5
                if (player1Score == 5 || player2Score == 5)
              {
                tick.Enabled = false;
               }
            
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(whiteBrush, ballX, ballY, ballWidth, ballHeight);
           
            e.Graphics.FillEllipse(greenBrush, paddle1X, paddle1Y, paddleWidth, paddleHeight);
            e.Graphics.FillEllipse(redBrush, paddle2X, paddle2Y, paddleWidth, paddleHeight);
            e.Graphics.DrawLine(whitePen, 200, 0, 200, 700);
            e.Graphics.DrawLine(whitePen, 700, 0, 700, 700);
            e.Graphics.DrawLine(whitePen, 200, 260,700, 260);
            e.Graphics.DrawLine(whitePen,200, 5, 700, 5);
            e.Graphics.DrawRectangle(whitePen,350,5,200,50);
            e.Graphics.DrawRectangle(whitePen, 350, 440, 200, 50);
            e.Graphics.DrawEllipse(whitePen,400,225,70,70);
       

        }
    }
}


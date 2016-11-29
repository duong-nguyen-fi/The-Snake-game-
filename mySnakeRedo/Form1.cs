using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace mySnakeRedo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myFood = new Food(randFood);
            //timer1.Interval = 200;
        }
        
        #region variables

        Snake mySnake = new Snake();
        Boolean up = false, down = false, right = false, left = false;
        Random randFood = new Random();
        Food myFood;
        int score = 0, speed = 0;
        
        #endregion variables

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (up)
            { mySnake.moveUp(); }
            if (down)
            { mySnake.moveDown(); }
            if (right)
            { mySnake.moveRight(); }
            if (left)
            { mySnake.moveLeft(); }
            CheckCollision();
            tssScoreNum.Text = score.ToString();
            tssSpeedNum.Text = speed.ToString();
            Invalidate();
            
            
        }  // second

        #region waste
        private void buttonDown_Click(object sender, EventArgs e)
        {


        }
        private void buttonStart_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            /* 
             if (e.KeyData == Keys.Space)
             {
                 spaceHit = true;
             }
             */
        }  // solution for not hitting button with space
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {



        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Click(object sender, EventArgs e)
        {

        }  // nothing

        private void buttonStart_Click(object sender, EventArgs e)
        {
            /* if (spaceHit)
             {
                 spaceHit = false;
                 return;
             }
             timer1.Enabled = true;
             timer1.Interval = 100;
             timer1.Start();
             buttonStart.Enabled = false;
            */

        }
        #endregion waste
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics paper = e.Graphics;
            Pen bolderPen = new Pen(Color.Black, 4);
            e.Graphics.DrawRectangle(bolderPen, 1,1,300,300);
            mySnake.drawSnake(paper);
            myFood.drawFood(paper);
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && up == false)
                    {
                       // buttonDown.PerformClick();
                        
                        up = false;
                        down = true;
                        left = false;
                        right = false;
                        
                    }
                    if (e.KeyCode == Keys.Up && down == false)
                    {
                        up = true;
                        down = false;
                        left = false;
                        right = false;
                    }
                    if (e.KeyCode == Keys.Left && right == false)
                    {
                        up = false;
                        down = false;
                        left = true;
                        right = false;
                    }
                    if (e.KeyCode == Keys.Right && left == false)
                    {
                        up = false;
                        down = false;
                        left = false;
                        right = true;
                    }
                
            
            


        }  // keyboard input

        public void CheckCollision() // check collision with body and wall
        {
            for (int i = 1; i < mySnake.SnakeRec.Length; i++)   // snake intersect itself
            {
                if (mySnake.SnakeRec[0].IntersectsWith(mySnake.SnakeRec[i]))
                {
                    timer1.Enabled = false;
                    ResetGame();
                }
            }

            for (int i = 0; i < mySnake.SnakeRec.Length; i++)
            {
                if (mySnake.SnakeRec[i].IntersectsWith(myFood.foodRec))
                {
                    myFood.foodLocation(randFood);
                    score++;
                    mySnake.GrowSnake();
                    if (mySnake.SnakeRec.Length % 2 == 0)
                    {
                        speed++;
                        timer1.Interval -= timer1.Interval * 10 / 100;
                    }
                }
            }

            if (mySnake.SnakeRec[0].X >= 300 || mySnake.SnakeRec[0].Y >= 300 || mySnake.SnakeRec[0].X < 0 ||
                mySnake.SnakeRec[0].Y < 0)
            {
                timer1.Enabled = false;
                ResetGame();
            }

        }

        void ResetGame()
        {

            string loseMessage = "You score " + score + ". Fancy another try?";
            var result = MessageBox.Show(loseMessage, "Lost", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bye!!!");
                Thread.Sleep(300);
                this.Close();
            }
            else
            {
                Thread thrd = new Thread(new ThreadStart(openStartForm));
                thrd.Start();
                this.Close();
            }

        }
        private void openStartForm()
        {
            Application.Run(new StartForm());
        }

        void resetAllButton()
        {
            left = false;
            right = false;
            up = false;
            down = false;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace mySnakeRedo
{
    class Snake
    {
        #region variables
        private Rectangle[] snakeRec;  // snake combines of rectangles
        public Rectangle[] SnakeRec
        {
            get
            {
                return snakeRec;
            }
            set
            {
                snakeRec = value;
            }

        }

        //public Rectangle[] snakeRec;
        private SolidBrush brush;
        private int x, y, width, height;
        #endregion Variables

        public Snake()
        {
            snakeRec = new Rectangle[3];  // initial snake length =3
            brush = new SolidBrush(Color.Red);
            x = 22; y = 2; width = 10; height = 10;   // the head from the right

            for (int i = 0; i < snakeRec.Length; i++)
            {
                snakeRec[i] = new Rectangle(x, y, width, height);
                x -= 10;
            }
        }
        public void drawSnake(Graphics paper)
        {
            for (int i = 1; i < snakeRec.Length; i++)
            {
                paper.FillRectangle(brush, snakeRec[i]);
            }
            paper.FillEllipse(brush, snakeRec[0]);

        }

        #region movement
        public void drawSnakeRun()
        {
            for (int i=snakeRec.Length-1;i>0;i--)
            {
                snakeRec[i] = snakeRec[i-1];
            }
        }
        public void moveUp()
        {
            drawSnakeRun();
            snakeRec[0].Y -= 10;
            
            
        }
        public void moveDown()
        {
            drawSnakeRun();
            snakeRec[0].Y += 10;
            
            
        }
        public void moveLeft()
        {
            drawSnakeRun();
            snakeRec[0].X -= 10;
            
            
        }
        public void moveRight()
        {
            drawSnakeRun();
            snakeRec[0].X += 10;
            
            
        }
        #endregion movement

        public void GrowSnake()
        {
            List<Rectangle> parts = SnakeRec.ToList(); // turn snake into a list of parts
            parts.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X, snakeRec[snakeRec.Length - 1].Y, width, height));
            // add a new rectangle as part in to "parts" list, at the position of the last part of the snake
            snakeRec = parts.ToArray();
        }
    }
}

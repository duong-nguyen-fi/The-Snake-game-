using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace mySnakeRedo
{
    class Food
    {

        private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle foodRec;
        //Random rand = new Random();
        Snake SnakeInFood = new Snake();
        


        public Food(Random randFood)
        {

            brush = new SolidBrush(Color.Blue);
            width = 10; height = 10;
            // initial the starting food different from the initial position of the snake
            // otherwise => endless loop => crash
            do
            {
                foodLocation(randFood);
            }
            while (x <= SnakeInFood.SnakeRec[0].X && SnakeInFood.SnakeRec[0].Y == 0);
            foodRec = new Rectangle(x, y, width, height);
        }

        public void foodLocation(Random randFood)
        {

            x = (randFood.Next(0, 30) * 10);
            y = (randFood.Next(0, 30) * 10);
        }

        public void drawFood(Graphics paper)
        {
            foodRec.X = x;
            foodRec.Y = y;
            paper.FillEllipse(brush, foodRec);
        }

    }
}

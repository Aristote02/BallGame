using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace BallGameWFA
{
    public class Ball
    {
        bool direction;
        //it's our point x
        int width;
        //it's our point y
        int height;
        //position of ball on the screen
        Point point { get; set; }
        //we use radius because our ball is a circle
        int radius = 10;
        //this step is to show at what time our bll is moving
        double step = 0.1;

        int power { get; set; }
        int angle { get; set; }
        int mass { get; set; }

        //local time of the ball
        public double localtime { get; set; }

        public Ball( int power, int angle, int mass, int width, int height, bool direction)
        {
            this.power = power;
            this.angle = angle;
            this.mass = mass;
            this.width = width;
            this.height = height;
            this.localtime = 0;
            this.direction = direction;
        }
        public Point trace(double t)
        {
            Point pnt = new Point();
            //mass constant denoted as g
            double g = 9.81;
            //formula for our speed or acceleration
            double v = Math.Sqrt(2 * power / mass);
            //to find current position of our ball and is denoted by pnt.X
            if(direction)
            {
                pnt.X = (int)Math.Round(t * v * Math.Cos(angle * Math.PI / 180));
            }
            else
            {
                pnt.X = width - 50 - (int)Math.Round(t * v * Math.Cos(angle * Math.PI / 180));
            }
            //to find the trajector of our ball
            pnt.Y = height - 50 - (int)Math.Round(t * v * Math.Sin(angle * Math.PI / 180) -
               0.5 * t * t * g);


            return pnt;
        }
        public void Draw(ref Graphics graphics, Color color)
        {
            SolidBrush brush = new SolidBrush(color);
            graphics.FillEllipse(brush, point.X, point.Y, radius, radius);
        }

        public bool Move()
        {
            bool isScreen = false;
            if((point.X < width) && (point.Y < height) && (point.X >= 0) && (point.Y >= 0))
            {
                localtime = localtime + step;

                point = trace(localtime);

                isScreen = true;
            }
            return isScreen;
        }
    }
}

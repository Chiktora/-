using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : IDrawable
    {
        
        public Circle(int radius)
        {
            Radius = radius;
        }
        private int radius;

        public int Radius
        {
            get { return radius; }
            private set { radius = value; }
        }

        public void Draw()
        {
            double r_in = radius - 0.4;
            double r_out = radius + 0.4;
            for (double y = radius; y >= -radius; y--)
            {
                for (double x = -radius; x < r_out; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= r_in * r_in && value <= r_out * r_out)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

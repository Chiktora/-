﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    internal class Rectangle:IDrawable
    {
        private int width;

        public int Width
        {
            get { return width; }
            private set { width = value; }
        }

        private int height;

        public int Height
        {
            get { return height; }
            private set { height = value; }
        }


        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public void Draw()
        {
            DrawLine(this.width, '*', '*');
            for (int i = 0; i < this.width - 1; i++)
            {
                DrawLine(this.width, '*', ' ');
            }
            DrawLine(this.width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
            { 
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
}

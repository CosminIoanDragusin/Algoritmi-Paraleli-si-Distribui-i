using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APDLAB1WinFormsApp1
{
    class Ball
    {
        int px = 0;
        int py = 0;
        int size = 0;
        Color color;
        Form1 parent = null;
        Thread bthread = null;

        public Ball(Form1 parent, int px, int py, int size, Color color)
        {
            this.parent = parent;
            this.px = px;
            this.py = py;
            this.size = size;
            this.color = color;
            bthread = new Thread(new ThreadStart(run));
            bthread.Start();
        }
        public int getPX()
        {
            return px;
        }
        public int getPY()
        {
            return py;
        }
        public int getSize()
        {
            return size;
        }
        public Color getColor()
        {
            return color;
        }

        public void terminateBallThread()
        {
         //   bthread.Abort();
        }
        public void run()
        {
            while (px < parent.Size.Width)
            {
                int gravy = 1;
                int speed = -30;
                int speedX = 0;
                int speedY = -30;

                while (true)
                {
                    speedY += gravy;
                    py += speedY;
                    px += speedX;

                    Thread.Sleep(20);
                    px++;
                    parent.Refresh();

                    if (py > parent.Size.Height) 
                    {
                        speedY = speed;
                        speed += 3;
                    }
                    if (speed == 0) break;
                }
  
            }
        }
    }
}

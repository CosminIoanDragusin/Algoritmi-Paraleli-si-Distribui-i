using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APDLAB1WinFormsApp1
{
    public partial class Form1 : Form
    {
        Ball ball,ball2,ball3 = null;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.BackColor = Color.White;
            ball = new Ball(this, 0, 50, 20, Color.Red);
            ball2 = new Ball(this, 10, 90, 30, Color.Yellow);
            ball3 = new Ball(this, 20, 70, 40, Color.Blue);
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
                this.Size = new Size(400, 300);
                this.Name = "Balls";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(brush, 0, 0, Size.Width, Size.Height);
            brush = new SolidBrush(ball.getColor());
            e.Graphics.FillEllipse(brush, ball.getPX(), ball.getPY(), ball.getSize(), ball.getSize());
 
            brush = new SolidBrush(ball2.getColor());
            e.Graphics.FillEllipse(brush, ball2.getPX(), ball2.getPY(), ball2.getSize(), ball2.getSize());

            brush = new SolidBrush(ball3.getColor());
            e.Graphics.FillEllipse(brush, ball3.getPX(), ball3.getPY(), ball3.getSize(), ball3.getSize());
            brush.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ball.terminateBallThread();
            ball2.terminateBallThread();
            ball3.terminateBallThread();
        }
    }
}

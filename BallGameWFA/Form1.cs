using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallGameWFA
{
    public partial class Form1 : Form

    {
        Ball ball;
        Ball ball2;
        Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //when the ball is moving we need to clear it on the screen(u can see it where it's written Backcolor
            if (ball != null)
                ball.Draw(ref graphics, BackColor);
            if (ball.Move())
            {
                ball.Draw(ref graphics, Color.Red);
            }
            else timer1.Stop();
        }

        private void Firebutton_Click(object sender, EventArgs e)
        {
            ball = new Ball((int)PowernumericUpDown.Value, (int)AnglenumericUpDown1.Value,
                (int)WeightnumericUpDown1.Value, Width, Height, true);
            timer1.Start();
        }

        //ball2
        private void timer2_Tick(object sender, EventArgs e)
        {
            //when the ball is moving we need to clear it on the screen(u can see it where it's written Backcolor)
            if (ball2 != null)
                ball2.Draw(ref graphics, BackColor);
            if (ball2.Move())
            {
                ball2.Draw(ref graphics, Color.Red);
            }
            else timer2.Stop();
        }

        private void Firebutton2_Click(object sender, EventArgs e)
        {
            ball2 = new Ball((int)PowernumericUpDown.Value, (int)AnglenumericUpDown1.Value,
               (int)WeightnumericUpDown1.Value, Width, Height, false);
            timer2.Start();
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class FormGame : Form
    {
        static Random rnd = new Random();  
        int racket_x, racket_y;   
        int ball_x,
            ball_y;
        int racket_shift_x = 10;
        int side_lx;
        int side_rx;
        int side_uy;
        int ball_shift_x = 7; //max ball shift
        int ball_shift_y = 4; 
        int ball_sx,//current ball shift
            ball_sy;
        int total_bricks;
        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Shown(object sender, EventArgs e)
        {
            init_game();
        }

        private void init_game()
        {
            racket_x = racket.Location.X;
            racket_y = racket.Location.Y;
            side_lx = label_left.Location.X + label_left.Width;
            side_rx = label_right.Location.X;
            side_uy = label_top.Location.X + label_top.Height;
            ball_x = ball.Location.X;
            ball_y = ball.Location.Y;
            ball_sx = ball_shift_x;
            ball_sy = -ball_shift_y;
            total_bricks = 5;
        }

      

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;

            switch (key)
            {
                case Keys.Left: shift_racket(-racket_shift_x);
                    break;
                case Keys.Right: shift_racket(racket_shift_x);
                    break;
                case Keys.Enter: timer.Enabled = true;
                    break;
            }
            
        }

        private void shift_racket(int sx)
        {  
            int ax1  =  racket_x + sx;
            int ax2 = racket.Width + ax1;
            if (side_lx > ax1) ax1=side_lx;
            if (side_rx < ax2) ax1 = side_rx - racket.Width;
            racket_x = ax1;
            racket.Location = new Point(racket_x, racket_y);
        }
        private void move_ball()
        {
            
            int bx1, bx2,
                by1, by2;
            bx1 = ball_x;
            bx2 = ball_x + ball.Width;
            by1 = ball_y;
            by2 = ball_y + ball.Height;
            if (bx1 + ball_sx < side_lx)
                ball_sx = ball_shift_x;
            if (bx2 + ball_sx > side_rx)
                ball_sx = -ball_shift_x;
            if (by1 + ball_sy < side_uy)
                ball_sy = ball_shift_y;
            if (by2 + ball_sy > racket_y)
            {
                int bx0, by0;
                bx0 = (bx1 + bx2) / 2;
                by0 = (by1 + by2) / 2;
                int rx1, rx2;
                rx1 = racket_x;
                rx2 = racket_x + racket.Width;
                if (rx1 <= bx0 && bx0 <= rx2)
                {
                    ball_sy = -ball_shift_y + rnd.Next(-1, 2);

                }
                else
                     if (rx1 <= bx2+ball.Width && bx2 + ball.Width <= rx2)
                {
                    ball_sy = -ball_shift_y + rnd.Next(-1, 2);
                    ball_sx = -ball_shift_x + rnd.Next(-1, 2);
                }
                else
                    if (rx1 <= bx1 - ball.Width && bx1 - ball.Width <= rx2)
                {
                    ball_sy = -ball_shift_y + rnd.Next(-1, 2);
                    ball_sx = ball_shift_x + rnd.Next(-1, 2);
                }
                else
                    lose_ball();
            }   
           

            ball_x += ball_sx;
            ball_y += ball_sy;
            ball.Location = new Point(ball_x, ball_y);
            Cross_brick(brick1);
            Cross_brick(brick2);
            Cross_brick(brick3);
            Cross_brick(brick4);
            Cross_brick(brick5);
        }
        private void Cross_brick(Label brick)
        {

            if (!brick.Visible) return;
            int bx1, bx0, bx2,
                by1, by0, by2;
            int rx1, rx2,
                ry1, ry2;

            bx1 = ball_x;
            bx2 = ball_x + ball.Width;
            bx0 = (bx1 + bx2) / 2;
            by1 = ball_y;
            by2 = ball_y + ball.Height;
            by0 = (by1 + by2) / 2;
            rx1 = brick.Location.X;
            rx2 = rx1 + brick.Width;
            ry1 = brick.Location.Y;
            ry2 = ry1 + brick.Height;

            if (rx1 <= bx0 && bx0 <= rx2
             && ry1 <= by2 && by2 <= ry2)
            {
                drop_break(brick);
                ball_sy = -ball_sy;
                return;
            }
            if (rx1 <= bx0 && bx0 <= rx2
             && ry1 <= by1 && by1 <= ry2)
            {
                drop_break(brick);
                ball_sy = -ball_sy;
                return;
            }
            if (rx1 <= bx2 && bx2 <= rx2
             && ry1 <= by0 && by0 <= ry2)
            {
                drop_break(brick);
                ball_sx = -ball_sx;
                return;
            }
            if (rx1 <= bx1 && bx1 <= rx2
             && ry1 <= by0 && by0 <= ry2)
            {
                drop_break(brick);
                ball_sx = -ball_sx;
                return;
            }
            //if ((rx1 <= bx2 && bx2 <= rx2 && ry1 <= by2 && by2 <= ry2) ||
            //    (rx1 <= bx1 && bx1 <= rx2 && ry1 <= by2 && by2 <= ry2) ||
            //    (rx1 <= bx1 && bx1 <= rx2 && ry1 <= by1 && by1 <= ry2) ||
            //    (rx1 <= bx2 && bx2 <= rx2 && ry1 <= by1 && by1 <= ry2))



            //{
            //    drop_break(brick);
            //    ball_sx = -ball_sx;
            //    ball_sy = -ball_sy;
            //    return;
            //}


        }
        private void drop_break(Label brick)
        {
            brick.Visible = false;
            total_bricks--;
            if (total_bricks == 0)
            {
                MessageBox.Show("Win!", "You are the best");
                DialogResult = System.Windows.Forms.DialogResult.OK;  
            }
        }
        private void lose_ball()
            {
            timer.Enabled = false;
            MessageBox.Show("Lose game");
            DialogResult = System.Windows.Forms.DialogResult.Abort; 
        }
    private void timer_Tick(object sender, EventArgs e)
        {
            move_ball();
           
        }
       
    }
}

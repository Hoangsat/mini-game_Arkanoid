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
            by2 = ball_y;
            by1 = ball_y + ball.Height;
            if (bx1 + ball_sx < side_lx)
                ball_sx = ball_shift_x;
            if (bx2 + ball_sx > side_rx)
                ball_sx = -ball_shift_x;
            if (by1 + ball_sy < side_uy)
                ball_sy = ball_shift_y;
            if(by2+ball_sy > racket_y)
                ball_sy = -ball_shift_y;


            ball_x += ball_sx;
            ball_y += ball_sy;
            ball.Location = new Point(ball_x, ball_y);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            move_ball();
        }
    }
}

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
        int ball_x, ball_y;
        int racket_shift_x = 10;
        int side_lx;
        int side_rx;
        int side_uy;
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

    }
}

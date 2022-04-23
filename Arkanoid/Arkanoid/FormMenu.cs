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
    public partial class FormMenu : System.Windows.Forms.Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame();
            game.ShowDialog();
        }
    }
}

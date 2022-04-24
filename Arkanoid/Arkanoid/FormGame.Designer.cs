namespace Arkanoid
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_top = new System.Windows.Forms.Label();
            this.label_left = new System.Windows.Forms.Label();
            this.label_right = new System.Windows.Forms.Label();
            this.racket = new System.Windows.Forms.Button();
            this.ball = new System.Windows.Forms.RadioButton();
            this.brick1 = new System.Windows.Forms.Label();
            this.brick5 = new System.Windows.Forms.Label();
            this.brick2 = new System.Windows.Forms.Label();
            this.brick3 = new System.Windows.Forms.Label();
            this.brick4 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_top
            // 
            this.label_top.BackColor = System.Drawing.Color.Yellow;
            this.label_top.Location = new System.Drawing.Point(-1, 0);
            this.label_top.Name = "label_top";
            this.label_top.Size = new System.Drawing.Size(995, 18);
            this.label_top.TabIndex = 0;
            // 
            // label_left
            // 
            this.label_left.BackColor = System.Drawing.Color.Yellow;
            this.label_left.Location = new System.Drawing.Point(-1, 0);
            this.label_left.Name = "label_left";
            this.label_left.Size = new System.Drawing.Size(16, 594);
            this.label_left.TabIndex = 2;
            // 
            // label_right
            // 
            this.label_right.BackColor = System.Drawing.Color.Yellow;
            this.label_right.Location = new System.Drawing.Point(976, 0);
            this.label_right.Name = "label_right";
            this.label_right.Size = new System.Drawing.Size(18, 594);
            this.label_right.TabIndex = 3;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Navy;
            this.racket.Enabled = false;
            this.racket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.racket.Location = new System.Drawing.Point(401, 576);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(137, 18);
            this.racket.TabIndex = 4;
            this.racket.Text = "= = = = = = == = ";
            this.racket.UseVisualStyleBackColor = false;
            // 
            // ball
            // 
            this.ball.AutoSize = true;
            this.ball.Checked = true;
            this.ball.Enabled = false;
            this.ball.Location = new System.Drawing.Point(465, 557);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(14, 13);
            this.ball.TabIndex = 5;
            this.ball.TabStop = true;
            this.ball.UseVisualStyleBackColor = true;
            // 
            // brick1
            // 
            this.brick1.BackColor = System.Drawing.Color.Red;
            this.brick1.Location = new System.Drawing.Point(119, 315);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(62, 28);
            this.brick1.TabIndex = 6;
            // 
            // brick5
            // 
            this.brick5.BackColor = System.Drawing.Color.Red;
            this.brick5.Location = new System.Drawing.Point(829, 319);
            this.brick5.Name = "brick5";
            this.brick5.Size = new System.Drawing.Size(62, 28);
            this.brick5.TabIndex = 7;
            // 
            // brick2
            // 
            this.brick2.BackColor = System.Drawing.Color.Red;
            this.brick2.Location = new System.Drawing.Point(264, 174);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(62, 28);
            this.brick2.TabIndex = 8;
            // 
            // brick3
            // 
            this.brick3.BackColor = System.Drawing.Color.Red;
            this.brick3.Location = new System.Drawing.Point(500, 81);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(62, 28);
            this.brick3.TabIndex = 9;
            // 
            // brick4
            // 
            this.brick4.BackColor = System.Drawing.Color.Red;
            this.brick4.Location = new System.Drawing.Point(718, 174);
            this.brick4.Name = "brick4";
            this.brick4.Size = new System.Drawing.Size(62, 28);
            this.brick4.TabIndex = 10;
            // 
            // timer
            // 
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(994, 732);
            this.Controls.Add(this.brick4);
            this.Controls.Add(this.brick3);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.brick5);
            this.Controls.Add(this.brick1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.racket);
            this.Controls.Add(this.label_right);
            this.Controls.Add(this.label_left);
            this.Controls.Add(this.label_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGame";
            this.Shown += new System.EventHandler(this.FormGame_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.Label label_left;
        private System.Windows.Forms.Label label_right;
        private System.Windows.Forms.Button racket;
        private System.Windows.Forms.RadioButton ball;
        private System.Windows.Forms.Label brick1;
        private System.Windows.Forms.Label brick5;
        private System.Windows.Forms.Label brick2;
        private System.Windows.Forms.Label brick3;
        private System.Windows.Forms.Label brick4;
        private System.Windows.Forms.Timer timer;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cobrinha_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Label snake = new Label();
        int direction = 0;
        Random position = new Random();
        List<Control> snakes = new List<Control>() { };
        List<Point> points = new List<Point>() { };
        int pts = 0;
        int time = 200;
        bool tickstate = false;

        private void bt_start_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            
            lb_snake.Visible = false;
            pb_snake.Visible = false;
            bt_start.Visible = false;

            snake.Text = "▉";
            Font f = new Font("Arial", 8, FontStyle.Bold);
            snake.Font = f;
            snake.ForeColor = Color.Black;
            snake.BackColor = Color.Black;
            snake.Visible = true;
            this.Controls.Add(snake);

            Point p = new Point(this.Width / 2, Convert.ToInt32(this.Height * 0.4));
            snake.Location = p;

            Size s = new Size(10, 10);
            snake.Size = s;

            points.Add(snake.Location);

            bt_start.Dispose();

            new_snake_piece("piece_1");

            snakes.Add(snake);

            pn_points.Visible = true;
            lb_points.Visible = true;

            timer1.Enabled = true;
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (direction != 2)
                {
                    direction = 1;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (direction != 1)
                {
                    direction = 2;
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (direction != 4)
                {
                    direction = 3;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (direction != 3)
                {
                    direction = 4;
                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            for (int i = points.Count - 1; i >= 1; i--)
            {
                points[i] = points[i - 1];
            }

            if (snakes.Count > 1)
            {
                for (int i = 1; i < snakes.Count; i++)
                {
                    snakes[i].Location = points[i];
                }
            }

            if (direction == 1)
            {
                snake.Top -= 10;
            }
            else if (direction == 2)
            {
                snake.Top += 10;
            }
            else if (direction == 3)
            {
                snake.Left -= 10;
            }
            else if (direction == 4)
            {
                snake.Left += 10;
            }

            if (snake.Left < 0)
            {
                snake.Left = this.Width - 30;
            }

            if (snake.Left > this.Width - 30)
            {
                snake.Left = 0;
            }

            if (snake.Top < 20)
            {
                snake.Top = this.Height - 50;
            }

            if (snake.Top > this.Height - 50)
            {
                snake.Top = 20;
            }

            points[0] = snake.Location;

            foreach (Control c in this.Controls)
            {
                if (c.Name.Contains("piece"))
                {
                    if (snake.Location == c.Location)
                    {
                        if (!snakes.Contains(c))
                        {
                            snakes.Add(c);
                            new_snake_piece("piece_" + snakes.Count.ToString());
                            pts += 1;
                            lb_points.Text = "Pontos: " + pts.ToString();
                            if (time > 20)
                            {
                                time -= 3;
                                timer1.Interval = time;
                            }
                        }
                        else
                        {
                            timer1.Enabled = false;
                            System.Threading.Thread.Sleep(1000);
                            lb_gameover.Text = "Game Over!" + Environment.NewLine + "Pontos: " + pts.ToString();
                            pn_points.Visible = false;
                            foreach (Control ctr in this.Controls)
                            {
                                if (ctr.Name.Contains("snake") || ctr.Name.Contains("piece"))
                                {
                                    c.Visible = false;
                                }
                            }
                            lb_gameover.Visible = true;
                            this.Update();
                            System.Threading.Thread.Sleep(5000);
                            Application.Restart();
                        }
                    }
                }
            }

            tickstate = !tickstate;
        }

        private void new_snake_piece(string name)
        {
            Label sn = new Label();
            sn.Text = "▉";
            Font f = new Font("Arial", 8, FontStyle.Bold);
            sn.Font = f;
            sn.ForeColor = Color.Black;
            sn.BackColor = Color.Black;
            sn.Visible = true;
            Point p = new Point(RoundUp(position.Next(10, 470)), RoundUp(position.Next(10, 440)));
            bool contain = true;
            while (contain)
            {
                bool equal = false;
                for (int i=0; i<points.Count; i++)
                {
                    if (points[i] == p)
                    {
                        equal = true;
                    }
                }

                if (equal)
                {
                    p = new Point(RoundUp(position.Next(20, 470)), RoundUp(position.Next(20, 430)));
                }
                else
                {
                    contain = false;
                }
            }

            sn.Location = p;
            Size s = new Size(10, 10);
            sn.Size = s;
            this.Controls.Add(sn);
            points.Add(sn.Location);
            sn.Name = name;
        }

        private int RoundUp(int toRound)
        {
            if (toRound % 10 == 0) return toRound;
            return (10 - toRound % 10) + toRound;
        }
    }
}

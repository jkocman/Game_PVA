using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool right;
        bool left;
        bool up;
        bool down;
        bool shoot;
        string facing = "right";
        int l;
        bool x = false;
        int enemyHitCount = 0;
        int zivotnepritel = 11;
        public Form1()
        {
            
            
            InitializeComponent();
            this.BackColor = Color.Aqua;
            panel1.BackgroundImage = Properties.Resources.background2;
            this.Size = new Size(1918, 1104);
            this.StartPosition = FormStartPosition.CenterScreen;
            timer1.Stop();
            panel2.Hide();
            panel2.BackColor = Color.Blue;
            this.Controls.Add(panel2);
            this.Controls.SetChildIndex(panel2, 0);
            this.Controls.Add(panel3);
            this.Controls.SetChildIndex(panel3, 0);
            panel3.Hide();
            panel3.BackColor = Color.Red;
            panel4.Hide();
            panel4.BackColor = Color.LimeGreen;
            nepritel2.SendToBack();
            nepritel3.SendToBack();
            nepritel4.SendToBack();
            nepritel5.SendToBack();
            zivotynepritele2.SendToBack();
            zivotynepritele3.SendToBack();
            zivotynepritele4.SendToBack();
            zivotynepritele5.SendToBack();
            nepritel.Hide();
            nepritel2.Hide();
            nepritel3.Hide();
            nepritel4.Hide();
            nepritel5.Hide();
            zivotynepritele.Hide();
            zivotynepritele2.Hide();
            zivotynepritele3.Hide();
            zivotynepritele4.Hide();
            zivotynepritele5.Hide();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
                facing = "right";
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
                facing = "left";
            }
            if (e.KeyCode == Keys.Up)
            {
                up = true;
                facing = "up";
            }
            if (e.KeyCode == Keys.Down)
            {
                down = true;
                facing = "down";
            }
            if (e.KeyCode == Keys.Space)
            {
                shoot = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                shoot = false;
            }
        }
        void PlayerMove()
        {
            if (right == true)
            {
                Player.Left += 8;

            }
            if (left == true)
            {
                Player.Left -= 8;

            }
            if (up == true)
            {
                Player.Top -= 8;


            }
            if (down == true)
            {
                Player.Top += 8;
            }
        }
        void Bolts()
        {
            int i = Player.Location.X;
            int j = Player.Location.Y;


            if (facing == "right")
            {
                kulka.Size = new Size(34, 20);
                Point currentLocation = kulka.Location;
                kulka.Location = new Point(currentLocation.X + 40, currentLocation.Y);
                if (shoot == true)
                {
                    kulka.Show();
                    kulka.Location = new Point(i, j);
                }
                if (kulka.Bounds.IntersectsWith(nepritel.Bounds))
                {
                    kulka.Hide();
                }
                if (kulka.Location.X == Player.Location.X + 400)
                {
                    kulka.Location = new Point(i, j);
                    kulka.Hide();
                }
            }
            if (facing == "left")
            {
                kulka.Size = new Size(34, 20);
                Point currentLocation = kulka.Location;
                kulka.Location = new Point(currentLocation.X - 40, currentLocation.Y);
                if (shoot == true)
                {
                    kulka.Show();
                    kulka.Location = new Point(i, j);
                }
                if (kulka.Bounds.IntersectsWith(nepritel.Bounds))
                {
                    kulka.Hide();
                }
                if (kulka.Location.X == Player.Location.X - 400)
                {
                    kulka.Location = new Point(i, j);
                    kulka.Hide();
                }
            }
            if (facing == "up")
            {
                kulka.Size = new Size(20, 34);
                Point currentLocation = kulka.Location;
                kulka.Location = new Point(currentLocation.X, currentLocation.Y - 40);
                if (shoot == true)
                {
                    kulka.Show();
                    kulka.Location = new Point(i, j);
                }
                if (kulka.Bounds.IntersectsWith(nepritel.Bounds))
                {
                    kulka.Hide();
                }
                if (kulka.Location.Y == Player.Location.Y - 400)
                {
                    kulka.Location = new Point(i, j);
                    kulka.Hide();
                }
            }
            if (facing == "down")
            {
                kulka.Size = new Size(20, 34);
                Point currentLocation = kulka.Location;
                kulka.Location = new Point(currentLocation.X, currentLocation.Y + 40);
                if (shoot == true)
                {
                    kulka.Show();
                    kulka.Location = new Point(i, j);
                }
                if (kulka.Bounds.IntersectsWith(nepritel.Bounds))
                {
                    kulka.Hide();
                }
                if (kulka.Location.Y == Player.Location.Y + 400)
                {
                    kulka.Location = new Point(i, j);
                    kulka.Hide();
                }
            }
        }
        void ZivotNepritel()
        {
            if (kulka.Bounds.IntersectsWith(nepritel.Bounds))
            {
                zivotnepritel = zivotnepritel - 1;
                if (zivotnepritel <= 0)
                {
                    nepritel.Hide();
                }
                kulka.Hide();
            }
            if (kulka.Bounds.IntersectsWith(nepritel2.Bounds))
            {
                zivotnepritel = zivotnepritel - 1;
                if (zivotnepritel <= 0)
                {
                    nepritel2.Hide();
                }
                kulka.Hide();
            }
            if (kulka.Bounds.IntersectsWith(nepritel3.Bounds))
            {
                zivotnepritel = zivotnepritel - 1;
                if (zivotnepritel <= 0)
                {
                    nepritel3.Hide();
                }
                kulka.Hide();
            }
            if (kulka.Bounds.IntersectsWith(nepritel4.Bounds))
            {
                zivotnepritel = zivotnepritel - 1;
                if (zivotnepritel <= 0)
                {
                    nepritel4.Hide();
                }
                kulka.Hide();
            }
            if (kulka.Bounds.IntersectsWith(nepritel5.Bounds))
            {
                zivotnepritel = zivotnepritel - 1;
                if (zivotnepritel <= 0)
                {
                    nepritel5.Hide();
                }
                kulka.Hide();
            }
            int p = nepritel.Location.X;
            int p2 = nepritel.Location.Y;
            zivotynepritele.Location = new Point(p - 30, p2 - 77);

            if (kulka.Bounds.IntersectsWith(nepritel.Bounds))
            {
                enemyHitCount++;

                switch (enemyHitCount)
                {
                    case 3:
                        zivotynepritele.Image = Properties.Resources.ok;
                        break;
                    case 7:
                        zivotynepritele.Image = Properties.Resources.blbý;
                        break;
                    case 11:
                        zivotynepritele.Image = Properties.Resources.cool3;
                        enemyHitCount = 0;
                        break;
                }
                zivotynepritele.Invalidate();

            }
            int p3 = nepritel2.Location.X;
            int p4 = nepritel2.Location.Y;
            zivotynepritele2.Location = new Point(p3 - 30, p4 - 77);

            if (kulka.Bounds.IntersectsWith(nepritel2.Bounds))
            {
                enemyHitCount++;

                switch (enemyHitCount)
                {
                    case 3:
                        zivotynepritele2.Image = Properties.Resources.ok;
                        break;
                    case 7:
                        zivotynepritele2.Image = Properties.Resources.blbý;
                        break;
                    case 11:
                        zivotynepritele2.Image = Properties.Resources.cool3;
                        enemyHitCount = 0;
                        break;
                }
                zivotynepritele2.Invalidate();

            }
            int p5 = nepritel3.Location.X;
            int p6 = nepritel3.Location.Y;
            zivotynepritele3.Location = new Point(p5 - 30, p6 - 77);

            if (kulka.Bounds.IntersectsWith(nepritel3.Bounds))
            {
                enemyHitCount++;

                switch (enemyHitCount)
                {
                    case 3:
                        zivotynepritele3.Image = Properties.Resources.ok;
                        break;
                    case 7:
                        zivotynepritele3.Image = Properties.Resources.blbý;
                        break;
                    case 11:
                        zivotynepritele3.Image = Properties.Resources.cool3;
                        enemyHitCount = 0;
                        break;
                }
                zivotynepritele3.Invalidate();

            }
            int p7 = nepritel4.Location.X;
            int p8 = nepritel4.Location.Y;
            zivotynepritele4.Location = new Point(p7 - 30, p8 - 77);

            if (kulka.Bounds.IntersectsWith(nepritel4.Bounds))
            {
                enemyHitCount++;

                switch (enemyHitCount)
                {
                    case 3:
                        zivotynepritele4.Image = Properties.Resources.ok;
                        break;
                    case 7:
                        zivotynepritele4.Image = Properties.Resources.blbý;
                        break;
                    case 11:
                        zivotynepritele4.Image = Properties.Resources.cool3;
                        enemyHitCount = 0;
                        break;
                }
                zivotynepritele4.Invalidate();

            }
            int p9 = nepritel5.Location.X;
            int p10 = nepritel5.Location.Y;
            zivotynepritele5.Location = new Point(p9 - 30, p10 - 77);

            if (kulka.Bounds.IntersectsWith(nepritel5.Bounds))
            {
                enemyHitCount++;

                switch (enemyHitCount)
                {
                    case 3:
                        zivotynepritele5.Image = Properties.Resources.ok;
                        break;
                    case 7:
                        zivotynepritele5.Image = Properties.Resources.blbý;
                        break;
                    case 11:
                        zivotynepritele5.Image = Properties.Resources.cool3;
                        enemyHitCount = 0;
                        break;
                }
                zivotynepritele5.Invalidate();

            }

        }
        void Steny()
        {
            if (Player.Bounds.IntersectsWith(stena2.Bounds))
            {
                Player.Top = stena2.Top - Player.Height;
            }
            if (Player.Bounds.IntersectsWith(stena.Bounds))
            {
                Player.Top = stena.Top + Player.Height;
            }
            if (Player.Bounds.IntersectsWith(stena3.Bounds))
            {
                Player.Left = stena3.Left + Player.Width;
            }
            if (Player.Bounds.IntersectsWith(stena4.Bounds))
            {
                Player.Left = stena4.Left - Player.Width;
            }

        }
        void LifeIndex()
        {
            if (l == 1)
            {
                zivot1.Image = Properties.Resources._2;
            }
            if (l == 2)
            {
                zivot2.Image = Properties.Resources._2;
            }
            if (l == 3)
            {
                zivot3.Image = Properties.Resources._2;
            }
            if (l >= 3)
            {
                x = true;
                panel2.Show();
                timer1.Stop();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            PlayerMove();
            Bolts();
            Steny();
        }

    }
}

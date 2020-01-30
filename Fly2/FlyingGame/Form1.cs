using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyingGame
{
    public partial class Form1 : Form
    {

        //движение игрока
        int moveLeft = 0;
        int enemyMove = 2;
        Random rnd = new Random();
        int bulletSpeed = 8;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            //labelScore.BringToFront();
            // самолеты сталкиваются
            int enemyLeft = panelBackground.Width - pictureBoxEnemy1.Width;

            pictureBoxEnemy1.Top = panelBackground.Top + rnd.Next(1, 50);
            pictureBoxEnemy1.Left = enemyLeft + pictureBoxEnemy1.Width;

            pictureBoxEnemy2.Top = panelBackground.Top + rnd.Next(1, 150);
            pictureBoxEnemy2.Left = enemyLeft + pictureBoxEnemy1.Width * 2 + rnd.Next(50, 300);

            pictureBoxEnemy3.Top = panelBackground.Top + rnd.Next(1, 180);
            pictureBoxEnemy3.Left = enemyLeft + pictureBoxEnemy1.Width * 3 + rnd.Next(300, 400);

            pictureBoxBullet.Top = -100;
            pictureBoxBullet.Left = -100;

            pictureBoxPlayer.Left = (panelBackground.Width / 2) - (pictureBoxPlayer.Width / 2); //расположение по ширине
            pictureBoxPlayer.Top = panelBackground.Height - pictureBoxPlayer.Height;            //расположение по высоте
        }

        private void enemyNewLocation()
        {
            pictureBoxEnemy1.Top = panelBackground.Top + rnd.Next(1, 50);
            pictureBoxEnemy1.Left = panelBackground.Width;
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBoxPlayer.Location.X < 0)
                {
                    moveLeft = 0;
                }
                else
                {
                    moveLeft = -5;
                }
            }

            else if (e.KeyCode == Keys.Right)
            {
                if (pictureBoxPlayer.Location.X > panelBackground.Width - pictureBoxPlayer.Width)
                {
                    moveLeft = 0;
                }
                else
                {
                    moveLeft = 5;
                }
            }

            //else if (e.KeyCode == Keys.Space)
            //{
            //    makeBullet();
            //}
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = 0;
            }

            else if (e.KeyCode == Keys.Right)
            {
                moveLeft = 0;
            }

            else if (e.KeyCode == Keys.Space)
            {
                makeBullet();
            }

        }

        private void makeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.bullet;
            bullet.Size = new Size(7, 27);
            bullet.Tag = "bullet";
            bullet.Left = pictureBoxPlayer.Left + (pictureBoxPlayer.Width / 2) - (bullet.Width / 2);
            bullet.Top = pictureBoxPlayer.Top;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        private void gameOver()
        {
            playTimer.Enabled = false;
            MessageBox.Show("вы проиграли");
        }

        private void playTimer_Tick(object sender, EventArgs e)
        {
            int enemyWidth = pictureBoxEnemy1.Width;

            pictureBoxEnemy1.Left -= enemyMove;
            pictureBoxEnemy2.Left -= enemyMove;
            pictureBoxEnemy3.Left -= enemyMove;

            pictureBoxPlayer.Left += moveLeft;

            if (pictureBoxEnemy1.Location.X < -enemyWidth || 
                pictureBoxEnemy2.Location.X < -enemyWidth || 
                pictureBoxEnemy3.Location.X < -enemyWidth)
            {
                gameOver();
            }

            //// анимация выстрела и полета пули исходный вариант
            //foreach (Control el in this.Controls)
            //{
            //    if (el is PictureBox && el.Tag == "bullet")
            //    {
            //        el.Top -= bulletSpeed;

            //        if (el.Top < 0)
            //        {
            //            Controls.Remove(el);
            //        }
            //    }
            //}

            // анимация выстрела и полета пули попытка 2
            foreach (Control bullet in this.Controls)
            {
                if (bullet is PictureBox && bullet.Tag == "bullet")
                {
                    bullet.Top -= bulletSpeed;

                    if (bullet.Top < 0)
                    {
                        Controls.Remove(bullet);
                    }

                    if (bullet.Bounds.IntersectsWith(pictureBoxEnemy1.Bounds))
                    {
                        Controls.Remove(bullet);
                        enemyNewLocation();
                        score++;
                    }
                }
            }

            //реализация попадания пули по врагу, столкновение пули и врага
            //foreach (Control i in this.Controls)
            //{
            //    foreach (Control j in this.Controls)
            //    {
            //        if (i is PictureBox && i.Tag == "enemy")
            //        {
            //            if (j is PictureBox && j.Tag == "bullet")
            //            {
            //                if (i.Bounds.IntersectsWith(j.Bounds))
            //                {
            //                    score++;
            //                    this.Controls.Remove(i);
            //                    this.Controls.Remove(j);
            //                }
            //            }
            //        }
            //    }
            //}
            //реализация попадания пули по врагу, столкновение пули и врага

            //foreach (Control enemy in this.Controls)
            //{
            //    foreach (Control bullet in this.Controls)
            //    {
            //        if (enemy is PictureBox && enemy.Tag == "enemy" &&
            //            bullet is PictureBox && bullet.Tag == "bullet" &&
            //            bullet.Bounds.IntersectsWith(enemy.Bounds))
            //        {
            //            score++;
            //            this.Controls.Remove(enemy);
            //            this.Controls.Remove(bullet);
            //        }
            //    }
            //}

            labelScore.Text = "Счет: " + score;
        }

        private void pictureBoxEnemy3_Click(object sender, EventArgs e)
        {

        }
    }
}

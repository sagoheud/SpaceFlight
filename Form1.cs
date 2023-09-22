using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SpaceFlight
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shoootgMedia;
        WindowsMediaPlayer explosion;

        PictureBox[] stars;
        int backgroundspeed;
        int playerSpeed;

        PictureBox[] munitions;
        int munitionsSpeed;

        PictureBox[] enemiesmunition;
        int enemiesmunitionSpeed;

        PictureBox[] enemies;
        int enemiSpeed;

        Random random;

        int score;
        int level;
        int difficulty;
        bool pause;
        bool gameIsOver;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pause = false;
            gameIsOver = false;
            score = 0;
            level = 1;
            difficulty = 9;

            backgroundspeed = 4;
            playerSpeed = 5;
            enemiSpeed = 4;
            munitionsSpeed = 20;
            enemiesmunitionSpeed = 4;
            random = new Random();

            gameMedia = new WindowsMediaPlayer();
            shoootgMedia = new WindowsMediaPlayer();
            explosion = new WindowsMediaPlayer();
            gameMedia.URL = "songs\\GameSong.mp3";
            shoootgMedia.URL = "songs\\shoot.mp3";
            explosion.URL = "songs\\boom.mp3";
            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shoootgMedia.settings.volume = 1;
            explosion.settings.volume = 4;

            Image munition = Image.FromFile("img\\munition.png");
            munitions = new PictureBox[4];
            for (int i = 0; i < munitions.Length; i++)
            {
                munitions[i] = new PictureBox();
                munitions[i].Size = new Size(8, 8);
                munitions[i].Image = munition;
                munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                munitions[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(munitions[i]);
            }

            Image enemi1 = Image.FromFile("img\\e1.png");
            Image enemi2 = Image.FromFile("img\\e2.png");
            Image enemi3 = Image.FromFile("img\\e3.png");
            Image Boss1 = Image.FromFile("img\\Boss1.png");
            Image Boss2 = Image.FromFile("img\\Boss2.png"); 
            enemies = new PictureBox[8];
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(40, 40);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].Visible = false;
                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point((i + 1) * 60, -50);
            }
            enemies[0].Image = enemi1;
            enemies[1].Image = enemi2;
            enemies[2].Image = enemi3;
            enemies[3].Image = enemi1;
            enemies[4].Image = enemi2;
            enemies[5].Image = enemi3;
            enemies[6].Image = Boss1;
            enemies[7].Image = Boss2;

            enemiesmunition = new PictureBox[8];
            for (int i = 0; i < enemiesmunition.Length; i++)
            {
                enemiesmunition[i] = new PictureBox();
                enemiesmunition[i].Size = new Size(2, 25);
                enemiesmunition[i].Visible = false;
                enemiesmunition[i].BackColor = Color.Yellow;
                int x = random.Next(0, 8);
                enemiesmunition[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                this.Controls.Add(enemiesmunition[i]);
            }

            stars = new PictureBox[50];
            random = new Random();
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(random.Next(20, 500), random.Next(-10, 400));
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.White;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }

                this.Controls.Add(stars[i]); // 위의 for문을 바탕으로 화면에 별 생성
            }

            gameMedia.controls.play();
        }

        private void MoveBgTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundspeed-1;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }

            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundspeed-2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void LeftMove_Tick(object sender, EventArgs e)
        {
            if (Player.Right > 25)
            {
                Player.Left -= playerSpeed;
            }
        }

        private void RightMove_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 610)
            {
                Player.Left += playerSpeed;
            }
        }

        private void UpMove_Tick(object sender, EventArgs e)
        {
            if (Player.Bottom > 20)
            {
                Player.Top -= playerSpeed;
            }
        }

        private void DownMove_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 425)
            {
                Player.Top += playerSpeed;
            }
        }

        private void MunitionMove_Tick(object sender, EventArgs e)
        {
            shoootgMedia.controls.play();
            for (int i = 0; i < munitions.Length; i++)
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= munitionsSpeed;
                    collision();
                }
                else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
            }
        }

        private void moveEnemies(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }

        private void MoveEnemies_Tick(object sender, EventArgs e)
        {
            moveEnemies(enemies, enemiSpeed);
        }

        private void EnemiesMunition_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemiesmunition.Length - difficulty; i++)
            {
                if (enemiesmunition[i].Top < this.Height)
                {
                    enemiesmunition[i].Visible = true;
                    enemiesmunition[i].Top += enemiesmunitionSpeed;
                    collisionWithEnemiesMunition();
                }
                else
                {
                    enemiesmunition[i].Visible = false;
                    int x = random.Next(0, 8);
                    enemiesmunition[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y +30);
                }
            }
        }


        private void GameOver(string str)
        {
            txtLv.Text = str;
            txtLv.Location = new Point(145, 120);
            txtLv.Visible = true;
            btnReplay.Visible = true;
            btnExit.Visible = true;

            gameMedia.controls.stop();
            StopTimers();
        }

        private void StopTimers()
        { 
            MoveBgTimer.Stop();
            MoveEnemies.Stop();
            MunitionMove.Stop();
            EnemiesMunition.Stop();
        }

        private void StartTimers()
        {
            MoveBgTimer.Start();
            MoveEnemies.Start();
            MunitionMove.Start();
            EnemiesMunition.Start();
        }

        private void collision()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (munitions[0].Bounds.IntersectsWith(enemies[i].Bounds)
                    || munitions[1].Bounds.IntersectsWith(enemies[i].Bounds)
                    || munitions[2].Bounds.IntersectsWith(enemies[i].Bounds)
                    || munitions[3].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.controls.play();

                    score += 1;
                    scorelbl.Text = (score < 10) ? "0" + score.ToString() : score.ToString();
                    if (score % 30 == 0)
                    {
                        level += 1;
                        levellbl.Text = (level < 10) ? "0" + level.ToString() : level.ToString();

                        if (enemiSpeed <= 10 && enemiesmunitionSpeed <= 10 && difficulty >= 0)
                        {
                            difficulty--;
                            enemiSpeed++;
                            enemiesmunitionSpeed++;
                        }
                        if (level == 10)
                        {
                            GameOver("NICE DONE");
                        }
                    }
                    enemies[i].Location = new Point((i + 1) * 60, -100);
                }
                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.settings.volume = 8;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("GameOver");
                }
            }
        }

        private void collisionWithEnemiesMunition()
        {
            for (int i = 0; i < enemiesmunition.Length; i++)
            {
                if (enemiesmunition[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    enemiesmunition[i].Visible = false;
                    explosion.settings.volume = 6;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("GameOver");
                }
            }
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Left)
                {
                    LeftMove.Start();
                }
                if (e.KeyCode == Keys.Right)
                {
                    RightMove.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    UpMove.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    DownMove.Start();
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                LeftMove.Stop();
            }
            if (e.KeyCode == Keys.Right)
            {
                RightMove.Stop();
            }
            if (e.KeyCode == Keys.Up)
            {
                UpMove.Stop();
            }
            if (e.KeyCode == Keys.Down)
            {
                DownMove.Stop();
            }

            if (e.KeyCode == Keys.Space)
            {
                if (!gameIsOver)
                {
                    if (pause)
                    {                      
                        txtLv.Visible = false;
                        pause = false;
                        StartTimers();
                        gameMedia.controls.play();
                    }
                    else
                    { 
                        txtLv.Location = new Point(this.Width/2-160, 160);
                        txtLv.Text = "PAUSED";
                        txtLv.Visible = true;
                        gameMedia.controls.pause();
                        StopTimers();
                        pause = true;
                    }
                }
            }
        }
    }
}

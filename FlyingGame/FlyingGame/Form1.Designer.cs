namespace FlyingGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelScore = new System.Windows.Forms.Label();
            this.playTimer = new System.Windows.Forms.Timer(this.components);
            this.panelBackground = new System.Windows.Forms.Panel();
            this.pictureBoxEnemy3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemy2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemy1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBullet = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(12, 403);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(194, 55);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Счет: 0";
            // 
            // playTimer
            // 
            this.playTimer.Enabled = true;
            this.playTimer.Interval = 10;
            this.playTimer.Tick += new System.EventHandler(this.playTimer_Tick);
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.pictureBoxEnemy3);
            this.panelBackground.Controls.Add(this.pictureBoxEnemy2);
            this.panelBackground.Controls.Add(this.pictureBoxEnemy1);
            this.panelBackground.Controls.Add(this.pictureBoxBullet);
            this.panelBackground.Controls.Add(this.labelScore);
            this.panelBackground.Controls.Add(this.pictureBoxPlayer);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(784, 561);
            this.panelBackground.TabIndex = 3;
            // 
            // pictureBoxEnemy3
            // 
            this.pictureBoxEnemy3.Image = global::FlyingGame.Properties.Resources.stormCloud;
            this.pictureBoxEnemy3.Location = new System.Drawing.Point(461, 78);
            this.pictureBoxEnemy3.Name = "pictureBoxEnemy3";
            this.pictureBoxEnemy3.Size = new System.Drawing.Size(72, 61);
            this.pictureBoxEnemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEnemy3.TabIndex = 5;
            this.pictureBoxEnemy3.TabStop = false;
            this.pictureBoxEnemy3.Tag = "enemy";
            this.pictureBoxEnemy3.Click += new System.EventHandler(this.pictureBoxEnemy3_Click);
            // 
            // pictureBoxEnemy2
            // 
            this.pictureBoxEnemy2.Image = global::FlyingGame.Properties.Resources.stormCloud;
            this.pictureBoxEnemy2.Location = new System.Drawing.Point(298, 94);
            this.pictureBoxEnemy2.Name = "pictureBoxEnemy2";
            this.pictureBoxEnemy2.Size = new System.Drawing.Size(72, 61);
            this.pictureBoxEnemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEnemy2.TabIndex = 4;
            this.pictureBoxEnemy2.TabStop = false;
            this.pictureBoxEnemy2.Tag = "enemy";
            // 
            // pictureBoxEnemy1
            // 
            this.pictureBoxEnemy1.Image = global::FlyingGame.Properties.Resources.stormCloud;
            this.pictureBoxEnemy1.Location = new System.Drawing.Point(0, 78);
            this.pictureBoxEnemy1.Name = "pictureBoxEnemy1";
            this.pictureBoxEnemy1.Size = new System.Drawing.Size(72, 61);
            this.pictureBoxEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEnemy1.TabIndex = 3;
            this.pictureBoxEnemy1.TabStop = false;
            this.pictureBoxEnemy1.Tag = "enemy";
            // 
            // pictureBoxBullet
            // 
            this.pictureBoxBullet.Image = global::FlyingGame.Properties.Resources.bullet;
            this.pictureBoxBullet.Location = new System.Drawing.Point(557, 3);
            this.pictureBoxBullet.Name = "pictureBoxBullet";
            this.pictureBoxBullet.Size = new System.Drawing.Size(7, 27);
            this.pictureBoxBullet.TabIndex = 2;
            this.pictureBoxBullet.TabStop = false;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Image = global::FlyingGame.Properties.Resources.tank;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(357, 340);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(40, 50);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayer.TabIndex = 0;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelBackground);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Сбей самолет\"";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.onKeyUp);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer playTimer;
        private System.Windows.Forms.PictureBox pictureBoxBullet;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.PictureBox pictureBoxEnemy3;
        private System.Windows.Forms.PictureBox pictureBoxEnemy2;
        private System.Windows.Forms.PictureBox pictureBoxEnemy1;
    }
}


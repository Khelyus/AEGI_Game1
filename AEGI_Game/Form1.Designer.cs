namespace AEGI_Game
{
    partial class FormOurGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOurGame));
            timer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            player = new PictureBox();
            enemy1 = new PictureBox();
            enemy2 = new PictureBox();
            enemy3 = new PictureBox();
            enemy4 = new PictureBox();
            labelLose = new Label();
            buttonRestart = new Button();
            buttonPause = new Button();
            buttonContinue = new Button();
            coin = new PictureBox();
            labelcoins = new Label();
            coin1 = new PictureBox();
            buttonStartplay = new Button();
            buttonExit = new Button();
            labelRecord = new Label();
            bomb = new PictureBox();
            bomb1 = new PictureBox();
            labelPause = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bomb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bomb1).BeginInit();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 15;
            timer.Tick += timer_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(738, 489);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, -488);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(738, 489);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // player
            // 
            player.Image = Properties.Resources.mycar_fotor_bg_remover_20240430212132;
            player.Location = new Point(458, 364);
            player.Margin = new Padding(3, 2, 3, 2);
            player.Name = "player";
            player.Size = new Size(39, 96);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 1;
            player.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.BackColor = Color.Gray;
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(523, -98);
            enemy1.Margin = new Padding(3, 2, 3, 2);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(39, 96);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 3;
            enemy1.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.BackColor = Color.Gray;
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(383, 300);
            enemy2.Margin = new Padding(3, 2, 3, 2);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(39, 96);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 4;
            enemy2.TabStop = false;
            // 
            // enemy3
            // 
            enemy3.BackColor = Color.Gray;
            enemy3.Image = (Image)resources.GetObject("enemy3.Image");
            enemy3.Location = new Point(311, 9);
            enemy3.Margin = new Padding(3, 2, 3, 2);
            enemy3.Name = "enemy3";
            enemy3.Size = new Size(39, 96);
            enemy3.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy3.TabIndex = 7;
            enemy3.TabStop = false;
            // 
            // enemy4
            // 
            enemy4.BackColor = Color.Gray;
            enemy4.Image = (Image)resources.GetObject("enemy4.Image");
            enemy4.Location = new Point(237, 300);
            enemy4.Margin = new Padding(3, 2, 3, 2);
            enemy4.Name = "enemy4";
            enemy4.Size = new Size(39, 96);
            enemy4.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy4.TabIndex = 8;
            enemy4.TabStop = false;
            // 
            // labelLose
            // 
            labelLose.AutoSize = true;
            labelLose.BackColor = Color.IndianRed;
            labelLose.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelLose.ForeColor = SystemColors.Control;
            labelLose.Location = new Point(214, 177);
            labelLose.Name = "labelLose";
            labelLose.Size = new Size(316, 40);
            labelLose.TabIndex = 9;
            labelLose.Text = "ВЫ ПРОИГРАЛИ!";
            // 
            // buttonRestart
            // 
            buttonRestart.BackColor = Color.IndianRed;
            buttonRestart.FlatStyle = FlatStyle.Flat;
            buttonRestart.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRestart.ForeColor = SystemColors.Control;
            buttonRestart.Location = new Point(262, 226);
            buttonRestart.Margin = new Padding(3, 2, 3, 2);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(260, 41);
            buttonRestart.TabIndex = 10;
            buttonRestart.Text = "Попробовать заново";
            buttonRestart.UseVisualStyleBackColor = false;
            buttonRestart.Click += buttonRestart_Click_1;
            // 
            // buttonPause
            // 
            buttonPause.BackColor = Color.IndianRed;
            buttonPause.FlatStyle = FlatStyle.Flat;
            buttonPause.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonPause.ForeColor = SystemColors.Control;
            buttonPause.Location = new Point(592, 9);
            buttonPause.Margin = new Padding(3, 2, 3, 2);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(133, 28);
            buttonPause.TabIndex = 21;
            buttonPause.Text = "Пауза";
            buttonPause.UseVisualStyleBackColor = false;
            buttonPause.Click += buttonPause_Click;
            // 
            // buttonContinue
            // 
            buttonContinue.BackColor = Color.IndianRed;
            buttonContinue.FlatStyle = FlatStyle.Flat;
            buttonContinue.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonContinue.ForeColor = SystemColors.Control;
            buttonContinue.Location = new Point(262, 226);
            buttonContinue.Margin = new Padding(3, 2, 3, 2);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(260, 41);
            buttonContinue.TabIndex = 22;
            buttonContinue.Text = "Продолжить";
            buttonContinue.UseVisualStyleBackColor = false;
            buttonContinue.Visible = false;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // coin
            // 
            coin.BackColor = Color.DimGray;
            coin.Image = (Image)resources.GetObject("coin.Image");
            coin.Location = new Point(387, -412);
            coin.Margin = new Padding(3, 2, 3, 2);
            coin.Name = "coin";
            coin.Size = new Size(18, 15);
            coin.SizeMode = PictureBoxSizeMode.StretchImage;
            coin.TabIndex = 11;
            coin.TabStop = false;
            // 
            // labelcoins
            // 
            labelcoins.AutoSize = true;
            labelcoins.BackColor = Color.IndianRed;
            labelcoins.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcoins.ForeColor = SystemColors.Control;
            labelcoins.Location = new Point(580, 461);
            labelcoins.Name = "labelcoins";
            labelcoins.Size = new Size(148, 20);
            labelcoins.TabIndex = 12;
            labelcoins.Text = "У ВАС МОНЕТ: 0";
            // 
            // coin1
            // 
            coin1.BackColor = Color.DimGray;
            coin1.Image = (Image)resources.GetObject("coin1.Image");
            coin1.Location = new Point(173, -450);
            coin1.Margin = new Padding(3, 2, 3, 2);
            coin1.Name = "coin1";
            coin1.Size = new Size(18, 15);
            coin1.SizeMode = PictureBoxSizeMode.StretchImage;
            coin1.TabIndex = 14;
            coin1.TabStop = false;
            // 
            // buttonStartplay
            // 
            buttonStartplay.BackColor = Color.IndianRed;
            buttonStartplay.FlatStyle = FlatStyle.Flat;
            buttonStartplay.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStartplay.ForeColor = SystemColors.Control;
            buttonStartplay.Location = new Point(262, 202);
            buttonStartplay.Margin = new Padding(3, 2, 3, 2);
            buttonStartplay.Name = "buttonStartplay";
            buttonStartplay.Size = new Size(260, 41);
            buttonStartplay.TabIndex = 15;
            buttonStartplay.Text = "Начать игру";
            buttonStartplay.UseVisualStyleBackColor = false;
            buttonStartplay.Click += buttonStartplay_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.IndianRed;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonExit.ForeColor = SystemColors.Control;
            buttonExit.Location = new Point(262, 279);
            buttonExit.Margin = new Padding(3, 2, 3, 2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(260, 41);
            buttonExit.TabIndex = 16;
            buttonExit.Text = "Завершить игру";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelRecord
            // 
            labelRecord.AutoSize = true;
            labelRecord.BackColor = Color.IndianRed;
            labelRecord.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRecord.ForeColor = SystemColors.Control;
            labelRecord.Location = new Point(326, 9);
            labelRecord.Name = "labelRecord";
            labelRecord.Size = new Size(132, 31);
            labelRecord.TabIndex = 17;
            labelRecord.Text = "Рекорд: 0";
            // 
            // bomb
            // 
            bomb.BackColor = Color.Gray;
            bomb.Image = (Image)resources.GetObject("bomb.Image");
            bomb.Location = new Point(467, -450);
            bomb.Margin = new Padding(3, 2, 3, 2);
            bomb.Name = "bomb";
            bomb.Size = new Size(28, 24);
            bomb.SizeMode = PictureBoxSizeMode.StretchImage;
            bomb.TabIndex = 18;
            bomb.TabStop = false;
            // 
            // bomb1
            // 
            bomb1.BackColor = Color.Gray;
            bomb1.Image = (Image)resources.GetObject("bomb1.Image");
            bomb1.Location = new Point(228, -450);
            bomb1.Margin = new Padding(3, 2, 3, 2);
            bomb1.Name = "bomb1";
            bomb1.Size = new Size(28, 24);
            bomb1.SizeMode = PictureBoxSizeMode.StretchImage;
            bomb1.TabIndex = 19;
            bomb1.TabStop = false;
            // 
            // labelPause
            // 
            labelPause.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelPause.AutoSize = true;
            labelPause.BackColor = Color.IndianRed;
            labelPause.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPause.ForeColor = SystemColors.Control;
            labelPause.Location = new Point(335, 177);
            labelPause.Name = "labelPause";
            labelPause.Size = new Size(109, 40);
            labelPause.TabIndex = 20;
            labelPause.Text = "Пауза";
            labelPause.Visible = false;
            // 
            // FormOurGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(735, 488);
            Controls.Add(labelPause);
            Controls.Add(buttonContinue);
            Controls.Add(buttonPause);
            Controls.Add(bomb1);
            Controls.Add(bomb);
            Controls.Add(buttonStartplay);
            Controls.Add(labelLose);
            Controls.Add(labelRecord);
            Controls.Add(buttonExit);
            Controls.Add(coin1);
            Controls.Add(labelcoins);
            Controls.Add(coin);
            Controls.Add(buttonRestart);
            Controls.Add(enemy4);
            Controls.Add(enemy3);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Controls.Add(pictureBox3);
            Controls.Add(player);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormOurGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OurGame";
            Load += FormOurGame_Load;
            KeyDown += FormOurGame_KeyDown;
            KeyPress += FormOurGame_KeyPress;
            KeyUp += FormOurGame_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy4).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bomb).EndInit();
            ((System.ComponentModel.ISupportInitialize)bomb1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxWithCar;
        private System.Windows.Forms.Timer timer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox player;
        private PictureBox enemy1;
        private PictureBox enemy2;
        private PictureBox enemy3;
        private PictureBox enemy4;
        private Label labelLose;
        private Button buttonRestart;
        private PictureBox coin;
        private Label labelcoins;
        private PictureBox coin1;
        private Button buttonTryAgain;
        private Label labellives;
        private Button buttonStartplay;
        private Button buttonExit;
        private Label labelRecord;
        private PictureBox bomb;
        private PictureBox bomb1;
        private Label labelPause;
        private Button buttonPause;
        private Button buttonContinue;
    }
}

namespace ArcadeValeriaV
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblPlay = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.grbPlay = new System.Windows.Forms.GroupBox();
            this.player1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblPianoTiles = new System.Windows.Forms.Label();
            this.picPianoTiles = new System.Windows.Forms.PictureBox();
            this.lblCathcGame = new System.Windows.Forms.Label();
            this.pngCatchGame = new System.Windows.Forms.PictureBox();
            this.lblFlappyBird = new System.Windows.Forms.Label();
            this.picFlappyBird = new System.Windows.Forms.PictureBox();
            this.grbPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPianoTiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pngCatchGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.BackColor = System.Drawing.Color.Transparent;
            this.lblPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPlay.Location = new System.Drawing.Point(185, 146);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(98, 46);
            this.lblPlay.TabIndex = 1;
            this.lblPlay.Text = "Play";
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.BackColor = System.Drawing.Color.Transparent;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCredits.Location = new System.Drawing.Point(171, 199);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(121, 38);
            this.lblCredits.TabIndex = 2;
            this.lblCredits.Text = "Credits";
            this.lblCredits.Click += new System.EventHandler(this.lblCredits_Click);
            // 
            // grbPlay
            // 
            this.grbPlay.BackgroundImage = global::ArcadeValeriaV.Properties.Resources.arcadeBackground;
            this.grbPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbPlay.Controls.Add(this.player1);
            this.grbPlay.Controls.Add(this.lblBack);
            this.grbPlay.Controls.Add(this.lblPianoTiles);
            this.grbPlay.Controls.Add(this.picPianoTiles);
            this.grbPlay.Controls.Add(this.lblCathcGame);
            this.grbPlay.Controls.Add(this.pngCatchGame);
            this.grbPlay.Controls.Add(this.lblFlappyBird);
            this.grbPlay.Controls.Add(this.picFlappyBird);
            this.grbPlay.Location = new System.Drawing.Point(-5, -9);
            this.grbPlay.Name = "grbPlay";
            this.grbPlay.Size = new System.Drawing.Size(591, 572);
            this.grbPlay.TabIndex = 3;
            this.grbPlay.TabStop = false;
            this.grbPlay.Enter += new System.EventHandler(this.grbPlay_Enter);
            // 
            // player1
            // 
            this.player1.Enabled = true;
            this.player1.Location = new System.Drawing.Point(71, 151);
            this.player1.Name = "player1";
            this.player1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player1.OcxState")));
            this.player1.Size = new System.Drawing.Size(75, 23);
            this.player1.TabIndex = 33;
            this.player1.Visible = false;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.Khaki;
            this.lblBack.Location = new System.Drawing.Point(31, 30);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(56, 25);
            this.lblBack.TabIndex = 6;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblPianoTiles
            // 
            this.lblPianoTiles.AutoSize = true;
            this.lblPianoTiles.BackColor = System.Drawing.Color.Transparent;
            this.lblPianoTiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPianoTiles.ForeColor = System.Drawing.Color.Orange;
            this.lblPianoTiles.Location = new System.Drawing.Point(214, 516);
            this.lblPianoTiles.Name = "lblPianoTiles";
            this.lblPianoTiles.Size = new System.Drawing.Size(109, 25);
            this.lblPianoTiles.TabIndex = 5;
            this.lblPianoTiles.Text = "Piano Tiles";
            this.lblPianoTiles.Click += new System.EventHandler(this.lblPianoTiles_Click);
            // 
            // picPianoTiles
            // 
            this.picPianoTiles.BackColor = System.Drawing.Color.Transparent;
            this.picPianoTiles.Image = global::ArcadeValeriaV.Properties.Resources.pinao_tiles;
            this.picPianoTiles.Location = new System.Drawing.Point(234, 397);
            this.picPianoTiles.Name = "picPianoTiles";
            this.picPianoTiles.Size = new System.Drawing.Size(122, 116);
            this.picPianoTiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPianoTiles.TabIndex = 4;
            this.picPianoTiles.TabStop = false;
            this.picPianoTiles.Click += new System.EventHandler(this.picPianoTiles_Click);
            // 
            // lblCathcGame
            // 
            this.lblCathcGame.AutoSize = true;
            this.lblCathcGame.BackColor = System.Drawing.Color.Transparent;
            this.lblCathcGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCathcGame.ForeColor = System.Drawing.Color.Orange;
            this.lblCathcGame.Location = new System.Drawing.Point(190, 334);
            this.lblCathcGame.Name = "lblCathcGame";
            this.lblCathcGame.Size = new System.Drawing.Size(124, 25);
            this.lblCathcGame.TabIndex = 3;
            this.lblCathcGame.Text = "Fruit Catcher";
            this.lblCathcGame.Click += new System.EventHandler(this.lblCathcGame_Click);
            // 
            // pngCatchGame
            // 
            this.pngCatchGame.BackColor = System.Drawing.Color.Transparent;
            this.pngCatchGame.Image = global::ArcadeValeriaV.Properties.Resources.catch3;
            this.pngCatchGame.Location = new System.Drawing.Point(220, 227);
            this.pngCatchGame.Name = "pngCatchGame";
            this.pngCatchGame.Size = new System.Drawing.Size(140, 124);
            this.pngCatchGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pngCatchGame.TabIndex = 2;
            this.pngCatchGame.TabStop = false;
            this.pngCatchGame.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lblFlappyBird
            // 
            this.lblFlappyBird.AutoSize = true;
            this.lblFlappyBird.BackColor = System.Drawing.Color.Transparent;
            this.lblFlappyBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlappyBird.ForeColor = System.Drawing.Color.Orange;
            this.lblFlappyBird.Location = new System.Drawing.Point(191, 161);
            this.lblFlappyBird.Name = "lblFlappyBird";
            this.lblFlappyBird.Size = new System.Drawing.Size(110, 25);
            this.lblFlappyBird.TabIndex = 1;
            this.lblFlappyBird.Text = "Flappy Bird";
            this.lblFlappyBird.Click += new System.EventHandler(this.lblFlappyBird_Click);
            // 
            // picFlappyBird
            // 
            this.picFlappyBird.BackColor = System.Drawing.Color.Transparent;
            this.picFlappyBird.Image = global::ArcadeValeriaV.Properties.Resources.bird1;
            this.picFlappyBird.Location = new System.Drawing.Point(220, 53);
            this.picFlappyBird.Name = "picFlappyBird";
            this.picFlappyBird.Size = new System.Drawing.Size(140, 121);
            this.picFlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlappyBird.TabIndex = 0;
            this.picFlappyBird.TabStop = false;
            this.picFlappyBird.Click += new System.EventHandler(this.picFlappyBird_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArcadeValeriaV.Properties.Resources.arcade2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 560);
            this.Controls.Add(this.grbPlay);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblPlay);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.grbPlay.ResumeLayout(false);
            this.grbPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPianoTiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pngCatchGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.GroupBox grbPlay;
        private System.Windows.Forms.PictureBox picFlappyBird;
        private System.Windows.Forms.PictureBox pngCatchGame;
        private System.Windows.Forms.Label lblFlappyBird;
        private System.Windows.Forms.PictureBox picPianoTiles;
        private System.Windows.Forms.Label lblCathcGame;
        private System.Windows.Forms.Label lblPianoTiles;
        private System.Windows.Forms.Label lblBack;
        private AxWMPLib.AxWindowsMediaPlayer player1;
    }
}
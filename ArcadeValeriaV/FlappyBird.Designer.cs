namespace ArcadeValeriaV
{
    partial class frmFlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlappyBird));
            this.picObst = new System.Windows.Forms.PictureBox();
            this.picObst2 = new System.Windows.Forms.PictureBox();
            this.picObst3 = new System.Windows.Forms.PictureBox();
            this.picCloud1 = new System.Windows.Forms.PictureBox();
            this.picCloud2 = new System.Windows.Forms.PictureBox();
            this.picBird = new System.Windows.Forms.PictureBox();
            this.picCoin = new System.Windows.Forms.PictureBox();
            this.lblCoins = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.picGround = new System.Windows.Forms.PictureBox();
            this.picLose = new System.Windows.Forms.PictureBox();
            this.btnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picObst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObst2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObst3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLose)).BeginInit();
            this.SuspendLayout();
            // 
            // picObst
            // 
            this.picObst.BackColor = System.Drawing.Color.Transparent;
            this.picObst.Image = ((System.Drawing.Image)(resources.GetObject("picObst.Image")));
            this.picObst.Location = new System.Drawing.Point(42, 297);
            this.picObst.Name = "picObst";
            this.picObst.Size = new System.Drawing.Size(122, 246);
            this.picObst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picObst.TabIndex = 5;
            this.picObst.TabStop = false;
            this.picObst.Tag = "obst";
            // 
            // picObst2
            // 
            this.picObst2.BackColor = System.Drawing.Color.Transparent;
            this.picObst2.Image = ((System.Drawing.Image)(resources.GetObject("picObst2.Image")));
            this.picObst2.Location = new System.Drawing.Point(206, 235);
            this.picObst2.Name = "picObst2";
            this.picObst2.Size = new System.Drawing.Size(117, 244);
            this.picObst2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picObst2.TabIndex = 6;
            this.picObst2.TabStop = false;
            this.picObst2.Tag = "obst";
            // 
            // picObst3
            // 
            this.picObst3.BackColor = System.Drawing.Color.Transparent;
            this.picObst3.Image = ((System.Drawing.Image)(resources.GetObject("picObst3.Image")));
            this.picObst3.Location = new System.Drawing.Point(372, 316);
            this.picObst3.Name = "picObst3";
            this.picObst3.Size = new System.Drawing.Size(110, 240);
            this.picObst3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picObst3.TabIndex = 7;
            this.picObst3.TabStop = false;
            this.picObst3.Tag = "obst";
            this.picObst3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picCloud1
            // 
            this.picCloud1.BackColor = System.Drawing.Color.Transparent;
            this.picCloud1.Image = ((System.Drawing.Image)(resources.GetObject("picCloud1.Image")));
            this.picCloud1.Location = new System.Drawing.Point(31, 23);
            this.picCloud1.Name = "picCloud1";
            this.picCloud1.Size = new System.Drawing.Size(133, 93);
            this.picCloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCloud1.TabIndex = 8;
            this.picCloud1.TabStop = false;
            this.picCloud1.Tag = "cloud";
            // 
            // picCloud2
            // 
            this.picCloud2.BackColor = System.Drawing.Color.Transparent;
            this.picCloud2.Image = ((System.Drawing.Image)(resources.GetObject("picCloud2.Image")));
            this.picCloud2.Location = new System.Drawing.Point(372, 85);
            this.picCloud2.Name = "picCloud2";
            this.picCloud2.Size = new System.Drawing.Size(87, 66);
            this.picCloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCloud2.TabIndex = 9;
            this.picCloud2.TabStop = false;
            this.picCloud2.Tag = "cloud";
            // 
            // picBird
            // 
            this.picBird.BackColor = System.Drawing.Color.Transparent;
            this.picBird.Image = ((System.Drawing.Image)(resources.GetObject("picBird.Image")));
            this.picBird.Location = new System.Drawing.Point(12, 185);
            this.picBird.Name = "picBird";
            this.picBird.Size = new System.Drawing.Size(50, 47);
            this.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBird.TabIndex = 10;
            this.picBird.TabStop = false;
            this.picBird.Click += new System.EventHandler(this.bird_Click);
            // 
            // picCoin
            // 
            this.picCoin.BackColor = System.Drawing.Color.Transparent;
            this.picCoin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCoin.BackgroundImage")));
            this.picCoin.Image = ((System.Drawing.Image)(resources.GetObject("picCoin.Image")));
            this.picCoin.Location = new System.Drawing.Point(372, 225);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(36, 35);
            this.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoin.TabIndex = 11;
            this.picCoin.TabStop = false;
            this.picCoin.Tag = "cloud";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.BackColor = System.Drawing.Color.Transparent;
            this.lblCoins.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoins.Location = new System.Drawing.Point(302, 23);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(59, 17);
            this.lblCoins.TabIndex = 12;
            this.lblCoins.Text = "Coins: ";
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 20;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // picGround
            // 
            this.picGround.BackColor = System.Drawing.Color.DimGray;
            this.picGround.Location = new System.Drawing.Point(-4, 446);
            this.picGround.Name = "picGround";
            this.picGround.Size = new System.Drawing.Size(428, 44);
            this.picGround.TabIndex = 13;
            this.picGround.TabStop = false;
            // 
            // picLose
            // 
            this.picLose.BackColor = System.Drawing.Color.Transparent;
            this.picLose.Image = ((System.Drawing.Image)(resources.GetObject("picLose.Image")));
            this.picLose.Location = new System.Drawing.Point(66, 146);
            this.picLose.Name = "picLose";
            this.picLose.Size = new System.Drawing.Size(273, 79);
            this.picLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLose.TabIndex = 14;
            this.picLose.TabStop = false;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Maroon;
            this.btnMain.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMain.Location = new System.Drawing.Point(175, 225);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(85, 35);
            this.btnMain.TabIndex = 15;
            this.btnMain.Text = "MainMenu";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // frmFlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 480);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.picLose);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.picCoin);
            this.Controls.Add(this.picBird);
            this.Controls.Add(this.picCloud2);
            this.Controls.Add(this.picCloud1);
            this.Controls.Add(this.picObst3);
            this.Controls.Add(this.picObst2);
            this.Controls.Add(this.picObst);
            this.Name = "frmFlappyBird";
            this.Text = "FlappyBird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picObst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObst2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObst3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picObst;
        private System.Windows.Forms.PictureBox picObst2;
        private System.Windows.Forms.PictureBox picObst3;
        private System.Windows.Forms.PictureBox picCloud1;
        private System.Windows.Forms.PictureBox picCloud2;
        private System.Windows.Forms.PictureBox picBird;
        private System.Windows.Forms.PictureBox picCoin;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.PictureBox picGround;
        private System.Windows.Forms.PictureBox picLose;
        private System.Windows.Forms.Button btnMain;
    }
}
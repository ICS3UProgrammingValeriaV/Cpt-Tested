namespace ArcadeValeriaV
{
    partial class frmCatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatch));
            this.picDesk = new System.Windows.Forms.PictureBox();
            this.picCoin = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMissed = new System.Windows.Forms.Label();
            this.picLose = new System.Windows.Forms.PictureBox();
            this.picJunk = new System.Windows.Forms.PictureBox();
            this.picHealth2 = new System.Windows.Forms.PictureBox();
            this.picHealth1 = new System.Windows.Forms.PictureBox();
            this.picBascket = new System.Windows.Forms.PictureBox();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.btnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDesk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJunk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHealth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHealth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBascket)).BeginInit();
            this.SuspendLayout();
            // 
            // picDesk
            // 
            this.picDesk.BackColor = System.Drawing.Color.Transparent;
            this.picDesk.Image = global::ArcadeValeriaV.Properties.Resources.table;
            this.picDesk.Location = new System.Drawing.Point(-2, 332);
            this.picDesk.Name = "picDesk";
            this.picDesk.Size = new System.Drawing.Size(408, 210);
            this.picDesk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDesk.TabIndex = 1;
            this.picDesk.TabStop = false;
            // 
            // picCoin
            // 
            this.picCoin.BackColor = System.Drawing.Color.Transparent;
            this.picCoin.Image = global::ArcadeValeriaV.Properties.Resources.coin1;
            this.picCoin.Location = new System.Drawing.Point(251, 50);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(39, 41);
            this.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoin.TabIndex = 26;
            this.picCoin.TabStop = false;
            this.picCoin.Tag = "coin";
            this.picCoin.Click += new System.EventHandler(this.picCoin_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore.Location = new System.Drawing.Point(321, 10);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(59, 17);
            this.lblScore.TabIndex = 25;
            this.lblScore.Text = "Coins: ";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // lblMissed
            // 
            this.lblMissed.AutoSize = true;
            this.lblMissed.BackColor = System.Drawing.Color.Transparent;
            this.lblMissed.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMissed.Location = new System.Drawing.Point(11, 10);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(59, 17);
            this.lblMissed.TabIndex = 24;
            this.lblMissed.Text = "Coins: ";
            this.lblMissed.Click += new System.EventHandler(this.lblMissed_Click);
            // 
            // picLose
            // 
            this.picLose.BackColor = System.Drawing.Color.Transparent;
            this.picLose.Image = ((System.Drawing.Image)(resources.GetObject("picLose.Image")));
            this.picLose.Location = new System.Drawing.Point(64, 149);
            this.picLose.Name = "picLose";
            this.picLose.Size = new System.Drawing.Size(273, 79);
            this.picLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLose.TabIndex = 23;
            this.picLose.TabStop = false;
            this.picLose.Click += new System.EventHandler(this.picLose_Click);
            // 
            // picJunk
            // 
            this.picJunk.BackColor = System.Drawing.Color.Transparent;
            this.picJunk.Image = global::ArcadeValeriaV.Properties.Resources.burger;
            this.picJunk.Location = new System.Drawing.Point(140, 50);
            this.picJunk.Name = "picJunk";
            this.picJunk.Size = new System.Drawing.Size(59, 51);
            this.picJunk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJunk.TabIndex = 22;
            this.picJunk.TabStop = false;
            this.picJunk.Tag = "popcorn";
            this.picJunk.Click += new System.EventHandler(this.picJunk_Click);
            // 
            // picHealth2
            // 
            this.picHealth2.BackColor = System.Drawing.Color.Transparent;
            this.picHealth2.Image = global::ArcadeValeriaV.Properties.Resources.appl;
            this.picHealth2.Location = new System.Drawing.Point(333, 50);
            this.picHealth2.Name = "picHealth2";
            this.picHealth2.Size = new System.Drawing.Size(59, 51);
            this.picHealth2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHealth2.TabIndex = 21;
            this.picHealth2.TabStop = false;
            this.picHealth2.Tag = "apple";
            this.picHealth2.Click += new System.EventHandler(this.picHealth2_Click);
            // 
            // picHealth1
            // 
            this.picHealth1.BackColor = System.Drawing.Color.Transparent;
            this.picHealth1.Image = global::ArcadeValeriaV.Properties.Resources.appl;
            this.picHealth1.Location = new System.Drawing.Point(27, 50);
            this.picHealth1.Name = "picHealth1";
            this.picHealth1.Size = new System.Drawing.Size(59, 51);
            this.picHealth1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHealth1.TabIndex = 20;
            this.picHealth1.TabStop = false;
            this.picHealth1.Tag = "apple";
            this.picHealth1.Click += new System.EventHandler(this.picHealth1_Click);
            // 
            // picBascket
            // 
            this.picBascket.BackColor = System.Drawing.Color.Transparent;
            this.picBascket.Image = global::ArcadeValeriaV.Properties.Resources.basket;
            this.picBascket.Location = new System.Drawing.Point(127, 262);
            this.picBascket.Name = "picBascket";
            this.picBascket.Size = new System.Drawing.Size(144, 71);
            this.picBascket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBascket.TabIndex = 19;
            this.picBascket.TabStop = false;
            this.picBascket.Click += new System.EventHandler(this.picBascket_Click);
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 20;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Maroon;
            this.btnMain.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMain.Location = new System.Drawing.Point(160, 223);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(85, 35);
            this.btnMain.TabIndex = 27;
            this.btnMain.Text = "MainMenu";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // frmCatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArcadeValeriaV.Properties.Resources.park;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 480);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.picCoin);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblMissed);
            this.Controls.Add(this.picLose);
            this.Controls.Add(this.picJunk);
            this.Controls.Add(this.picHealth2);
            this.Controls.Add(this.picHealth1);
            this.Controls.Add(this.picBascket);
            this.Controls.Add(this.picDesk);
            this.Name = "frmCatch";
            this.Text = "Catch";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.picDesk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJunk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHealth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHealth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBascket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDesk;
        private System.Windows.Forms.PictureBox picCoin;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMissed;
        private System.Windows.Forms.PictureBox picLose;
        private System.Windows.Forms.PictureBox picJunk;
        private System.Windows.Forms.PictureBox picHealth2;
        private System.Windows.Forms.PictureBox picHealth1;
        private System.Windows.Forms.PictureBox picBascket;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Button btnMain;
    }
}
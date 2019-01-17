namespace ArcadeValeriaV
{
    partial class Piano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Piano));
            this.tmrFirstMove = new System.Windows.Forms.Timer(this.components);
            this.tmrSecondMove = new System.Windows.Forms.Timer(this.components);
            this.tmrThirdMove = new System.Windows.Forms.Timer(this.components);
            this.tmrFourthMove = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.grbLose = new System.Windows.Forms.GroupBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.picTile4 = new System.Windows.Forms.PictureBox();
            this.picTile3 = new System.Windows.Forms.PictureBox();
            this.picTile2 = new System.Windows.Forms.PictureBox();
            this.picTile1 = new System.Windows.Forms.PictureBox();
            this.player3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.grbLose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTile4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTile3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrFirstMove
            // 
            this.tmrFirstMove.Tick += new System.EventHandler(this.tmrFirstMove_Tick_1);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore.Location = new System.Drawing.Point(334, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(59, 17);
            this.lblScore.TabIndex = 31;
            this.lblScore.Text = "Coins: ";
            // 
            // grbLose
            // 
            this.grbLose.BackgroundImage = global::ArcadeValeriaV.Properties.Resources.GameOver;
            this.grbLose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbLose.Controls.Add(this.player3);
            this.grbLose.Controls.Add(this.btnMain);
            this.grbLose.Location = new System.Drawing.Point(1, -3);
            this.grbLose.Name = "grbLose";
            this.grbLose.Size = new System.Drawing.Size(403, 484);
            this.grbLose.TabIndex = 32;
            this.grbLose.TabStop = false;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Maroon;
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMain.Location = new System.Drawing.Point(144, 256);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(85, 35);
            this.btnMain.TabIndex = 31;
            this.btnMain.Text = "MainMenu";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click_2);
            // 
            // picTile4
            // 
            this.picTile4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picTile4.Image = global::ArcadeValeriaV.Properties.Resources.tile4;
            this.picTile4.Location = new System.Drawing.Point(0, -38);
            this.picTile4.Name = "picTile4";
            this.picTile4.Size = new System.Drawing.Size(101, 139);
            this.picTile4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTile4.TabIndex = 7;
            this.picTile4.TabStop = false;
            this.picTile4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // picTile3
            // 
            this.picTile3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picTile3.Image = global::ArcadeValeriaV.Properties.Resources.tile3;
            this.picTile3.Location = new System.Drawing.Point(101, 101);
            this.picTile3.Name = "picTile3";
            this.picTile3.Size = new System.Drawing.Size(101, 139);
            this.picTile3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTile3.TabIndex = 6;
            this.picTile3.TabStop = false;
            this.picTile3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picTile2
            // 
            this.picTile2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picTile2.Image = global::ArcadeValeriaV.Properties.Resources.tile2;
            this.picTile2.Location = new System.Drawing.Point(202, 240);
            this.picTile2.Name = "picTile2";
            this.picTile2.Size = new System.Drawing.Size(101, 139);
            this.picTile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTile2.TabIndex = 5;
            this.picTile2.TabStop = false;
            this.picTile2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picTile1
            // 
            this.picTile1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picTile1.Image = global::ArcadeValeriaV.Properties.Resources.tile1;
            this.picTile1.Location = new System.Drawing.Point(303, 379);
            this.picTile1.Name = "picTile1";
            this.picTile1.Size = new System.Drawing.Size(101, 139);
            this.picTile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTile1.TabIndex = 4;
            this.picTile1.TabStop = false;
            this.picTile1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // player3
            // 
            this.player3.Enabled = true;
            this.player3.Location = new System.Drawing.Point(164, 231);
            this.player3.Name = "player3";
            this.player3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player3.OcxState")));
            this.player3.Size = new System.Drawing.Size(75, 23);
            this.player3.TabIndex = 38;
            this.player3.Visible = false;
            this.player3.Enter += new System.EventHandler(this.player3_Enter);
            // 
            // Piano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(405, 480);
            this.Controls.Add(this.grbLose);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picTile4);
            this.Controls.Add(this.picTile3);
            this.Controls.Add(this.picTile2);
            this.Controls.Add(this.picTile1);
            this.Name = "Piano";
            this.Text = "Piano";
            this.Load += new System.EventHandler(this.Piano_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickForm);
            this.grbLose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTile4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTile3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTile4;
        private System.Windows.Forms.PictureBox picTile3;
        private System.Windows.Forms.PictureBox picTile2;
        private System.Windows.Forms.PictureBox picTile1;
        private System.Windows.Forms.Timer tmrFirstMove;
        private System.Windows.Forms.Timer tmrSecondMove;
        private System.Windows.Forms.Timer tmrThirdMove;
        private System.Windows.Forms.Timer tmrFourthMove;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.GroupBox grbLose;
        private System.Windows.Forms.Button btnMain;
        private AxWMPLib.AxWindowsMediaPlayer player3;
    }
}
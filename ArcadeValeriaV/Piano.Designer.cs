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
            this.picTile4 = new System.Windows.Forms.PictureBox();
            this.picTile3 = new System.Windows.Forms.PictureBox();
            this.picTile2 = new System.Windows.Forms.PictureBox();
            this.picTile1 = new System.Windows.Forms.PictureBox();
            this.picLose = new System.Windows.Forms.PictureBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.picCoin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTile4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTile3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrFirstMove
            // 
            this.tmrFirstMove.Tick += new System.EventHandler(this.tmrFirstMove_Tick_1);
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
            // picLose
            // 
            this.picLose.BackColor = System.Drawing.Color.Transparent;
            this.picLose.Image = ((System.Drawing.Image)(resources.GetObject("picLose.Image")));
            this.picLose.Location = new System.Drawing.Point(66, 201);
            this.picLose.Name = "picLose";
            this.picLose.Size = new System.Drawing.Size(273, 79);
            this.picLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLose.TabIndex = 24;
            this.picLose.TabStop = false;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Maroon;
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMain.Location = new System.Drawing.Point(163, 280);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(85, 35);
            this.btnMain.TabIndex = 28;
            this.btnMain.Text = "MainMenu";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // picCoin
            // 
            this.picCoin.BackColor = System.Drawing.Color.Transparent;
            this.picCoin.Image = global::ArcadeValeriaV.Properties.Resources.coin1;
            this.picCoin.Location = new System.Drawing.Point(209, 2);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(39, 41);
            this.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoin.TabIndex = 29;
            this.picCoin.TabStop = false;
            this.picCoin.Tag = "coin";
            this.picCoin.Click += new System.EventHandler(this.picCoin_Click);
            // 
            // Piano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(405, 480);
            this.Controls.Add(this.picCoin);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.picLose);
            this.Controls.Add(this.picTile4);
            this.Controls.Add(this.picTile3);
            this.Controls.Add(this.picTile2);
            this.Controls.Add(this.picTile1);
            this.Name = "Piano";
            this.Text = "Piano";
            this.Load += new System.EventHandler(this.Piano_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickForm);
            ((System.ComponentModel.ISupportInitialize)(this.picTile4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTile3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox picLose;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.PictureBox picCoin;
    }
}
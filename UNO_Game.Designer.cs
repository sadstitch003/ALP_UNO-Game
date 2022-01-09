namespace ALP_UNO_Game
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pnl_MainMenu = new System.Windows.Forms.Panel();
            this.PlayButton = new System.Windows.Forms.CheckBox();
            this.pic_UnoPicture = new System.Windows.Forms.PictureBox();
            this.pic_MenuPic = new System.Windows.Forms.PictureBox();
            this.btn_RulesButton = new System.Windows.Forms.PictureBox();
            this.btn_CreditsButton = new System.Windows.Forms.PictureBox();
            this.btn_StartButton = new System.Windows.Forms.PictureBox();
            this.pnl_GamePanel = new System.Windows.Forms.Panel();
            this.lbl_CardDeckCount = new System.Windows.Forms.Label();
            this.pic_CardDeck = new System.Windows.Forms.PictureBox();
            this.pic_TheCard = new System.Windows.Forms.PictureBox();
            this.pnl_EnemyCard1 = new System.Windows.Forms.Panel();
            this.pnl_PlayerCard = new System.Windows.Forms.Panel();
            this.pnl_GameOver = new System.Windows.Forms.Panel();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_Winner = new System.Windows.Forms.Label();
            this.btn_PlayAgain = new System.Windows.Forms.PictureBox();
            this.pic_GameOver = new System.Windows.Forms.PictureBox();
            this.pnl_MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UnoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MenuPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RulesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CreditsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_StartButton)).BeginInit();
            this.pnl_GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CardDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TheCard)).BeginInit();
            this.pnl_GameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PlayAgain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_MainMenu
            // 
            this.pnl_MainMenu.BackgroundImage = global::ALP_UNO_Game.Properties.Resources.background;
            this.pnl_MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_MainMenu.Controls.Add(this.PlayButton);
            this.pnl_MainMenu.Controls.Add(this.pic_UnoPicture);
            this.pnl_MainMenu.Controls.Add(this.pic_MenuPic);
            this.pnl_MainMenu.Controls.Add(this.btn_RulesButton);
            this.pnl_MainMenu.Controls.Add(this.btn_CreditsButton);
            this.pnl_MainMenu.Controls.Add(this.btn_StartButton);
            this.pnl_MainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnl_MainMenu.Name = "pnl_MainMenu";
            this.pnl_MainMenu.Padding = new System.Windows.Forms.Padding(0, 20, 10, 0);
            this.pnl_MainMenu.Size = new System.Drawing.Size(782, 188);
            this.pnl_MainMenu.TabIndex = 0;
            // 
            // PlayButton
            // 
            this.PlayButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.PlayButton.BackgroundImage = global::ALP_UNO_Game.Properties.Resources.music_pic1;
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayButton.Location = new System.Drawing.Point(12, 12);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(40, 40);
            this.PlayButton.TabIndex = 6;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pic_UnoPicture
            // 
            this.pic_UnoPicture.BackColor = System.Drawing.Color.Transparent;
            this.pic_UnoPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_UnoPicture.Image = global::ALP_UNO_Game.Properties.Resources.uno_logo;
            this.pic_UnoPicture.Location = new System.Drawing.Point(406, 20);
            this.pic_UnoPicture.Name = "pic_UnoPicture";
            this.pic_UnoPicture.Size = new System.Drawing.Size(366, 240);
            this.pic_UnoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_UnoPicture.TabIndex = 4;
            this.pic_UnoPicture.TabStop = false;
            // 
            // pic_MenuPic
            // 
            this.pic_MenuPic.BackColor = System.Drawing.Color.Transparent;
            this.pic_MenuPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_MenuPic.Image = ((System.Drawing.Image)(resources.GetObject("pic_MenuPic.Image")));
            this.pic_MenuPic.Location = new System.Drawing.Point(0, 20);
            this.pic_MenuPic.Name = "pic_MenuPic";
            this.pic_MenuPic.Size = new System.Drawing.Size(406, 168);
            this.pic_MenuPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_MenuPic.TabIndex = 3;
            this.pic_MenuPic.TabStop = false;
            // 
            // btn_RulesButton
            // 
            this.btn_RulesButton.BackColor = System.Drawing.Color.Transparent;
            this.btn_RulesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RulesButton.Image = global::ALP_UNO_Game.Properties.Resources.rules_button;
            this.btn_RulesButton.InitialImage = global::ALP_UNO_Game.Properties.Resources.play_button;
            this.btn_RulesButton.Location = new System.Drawing.Point(529, 325);
            this.btn_RulesButton.Name = "btn_RulesButton";
            this.btn_RulesButton.Size = new System.Drawing.Size(145, 50);
            this.btn_RulesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_RulesButton.TabIndex = 2;
            this.btn_RulesButton.TabStop = false;
            // 
            // btn_CreditsButton
            // 
            this.btn_CreditsButton.BackColor = System.Drawing.Color.Transparent;
            this.btn_CreditsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreditsButton.Image = global::ALP_UNO_Game.Properties.Resources.credits_button;
            this.btn_CreditsButton.InitialImage = global::ALP_UNO_Game.Properties.Resources.play_button;
            this.btn_CreditsButton.Location = new System.Drawing.Point(529, 384);
            this.btn_CreditsButton.Name = "btn_CreditsButton";
            this.btn_CreditsButton.Size = new System.Drawing.Size(145, 50);
            this.btn_CreditsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_CreditsButton.TabIndex = 1;
            this.btn_CreditsButton.TabStop = false;
            // 
            // btn_StartButton
            // 
            this.btn_StartButton.BackColor = System.Drawing.Color.Transparent;
            this.btn_StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StartButton.Image = global::ALP_UNO_Game.Properties.Resources.play_button;
            this.btn_StartButton.InitialImage = global::ALP_UNO_Game.Properties.Resources.play_button;
            this.btn_StartButton.Location = new System.Drawing.Point(529, 269);
            this.btn_StartButton.Name = "btn_StartButton";
            this.btn_StartButton.Size = new System.Drawing.Size(145, 50);
            this.btn_StartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_StartButton.TabIndex = 0;
            this.btn_StartButton.TabStop = false;
            this.btn_StartButton.Click += new System.EventHandler(this.btn_StartButton_Click);
            this.btn_StartButton.MouseLeave += new System.EventHandler(this.btn_StartButton_MouseLeave);
            this.btn_StartButton.MouseHover += new System.EventHandler(this.btn_StartButton_MouseHover);
            // 
            // pnl_GamePanel
            // 
            this.pnl_GamePanel.BackgroundImage = global::ALP_UNO_Game.Properties.Resources.background;
            this.pnl_GamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_GamePanel.Controls.Add(this.lbl_CardDeckCount);
            this.pnl_GamePanel.Controls.Add(this.pic_CardDeck);
            this.pnl_GamePanel.Controls.Add(this.pic_TheCard);
            this.pnl_GamePanel.Controls.Add(this.pnl_EnemyCard1);
            this.pnl_GamePanel.Controls.Add(this.pnl_PlayerCard);
            this.pnl_GamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_GamePanel.Location = new System.Drawing.Point(0, 188);
            this.pnl_GamePanel.Name = "pnl_GamePanel";
            this.pnl_GamePanel.Size = new System.Drawing.Size(782, 221);
            this.pnl_GamePanel.TabIndex = 1;
            this.pnl_GamePanel.Visible = false;
            // 
            // lbl_CardDeckCount
            // 
            this.lbl_CardDeckCount.AutoSize = true;
            this.lbl_CardDeckCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CardDeckCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CardDeckCount.Location = new System.Drawing.Point(250, 256);
            this.lbl_CardDeckCount.Name = "lbl_CardDeckCount";
            this.lbl_CardDeckCount.Size = new System.Drawing.Size(52, 16);
            this.lbl_CardDeckCount.TabIndex = 4;
            this.lbl_CardDeckCount.Text = "Card : ";
            this.lbl_CardDeckCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_CardDeck
            // 
            this.pic_CardDeck.BackColor = System.Drawing.Color.Transparent;
            this.pic_CardDeck.Image = global::ALP_UNO_Game.Properties.Resources.unoCard;
            this.pic_CardDeck.Location = new System.Drawing.Point(222, 124);
            this.pic_CardDeck.Name = "pic_CardDeck";
            this.pic_CardDeck.Size = new System.Drawing.Size(100, 129);
            this.pic_CardDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_CardDeck.TabIndex = 3;
            this.pic_CardDeck.TabStop = false;
            this.pic_CardDeck.Click += new System.EventHandler(this.pic_CardDeck_Click);
            this.pic_CardDeck.MouseLeave += new System.EventHandler(this.pic_CardDeck_MouseLeave);
            this.pic_CardDeck.MouseHover += new System.EventHandler(this.pic_CardDeck_MouseHover);
            // 
            // pic_TheCard
            // 
            this.pic_TheCard.BackColor = System.Drawing.Color.Transparent;
            this.pic_TheCard.Location = new System.Drawing.Point(471, 124);
            this.pic_TheCard.Name = "pic_TheCard";
            this.pic_TheCard.Size = new System.Drawing.Size(100, 129);
            this.pic_TheCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_TheCard.TabIndex = 2;
            this.pic_TheCard.TabStop = false;
            // 
            // pnl_EnemyCard1
            // 
            this.pnl_EnemyCard1.BackColor = System.Drawing.Color.Transparent;
            this.pnl_EnemyCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_EnemyCard1.Location = new System.Drawing.Point(0, 0);
            this.pnl_EnemyCard1.Name = "pnl_EnemyCard1";
            this.pnl_EnemyCard1.Size = new System.Drawing.Size(782, 102);
            this.pnl_EnemyCard1.TabIndex = 1;
            // 
            // pnl_PlayerCard
            // 
            this.pnl_PlayerCard.BackColor = System.Drawing.Color.Transparent;
            this.pnl_PlayerCard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_PlayerCard.Location = new System.Drawing.Point(0, 46);
            this.pnl_PlayerCard.Name = "pnl_PlayerCard";
            this.pnl_PlayerCard.Size = new System.Drawing.Size(782, 175);
            this.pnl_PlayerCard.TabIndex = 0;
            // 
            // pnl_GameOver
            // 
            this.pnl_GameOver.BackgroundImage = global::ALP_UNO_Game.Properties.Resources.background;
            this.pnl_GameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_GameOver.Controls.Add(this.lbl_Score);
            this.pnl_GameOver.Controls.Add(this.lbl_Winner);
            this.pnl_GameOver.Controls.Add(this.btn_PlayAgain);
            this.pnl_GameOver.Controls.Add(this.pic_GameOver);
            this.pnl_GameOver.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_GameOver.Location = new System.Drawing.Point(0, 409);
            this.pnl_GameOver.Name = "pnl_GameOver";
            this.pnl_GameOver.Size = new System.Drawing.Size(782, 450);
            this.pnl_GameOver.TabIndex = 2;
            this.pnl_GameOver.Visible = false;
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(375, 297);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(60, 16);
            this.lbl_Score.TabIndex = 3;
            this.lbl_Score.Text = "Score : ";
            // 
            // lbl_Winner
            // 
            this.lbl_Winner.AutoSize = true;
            this.lbl_Winner.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Winner.Location = new System.Drawing.Point(375, 271);
            this.lbl_Winner.Name = "lbl_Winner";
            this.lbl_Winner.Size = new System.Drawing.Size(67, 16);
            this.lbl_Winner.TabIndex = 2;
            this.lbl_Winner.Text = "Winner : ";
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlayAgain.BackgroundImage = global::ALP_UNO_Game.Properties.Resources.play_button;
            this.btn_PlayAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PlayAgain.Location = new System.Drawing.Point(323, 379);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(160, 50);
            this.btn_PlayAgain.TabIndex = 1;
            this.btn_PlayAgain.TabStop = false;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click);
            // 
            // pic_GameOver
            // 
            this.pic_GameOver.BackColor = System.Drawing.Color.Transparent;
            this.pic_GameOver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_GameOver.Image = global::ALP_UNO_Game.Properties.Resources.game_over;
            this.pic_GameOver.Location = new System.Drawing.Point(0, 0);
            this.pic_GameOver.Name = "pic_GameOver";
            this.pic_GameOver.Size = new System.Drawing.Size(782, 450);
            this.pic_GameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_GameOver.TabIndex = 0;
            this.pic_GameOver.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(782, 1008);
            this.Controls.Add(this.pnl_GameOver);
            this.Controls.Add(this.pnl_GamePanel);
            this.Controls.Add(this.pnl_MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "UNO Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.SizeChanged += new System.EventHandler(this.Game_SizeChanged);
            this.pnl_MainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_UnoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MenuPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RulesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CreditsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_StartButton)).EndInit();
            this.pnl_GamePanel.ResumeLayout(false);
            this.pnl_GamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CardDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TheCard)).EndInit();
            this.pnl_GameOver.ResumeLayout(false);
            this.pnl_GameOver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PlayAgain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GameOver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_MainMenu;
        private System.Windows.Forms.PictureBox btn_RulesButton;
        private System.Windows.Forms.PictureBox btn_CreditsButton;
        private System.Windows.Forms.PictureBox btn_StartButton;
        private System.Windows.Forms.PictureBox pic_MenuPic;
        private System.Windows.Forms.PictureBox pic_UnoPicture;
        private System.Windows.Forms.Panel pnl_EnemyCard1;
        private System.Windows.Forms.Panel pnl_PlayerCard;
        private System.Windows.Forms.PictureBox pic_TheCard;
        private System.Windows.Forms.PictureBox pic_CardDeck;
        private System.Windows.Forms.Label lbl_CardDeckCount;
        private System.Windows.Forms.Panel pnl_GamePanel;
        private System.Windows.Forms.CheckBox PlayButton;
        private System.Windows.Forms.Panel pnl_GameOver;
        private System.Windows.Forms.PictureBox pic_GameOver;
        private System.Windows.Forms.PictureBox btn_PlayAgain;
        private System.Windows.Forms.Label lbl_Winner;
        private System.Windows.Forms.Label lbl_Score;
    }
}


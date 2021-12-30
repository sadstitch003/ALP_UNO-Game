namespace ALP_UNO_Game
{
    partial class playCard
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
            this.pic_cardPic = new System.Windows.Forms.PictureBox();
            this.lbl_Text = new System.Windows.Forms.Label();
            this.btn_YesButton = new System.Windows.Forms.Button();
            this.btn_NoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cardPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_cardPic
            // 
            this.pic_cardPic.BackColor = System.Drawing.Color.Transparent;
            this.pic_cardPic.Image = global::ALP_UNO_Game.Properties.Resources.unoCard;
            this.pic_cardPic.Location = new System.Drawing.Point(30, 29);
            this.pic_cardPic.Name = "pic_cardPic";
            this.pic_cardPic.Size = new System.Drawing.Size(90, 114);
            this.pic_cardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_cardPic.TabIndex = 0;
            this.pic_cardPic.TabStop = false;
            // 
            // lbl_Text
            // 
            this.lbl_Text.AutoSize = true;
            this.lbl_Text.Location = new System.Drawing.Point(155, 57);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(184, 16);
            this.lbl_Text.TabIndex = 1;
            this.lbl_Text.Text = "Do you want to play the card ?";
            // 
            // btn_YesButton
            // 
            this.btn_YesButton.Location = new System.Drawing.Point(158, 89);
            this.btn_YesButton.Name = "btn_YesButton";
            this.btn_YesButton.Size = new System.Drawing.Size(75, 23);
            this.btn_YesButton.TabIndex = 2;
            this.btn_YesButton.Text = "Yes";
            this.btn_YesButton.UseVisualStyleBackColor = true;
            this.btn_YesButton.Click += new System.EventHandler(this.btn_YesButton_Click);
            // 
            // btn_NoButton
            // 
            this.btn_NoButton.Location = new System.Drawing.Point(264, 89);
            this.btn_NoButton.Name = "btn_NoButton";
            this.btn_NoButton.Size = new System.Drawing.Size(75, 23);
            this.btn_NoButton.TabIndex = 3;
            this.btn_NoButton.Text = "No";
            this.btn_NoButton.UseVisualStyleBackColor = true;
            this.btn_NoButton.Click += new System.EventHandler(this.btn_NoButton_Click);
            // 
            // playCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 168);
            this.Controls.Add(this.btn_NoButton);
            this.Controls.Add(this.btn_YesButton);
            this.Controls.Add(this.lbl_Text);
            this.Controls.Add(this.pic_cardPic);
            this.MaximumSize = new System.Drawing.Size(400, 215);
            this.MinimumSize = new System.Drawing.Size(400, 215);
            this.Name = "playCard";
            this.Text = "Play Card";
            ((System.ComponentModel.ISupportInitialize)(this.pic_cardPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_cardPic;
        private System.Windows.Forms.Label lbl_Text;
        private System.Windows.Forms.Button btn_YesButton;
        private System.Windows.Forms.Button btn_NoButton;
    }
}
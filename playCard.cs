using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_UNO_Game
{
    public partial class playCard : Form
    {
        public playCard(string cardName)
        {
            InitializeComponent();
            pic_cardPic.Image = (Image)Properties.Resources.ResourceManager.GetObject(cardName);
        }

        private bool yesButton = false;

        public bool buttonClicked
        {
            get { return yesButton; }
        }
        private void btn_YesButton_Click(object sender, EventArgs e)
        {
            yesButton = true;
            this.Close();
        }

        private void btn_NoButton_Click(object sender, EventArgs e)
        {
            yesButton = false;
            this.Close();
        }
    }
}

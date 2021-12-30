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
    public partial class colorPicker : Form
    {
        public colorPicker()
        {
            InitializeComponent();
        }

        public static string warna { get; set; }
        
        private void BlueButton_Click(object sender, EventArgs e)
        {
            warna = "blue";
            this.Close();
            MessageBox.Show("The Color has been changed to Blue!!");
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            warna = "yellow";
            this.Close();
            MessageBox.Show("The Color has been changed to Yellow!!");
        }

        private void GreenButton_Click(object sender, EventArgs e) 
        {
            warna = "green";
            this.Close();
            MessageBox.Show("The Color has been changed to Green!!");
        }

        private void button1_Click(object sender, EventArgs e) //merah
        {
            warna = "red";
            this.Close();
            MessageBox.Show("The Color has been changed to Red!!");
        }
    }
}

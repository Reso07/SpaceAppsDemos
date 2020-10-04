using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NASA_Space_Apps_Challenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_airquality_Click(object sender, EventArgs e)
        {

        }
        private void Air_Quality_Index_Scroll(object sender, EventArgs e
)
        {
            lbl_indexmagnitute.Text = Air_Quality_Index.Value.ToString();
            if(Air_Quality_Index.Value <=50)
            {
                lbl_indexmagnitute.ForeColor = Color.Green;
                pb_rgyLung.Image = imageList_LungHealthScale.Images[0];
            }
            else if(Air_Quality_Index.Value <= 100)
            {
                lbl_indexmagnitute.ForeColor = Color.Yellow;
                pb_rgyLung.Image = imageList_LungHealthScale.Images[1];
            }
            else if (Air_Quality_Index.Value <= 150)
            {
                lbl_indexmagnitute.ForeColor = Color.Orange;
                pb_rgyLung.Image = imageList_LungHealthScale.Images[1];
            }
            else if (Air_Quality_Index.Value <= 200)
            {
                lbl_indexmagnitute.ForeColor = Color.Red;
                pb_rgyLung.Image = imageList_LungHealthScale.Images[2];
            }
            else if (Air_Quality_Index.Value <= 300)
            {
                lbl_indexmagnitute.ForeColor = Color.Purple;
                pb_rgyLung.Image = imageList_LungHealthScale.Images[2];

            }
            else
            {
                lbl_indexmagnitute.ForeColor = Color.Brown;
                pb_rgyLung.Image = imageList_LungHealthScale.Images[3];
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void redLung_Click(object sender, EventArgs e)
        {

        }
    }
}

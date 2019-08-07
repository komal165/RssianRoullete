using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssianRoullete
{
    public partial class Russiangungame : Form
    {
        public Russiangungame()
        {

            InitializeComponent();
        }
        Roulleteclass RoulleteOBJ = new Roulleteclass();
        Random spin = new Random();
        private void gunloadbtn_Click(object sender, EventArgs e)
        {
            Spingunbtn.Enabled = true;



            imglooder.Image = RssianRoullete.Properties.Resources.load;

            gunloadbtn.Enabled = false;

        }

        private void Spingunbtn_Click(object sender, EventArgs e)
        {
            RoulleteOBJ.loadguns = spin.Next(1, 6);
            Shootgunbtn.Enabled = true;

            imglooder.Image = RssianRoullete.Properties.Resources.spin;


            Spingunbtn.Enabled = false;
            RoulleteOBJ.Shootaweay = 2;

        }

        private void Shootgunbtn_Click(object sender, EventArgs e)
        {

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(RssianRoullete.Properties.Resources.shoot);
            player.Play();
            int awaybullete = RoulleteOBJ.shootloaded();
            if (awaybullete == 1)
            {
                MessageBox.Show("lost click replay");
                gunloadbtn.Enabled = false;
                Spingunbtn.Enabled = false;
                Shootgunbtn.Enabled = false;
                Shootabtn.Enabled = false;

                imglooder.Image = RssianRoullete.Properties.Resources.spin;



            }
            if (awaybullete == 2)
            {


                RoulleteOBJ.totalbulletsleft = RoulleteOBJ.totalbulletsleft - 1;
                RoulleteOBJ.loadguns = RoulleteOBJ.Spinloadedbullete(RoulleteOBJ.loadguns);
                MessageBox.Show("no shot");
            }

        }

        private void Shootabtn_Click(object sender, EventArgs e)
        {
            int Load = RoulleteOBJ.Bulleteaway();
            if (Load == 1)
            {

                MessageBox.Show("won with score 1000");
                gunloadbtn.Enabled = false;
                Spingunbtn.Enabled = false;
                Shootgunbtn.Enabled = false;
                Shootabtn.Enabled = false;

                imglooder.Image = RssianRoullete.Properties.Resources.spin;


            }
            if (Load == 2)
            {
                MessageBox.Show("won with score 500");
                gunloadbtn.Enabled = false;
                Spingunbtn.Enabled = false;
                Shootgunbtn.Enabled = false;
                Shootabtn.Enabled = false;



                imglooder.Image = RssianRoullete.Properties.Resources.spin;


            }
            if (Load == 0)
            {

                MessageBox.Show("no shot");
            }
            if (RoulleteOBJ.totalbulletsleft == 0)
            {

                MessageBox.Show("loose");
                gunloadbtn.Enabled = false;
                Spingunbtn.Enabled = false;
                Shootgunbtn.Enabled = false;
                Shootabtn.Enabled = false;



                imglooder.Image = RssianRoullete.Properties.Resources.spin;




            }
        }

        private void Playagainbtn_Click(object sender, EventArgs e)
        {
            (new Russiangungame()).Show();
            this.Hide();
        }

        private void Russiangungame_Load(object sender, EventArgs e)
        {

        }
    }
}

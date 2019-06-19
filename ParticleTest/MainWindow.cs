using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace ParticleTest
{
    public partial class MainWindow : Form
    {

        List<Particle> listParticles = new List<Particle>();
        List<Particle> listRemoveParticles = new List<Particle>();
        Random random = new Random();
        Color color = Color.Blue;
        TimeSpan timeSpan = new TimeSpan(0);


        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindowPaint(object sender, PaintEventArgs e)
        {
            foreach (Particle p in listParticles)
            {
                if (!p.isAlive(int.Parse(txtLiveTime.Text)))
                {
                    listRemoveParticles.Add(p);
                }
                else
                {
                    p.drawParticle(e.Graphics);
                }
            }
            foreach (Particle rp in listRemoveParticles)
            {
                listParticles.Remove(rp);
            }

        }

        private void mainWindowMouseDown(object sender, MouseEventArgs e)
        {

            if (int.Parse(txtVolumeLower.Text) > int.Parse(txtVolumeUpper.Text))
            {
                MessageBox.Show("Lower bound for volume cannot be higher than upper bound.","Mass Error"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(int.Parse(txtDensityLower.Text) > int.Parse(txtDensityUpper.Text))
            {
                MessageBox.Show("Lower bound for density cannot be higher than upper bound.", "Mass Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int intAmount = int.Parse(txtAmount.Text);
                int intVolume;
                int intDensity;
                float fltSpeedDecay = float.Parse(txtSpeedDecay.Text);
                double dblForce = double.Parse(txtForce.Text);
                PointF p;
                bool fade;
                if(chkFadeOut.Checked == true)
                {
                    fade = true;
                }
                else
                {
                    fade = false;
                }

                for (int i = 0; i < intAmount; i++)
                {
                    p = new PointF(e.Location.X, e.Location.Y);
                    intVolume = random.Next(int.Parse(txtVolumeLower.Text), int.Parse(txtVolumeUpper.Text));
                    intDensity = random.Next(int.Parse(txtDensityLower.Text), int.Parse(txtDensityUpper.Text));
                    Particle part = new Particle(p, dblForce, random, color, intVolume, intDensity, fltSpeedDecay, fade);
                    listParticles.Add(part);

                }
            }     
        }


        private void ParticleTimer_Tick(object sender, EventArgs e)
        {
            foreach (Particle p in listParticles)
            {
                p.moveParticle();
            }
            this.Invalidate();
        }

        private void btnColorOnClick(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();



            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pbColor.BackColor = colorDialog.Color;
                color = colorDialog.Color;

            }
        }
    }
}

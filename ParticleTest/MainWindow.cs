using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;

using System.Windows.Forms;

namespace ParticleTest
{
    public partial class MainWindow : Form
    {

        List<Particle> listParticles = new List<Particle>();
        List<Particle> listRemoveParticles = new List<Particle>();
        List<Projectile> listProjectiles = new List<Projectile>();
        List<Projectile> listRemoveProjectiles = new List<Projectile>();
        Random random = new Random();
        Color color = Color.Blue;
        TimeSpan timeSpan = new TimeSpan(0);

        int spreadAngle = 360;
        int directionAngle = 360;


        SolidBrush brush = new SolidBrush(Color.Black);
        Rectangle wall = new Rectangle(new Point(700,50),new Size(20,900) );

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindowPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(brush,wall);

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

            foreach(Projectile pr in listProjectiles)
            {
                
                if (pr.isColliding(wall))
                {
                    listRemoveProjectiles.Add(pr);
                    particleBoom(new PointF((int)pr.PLocation.X+20,(int)pr.PLocation.Y+5));
                    
                }
                else
                {
                    pr.drawProjectile(e.Graphics);
                }
            }

            foreach (Particle rp in listRemoveParticles)
            {
                listParticles.Remove(rp);

            }

            foreach (Projectile proj in listRemoveProjectiles)
            {
                listProjectiles.Remove(proj);
            }


        }

        private void mainWindowMouseDown(object sender, MouseEventArgs e)
        {
            PointF p = new PointF(e.Location.X, e.Location.Y);
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
                if(e.Button == MouseButtons.Right)
                {
                    particleBoom(p);
                }
                if(e.Button == MouseButtons.Left)
                {
                    Debug.WriteLine("Projectile created");
                    
                    Projectile projectile = new Projectile(p);
                    listProjectiles.Add(projectile);
                }
                
            }     
        }


        private void particleBoom(PointF pointF)
        {
            int intAmount = int.Parse(txtAmount.Text);
            int intVolume;
            int intDensity;
            float fltSpeedDecay = float.Parse(txtSpeedDecay.Text);
            double dblForce = double.Parse(txtForce.Text);

            bool fade;
            if (chkFadeOut.Checked)
            {
                fade = true;
            }
            else
            {
                fade = false;
            }

            for (int i = 0; i < intAmount; i++)
            {

                intVolume = random.Next(int.Parse(txtVolumeLower.Text), int.Parse(txtVolumeUpper.Text));
                intDensity = random.Next(int.Parse(txtDensityLower.Text), int.Parse(txtDensityUpper.Text));
                Particle part = new Particle(pointF, dblForce, random, color, intVolume, intDensity, fltSpeedDecay,
                    fade, spreadAngle, directionAngle);
                listParticles.Add(part);

            }
        }



        private void particleTimerTick(object sender, EventArgs e)
        {
            foreach (Particle p in listParticles)
            {
                p.moveParticle();
            }

            foreach(Projectile pr in listProjectiles)
            {
                pr.moveProjectile();
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

        private void showSpreadAdjust(object sender, EventArgs e)
        {
            SpreadForm spreadForm = new SpreadForm(spreadAngle, directionAngle);
            DialogResult result = spreadForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                spreadAngle = spreadForm.spreadAngle;
                directionAngle = spreadForm.directionAngle;
            }
        }
    }
}

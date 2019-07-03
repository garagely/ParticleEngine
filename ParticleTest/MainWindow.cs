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


        Pen pen = new Pen(Color.Black);
        Rectangle wall = new Rectangle(new Point(700,100),new Size(20,900) );

        public MainWindow()
        {
            
            InitializeComponent();

           

        }

        private void mainWindowPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(pen,wall);

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
                    for (int x = 0; x<10; x++)
                    {
                        Particle particle = new Particle(new PointF(pr.PLocation.X, pr.PLocation.Y),100, random, Color.Crimson,
                            5, 5, 1, false);
                        listParticles.Add(particle);
                    }
                    
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
                    int intAmount = int.Parse(txtAmount.Text);
                    int intVolume;
                    int intDensity;
                    float fltSpeedDecay = float.Parse(txtSpeedDecay.Text);
                    double dblForce = double.Parse(txtForce.Text);
                    
                    bool fade;
                    if (chkFadeOut.Checked == true)
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
                        Particle part = new Particle(p, dblForce, random, color, intVolume, intDensity, fltSpeedDecay, fade);
                        listParticles.Add(part);

                    }
                }
                if(e.Button == MouseButtons.Left)
                {
                    Debug.WriteLine("Projectile created");
                    
                    Projectile projectile = new Projectile(p, 10f);
                    listProjectiles.Add(projectile);
                }
                
            }     
        }




        private void ParticleTimer_Tick(object sender, EventArgs e)
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
    }
}

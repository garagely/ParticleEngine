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

        private void PanMain_Paint(object sender, PaintEventArgs e)
        {
            foreach (Particle p in listParticles)
            {
                if (!p.isAlive())
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

        private void PanMain_MouseDown(object sender, MouseEventArgs e)
        {

            if (int.Parse(txtMassLower.Text) > int.Parse(txtMassUpper.Text))
            {
                MessageBox.Show("Lower bound for mass cannot be higher than upper bound.","Mass Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int intAmount = int.Parse(txtAmount.Text);
                int intMass;
                double dblForce = double.Parse(txtForce.Text);
                PointF p;

                for (int i = 0; i < intAmount; i++)
                {
                    p = new PointF(e.Location.X, e.Location.Y);
                    intMass = random.Next(int.Parse(txtMassLower.Text), int.Parse(txtMassUpper.Text));
                    Particle part = new Particle(p, intMass, dblForce, random, color);
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
            panMain.Invalidate();
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

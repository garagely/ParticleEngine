using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleTest
{
    class Particle
    {
        private PointF pLocation;
        private PointF pVector;
        private float dblAcceleration;
        private int intMass;
        private double dblForce;
        private Color color;
        private Random random;
        private DateTime timeToLive;

        public Particle(PointF lPointF, int mass, double force, Random random, Color color)
        {
            this.random = random;
            this.pLocation = lPointF;
            this.intMass = mass;
            this.dblForce = force;
            this.dblAcceleration = getSpeed();
            this.pVector = this.randomVector();
            this.color = color;
            this.timeToLive = DateTime.UtcNow;
            
        }

        public bool isAlive()
        {
            return timeToLive.AddSeconds(3) > DateTime.UtcNow;
        }
       

        public void moveParticle()
        {
            pLocation = new PointF(pLocation.X + pVector.X, pLocation.Y + pVector.Y);
            //pVector = new PointF(pVector.X*.98f, pVector.Y * .98f);
        }

        public void drawParticle(Graphics g)
        {
            g.FillRectangle(new SolidBrush(color), pLocation.X-(intMass/2), pLocation.Y- (intMass / 2), intMass, intMass);
        }

        public PointF randomVector()
        {
            float angle = (float)(random.NextDouble()*(Math.PI*2));
            return new PointF((float)(Math.Cos(angle)*dblAcceleration),(float)(Math.Sin(angle))*dblAcceleration);
        }

        private float getSpeed()
        {
            return (float)(this.dblForce / intMass);
        }
    }
}

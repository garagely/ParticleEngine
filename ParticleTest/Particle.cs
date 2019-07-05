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
        private int intDensity;
        private int intVolume;
        private double dblForce;
        private float fltDecayRate;
        private Color color;
        private Random random;
        private DateTime timeToLive;
        private int alpha = 255;
        private bool bolFade;

        private int intSpreadZone;
        private int intSpreadDirection;


        public Particle(PointF lPointF, double force, Random random, Color color,
            int volume, int density, float decayRate, bool fade, int spreadZone, int spreadDirection)
        {
            this.random = random;
            pLocation = lPointF;
            intVolume = volume;
            intDensity = density;
            intMass = getMass(); ;
            dblForce = force;
            fltDecayRate = decayRate;
            dblAcceleration = getSpeed();
            intSpreadZone = spreadZone;
            intSpreadDirection = spreadDirection;
            pVector = randomVector();
            this.color = color;
            timeToLive = DateTime.UtcNow;
            bolFade = fade;
            

        }


        public bool isAlive(int liveTime)
        {
            return timeToLive.AddMilliseconds(liveTime) >= DateTime.UtcNow;
        }
       

        public void moveParticle()
        {
            if (bolFade)
            {
                alpha -= 5;
                if (alpha < 0)
                {
                    alpha = 0;
                }
            }
          
            
            pLocation = new PointF(pLocation.X + pVector.X, pLocation.Y + pVector.Y);
            pVector = new PointF(pVector.X*fltDecayRate, pVector.Y * fltDecayRate);
            color = Color.FromArgb(alpha, color);
        }

        public void drawParticle(Graphics g)
        {
            g.FillRectangle(new SolidBrush(color), pLocation.X-(intVolume/2), pLocation.Y- (intVolume / 2),
                intVolume, intVolume);
        }

        private PointF randomVector()
        {
            
            double spreadZone = intSpreadZone * Math.PI / 180;

            
            double zoneAngle = intSpreadDirection * Math.PI / 180;

            float angle = (float)(random.NextDouble()*(spreadZone)+zoneAngle);
            return new PointF((float)(Math.Cos(angle)*dblAcceleration),(float)(Math.Sin(angle))*dblAcceleration);
        }

        private float getSpeed()
        {
            return (float)(dblForce / intMass);
        }

        private int getMass()
        {
            return intVolume * intDensity;
        }
    }
}

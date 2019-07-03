using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleTest
{
    class Projectile 
    {
        public PointF PLocation { get; private set; }
        private float fSpeed;
        private Point pSize;
        private Color color;
        private Rectangle hitBox;

        public Projectile(PointF pLocation, float fSpeed)
        {
            this.PLocation = pLocation;
            this.fSpeed = fSpeed;
            this.pSize = new Point(20,10);
            this.color = Color.Black;
            this.hitBox = new Rectangle((int)pLocation.X, (int)pLocation.Y, pSize.X, pSize.Y);
        }

        public void drawProjectile(Graphics g)
        {
            Brush b = new SolidBrush(color);
            g.FillRectangle(b, PLocation.X, PLocation.Y, pSize.X, pSize.Y);
        }

        public void moveProjectile()
        {
            PLocation = new PointF(PLocation.X + fSpeed, PLocation.Y);
            hitBox.Location = new Point((int)PLocation.X, (int)PLocation.Y);
        }

        public Boolean isColliding(Rectangle box)
        {
            if (hitBox.IntersectsWith(box))
            {
               Debug.WriteLine("Collided");
               return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}

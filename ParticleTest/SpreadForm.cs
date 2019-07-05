using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleTest
{
    public partial class SpreadForm : Form
    {
        public int spreadAngle { get; set; }
        public int directionAngle { get; set; }
        public SpreadForm(int spread, int direction)
        {
            spreadAngle = spread;
            directionAngle = direction;
            
            InitializeComponent();

            txtSpread.Text = spreadAngle.ToString();
            txtDirection.Text = directionAngle.ToString();
        }

        private void onPaint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 1);
            e.Graphics.DrawArc(pen ,125,125,400,400,0,360 );
            drawSpreadArc(e.Graphics, pen);

            pen.Dispose();
        }

        private void drawSpreadArc(Graphics g, Pen pen)
        {
            
            pen.Width = 5;
            int spread = int.Parse(txtSpread.Text);
            int direction = int.Parse(txtDirection.Text);
            g.DrawArc(pen, 125, 125, 400, 400, direction, spread);

        }


        private void adjustSpread(object sender, EventArgs e)
        {
            txtSpread.Text = tbSpread.Value.ToString();
            Refresh();
        }

        private void adjustDirection(object sender, EventArgs e)
        {
            txtDirection.Text = tbDirection.Value.ToString();
            Refresh();
        }

        private void closeDialog(object sender, EventArgs e)
        {
            spreadAngle = int.Parse(txtSpread.Text);
            directionAngle = int.Parse(txtDirection.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelDialog(object sender, EventArgs e)
        {
            Close();
        }

    }
}

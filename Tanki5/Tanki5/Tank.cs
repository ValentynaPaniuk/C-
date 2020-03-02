using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanki5
{
    class Tank
    {
        private float x;
        private float r;
        private float y;
        private float angle = 0;
        private float velocity = 0;
        private float angularVelocity = 0;
        private Pen pen;

        public Tank(Pen pen, float x, float y)
        {
            this.pen = pen;
            this.x = x;
            this.y = y;
        }

        public void setAngularVelocity(float angularVelocity)
        {
            this.angularVelocity = angularVelocity;
        }

        public void setVelocity(float velocity)
        {
            this.velocity = velocity;
        }

        public void move(float time)
        {
            angle += angularVelocity;
            r = velocity * time ;
            x += Convert.ToSingle( Math.Sin( angle * 6.28 / 360) * r);
            y -= Convert.ToSingle(Math.Cos(angle * 6.28 / 360) * r);
        }

        public void draw(Graphics g)
        {
            g.TranslateTransform(x, y);
            g.RotateTransform(angle);

            g.DrawRectangle(pen, -10, -15, 20, 30);
            g.DrawEllipse(pen, -5, -7, 10, 14);
            g.DrawLine(pen, 0, -22, 0, -7);

            g.RotateTransform(-angle);
            g.TranslateTransform(-x, -y);}
    
       
        }
    }


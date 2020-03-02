using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanki5
{
    class Pylia
    { 
        private float x;
        private float r;
        private float y;
        private float angle = 0;
        private float velocity = 0;
        
        private Pen pen;

        public Pylia(Pen pen, float x, float y)
        {
            this.pen = pen;
            this.x = x;
            this.y = y;
        }

      

        public void setVelocity(float velocity)
        {
            this.velocity = velocity;
        }

        public void move(float time)
        {
            
            r = velocity * time ;
            
        }

        public void draw(Graphics g)
        {
            g.TranslateTransform(x, y);
            g.RotateTransform(angle);

            g.DrawEllipse(pen, -100, -300, 20, 10);
            

            g.RotateTransform(-angle);
            g.TranslateTransform(-x, -y);}
    
       
        }
    }


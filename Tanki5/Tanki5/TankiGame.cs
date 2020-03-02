using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanki5
{
    public partial class TankiGame : UserControl
    {
        Tank[] tanks = new Tank[4];
        int tanksCount = 0;
        Pylia[] pylias = new Pylia[4];
        int pyliasCount = 0;
        public TankiGame()
        {
            InitializeComponent();
        }

        private void TankiGame_Load(object sender, EventArgs e)
        {

        }

        public void addTank(Pen pen, float x, float y)
        {
            tanks[tanksCount] = new Tank(pen, x, y);
            tanksCount++;
        }
        public void addPylia(Pen pen, float x, float y)
        {
            pylias[pyliasCount] = new Pylia(pen, x, y);
            pyliasCount++;
        }

        public void startTurningLeft(int tankNum)
        {
            tanks[tankNum].setAngularVelocity(-10f);
        }
        public void startidtivpered(int tankNum)
        {
            tanks[tankNum].setVelocity(10f);
        }
        public void startidtinazad(int tankNum)
        {
            tanks[tankNum].setVelocity(-10f);
        }

        public void startTurningRight(int tankNum)
        {
            tanks[tankNum].setAngularVelocity(10f);
        }

        public void startForward(int tankNum)
        {
        }
        public void startBackwards(int tankNum)
        {
        }

        public void startFiring(int tankNum)
        {
        }
        public void stoptidtinazad(int tankNum)
        {
            tanks[tankNum].setVelocity(0f);
        }
        public void stopTurningLeft(int tankNum)
        {
            tanks[tankNum].setAngularVelocity(0f);

        }
        public void stopidtivpered(int tankNum)
        {
            tanks[tankNum].setVelocity(0f);
        }

        public void stopTurningRight(int tankNum)
        {
            tanks[tankNum].setAngularVelocity(0f);
        }

        public void stopForward(int tankNum)
        {
        }
       

        public void stopBackwards(int tankNum)
        {
        }

        public void stopFiring(int tankNum)
        {
        }

        public void timePassed(float time)
        {
            for (int i = 0; i < tanksCount; i++)
            {
                tanks[i].move(time);
            }

            Refresh();
        }

        private void TankiGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < tanksCount; i++)
            {
                tanks[i].draw(g);
            }
        }

    }
}

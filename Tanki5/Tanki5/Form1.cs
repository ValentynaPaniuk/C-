using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanki5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            game1.addTank(Pens.DarkGreen, 50, 50);
            game1.addTank(Pens.Red, 200, 300);
            game1.addPylia(Pens.Yellow, 10, 10);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A: 
                    game1.startTurningLeft(0);
                    
                    break;
                case Keys.D: game1.startTurningRight(0);
                    break;
                case Keys.W: game1.startForward(0);
                    game1.startidtivpered(0);
                    break;
                case Keys.S: game1.startBackwards(0);
                    game1.startidtinazad(0);
                    break;
                case Keys.Q: game1.startFiring(0);
                    break;

                case Keys.J: game1.startTurningLeft(1);
                    break;
                case Keys.L: game1.startTurningRight(1);
                    break;
                case Keys.I: game1.startForward(1);
                    game1.startidtivpered(1);
                    break;
                case Keys.K: game1.startBackwards(1);
                    game1.startidtinazad(1);
                    break;
                case Keys.U: game1.startFiring(1);
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A: game1.stopTurningLeft(0);
                    
                    break;
                case Keys.D: game1.stopTurningRight(0);
                    break;
                case Keys.W: game1.stopForward(0);
                    game1.stopidtivpered(0);
                    break;
                case Keys.S: game1.stopBackwards(0);
                    game1.stoptidtinazad(0);
                    break;
                case Keys.Q: game1.stopFiring(0);
                    break;

                case Keys.J: game1.stopTurningLeft(1);
                    break;
                case Keys.L: game1.stopTurningRight(1);
                    break;
                case Keys.I: game1.stopForward(1);
                    game1.stopidtivpered(1);
                    break;
                case Keys.K: game1.stopBackwards(1);
                    game1.stoptidtinazad(1);
                    break;
                case Keys.U: game1.stopFiring(1);
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game1.timePassed(1f);
        }
    }
}

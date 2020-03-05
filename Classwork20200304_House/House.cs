using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304_House
{
    class House 
    {


        protected int area;
        protected Basement basement;
        protected Walls walls;
        protected Door door;
        protected Window window;
        protected Roof roof;


        public House(int area)
        {
            this.area = area;
            this.basement = new Basement();
            this.walls = new Walls();
            this.door = new Door();
            this.window = new Window();
            this.roof = new Roof();

        }

        public int Area
        { get { return area; }
            set { area = value; }
        }
        public Door Door
        {
            get { return door; }
            set { door = value; }
        }

        public Basement Basement
        {
            get { return basement; }
            set { basement = value; }
        }


        public Roof Roof
        {
            get { return roof; }
            set { roof = value; }
        }


        public Walls Walls
        {
            get { return walls; }
            set { walls = value; }
        }

        public Window Window
        {
            get { return window; }
            set { window = value; }
        }

        public virtual void ShowData()
        {
            Console.WriteLine("I am a house, my area is {0} m2.", area);
        }


    }
}

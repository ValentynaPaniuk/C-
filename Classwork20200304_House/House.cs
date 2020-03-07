using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200304_House
{
    class House 
    {
        protected Basement basement;
        protected Walls walls;
        protected Door door;
        protected Window window;
        protected Roof roof;

        public House()
        { }

        public House(Basement basement)
        {
         this.basement = new Basement();
         }

        public House(Basement basement, Walls walls)
        {
            this.walls = new Walls();
        }

        public House(Basement basement, Walls walls, Door door)
        {
            this.door = new Door();
        }

        public House(Basement basement, Walls walls, Door door, Window window)
        {
            this.window = new Window();

        }

        public House(Basement basement, Walls walls, Door door, Window window, Roof roof) //: this(basement, walls, door, window) : this (basement, walls, door) : this (basement, walls) : this (basement)
        {
            this.roof = new Roof();
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
            Console.WriteLine("I am a house");

        }


    }
}

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
        {
            Console.WriteLine("Default constructor");
        }

        public House(Basement basement)
        {
         this.basement = new Basement();
            Console.WriteLine("Overload constructor (Basement)");
        }

        public House(Basement basement, Walls walls)
        {
            
            this.walls = new Walls();
            Console.WriteLine("Overload constructor (Basement, Walls)");
        }

        public House(Basement basement, Walls walls, Door door)
        {
            
            this.door = new Door();
            Console.WriteLine("Overload constructor (Basement, Walls, Door)");
        }

        public House(Basement basement, Walls walls, Door door, Window window)
        {
            this.window = new Window();
            Console.WriteLine("Overload constructor (Basement, Walls, Door, Window)");
        }

    

        public House(Basement basement, Walls walls, Door door, Window window, Roof roof)
        {
            this.roof = new Roof();
            Console.WriteLine("Overload constructor (Basement, Walls, Door, Window, Roof)");
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


        public Walls Walls  {
            get { return walls; }
            set { walls = value; }
        }

        public Window Window
        {
            get { return window; }
            set { window = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("I am a house");

        }


    }
}

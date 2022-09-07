using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bo_godt;

namespace Bo_godt
{
    internal abstract class Flat : Ii
    {
        //propertys
        private int numbersOfRooms;
        private int squareMetres;
        private int doors;
        private int windows;
        private bool twoPaneWindow;


        //encapsulation
        protected internal int NumbersOfRooms { get { return numbersOfRooms; } set { numbersOfRooms = value; } }
        protected internal int SquareMetres { get { return squareMetres; } set { squareMetres = value; } }
        protected internal int Doors { get { return doors; } set { doors = value; } }
        protected internal int Windows { get { return windows; } set { windows = value; } }
        protected internal bool TwoPaneWindow { get { return twoPaneWindow; } set { twoPaneWindow = value; } }

        //constructor
        public Flat(int numberOfRooms, int squareMeter, int doors, int windows, bool twoPaneWindow)
        {
            this.numbersOfRooms = numberOfRooms;
            this.squareMetres = squareMeter;
            this.doors = doors;
            this.windows = windows;
            this.twoPaneWindow = twoPaneWindow;

        }

        //abstract method used though the inheriting classes from the super Classes 
        protected internal abstract void GetInfo();

        //makes the object contaning the interface public 
        public object Inte { get; private set; }




    }
}

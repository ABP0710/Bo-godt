using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo_godt
{
    internal class SmallFlat : Flat
    {
        //constructor
        public SmallFlat(int numberOfRooms, int squareMeter, int doors, int windows, bool twoPaneWindow) : base(numberOfRooms, squareMeter, doors, windows, twoPaneWindow)
        {

        }

        //method that link to the abstract method in the superclass named Flat
        //and therefore the propertys squareMeters, doors, windows, twoPaneWindow can be reached
        protected internal override void GetInfo()
        {
            Console.WriteLine("This flat contains:");
            Console.WriteLine(this.NumbersOfRooms + "Rooms");
            Console.WriteLine(this.SquareMetres + "square meters");
            Console.WriteLine(this.Doors + "Doors");
            Console.WriteLine(this.Windows + "Windows");
            Console.WriteLine("Two pane window " + this.TwoPaneWindow);
            

        }


    }
}

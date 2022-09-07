using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo_godt
{
    internal class BigFlat :SmallFlat
    {
        //property
        private bool treePaneWindow;

        //encapsulation
        protected internal bool TreePaneWindow
        {
            get { return treePaneWindow; }
            set { treePaneWindow = value; }
        }

        //constructor
        public BigFlat(int numberOfRooms, int squareMeter, int doors, int windows, bool twoPaneWindow, bool treePaneWindow) : base(numberOfRooms, squareMeter, doors, windows, twoPaneWindow)
        {
            this.treePaneWindow = treePaneWindow;
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
            Console.WriteLine("Tree pane window " + treePaneWindow);
            Console.WriteLine();
            
        }


    }
}

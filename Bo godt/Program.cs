using System;

namespace Bo_godt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is a assignment for school

            //create an object storing the interface
            interior inte = new interior();
            

            //makes the object of the flats
            Flat flat1 = new SmallFlat(2, 55, 4, 3, true);
            Flat flat2 = new BigFlat(5, 110, 7, 6, false, true);

            //outout the flats
            flat1.GetInfo();
            
            flat2.GetInfo();

            //im not done whit the interface and its method
            inte.Interiors();

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bo_godt
{
    internal class interior
    {
    }
    interface Ii
    {
        void Interiors()
        {
            bool newKitchen = true;
            bool newFrontDoor = true;
            bool newBackDoor = true;
            bool livingroom = true;
            bool newFloor = true;
            bool bathroom = true;
            bool frostetWindow = true;

            Console.WriteLine("new kitchen " + newKitchen);
            Console.WriteLine("new frontdoor " + newFrontDoor);
            Console.WriteLine("new backdoor " + newBackDoor);
            Console.WriteLine("livingroom " + livingroom);
            Console.WriteLine("new floors " + newFloor);
            Console.WriteLine("bathroom " + bathroom);
            Console.WriteLine("frostet window in the the bathroom " + frostetWindow);

        }
    }
}

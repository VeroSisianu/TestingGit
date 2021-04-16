using System;
using System.Collections.Generic;
using System.Text;

namespace Lectia22_5
{
    class Couch : Furniture
    {
        string type = "Couch";
        string material;
        public override void GetTypeOfFurniture()
        {
            Console.WriteLine(type);
        }
        public int numOfSeats()
        {
            return 4;
        }
    }
}

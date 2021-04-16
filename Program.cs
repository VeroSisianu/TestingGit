using System;

namespace Lectia22_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Couch couch1 = new Couch();
            couch1.GetTypeOfFurniture();
            Room room1 = new Room();
            room1.furniture = couch1;

            room1.structure = new Structure[2];
            Window window1 = new Window();
            room1.structure[0] = window1;
            
            Wall wall1 = new Wall();
            room1.structure[1] = wall1;

            window1.Close();
            Console.WriteLine(wall1.LoadBearing());
        }
    }
}

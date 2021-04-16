using System;
using System.Collections.Generic;
using System.Text;

namespace Lectia22_5
{
    class Room : IDrawable
    {
        int x;
        int y;
        double height;
        double width;
        public Furniture furniture { get; set; }
        public Structure []structure { get; set; }
        public void Hide()
        {
            Console.WriteLine("The room is hidden.");
        }
        public void Redraw()
        {
            Console.WriteLine("Redrawing the room.");
        }
        public void Remove()
        {
            Console.WriteLine("Room removed.");
        }
        public void Clone()
        {
            Console.WriteLine("The room was cloned");
        }
    }
}

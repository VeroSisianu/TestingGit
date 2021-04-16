using System;
using System.Collections.Generic;
using System.Text;

namespace Lectia22_5
{
    class Window : Structure
    {
        double opacity;
        bool isOpen;
        public override bool LoadBearing()
        {
            return false;
        }
        public void Close()
        {
            Console.WriteLine("Window closed");
            isOpen = false;
        }
        public void Open()
        {
            Console.WriteLine("Window opened");
            isOpen = true;
        }
        public bool IsOpen()
        {
            return isOpen;
        }
    }
}

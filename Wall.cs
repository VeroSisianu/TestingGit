using System;
using System.Collections.Generic;
using System.Text;

namespace Lectia22_5
{
    class Wall : Structure
    {
        string insideColor;
        string outsideColor;
        public override bool LoadBearing()
        {
            return true;
        }
    }
}

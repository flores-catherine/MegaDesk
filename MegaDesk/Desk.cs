﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberDrawers { get; set; }
        public string SurfaceMaterial { get; set; }
        public int RushDays { get; set; }


        //desk contstraints / Constants
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
    }
}

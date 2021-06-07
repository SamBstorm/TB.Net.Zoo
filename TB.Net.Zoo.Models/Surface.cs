using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.Zoo.Models
{
    public struct Surface
    {
        public double Width;
        public double Lenght;

        public double Area { get { return Width * Lenght; } }
    }
}

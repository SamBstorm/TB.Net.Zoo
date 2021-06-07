using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.Zoo.Models
{
    public struct Volume
    {
        public Surface Base;
        public double Depth;
        public double Capacity { get { return Base.Area * Depth; } }
    }
}

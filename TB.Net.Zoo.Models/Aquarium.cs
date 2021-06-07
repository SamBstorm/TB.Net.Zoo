using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.Zoo.Models
{
    public class Aquarium : Enclosure
    {
        private Volume _volume;
        private double _salty;

        public double Depth { 
            get { return _volume.Depth; }
            set { _volume.Depth = value; }
        }
        public double Capacity { get { return _volume.Capacity; } }

        public override double Lenght
        {
            get { return _volume.Base.Lenght; }
            protected set { _volume.Base.Lenght = (value >= 2) ? value : throw new ArgumentOutOfRangeException(); }
        }
        public override double Width
        {
            get { return _volume.Base.Width; }
            protected set { _volume.Base.Width = (value >= 2) ? value : throw new ArgumentOutOfRangeException(); }
        }

        public override double Area { get { return _volume.Base.Area; } }

        public double Salty {
            get { return _salty; }
            set {
                if (value < 0 || value > 1) throw new ArgumentOutOfRangeException();
                _salty = value;
            }
        }

        public Aquarium(string nom, double temp, double lenght, double width, double depth, double salty) : base(nom, temp, lenght, width)
        {
            this.Depth = depth;
            this.Salty = salty;
        }
    }
}

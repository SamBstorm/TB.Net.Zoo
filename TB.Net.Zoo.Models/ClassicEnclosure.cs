using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.Zoo.Models
{
    public class ClassicEnclosure : Enclosure
    {
        private Surface _surface;
        private Environement _environement;
        private double _gridHeight;
        private Volume _bassin;
        public override double Lenght
        {
            get { return _surface.Lenght; }
            protected set { _surface.Lenght = (value >= 2 && value > BassinLenght) ? value : throw new ArgumentOutOfRangeException(); }
        }

        public override double Width
        {
            get { return _surface.Width; }
            protected set { _surface.Width = (value >= 2 && value > BassinWidth) ? value : throw new ArgumentOutOfRangeException(); }
        }
        public override double Area { get { return _surface.Area; } }

        public Environement Environement
        {
            get { return _environement; }
            set { _environement = value; }
        }
        public double GridHeight { get { return _gridHeight; }
            set { _gridHeight = value; }
        }


        public bool HaveBassin { get { return BassinVolume > 0; } }

        public double BassinLenght { get { return _bassin.Base.Lenght; }
            set {
                if (value >= Lenght) throw new ArgumentOutOfRangeException();
                this._bassin.Base.Lenght = value;
            }
        }
        public double BassinWidth { get { return _bassin.Base.Width; }
            set
            {
                if (value >= Width) throw new ArgumentOutOfRangeException();
                this._bassin.Base.Width = value;
            }
        }
        public double BassinDepth { get { return _bassin.Depth; }
            set { _bassin.Depth = value; }
        }
        public double BassinArea { get { return _bassin.Base.Area; } }
        public double BassinVolume { get { return _bassin.Capacity; } }

        public ClassicEnclosure(string nom, double temp, double lenght, double width, double grid, Environement env, Volume bassinVolume ) : base(nom, temp, lenght, width)
        {
            this.GridHeight = grid;
            this.Environement = env;
            this.BassinLenght = bassinVolume.Base.Lenght;
            this.BassinWidth = bassinVolume.Base.Width;
            this.BassinDepth = bassinVolume.Depth;
        }
        public ClassicEnclosure(string nom, double temp, double lenght, double width, double grid, Environement env) : this (nom, temp, lenght, width, grid, env, new Volume())
        {
        }
    }
}

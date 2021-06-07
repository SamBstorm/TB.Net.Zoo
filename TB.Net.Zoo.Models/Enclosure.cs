using System;

namespace TB.Net.Zoo.Models
{
    public abstract class Enclosure
    {
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            private set { _nom = value; }
        }

        private double _temp;

        public double Temperature
        {
            get { return _temp; }
            set { _temp = value; }
        }

        public abstract double Lenght { get; protected set; }
        public abstract double Width { get; protected set; }
        public abstract double Area { get; }

        public Enclosure(string nom, double temp, double lenght, double width)
        {
            if (string.IsNullOrEmpty(nom)) throw new ArgumentNullException();
            this._nom = nom;
            this._temp = temp;

            this.Width = width;
            this.Lenght = lenght;
        }

    }
}
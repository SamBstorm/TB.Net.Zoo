using System;
using System.Collections.Generic;

namespace TB.Net.Zoo.Models
{
    public class Zoo
    {
        private string _nom;
        private Address _address;
        private Dictionary<string, Enclosure> _enclosures;
        public string Nom {
            get { return _nom; }
            set { _nom = value; }
        }
        public Address Address {
            get { return _address; }
            private set { _address = value; }
        }

        public double GlobalArea { get {
                double result = 0;
                foreach (Enclosure enclosure in _enclosures.Values)
                {
                    result += enclosure; //result += enclosuer.Area;
                }
                return result*2.2;
            } 
        }

        public Zoo(string nom, Address address)
        {
            this.Nom = nom;
            this.Address = address;
            _enclosures = new Dictionary<string, Enclosure>();
        }

        public void AddAquarium(string nom, double temp, double lenght, double width, double depth, double salty) {
            if (string.IsNullOrEmpty(nom)) throw new ArgumentNullException();
            if (_enclosures.ContainsKey(nom.ToUpper())) throw new ArgumentException();
            try
            {
                this._enclosures.Add(nom.ToUpper(), new Aquarium(nom, temp, lenght, width, depth, salty));
            }
            catch (Exception)
            {
                throw new Exception("Aquarium incorrect");
            }
        }
        //public void AddAquarium(Aquarium aquarium)
        //{
        //    if (string.IsNullOrEmpty(aquarium.Nom)) throw new ArgumentNullException();
        //    if (_enclosures.ContainsKey(aquarium.Nom.ToUpper())) throw new ArgumentException();
        //    if (_enclosures.ContainsValue(aquarium)) throw new ArgumentException();
        //    this._enclosures.Add(aquarium.Nom.ToUpper(), aquarium);
        //}
        public void AddClassicEnclosure(string nom, double temp, double lenght, double width, double grid, Environement env, Volume bassinVolume) {
            if (string.IsNullOrEmpty(nom)) throw new ArgumentNullException();
            if (_enclosures.ContainsKey(nom.ToUpper())) throw new ArgumentException();
            try
            {
                this._enclosures.Add(nom.ToUpper(), new ClassicEnclosure(nom, temp, lenght, width, grid, env, bassinVolume));
            }
            catch (Exception)
            {
                throw new Exception("Enclos classique incorrect");
            }
        }
        public void AddClassicEnclosure(string nom, double temp, double lenght, double width, double grid, Environement env)
        {
            if (string.IsNullOrEmpty(nom)) throw new ArgumentNullException();
            if (_enclosures.ContainsKey(nom.ToUpper())) throw new ArgumentException();
            try
            {
                this._enclosures.Add(nom.ToUpper(), new ClassicEnclosure(nom, temp, lenght, width, grid, env));
            }
            catch (Exception)
            {
                throw new Exception("Enclos classique incorrect");
            }
        }


    }
}

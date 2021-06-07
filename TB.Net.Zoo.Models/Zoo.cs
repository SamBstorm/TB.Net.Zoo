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



    }
}

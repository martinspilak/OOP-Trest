using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Trest
{
    class TV
    {
        public TV (string brand, string type, int diagonal)
        {
            Brand = brand;
            Type = type;
            Diagonal = diagonal;            
        }
        public string Brand { get; }
        public string Type { get; }
        public int Diagonal { get; }
    }
}

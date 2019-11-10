using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Trest
{
    class Phone
    {
        public Phone (string brand, string type)
        {
            Brand = brand;
            Type = type;          
        }
        public string Brand { get; }
        public string Type { get; }      
    }
}

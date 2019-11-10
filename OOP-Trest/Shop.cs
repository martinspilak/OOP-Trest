using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Trest
{
    class Shop
    {
        public List<TV> TVs;
        public List<Phone> Phones;


        public Shop()
        {
            TVs = new List<TV>
            {
                new TV("LG", "HD", 32),
                new TV("Saumsung", "FullHD", 48),
                new TV("Sony", "OLED", 43),
                new TV("Philips", "UltraHD", 50)
            };
            Phones = new List<Phone>
            {
                new Phone("LG", "Android"),
                new Phone("Saumsung", "Android"),
                new Phone("Apple", "IOS"),
                new Phone("Nokia", "Windowsphone")
            };
        }
       
    }
}

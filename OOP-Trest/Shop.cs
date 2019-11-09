using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Trest
{
    class Shop
    {
        public List<TV> TVs;

        public Shop()
        {
            TVs = new List<TV>
            {
                new TV("LG", "HD", 32),
                new TV("Saumsung", "FullHD", 48),
                new TV("Sony", "OLED", 43),
                new TV("Philips", "UltraHD", 50)
            };
        }
    }
}

using System;
using System.Collections.Generic;

namespace rataattatatatat
{
    public class ContrabandCar : Car
    {
        public ContrabandCar()
        {
         passangers = generator.Next(1, 4);
         contrabandAmount = generator.Next(1, 4);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.CreationalPatterns.FactoryMethod.metanit.com.Example1
{

    class WoodenHouse : House
    {
        public WoodenHouse()
        {
            this.HouseType = "WoodenHouse";
        }

        public override string HouseType { get; protected set; }
    }
}


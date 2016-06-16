using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.CreationalPatterns.FactoryMethod.metanit.com.Example1
{
    public class WoodenHouseBuilder : HouseBuilder
    {
        public WoodenHouseBuilder(string name) : base(name)
        {
        }

        public override House Create()
        {
            return new WoodenHouse();
        }
    }
}

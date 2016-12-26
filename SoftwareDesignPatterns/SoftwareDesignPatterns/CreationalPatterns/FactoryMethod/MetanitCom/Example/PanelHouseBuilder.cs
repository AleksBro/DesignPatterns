using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.CreationalPatterns.FactoryMethod.MetanitCom.Example
{
    public class PanelHouseBuilder : HouseBuilder
    {
        
        public PanelHouseBuilder(string name) : base(name)
        {
        }


        public override House Create()
        {
            return new PanelHouse();
        }
    }
}

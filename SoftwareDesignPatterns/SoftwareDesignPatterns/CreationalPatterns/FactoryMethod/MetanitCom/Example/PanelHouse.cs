using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.CreationalPatterns.FactoryMethod.MetanitCom.Example
{
    class PanelHouse : House
    {
        public override string HouseType { get; protected set; }

        public PanelHouse()
        {
            this.HouseType = "PanelHouse";
        }

    }
}

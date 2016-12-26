using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.CreationalPatterns.FactoryMethod.MetanitCom.Example
{
    public class UsingExample
    {
        public UsingExample()
        {
            List<House> allHouses = new List<House>();

            HouseBuilder houseBuilder = new WoodenHouseBuilder("OOO WoodIsBest");

            House h1 = houseBuilder.Create();
            allHouses.Add(h1);

            // меняем застройщика:
            houseBuilder = new PanelHouseBuilder("Private Panels");
            allHouses.Add(houseBuilder.Create());

            foreach (var house in allHouses)
            {
                Console.WriteLine(house.HouseType);
            }
        }
    }
}

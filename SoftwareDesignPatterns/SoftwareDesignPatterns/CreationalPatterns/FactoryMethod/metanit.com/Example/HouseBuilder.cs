using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.CreationalPatterns.FactoryMethod.metanit.com.Example1
{
    /// <summary>
    /// абстрактный класс строительной компании
    /// </summary>
    public abstract class HouseBuilder
    {
        public string Name { get; private set; }

        public HouseBuilder(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// фабричный метод
        /// </summary>
        /// <returns></returns>
        public abstract House Create();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoftwareDesignPatterns.CreationalPatterns.FactoryMethod.metanit.com.Example1
{
    /// <summary>
    /// Абстрактный класс дома
    /// </summary>
    public abstract class House
    {
        public abstract string HouseType { get; protected set; }
    }
}

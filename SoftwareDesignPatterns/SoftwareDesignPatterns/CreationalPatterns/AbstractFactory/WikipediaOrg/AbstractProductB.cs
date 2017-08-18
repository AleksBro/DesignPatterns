using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.CreationalPatterns.AbstractFactory.WikipediaOrg
{
    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>
    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareDesignPatterns.CreationalPatterns.AbstractFactory.WikipediaOrg;

namespace ConsoleApps.AbstractFactory_UsingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------------------
            // https://ru.wikipedia.org/wiki/Абстрактная_фабрика_(шаблон_проектирования)
            // ----------------------------------------------------------------------------

            // Abstract factory #1
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

            // Wait for user input
            Console.ReadKey();

            // ----------------------------------------------------------------------------
            // ----------------------------------------------------------------------------
        }
    }
}

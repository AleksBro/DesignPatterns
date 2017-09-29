using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareDesignPatterns.CreationalPatterns.AbstractFactory.WikipediaOrg;
using SoftwareDesignPatterns.CreationalPatterns.AbstractFactory.MetanitCom.Example;

namespace ConsoleApps.AbstractFactory_UsingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
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
            // https://metanit.com/sharp/patterns/2.2.php
            // ----------------------------------------------------------------------------

            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Hero voin = new Hero(new VoinFactory());
            voin.Hit();
            voin.Run();

            Console.ReadLine();

        }
    }
}

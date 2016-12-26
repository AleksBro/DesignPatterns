using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.CreationalPatterns.Builder.MetanitCom.Example
{
    public class UsingExample
    {
        public UsingExample()
        {
            // содаем объект пекаря
            Baker baker = new Baker();

            // создаем билдер для ржаного хлеба
            BreadBuilder builder = new RyeBreadBuilder();

            // выпекаем
            Bread ryeBread = baker.Bake(builder);
            Console.WriteLine(ryeBread.ToString());

            // cоздаем билдер для пшеничного хлеба
            builder = new WheatBreadBuilder();
            Bread wheatBread = baker.Bake(builder);
            Console.WriteLine(wheatBread.ToString());

            Console.Read();
        }
    }




}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.CreationalPatterns.Builder.MetanitCom.Example
{
    class Bread
    {
        // пшеничная мука
        public Flour WheatFlour { get; set; }

        // ржаная мука
        public Flour RyeFlour { get; set; }

        // соль
        public Salt Salt { get; set; }

        // пищевые добавки
        public Additives Additives { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (WheatFlour != null)
                sb.Append("Пшеничная мука " + WheatFlour.Sort + "\n");
            if (RyeFlour != null)
                sb.Append("Ржаная мука " + RyeFlour.Sort + " \n");
            if (Salt != null)
                sb.Append("Соль \n");
            if (Additives != null)
                sb.Append("Добавки: " + Additives.Name + " \n");

            return sb.ToString();
        }
    }
}

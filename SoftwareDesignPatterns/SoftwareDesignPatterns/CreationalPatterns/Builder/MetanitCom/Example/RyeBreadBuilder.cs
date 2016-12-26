using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.CreationalPatterns.Builder.MetanitCom.Example
{
    // строитель для ржаного хлеба
    class RyeBreadBuilder : BreadBuilder
    {
        public override void SetWheatFlour()
        {
            // не используется
        }

        public override void SetRyeFlour()
        {
            this.Bread.RyeFlour = new Flour { Sort = "1 сорт" };
        }

        public override void SetSalt()
        {
            this.Bread.Salt = new Salt();
        }

        public override void SetAdditives()
        {
            // не используется
        }
    }
}

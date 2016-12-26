using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.CreationalPatterns.Builder.MetanitCom.Example
{
    // абстрактный класс строителя
    abstract class BreadBuilder
    {
        public Bread Bread { get; private set; }

        public void CreateBread()
        {
            Bread = new Bread();
        }

        public abstract void SetWheatFlour();

        public abstract void SetRyeFlour();

        public abstract void SetSalt();

        public abstract void SetAdditives();
    }
}

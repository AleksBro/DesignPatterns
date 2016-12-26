using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.CreationalPatterns.Builder.WikipediaOrg
{
    public abstract class Builder
    {
        public virtual void BuildPartA() { }
        public virtual void BuildPartB() { }
        public abstract Product GetResult();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.BehavioralPatterns.ChainOfResponsibility.wikipedia.org
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }
}

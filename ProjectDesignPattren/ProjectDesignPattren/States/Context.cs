using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDesignPattren.States
{
    public class Context
    {
        private IState mystate;

        public Context()
        {
            mystate = new RoughCopy();
        }
        public void ChangeState(IState state)
        {
            Console.WriteLine("changed state");
            mystate = state;
            //mystate.setstate(this);

        }
        public IState GetState()
        {
            return mystate;
        }
    }
}
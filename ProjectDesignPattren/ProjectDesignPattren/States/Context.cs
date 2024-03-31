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
        public Context(IState state)
        {
            this.mystate = state;
        }
        public void SetState(IState state)
        {
            Console.WriteLine("changed state");
            mystate = state;
        }
        public IState GetState()
        {
            return mystate;
        }
        public void changeState()
        {
            this.mystate.changeState(this);
            this.mystate.Print();
        }
    }
}
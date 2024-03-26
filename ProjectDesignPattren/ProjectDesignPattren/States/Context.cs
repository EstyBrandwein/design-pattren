using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDesignPattren.States
{
    public class State
    {
        private IState mystate;

        public State()
        {
            mystate = new RoughCopy();
        }
        public void ChangeState(IState state)
        {
            Console.WriteLine("changed state");
            mystate = state;
            mystate.setstate(this);

        }

        public static void changeState(string v)
        {
            
        }


    }
}
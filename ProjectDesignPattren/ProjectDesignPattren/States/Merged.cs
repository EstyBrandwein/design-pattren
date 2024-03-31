using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDesignPattren.States
{
    public class Merged : IState
    {
        public void changeState(Context state)
        { 
            //state.SetState(new Committed());
        }

        public void Print()
        {
            Console.WriteLine("now you are in the Merged state");
        }
    }
}

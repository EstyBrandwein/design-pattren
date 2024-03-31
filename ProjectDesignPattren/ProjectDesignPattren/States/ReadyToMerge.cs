using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDesignPattren.States
{
    public class ReadyToMerge : IState
    {
        public void changeState(Context state)
        {            
            state.SetState(new Merged());
        }

        public void Print()
        {
            Console.WriteLine("now you are in the Ready To Merge state");
        }
    }
}
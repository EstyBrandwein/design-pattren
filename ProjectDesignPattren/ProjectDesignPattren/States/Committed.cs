using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDesignPattren.States
{
    public class Committed : IState
    {
        public void changeState(Context state)
        {
            state.ChangeState(new UnderReview());
        }

        public void Print()
        {
            Console.WriteLine("now you are in the Committedstate");
        }
    }
}

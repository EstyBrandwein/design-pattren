using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjectDesignPattren
{
    public class State
    {

        public State() { }
        public State state;
        public  void ChangeState()
        {
            throw new NotImplementedException();
        }

        internal static State changeState(string v)
        {
            throw new NotImplementedException();
        }
    }
}
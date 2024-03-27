using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDesignPattren.States;
namespace ProjectDesignPattren.States
{
    public interface IState
    {
        void changeState(Context state);
        public void Print();
    }
}
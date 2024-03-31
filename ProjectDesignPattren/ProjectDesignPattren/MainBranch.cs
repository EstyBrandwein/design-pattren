using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDesignPattren
{
    public sealed class MainBranch : Branch
    {

        private static Branch mainBranch;
        private MainBranch() : base("main")
        {
        }
        public static Branch GetInstance()
        {
            if (mainBranch == null)
            {
                mainBranch = new MainBranch();
            }
            return mainBranch;
        }
    }
}
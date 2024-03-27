using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDesignPattren.Files;
using ProjectDesignPattren.States;

namespace ProjectDesignPattren
{
    public  class Branch
    {
        public List<MyDirectory> listFolders;
        public string name;
        public List<Branch> branches;
        private Context state;
        IState istate;
        public void ChangeState()
        {
            state.ChangeState(istate);
        }
        public Branch creat(string name)
        {
            Branch newbranch = new Branch(name);
            newbranch.listFolders = this.listFolders;
            branches.Add(newbranch);
            return newbranch;
        }
        public Branch(string name)
        {
            this.listFolders = new List<MyDirectory>();
            this.name = name;
            this.branches = new List<Branch>();
            this.state = new Context();
            istate = new RoughCopy();
        }
        public void delete()
        {
            this.listFolders = null;
            this.name = null;
            this.branches = null;
            this.state = null;
            foreach (Branch branch in branches)
            {
                branch.delete();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjectDesignPattren
{
    public class Branch
    {
        public List<folders> listFolders;
        public string name;
        public List<Branch> branches;
        private State state;
        public void ChangeState()
        {
            state.ChangeState();
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
            this.listFolders = new List<folders>();
            this.name = name;
            this.branches = new List<Branch>();
            this.state = new State();
        }
        public void delete()
        {
            this.listFolders = null;
            this.name = null;
            this.branches = null;
            this.state = State.changeState("delete");
            foreach (Branch branch in branches)
            {
                branch.delete();
            }
        }
    }
}

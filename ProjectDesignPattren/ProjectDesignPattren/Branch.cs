using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDesignPattren.Files;
using ProjectDesignPattren.Files_Directory;
using ProjectDesignPattren.Memnto;
using ProjectDesignPattren.States;

namespace ProjectDesignPattren
{
    public class Branch
    {
        public List<MyDirectory> listFolders;
        public string name;
        public List<Branch> branches;
        private Context context;
        //IState istate;
        //Caretaker caretaker;
        public Branch(string name)
        {
            this.listFolders = new List<MyDirectory>();
            this.name = name;
            this.branches = new List<Branch>();
            this.context = new Context(new RoughCopy());
            //istate = new RoughCopy();
        }
        public MyDirectory AddDirectory(MyDirectory myDirectory)
        {
            //caretaker.Backup();
            listFolders.Add(myDirectory);
            return myDirectory;
        }
        public MyDirectory ChangeDirectory(MyDirectory myDirectory)
        {
            int i = 0;
            foreach (var item in listFolders)
            {
                i++;
                if (item.Equals(myDirectory))
                {
                    listFolders[i] = myDirectory;
                }
            }
            return myDirectory;
        }
        public void PrintDirectory()
        {
            foreach (MyDirectory item in listFolders)
            {
                Console.Write("my type is : ");
                Console.WriteLine(item.TypeOfDirectory());

            }
        }  
        public void ChangeState()
        {
            context.changeState();
        }
        public Branch Creat(string branchName, string newBranchName)
        {
            if (this.name == name)
            {
                //caretaker.Backup();
                var branch = new Branch(newBranchName) { branches = new List<Branch>(), listFolders = this.listFolders };
                branches.Add(branch);
                return branch;
            }
            foreach (var item in branches)
            {
                return item.Creat(branchName, newBranchName);
            }
            throw new Exception("there are no branch with this name");

        }
        public void delete()
        {
            //caretaker.Backup();
            this.listFolders = null;
            this.name = null;
            this.branches = null;
            this.context = null;
            foreach (Branch branch in branches)
            {
                branch.delete();
            }
        }

    }
}

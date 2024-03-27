using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDesignPattren.Files
{
    public abstract class MyDirectory
    {
        //abstract public int size();
        abstract public string Type();
        public MyDirectory() {

        }
/*        public virtual bool IsComposite()
        {
            return true;
        }*/
    }
}

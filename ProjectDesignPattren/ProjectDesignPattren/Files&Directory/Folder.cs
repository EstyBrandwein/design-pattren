using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectDesignPattren.Files
{
    public class Folder: MyDirectory
    {
        private List<MyDirectory> _children = new List<MyDirectory>();

        public void Add(MyDirectory c)
        {
            _children.Add(c);
        }
        public override string TypeOfDirectory()
        {
            return "Folder";
        }
        /*        public override int size()
                {
                    int i = 0;
                    int result = 0;

                    foreach (Directory component in this._children)
                    {
                        result += component.size();
                        if (i != this._children.Count - 1)
                        {
                            result++;
                        }
                        i++;
                    }

                    return result;
                }*/
        /*        public override string name()
                {
                    int i = 0;
                    string result = "Branch(";

                    foreach (Directory component in this._children)
                    {
                        result += component.name();
                        if (i != this._children.Count - 1)
                        {
                            result += "\\";
                        }
                        i++;
                    }

                    return result + ")";
                }*/

    }
}

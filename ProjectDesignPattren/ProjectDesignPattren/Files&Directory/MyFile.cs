using ProjectDesignPattren.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDesignPattren.Files_Directory
{
    class MyFile : MyDirectory
    {
        public override string Type()
        {
            return "file";
        }


        //public override bool IsComposite()
        //{
        //    return false;
        //}
    }

}

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
            const string FILENAME = @"..\file1.txt";
            StreamWriter streamWriter = new(FILENAME, true);
            streamWriter.WriteLine("now thre is a file in review");
            streamWriter.Close();

            state.ChangeState(new UnderReview());
        }

        public void Print()
        {
            Console.WriteLine("now you are in the Committedstate");
        }
    }
}

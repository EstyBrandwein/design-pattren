namespace ProjectDesignPattren.States
{
    public class RoughCopy : IState
    {
        public void changeState(Context state)
        {
            state.ChangeState(new Committed());
        }

        public void Print()
        {
            Console.WriteLine("now you are in the Rough Copy state");
        }
    }
}
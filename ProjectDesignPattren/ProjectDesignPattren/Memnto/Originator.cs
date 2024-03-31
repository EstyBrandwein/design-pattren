namespace ProjectDesignPattren.Memnto
{

   public class Originator
    {
        // For the sake of simplicity, the originator's state is stored inside a
        // single variable.
        private string _state;

        public Originator(string state)
        {
            this._state = state;
            Console.WriteLine("Originator: My initial state is: " + state);
        }

        // The Originator's business logic may affect its internal state.
        // Therefore, the client should backup the state before launching
        // methods of the business logic via the save() method.
        public void DoSomething()
        {
            Console.WriteLine("Originator: I'm doing something important.");
            this._state = this.GenerateRandomString(30);
            Console.WriteLine($"Originator: and my state has changed to: {_state}");
        }

        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }

        // Saves the current state inside a memento.
        public IMemento Save()
        {
            return new ConcreteMemento(this._state);
        }

        // Restores the Originator's state from a memento object.
        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            this._state = memento.GetState();
            Console.Write($"Originator: My state has changed to: {_state}");
        }
    }

}
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Client code.
//        Originator originator = new Originator("Super-duper-super-puper-super.");
//        Caretaker caretaker = new Caretaker(originator);

//        caretaker.Backup();
//        originator.DoSomething();

//        caretaker.Backup();
//        originator.DoSomething();

//        caretaker.Backup();
//        originator.DoSomething();

//        Console.WriteLine();
//        caretaker.ShowHistory();

//        Console.WriteLine("\nClient: Now, let's rollback!\n");
//        caretaker.Undo();

//        Console.WriteLine("\n\nClient: Once more!\n");
//        caretaker.Undo();

//        Console.WriteLine();
//    }
//}
//}
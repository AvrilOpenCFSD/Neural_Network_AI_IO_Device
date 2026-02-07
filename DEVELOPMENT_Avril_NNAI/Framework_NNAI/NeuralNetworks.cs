
namespace Avril_NNAI
{
    public class NeuralNetworks
    {
// classes.
        private Avril_NNAI.Global _global;
        private Avril_NNAI.Aglorithms _aglorithms;
        private Avril_NNAI.Data _data;
        private Avril_NNAI.Execute _execute;
// registers.

// constructor.
        public NeuralNetworks()
        {
            System.Console.WriteLine("entered NeuralNetworks.");
            Create_Global();
            Create_Aglorithms();
            Create_Data();
            Create_Execute();
            System.Console.WriteLine("exiting NeuralNetworks.");
        }

// destructor
        ~NeuralNetworks()
        {
            //System.Console.WriteLine("exited NeuralNetworks.");
        }

// public.
    // get.
        public Avril_NNAI.Aglorithms Get_Aglorithms()
        {
            return _aglorithms;
        }
        public Avril_NNAI.Data Get_Data()
        {
            return _data;
        }
        public Avril_NNAI.Execute Get_Execute()
        {
            return _execute;
        }
        public Avril_NNAI.Global Get_Global()
        {
            return _global;
        }
    // set.

// private.
        private void Create_Aglorithms()
        {
            _aglorithms = new Avril_NNAI.Aglorithms();
            while (Get_Aglorithms() == null) { }
        }
        private void Create_Global()
        {
            _global = new Avril_NNAI.Global();
            while (Get_Global() == null) { }
        }
        private void Create_Data()
        {
            _data = new Avril_NNAI.Data();
            while (Get_Data() == null) { }
        }
        private void Create_Execute()
        {
            _execute = new Avril_NNAI.Execute();
            while (Get_Execute() == null) { }
        }
    // get.
    // set.
    }
}

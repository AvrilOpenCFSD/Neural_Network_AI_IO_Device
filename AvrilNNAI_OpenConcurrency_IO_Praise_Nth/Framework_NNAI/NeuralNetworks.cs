
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
            //System.Console.WriteLine("entered NeuralNetworks.");
            Create_Global(new Avril_NNAI.Global());
            while (Get_Global() == null) { }

            Create_Aglorithms(new Avril_NNAI.Aglorithms());
            while (Get_Aglorithms() == null) { }

            Create_Data(new Avril_NNAI.Data());
            while (Get_Data() == null) { }

            Create_Execute(new Avril_NNAI.Execute());
            while (Get_Execute() == null) { }
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
        private void Create_Aglorithms(Avril_NNAI.Aglorithms aglorithms)
        {
            _aglorithms = aglorithms;
        }
        private void Create_Global(Avril_NNAI.Global global)
        {
            _global = global;
        }
        private void Create_Data(Avril_NNAI.Data data)
        {
            _data = data;
        }
        private void Create_Execute(Avril_NNAI.Execute execute)
        {
            _execute = execute;
        }
    // get.
    // set.
    }
}

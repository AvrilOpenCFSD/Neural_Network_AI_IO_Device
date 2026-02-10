
namespace OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1
{
    public class NeuralNetworks
    {
// classes.
        private Global _global;
        private Aglorithms _aglorithms;
        private Data _data;
        private Execute _execute;
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
        public Aglorithms Get_Aglorithms()
        {
            return _aglorithms;
        }
        public Data Get_Data()
        {
            return _data;
        }
        public Execute Get_Execute()
        {
            return _execute;
        }
        public Global Get_Global()
        {
            return _global;
        }
    // set.

// private.
        private void Create_Aglorithms()
        {
            _aglorithms = new Aglorithms();
            while (Get_Aglorithms() == null) { }
        }
        private void Create_Global()
        {
            _global = new Global();
            while (Get_Global() == null) { }
        }
        private void Create_Data()
        {
            _data = new Data();
            while (Get_Data() == null) { }
        }
        private void Create_Execute()
        {
            _execute = new Execute();
            while (Get_Execute() == null) { }
        }
    // get.
    // set.
    }
}

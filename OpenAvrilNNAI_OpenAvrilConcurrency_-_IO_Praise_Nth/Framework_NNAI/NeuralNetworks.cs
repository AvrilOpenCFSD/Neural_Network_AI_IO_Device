
namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class NeuralNetworks
    {
// classes.
        private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global _global;
        private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Aglorithms _aglorithms;
        private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Data _data;
        private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Execute _execute;
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
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Aglorithms Get_Aglorithms()
        {
            return _aglorithms;
        }
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Data Get_Data()
        {
            return _data;
        }
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Execute Get_Execute()
        {
            return _execute;
        }
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global Get_Global()
        {
            return _global;
        }
    // set.

// private.
        private void Create_Aglorithms()
        {
            _aglorithms = new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Aglorithms();
            while (Get_Aglorithms() == null) { }
        }
        private void Create_Global()
        {
            _global = new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global();
            while (Get_Global() == null) { }
        }
        private void Create_Data()
        {
            _data = new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Data();
            while (Get_Data() == null) { }
        }
        private void Create_Execute()
        {
            _execute = new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Execute();
            while (Get_Execute() == null) { }
        }
    // get.
    // set.
    }
}

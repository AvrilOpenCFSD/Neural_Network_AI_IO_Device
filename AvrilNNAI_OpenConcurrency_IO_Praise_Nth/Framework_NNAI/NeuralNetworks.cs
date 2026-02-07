
namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class NeuralNetworks
    {
// classes.
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Global _global;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Aglorithms _aglorithms;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Data _data;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Execute _execute;
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
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Aglorithms Get_Aglorithms()
        {
            return _aglorithms;
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Data Get_Data()
        {
            return _data;
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Execute Get_Execute()
        {
            return _execute;
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Global Get_Global()
        {
            return _global;
        }
    // set.

// private.
        private void Create_Aglorithms()
        {
            _aglorithms = new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Aglorithms();
            while (Get_Aglorithms() == null) { }
        }
        private void Create_Global()
        {
            _global = new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Global();
            while (Get_Global() == null) { }
        }
        private void Create_Data()
        {
            _data = new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Data();
            while (Get_Data() == null) { }
        }
        private void Create_Execute()
        {
            _execute = new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Execute();
            while (Get_Execute() == null) { }
        }
    // get.
    // set.
    }
}

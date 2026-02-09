
namespace OpenAvrilNNI
{
    public class NeuralNetworks
    {
// classes.
        private OpenAvrilNNI.Global _global;
        private OpenAvrilNNI.Aglorithms _aglorithms;
        private OpenAvrilNNI.Data _data;
        private OpenAvrilNNI.Execute _execute;
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
        public OpenAvrilNNI.Aglorithms Get_Aglorithms()
        {
            return _aglorithms;
        }
        public OpenAvrilNNI.Data Get_Data()
        {
            return _data;
        }
        public OpenAvrilNNI.Execute Get_Execute()
        {
            return _execute;
        }
        public OpenAvrilNNI.Global Get_Global()
        {
            return _global;
        }
    // set.

// private.
        private void Create_Aglorithms()
        {
            _aglorithms = new OpenAvrilNNI.Aglorithms();
            while (Get_Aglorithms() == null) { }
        }
        private void Create_Global()
        {
            _global = new OpenAvrilNNI.Global();
            while (Get_Global() == null) { }
        }
        private void Create_Data()
        {
            _data = new OpenAvrilNNI.Data();
            while (Get_Data() == null) { }
        }
        private void Create_Execute()
        {
            _execute = new OpenAvrilNNI.Execute();
            while (Get_Execute() == null) { }
        }
    // get.
    // set.
    }
}

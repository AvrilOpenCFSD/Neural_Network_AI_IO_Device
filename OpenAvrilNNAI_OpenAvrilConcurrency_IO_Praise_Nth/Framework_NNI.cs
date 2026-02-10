
namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class Framework_NNI
    {
// classes.
        private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.NeuralNetworks _neuralNetwork;

// registers.

// constructor.
        public Framework_NNI()
        {
            System.Console.WriteLine("entered Framework_NNI.");
            Create_NeuralNetworks();
        }

// destructor.
        ~Framework_NNI()
        {
            //System.Console.WriteLine("exited Framework_NNI.");
        }

// public.
        public void Initialise(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj)
        {
            obj.Get_Neural_Networks().Get_Execute().Create_And_Run_UI();
        }
    // get.
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.NeuralNetworks Get_Neural_Networks()
        {
            return _neuralNetwork;
        }
    // set.

// private.
        private void Create_NeuralNetworks()
        {
            _neuralNetwork = new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.NeuralNetworks();
            while(Get_Neural_Networks() == null) { }
        }
    // get.
    // set.
    }
}

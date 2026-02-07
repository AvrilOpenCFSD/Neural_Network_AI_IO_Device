
namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class Framework_NNAI
    {
// classes.
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.NeuralNetworks _neuralNetwork;

// registers.

// constructor.
        public Framework_NNAI()
        {
            System.Console.WriteLine("entered Framework_NNAI.");
            Create_NeuralNetworks();
        }

// destructor.
        ~Framework_NNAI()
        {
            //System.Console.WriteLine("exited Framework_NNAI.");
        }

// public.
        public void Initialise(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Framework_NNAI obj)
        {
            obj.Get_Neural_Networks().Get_Execute().Create_And_Run_UI();
        }
    // get.
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.NeuralNetworks Get_Neural_Networks()
        {
            return _neuralNetwork;
        }
    // set.

// private.
        private void Create_NeuralNetworks()
        {
            _neuralNetwork = new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.NeuralNetworks();
            while(Get_Neural_Networks() == null) { }
        }
    // get.
    // set.
    }
}

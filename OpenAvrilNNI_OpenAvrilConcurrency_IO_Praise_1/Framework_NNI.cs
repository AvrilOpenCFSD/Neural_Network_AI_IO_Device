
namespace OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1
{
    public class Framework_NNI
    {
// classes.
        private NeuralNetworks _neuralNetwork;

// registers.

// constructor.
        public Framework_NNI()
        {
            Console.WriteLine("entered Framework_NNI.");
            Create_NeuralNetworks();
        }

// destructor.
        ~Framework_NNI()
        {
            //System.Console.WriteLine("exited Framework_NNI.");
        }

// public.
        public void Initialise(Framework_NNI obj)
        {
            obj.Get_Neural_Networks().Get_Execute().Create_And_Run_UI();
        }
    // get.
        public NeuralNetworks Get_Neural_Networks()
        {
            return _neuralNetwork;
        }
    // set.

// private.
        private void Create_NeuralNetworks()
        {
            _neuralNetwork = new NeuralNetworks();
            while(Get_Neural_Networks() == null) { }
        }
    // get.
    // set.
    }
}

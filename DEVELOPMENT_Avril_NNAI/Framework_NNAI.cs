
namespace Avril_NNAI
{
    public class Framework_NNAI
    {
// classes.
        private Avril_NNAI.NeuralNetworks _neuralNetwork;
        private Avril_NNAI.SIMULATION _simulation;

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
        public void Initialise(Avril_NNAI.Framework_NNAI obj)
        {
            obj.Get_Neural_Networks().Get_Execute().Create_And_Run_UI();
        }
    // get.
        public Avril_NNAI.NeuralNetworks Get_Neural_Networks()
        {
            return _neuralNetwork;
        }
    // set.

// private.
        private void Create_NeuralNetworks()
        {
            _neuralNetwork = new Avril_NNAI.NeuralNetworks();
            while(Get_Neural_Networks() == null) { }
        }
    // get.
    // set.
    }
}

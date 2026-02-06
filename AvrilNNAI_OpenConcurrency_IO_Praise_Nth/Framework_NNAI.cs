
namespace Avril_NNAI
{
    public class Framework_NNAI
    {
// classes.
        private Avril_NNAI.NeuralNetworks _neuralNetwork;

// registers.

// constructor.
        public Framework_NNAI()
        {
            //System.Console.WriteLine("entered Framework_NNAI.");
            Create_NeuralNetworks(new Avril_NNAI.NeuralNetworks());
            while (Get_Neural_Networks() == null) { }
        }

// destructor.
        ~Framework_NNAI()
        {
            //System.Console.WriteLine("exited Framework_NNAI.");
        }

// public.
    // get.
        public Avril_NNAI.NeuralNetworks Get_Neural_Networks()
        {
            return _neuralNetwork;
        }
    // set.

// private.
        private void Create_NeuralNetworks(Avril_NNAI.NeuralNetworks neuralNetwork)
        {
            _neuralNetwork = neuralNetwork;
        }
    // get.
    // set.
    }
}


namespace Avril_NNAI
{
    public class Framework_NNAI
    {
        private Avril_NNAI.NeuralNetworks _neuralNetwork;

        public Framework_NNAI()
        {
            Set_NeuralNetworks(new Avril_NNAI.NeuralNetworks());
            while (Get_Neural_Networks() == null) { }
        }

        public void Initialise(Avril_NNAI.Framework_NNAI obj)
        {
            obj.Get_Neural_Networks().Get_Execute().Create_And_Run_UI();
        }

        public Avril_NNAI.NeuralNetworks Get_Neural_Networks()
        {
            return _neuralNetwork;
        }

        private void Set_NeuralNetworks(Avril_NNAI.NeuralNetworks neuralNetwork)
        {
            _neuralNetwork = neuralNetwork;
        }
    }
}

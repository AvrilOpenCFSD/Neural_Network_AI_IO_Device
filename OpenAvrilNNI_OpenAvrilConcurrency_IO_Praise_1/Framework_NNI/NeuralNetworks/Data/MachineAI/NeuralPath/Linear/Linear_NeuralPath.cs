
namespace OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1
{
    public class Linear_NeuralPath
    {
// classes.

// registers.
        private double _bias;
        private double _weight;

// constructor.
        public Linear_NeuralPath() 
        { 
            //System.Console.WriteLine("entered Linear.");
            Create_Bias();
            Create_Weight();
            //System.Console.WriteLine("exiting Linear.");
        }

// destructor.
        ~Linear_NeuralPath()
        {

        }

// public.
    // get.
        public double Get_Bias()
        {
            return _bias;
        }
        public double Get_Weight()
        {
            return _weight;
        }
    // set.
        public void Set_Bias(double newBias)
        {
            _bias = newBias;
        }
        public void Set_Weight(double newWeight)
        {
            _weight = newWeight;
        }

// private.
        private void Create_Bias()
        {
            _bias = new double();
            Set_Bias(0.0);
        }
        private void Create_Weight()
        {
            _weight = new double();
            Set_Weight(0.0);
        }
// get.
// set.
    }
}
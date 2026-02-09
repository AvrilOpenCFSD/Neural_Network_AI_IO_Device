
namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class Linear
    {
// classes.

// registers.
        private double _bias;
        private double _weight;

// constructor.
        public Linear()
        {
            //System.Console.WriteLine("entered Linear.");
            Create_Bias();
            Create_Weight();
            //System.Console.WriteLine("exiting Linear.");
        }

// destructor.
        ~Linear()
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
    // set
    }
}

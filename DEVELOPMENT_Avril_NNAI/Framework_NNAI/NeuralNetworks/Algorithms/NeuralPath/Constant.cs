
namespace Avril_NNAI
{
    public class Constant
    {
// definitions.

// classes.

// registers.
        private double _constant_REGISTERED_Output;

// constructor.
        public Constant()
        {
            //System.Console.WriteLine("entered Constant.");
            Create_Constant_REGISTERED_Output();
            //System.Console.WriteLine("exiting Constant.");
        }

// destructor.
        ~Constant()
        {

        }

// public.
    // get.
        public double Get_Constant_REGISTERED_Output()
        {
            return _constant_REGISTERED_Output;
        }
    // set.
        public void Set_Constant_REGISTERED_Output(double newConstant)
        {
            _constant_REGISTERED_Output = newConstant;
        }
        
// private.
        private void Create_Constant_REGISTERED_Output()
        {
            _constant_REGISTERED_Output = new double();
            Set_Constant_REGISTERED_Output(0.0);
        }   
    // get.
    // set
    }
}

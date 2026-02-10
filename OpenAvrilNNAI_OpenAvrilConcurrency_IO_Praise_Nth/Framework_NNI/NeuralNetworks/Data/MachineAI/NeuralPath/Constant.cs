namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class Constant
    {
// definitions.

// classes.

// registers.
        private double _constant;

// constructor.
        public Constant()
        {
            //System.Console.WriteLine("entered Constant.");
            Create_Constant();
            //System.Console.WriteLine("exiting Constant.");
        }

// destructor.
        ~Constant()
        {

        }

// public.
    // get.
        public double Get_Constant()
        {
            return _constant;
        }
    // set.
        public void Set_Constant(double newConstant)
        {
            _constant = newConstant;
        }
        
// private.
        private void Create_Constant()
        {
            _constant = new double();
            Set_Constant(0.0);
        }   
    // get.
    // set
    }
}

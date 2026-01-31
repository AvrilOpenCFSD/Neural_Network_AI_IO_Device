
using System;

namespace Avril_NNAI
{
    public class NeuralPath
    {
// classes.
        private Avril_NNAI.Linear _New_Linear;
            
// registers.

// constructor.
        public NeuralPath() 
        {
            //System.Console.WriteLine("entered NeuralPath.");
            Create_New_Linear(new Avril_NNAI.Linear());
            while (Get_New_Linear() == null) { }
            //System.Console.WriteLine("exiting NeuralPath.");
        }

// destructor
        ~NeuralPath()
        {

        }

// public.
        public double Generate_Initial_Random_Small_Value(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    // get.
        public Avril_NNAI.Linear Get_New_Linear()
        {
            return _New_Linear;
        }
    // set.

// private.
        private void Create_New_Linear(Avril_NNAI.Linear linear)
        {
            _New_Linear = linear;
        }
    // get.

    // set.
    }
}

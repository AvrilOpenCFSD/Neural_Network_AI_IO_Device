
namespace OpenAvrilNNI
{
    public class Linear
    {
// classes.
        private PraiseSet _praiseSet;

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
        public PraiseSet Get_PraiseSet()
        {
            return _praiseSet;
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
        private void Create_PraiseSet()
        {
            Set_PraiseSet(new PraiseSet());
            while (Get_PraiseSet() == null) { }
        }
    // get.
    // set
        private void Set_PraiseSet(PraiseSet newPraiseSet)
        {
            _praiseSet = newPraiseSet;
        }
    }
}


namespace OpenAvrilNNI
{
    public class Linear
    {
// classes.
        private PraiseSet _praiseSet;

// registers.


// constructor.
        public Linear()
        {
            //System.Console.WriteLine("entered Linear.");
            Create_PraiseSet();
            //System.Console.WriteLine("exiting Linear.");
        }

// destructor.
        ~Linear()
        {

        }

// public.
    // get.
        public PraiseSet Get_PraiseSet()
        {
            return _praiseSet;
        }
    // set.

// private.
        private void Create_PraiseSet()
        {
            Set_PraiseSet(new OpenAvrilNNI.PraiseSet());
            while (Get_PraiseSet() == null) { }
        }
    // get.
    // set
        private void Set_PraiseSet(OpenAvrilNNI.PraiseSet newPraiseSet)
        {
            _praiseSet = newPraiseSet;
        }
    }
}

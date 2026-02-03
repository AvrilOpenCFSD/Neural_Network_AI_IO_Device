
namespace Avril_NNAI
{
    public class MachineAI
    {
// classes.
        private Avril_NNAI.MetaData _metaData;
        private Avril_NNAI.PraiseSet _praiseSet;

// registers.


// constructor.
        public MachineAI()
        {
            //System.Console.WriteLine("entered MachineAI.");
            Create_MetaData(new Avril_NNAI.MetaData());
            while (Get_MetaData() == null) { }
            //System.Console.WriteLine("ALPHA.");

        }

// destructor.
        ~MachineAI()
        {
        }

// public.
    // get.
        public Avril_NNAI.MetaData Get_MetaData()
        {
            return _metaData;
        }


    // set.
        
// private.
        private void Create_MetaData(Avril_NNAI.MetaData value)
        {
            _metaData = value;
        }

    // get.
        
    // set.
        private void Set_MetaData(Avril_NNAI.MetaData metaData)
        {
            _metaData = metaData;
        }

    }
}

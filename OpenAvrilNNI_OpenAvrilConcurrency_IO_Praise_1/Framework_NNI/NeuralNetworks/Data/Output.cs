
namespace OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1
{
    public class Output
    {
// classes.
        private Output_Praise_1 _Output_Praise_1;

// registers.

// constructor.
        public Output()
        {
            //System.Console.WriteLine("entered Output.");
            Create_Output_Praise_1();
            while (Get_Output_Praise_1() == null) { }
        }

// destructor.
        ~Output() 
        {
        
        }

// public.
    // get.
        public Output_Praise_1 Get_Output_Praise_1()
        {
            return _Output_Praise_1;
        }
    // set.

// private.
        private void Create_Output_Praise_1()
        {
            Set_Output_Praise_1(new Output_Praise_1());
        }
    // get.
    // set.
        private void Set_Output_Praise_1(Output_Praise_1 newPraise)
        {
            _Output_Praise_1 = newPraise;
        }
    }
}

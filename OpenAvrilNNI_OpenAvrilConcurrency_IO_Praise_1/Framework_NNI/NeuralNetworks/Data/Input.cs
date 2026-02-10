
namespace OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1
{
    public class Input
    {
// classes.
        private Input_Praise_1 _Input_Praise_1;

// registers.        

// constructor.
        public Input()
        {
            //System.Console.WriteLine("entered Input.");
            Create_Input_Praise_1();
        }

// destructor.
        ~Input()
        {
        }

// public.
    // get.
        public Input_Praise_1 Get_Input_Praise_1()
        {
            return _Input_Praise_1;
        }
    // set.

// private.
        private void Create_Input_Praise_1()
        {
            Set_Input_Praise_1(new Input_Praise_1());
            while (Get_Input_Praise_1() == null) { }
        }
    // get.
    // set.
        private void Set_Input_Praise_1(Input_Praise_1 praiseInputSubset)
        {
            _Input_Praise_1 = praiseInputSubset;
        }
    }
}

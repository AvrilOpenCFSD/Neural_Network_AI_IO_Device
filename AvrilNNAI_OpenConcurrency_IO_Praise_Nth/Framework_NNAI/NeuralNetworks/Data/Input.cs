
namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class Input
    {
// classes.
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input_Praise_0 _Input_Praise_0;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input_Praise_1 _Input_Praise_1;
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input_Praise_2 _Input_Praise_2;

// registers.        
        private Object[] _List_Of_Input_Subsets;

// constructor.
        public Input()
        {
            //System.Console.WriteLine("entered Input.");
            Create_List_Of_Input_Subsets(3);
            Create_Input_Praise_0();
            Create_Input_Praise_1();
            Create_Input_Praise_2();
        }

// destructor.
        ~Input()
        {
        }

// public.
    // get.
        public Object Get_Item_On_List_Of_Input_Subsets(ulong praiseID)
        {
            return _List_Of_Input_Subsets[praiseID];
        }
    // set.

// private.
        private void Create_List_Of_Input_Subsets(ulong praiseIDcount)
        {
            _List_Of_Input_Subsets = new Object[praiseIDcount];
            while (Get_List_Of_Input_Subsets() == null) { }
        }
        private void Create_Input_Praise_0()
        {
            _Input_Praise_0 = new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input_Praise_0();
            while (Get_Input_Praise_0() == null) { }
            Set_Item_On_List_Of_Input_Subsets(Get_Input_Praise_0());
        }
        private void Create_Input_Praise_1()
        {
            _Input_Praise_1 = new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input_Praise_1();
            while (Get_Input_Praise_1() == null) { }
            Set_Item_On_List_Of_Input_Subsets(Get_Input_Praise_1());
        }
        private void Create_Input_Praise_2()
        {
            _Input_Praise_2 = new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input_Praise_2();
            while (Get_Input_Praise_2() == null) { }
            Set_Item_On_List_Of_Input_Subsets(Get_Input_Praise_2());
        }

    // get.
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input_Praise_0 Get_Input_Praise_0()
        {
            return _Input_Praise_0;
        }
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input_Praise_1 Get_Input_Praise_1()
        {
            return _Input_Praise_1;
        }
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input_Praise_2 Get_Input_Praise_2()
        {
            return _Input_Praise_2;
        }
        private Object[] Get_List_Of_Input_Subsets()
        {
            return _List_Of_Input_Subsets;
        }
    // set.
        private void Set_Item_On_List_Of_Input_Subsets(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input_Praise_0 praiseInputSubset)
        {
            _List_Of_Input_Subsets[0] = (Object)praiseInputSubset;
        }
        private void Set_Item_On_List_Of_Input_Subsets(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input_Praise_1 praiseInputSubset)
        {
            _List_Of_Input_Subsets[1] = (Object)praiseInputSubset;
        }
        private void Set_Item_On_List_Of_Input_Subsets(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Input_Praise_2 praiseInputSubset)
        {
            _List_Of_Input_Subsets[2] = (Object)praiseInputSubset;
        }
    }
}

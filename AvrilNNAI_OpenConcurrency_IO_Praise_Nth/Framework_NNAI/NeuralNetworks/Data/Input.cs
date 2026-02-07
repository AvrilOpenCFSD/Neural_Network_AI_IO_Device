namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class Input
    {
// classes.
        private Input_Praise_0 _Input_Praise_0;
        private Input_Praise_1 _Input_Praise_1;
        private Input_Praise_2 _Input_Praise_2;

// registers.        
        private object[] _ListOfInputSubsets;

// constructor.
        public Input()
        {
            //System.Console.WriteLine("entered Input.");
            Create_ListOfInputSubsets(new object[3]);

            Create_Input_Praise_0(new Input_Praise_0());
            while (Get_Input_Praise_0() == null) { }
            Set_ListOfInputSubsets(0, Get_Input_Praise_0());

            Create_Input_Praise_1(new Input_Praise_1());
            while (Get_Input_Praise_1() == null) { }
            Set_ListOfInputSubsets(1, Get_Input_Praise_1());

            Create_Input_Praise_2(new Input_Praise_2());
            while (Get_Input_Praise_2() == null) { }
            Set_ListOfInputSubsets(2, Get_Input_Praise_2());
        }

// destructor.
        ~Input()
        {
        }

// public.
    // get.
        public object Get_ItemOnListOfInputSubsets(ulong praiseID)
        {
            return _ListOfInputSubsets[praiseID];
        }
    // set.

// private.
        private void Create_ListOfInputSubsets(object[] listOfInputSubsets)
        {
            _ListOfInputSubsets = listOfInputSubsets;
        }
        private void Create_Input_Praise_0(Input_Praise_0 input_Praise_0)
        {
            _Input_Praise_0 = input_Praise_0;
        }
        private void Create_Input_Praise_1(Input_Praise_1 input_Praise_1)
        {
            _Input_Praise_1 = input_Praise_1;
        }
        private void Create_Input_Praise_2(Input_Praise_2 input_Praise_2)
        {
            _Input_Praise_2 = input_Praise_2;
        }

    // get.
        private Input_Praise_0 Get_Input_Praise_0()
        {
            return _Input_Praise_0;
        }
        private Input_Praise_1 Get_Input_Praise_1()
        {
            return _Input_Praise_1;
        }
        private Input_Praise_2 Get_Input_Praise_2()
        {
            return _Input_Praise_2;
        }

    // set.
        private void Set_ListOfInputSubsets(ulong praiseID, Input_Praise_0 praiseInputSubset)
        {
            _ListOfInputSubsets[praiseID] = praiseInputSubset;
        }
        private void Set_ListOfInputSubsets(ulong praiseID, Input_Praise_1 praiseInputSubset)
        {
            _ListOfInputSubsets[praiseID] = praiseInputSubset;
        }
        private void Set_ListOfInputSubsets(ulong praiseID, Input_Praise_2 praiseInputSubset)
        {
            _ListOfInputSubsets[praiseID] = praiseInputSubset;
        }
    }
}

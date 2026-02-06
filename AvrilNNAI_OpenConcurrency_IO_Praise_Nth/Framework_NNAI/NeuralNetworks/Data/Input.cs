
namespace Avril_NNAI
{
    public class Input
    {
// classes.
        private Avril_NNAI.Input_Praise_0 _Input_Praise_0;
        private Avril_NNAI.Input_Praise_1 _Input_Praise_1;
        private Avril_NNAI.Input_Praise_2 _Input_Praise_2;

// registers.        
        private Object[] _ListOfInputSubsets;

// constructor.
        public Input()
        {
            //System.Console.WriteLine("entered Input.");
            Create_ListOfInputSubsets(new Object[3]);

            Create_Input_Praise_0(new Avril_NNAI.Input_Praise_0());
            while (Get_Input_Praise_0() == null) { }
            Set_ListOfInputSubsets(0, Get_Input_Praise_0());

            Create_Input_Praise_1(new Avril_NNAI.Input_Praise_1());
            while (Get_Input_Praise_1() == null) { }
            Set_ListOfInputSubsets(1, Get_Input_Praise_1());

            Create_Input_Praise_2(new Avril_NNAI.Input_Praise_2());
            while (Get_Input_Praise_2() == null) { }
            Set_ListOfInputSubsets(2, Get_Input_Praise_2());
        }

// destructor.
        ~Input()
        {
        }

// public.
    // get.
        public Object Get_ItemOnListOfInputSubsets(ulong praiseID)
        {
            return _ListOfInputSubsets[praiseID];
        }
    // set.

// private.
        private void Create_ListOfInputSubsets(Object[] listOfInputSubsets)
        {
            _ListOfInputSubsets = listOfInputSubsets;
        }
        private void Create_Input_Praise_0(Avril_NNAI.Input_Praise_0 input_Praise_0)
        {
            _Input_Praise_0 = input_Praise_0;
        }
        private void Create_Input_Praise_1(Avril_NNAI.Input_Praise_1 input_Praise_1)
        {
            _Input_Praise_1 = input_Praise_1;
        }
        private void Create_Input_Praise_2(Avril_NNAI.Input_Praise_2 input_Praise_2)
        {
            _Input_Praise_2 = input_Praise_2;
        }

    // get.
        private Avril_NNAI.Input_Praise_0 Get_Input_Praise_0()
        {
            return _Input_Praise_0;
        }
        private Avril_NNAI.Input_Praise_1 Get_Input_Praise_1()
        {
            return _Input_Praise_1;
        }
        private Avril_NNAI.Input_Praise_2 Get_Input_Praise_2()
        {
            return _Input_Praise_2;
        }

    // set.
        private void Set_ListOfInputSubsets(ulong praiseID, Avril_NNAI.Input_Praise_0 praiseInputSubset)
        {
            _ListOfInputSubsets[praiseID] = (Object)praiseInputSubset;
        }
        private void Set_ListOfInputSubsets(ulong praiseID, Avril_NNAI.Input_Praise_1 praiseInputSubset)
        {
            _ListOfInputSubsets[praiseID] = (Object)praiseInputSubset;
        }
        private void Set_ListOfInputSubsets(ulong praiseID, Avril_NNAI.Input_Praise_2 praiseInputSubset)
        {
            _ListOfInputSubsets[praiseID] = (Object)praiseInputSubset;
        }
    }
}

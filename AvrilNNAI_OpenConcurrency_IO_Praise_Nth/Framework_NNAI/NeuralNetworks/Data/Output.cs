
namespace Avril_NNAI
{
    public class Output
    {
// classes.
        private Avril_NNAI.Output_Praise_0 _Output_Praise_0;
        private Avril_NNAI.Output_Praise_1 _Output_Praise_1;
        private Avril_NNAI.Output_Praise_2 _Output_Praise_2;

// registers.
        private Object[] _ListOfOutputSubsets;

// constructor.
        public Output()
        {
            //System.Console.WriteLine("entered Output.");
            _ListOfOutputSubsets = new Object[3];
            
            Create_Output_Praise_0(new Avril_NNAI.Output_Praise_0());
            while (Get_Output_Praise_0() == null) { }
            Set_ListOfOutputSubsets(0, Get_Output_Praise_0());

            Create_Output_Praise_1(new Avril_NNAI.Output_Praise_1());
            while (Get_Output_Praise_1() == null) { }
            Set_ListOfOutputSubsets(1, Get_Output_Praise_1());

            Create_Output_Praise_2(new Avril_NNAI.Output_Praise_2());
            while (Get_Output_Praise_2() == null) { }
            Set_ListOfOutputSubsets(2, Get_Output_Praise_2());
        }

// destructor.
        ~Output() 
        {
        
        }

// public.
    // get.
        public Object Get_ItemOnListOfOutputSubsets(ulong praiseID)
        {
            return _ListOfOutputSubsets[praiseID];
        }
    // set.

// private.
        private void Create_Output_Praise_0(Avril_NNAI.Output_Praise_0 output_Praise_0)
        {
            _Output_Praise_0 = output_Praise_0;
        }

        private void Create_Output_Praise_1(Avril_NNAI.Output_Praise_1 output_Praise_1)
        {
            _Output_Praise_1 = output_Praise_1;
        }

        private void Create_Output_Praise_2(Avril_NNAI.Output_Praise_2 output_Praise_2)
        {
            _Output_Praise_2 = output_Praise_2;
        }
    // get.
        private Avril_NNAI.Output_Praise_0 Get_Output_Praise_0()
        {
            return _Output_Praise_0;
        }

        private Avril_NNAI.Output_Praise_1 Get_Output_Praise_1()
        {
            return _Output_Praise_1;
        }

        private Avril_NNAI.Output_Praise_2 Get_Output_Praise_2()
        {
            return _Output_Praise_2;
        }
        
    // set.
        private void Set_ListOfOutputSubsets(ulong praiseID, Avril_NNAI.Output_Praise_0 praiseOutputSubset)
        {
            _ListOfOutputSubsets[praiseID] = (Object)praiseOutputSubset;
        }
        private void Set_ListOfOutputSubsets(ulong praiseID, Avril_NNAI.Output_Praise_1 praiseOutputSubset)
        {
            _ListOfOutputSubsets[praiseID] = (Object)praiseOutputSubset;
        }

        private void Set_ListOfOutputSubsets(ulong praiseID, Avril_NNAI.Output_Praise_2 praiseOutputSubset)
        {
            _ListOfOutputSubsets[praiseID] = (Object)praiseOutputSubset;
        }
    }
}

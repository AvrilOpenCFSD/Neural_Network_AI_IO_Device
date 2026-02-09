
namespace OpenAvrilNNI
{
    public class SolutionLogic
    {
// classes.
        private OpenAvrilNNI.Algorithm_Praise_0 _Algorithm_Praise_0;
        private OpenAvrilNNI.Algorithm_Praise_1 _Algorithm_Praise_1;
        private OpenAvrilNNI.Algorithm_Praise_2 _Algorithm_Praise_2;

// registers.    
        private Object[] _ListOfAlgorithmSubsets;

// constructor.
        public SolutionLogic() 
        { 
            Create_ListOfAlgorithmSubsets((byte)3);
            Create_Algorithm_Praise_0();
            Create_Algorithm_Praise_1();
            Create_Algorithm_Praise_2();
        }

// destructor
        ~SolutionLogic() 
        { 
        
        }

// public.
    // get.
        public Object Get_ItemOnListOfAlgorithmSubsets(byte praiseID)
        {
            return _ListOfAlgorithmSubsets[praiseID];
        }
    // set.

// private.
        private void Create_Algorithm_Praise_0()
        {
            _Algorithm_Praise_0 = new OpenAvrilNNI.Algorithm_Praise_0();
            while (Get_Algorithm_Praise_0() == null) { }
            Set_ListOfAlgorithmSubsets(0, (object)Get_Algorithm_Praise_0());
        }
        private void Create_Algorithm_Praise_1()
        {
            _Algorithm_Praise_1 = new OpenAvrilNNI.Algorithm_Praise_1();
            while (Get_Algorithm_Praise_1() == null) { }
            Set_ListOfAlgorithmSubsets(1, (object)Get_Algorithm_Praise_1());
        }
        private void Create_Algorithm_Praise_2()
        {
            _Algorithm_Praise_2 = new OpenAvrilNNI.Algorithm_Praise_2();
            while (Get_Algorithm_Praise_2() == null) { }
            Set_ListOfAlgorithmSubsets(2, (object)Get_Algorithm_Praise_2());
        }
        private void Create_ListOfAlgorithmSubsets(byte praiseIDcount)
        {
            _ListOfAlgorithmSubsets = new Object[praiseIDcount];
            while (Get_List_Of_Algorithms() == null) { }
            for (byte index = 0; index < praiseIDcount; index++) 
            {
                Set_ListOfAlgorithmSubsets(index, null);
            }
        }
    // get.
        private OpenAvrilNNI.Algorithm_Praise_0 Get_Algorithm_Praise_0()
        {
            return _Algorithm_Praise_0;
        }
        private OpenAvrilNNI.Algorithm_Praise_1 Get_Algorithm_Praise_1()
        {
            return _Algorithm_Praise_1;
        }
        private OpenAvrilNNI.Algorithm_Praise_2 Get_Algorithm_Praise_2()
        {
            return _Algorithm_Praise_2;
        }
        private Object[] Get_List_Of_Algorithms()
        {
            return _ListOfAlgorithmSubsets;
        }
    // set.
        private void Set_ListOfAlgorithmSubsets(byte praiseID, Object newAlgorithmSubset)
        {
            _ListOfAlgorithmSubsets[praiseID] = newAlgorithmSubset;
        }
    }
}

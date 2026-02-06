
namespace Avril_NNAI
{
    public class SolutionLogic
    {
// classes.
        private Avril_NNAI.Algorithm_Praise_0 _Algorithm_Praise_0;
        private Avril_NNAI.Algorithm_Praise_1 _Algorithm_Praise_1;
        private Avril_NNAI.Algorithm_Praise_2 _Algorithm_Praise_2;

// registers.    
        private Object[] _ListOfAlgorithmSubsets;

// constructor.
        public SolutionLogic() 
        { 
            Create_ListOfAlgorithmSubsets(new Object[3]);

            Create_Algorithm_Praise_0(new Avril_NNAI.Algorithm_Praise_0());
            while (Get_Algorithm_Praise_0() == null) { }
            Set_ListOfAlgorithmSubsets(0, (object)Get_Algorithm_Praise_0());

            Create_Algorithm_Praise_1(new Avril_NNAI.Algorithm_Praise_1());
            while (Get_Algorithm_Praise_1() == null) { }
            Set_ListOfAlgorithmSubsets(1, (object)Get_Algorithm_Praise_1());

            Create_Algorithm_Praise_2(new Avril_NNAI.Algorithm_Praise_2());
            while (Get_Algorithm_Praise_2() == null) { }
            Set_ListOfAlgorithmSubsets(2, (object)Get_Algorithm_Praise_2());
        }

// destructor
        ~SolutionLogic() 
        { 
        
        }

// public.
    // get.
        public Object Get_ItemOnListOfAlgorithmSubsets(ulong praiseID)
        {
            return _ListOfAlgorithmSubsets[praiseID];
        }

    // set.

// private.
        private void Create_Algorithm_Praise_0(Avril_NNAI.Algorithm_Praise_0 algorithm_Praise_0)
        {
            _Algorithm_Praise_0 = algorithm_Praise_0;
        }
        private void Create_Algorithm_Praise_1(Avril_NNAI.Algorithm_Praise_1 algorithm_Praise_1)
        {
            _Algorithm_Praise_1 = algorithm_Praise_1;
        }
        private void Create_Algorithm_Praise_2(Avril_NNAI.Algorithm_Praise_2 algorithm_Praise_2)
        {
            _Algorithm_Praise_2 = algorithm_Praise_2;
        }
        private void Create_ListOfAlgorithmSubsets(Object[] listOfAlgorithmSubsets)
        {
            _ListOfAlgorithmSubsets = listOfAlgorithmSubsets;
        }

    // get.
        private Avril_NNAI.Algorithm_Praise_0 Get_Algorithm_Praise_0()
        {
            return _Algorithm_Praise_0;
        }
        private Avril_NNAI.Algorithm_Praise_1 Get_Algorithm_Praise_1()
        {
            return _Algorithm_Praise_1;
        }
        private Avril_NNAI.Algorithm_Praise_2 Get_Algorithm_Praise_2()
        {
            return _Algorithm_Praise_2;
        }
        private Object Get_ItemOnListOfAlgorithmSubsets()
        {
            return _ListOfAlgorithmSubsets;
        }

    // set.
        private void Set_ListOfAlgorithmSubsets(ulong praiseID, Object algorithmSubset)
        {
            _ListOfAlgorithmSubsets[praiseID] = algorithmSubset;
        }
    }
}

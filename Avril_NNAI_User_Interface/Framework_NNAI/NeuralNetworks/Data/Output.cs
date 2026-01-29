
using System;

namespace Avril_NNAI
{
    public class Output
    {
        private Avril_NNAI.Output_Praise_0 _Output_Praise_0;
        private Avril_NNAI.Output_Praise_1 _Output_Praise_1;
        private Avril_NNAI.Output_Praise_2 _Output_Praise_2;

        private Object[] _ListOfOutputSubsets;

        public Output()
        {
            _ListOfOutputSubsets = new Object[3];
            
            Set_Output_Praise_0(new Avril_NNAI.Output_Praise_0());
            while (Get_Output_Praise_0() == null) { }
            Set_ListOfOutputSubsets(0, Get_Output_Praise_0());
         
            Set_Output_Praise_1(new Avril_NNAI.Output_Praise_1());
            while (Get_Output_Praise_1() == null) { }
            Set_ListOfOutputSubsets(1, Get_Output_Praise_1());
            
            Set_Output_Praise_2(new Avril_NNAI.Output_Praise_2());
            while (Get_Output_Praise_2() == null) { }
            Set_ListOfOutputSubsets(2, Get_Output_Praise_2());
        }

        public Avril_NNAI.Output_Praise_0 Get_Output_Praise_0()
        {
            return _Output_Praise_0;
        }
        
        public Avril_NNAI.Output_Praise_1 Get_Output_Praise_1()
        {
            return _Output_Praise_1;
        }

        public Avril_NNAI.Output_Praise_2 Get_Output_Praise_2()
        {
            return _Output_Praise_2;
        }

        public Object Get_ItemOnListOfOutputSubsets(ulong praiseID)
        {
            return _ListOfOutputSubsets[praiseID];
        }

        private void Set_Output_Praise_0(Avril_NNAI.Output_Praise_0 output_Praise_0)
        {
            _Output_Praise_0 = output_Praise_0;
        }

        private void Set_Output_Praise_1(Avril_NNAI.Output_Praise_1 output_Praise_1)
        {
            _Output_Praise_1 = output_Praise_1;
        }

        private void Set_Output_Praise_2(Avril_NNAI.Output_Praise_2 output_Praise_2)
        {
            _Output_Praise_2 = output_Praise_2;
        }

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

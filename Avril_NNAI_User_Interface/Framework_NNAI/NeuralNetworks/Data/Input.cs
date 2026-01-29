
using System;
using System.Collections.Generic;

namespace Avril_NNAI
{
    public class Input
    {
        private Avril_NNAI.Input_Praise_0 _Input_Praise_0;
        private Avril_NNAI.Input_Praise_1 _Input_Praise_1;
        private Avril_NNAI.Input_Praise_2 _Input_Praise_2;
        
        private Object[] _ListOfInputSubsets;

        public Input()
        {
            _ListOfInputSubsets = new Object[3];

            Set_Input_Praise_0(new Avril_NNAI.Input_Praise_0());
            while (Get_Input_Praise_0() == null) { }
            Set_ListOfInputSubsets(0, Get_Input_Praise_0());

            Set_Input_Praise_1(new Avril_NNAI.Input_Praise_1());
            while (Get_Input_Praise_1() == null) { }
            Set_ListOfInputSubsets(1, Get_Input_Praise_1());

            Set_Input_Praise_2(new Avril_NNAI.Input_Praise_2());
            while (Get_Input_Praise_2() == null) { }
            Set_ListOfInputSubsets(2, Get_Input_Praise_2());
        }
        public Avril_NNAI.Input_Praise_0 Get_Input_Praise_0()
        {
            return _Input_Praise_0;
        }
        public Avril_NNAI.Input_Praise_1 Get_Input_Praise_1()
        {
            return _Input_Praise_1;
        }
        public Avril_NNAI.Input_Praise_2 Get_Input_Praise_2()
        {
            return _Input_Praise_2;
        }
        public Object Get_ItemOnListOfInputSubsets(ulong praiseID)
        {
            return _ListOfInputSubsets[praiseID];
        }
        private void Set_Input_Praise_0(Avril_NNAI.Input_Praise_0 input_Praise_0)
        {
            _Input_Praise_0 = input_Praise_0;
        }
        private void Set_Input_Praise_1(Avril_NNAI.Input_Praise_1 input_Praise_1)
        {
            _Input_Praise_1 = input_Praise_1;
        }
        private void Set_Input_Praise_2(Avril_NNAI.Input_Praise_2 input_Praise_2)
        {
            _Input_Praise_2 = input_Praise_2;
        }
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

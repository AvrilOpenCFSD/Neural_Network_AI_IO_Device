
using System;

namespace Avril_NNAI
{
    public class NeuralPath
    {
// classes.
        private Avril_NNAI.Linear _New_Linear;
            
// registers.

// constructor.
        public NeuralPath() 
        {
            //System.Console.WriteLine("entered NeuralPath.");
            Create_New_Linear(new Avril_NNAI.Linear());
            while (Get_New_Linear() == null) { }
            //System.Console.WriteLine("exiting NeuralPath.");
        }

// destructor
        ~NeuralPath()
        {

        }

        // public.
        public void Calculate_NumberOfPraiseInputValues(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong[] praiseID)
        {
            objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(0);
            for (ulong index = 0; index < (ulong)praiseID.LongLength; index++)
            {
                switch (praiseID[index])
                {
                    case 0:
                        var objValue_Praise0 = (Avril_NNAI.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(0);
                        objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(_NumberOfPraiseInputValues + objValue_Praise0.Get_NumberOfInputValues());
                        break;

                    case 1:
                        var objValue_Praise1 = (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(1);
                        objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(_NumberOfPraiseInputValues + objValue_Praise1.Get_NumberOfInputValues());
                        break;

                    case 2:
                        var objValue_Praise2 = (Avril_NNAI.Input_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(2);
                        objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(_NumberOfPraiseInputValues + objValue_Praise2.Get_NumberOfInputValues());
                        break;
                    default:
                        break;
                }
            }
        }
        public double Generate_Initial_Random_Small_Value(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
        public void Generate_REGISTERED_Inputs_List(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong[] praiseID)
        {
            for (ulong index_A = 0; index_A < (ulong)praiseID.LongLength; index_A++)
            {
                switch (praiseID[index_A])
                {
                    case (ulong)PraiseID.Praise_0:
                        Avril_NNAI.Input_Praise_0 subsetOfInput_Praise_0 = (Avril_NNAI.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(0);
                        objNNAI.Get_MetaData().Create_REGISTERED_Inputs(new double[subsetOfInput_Praise_0.Get_NumberOfInputValues()]);
                        for (byte index = 0; index < subsetOfInput_Praise_0.Get_NumberOfInputValues(); index++)
                        {
                            subsetOfInput_Praise_0.Set_Item_Of_Input_Praise(index, 0.0);
                        }
                        break;

                    case (ulong)PraiseID.Praise_1:
                        Avril_NNAI.Input_Praise_1 subsetOfInput_Praise_1 = (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(1);
                        objNNAI.Get_MetaData().Create_REGISTERED_Inputs(new double[subsetOfInput_Praise_1.Get_NumberOfInputValues()]);
                        for (byte index = 0; index < subsetOfInput_Praise_1.Get_NumberOfInputValues(); index++)
                        {
                            subsetOfInput_Praise_1.Set_Item_Of_Input_Praise(index, 0.0);
                        }
                        break;

                    case (ulong)PraiseID.Praise_2:
                        Avril_NNAI.Input_Praise_2 subsetOfInput_Praise_2 = (Avril_NNAI.Input_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(2);
                        objNNAI.Get_MetaData().Create_REGISTERED_Inputs(new double[subsetOfInput_Praise_2.Get_NumberOfInputValues()]);
                        for (byte index = 0; index < subsetOfInput_Praise_2.Get_NumberOfInputValues(); index++)
                        {
                            subsetOfInput_Praise_2.Set_Item_Of_Input_Praise(index, 0.0);
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        // get.
        public Avril_NNAI.Linear Get_New_Linear()
        {
            return _New_Linear;
        }
    // set.

// private.
        private void Create_New_Linear(Avril_NNAI.Linear linear)
        {
            _New_Linear = linear;
        }
    // get.

    // set.
    }
}

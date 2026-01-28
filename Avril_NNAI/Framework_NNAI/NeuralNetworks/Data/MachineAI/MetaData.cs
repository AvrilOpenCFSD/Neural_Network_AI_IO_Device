
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Avril_NNAI
{
    public class MetaData
    {
        ulong _NumberOfPraises;
        ulong _NumberOfPraiseInputValues;
        double[] _REGISTERED_Inputs = new double[1];
        Avril_NNAI.Node[] _Layer4_Nodes = new Avril_NNAI.Node[1];
        Avril_NNAI.Node[] _Layer3_Nodes = new Avril_NNAI.Node[1];
        Avril_NNAI.Node[] _Layer2_Nodes = new Avril_NNAI.Node[1];
        Avril_NNAI.Node[] _Layer1_Nodes = new Avril_NNAI.Node[1];
        Avril_NNAI.Node[] _Layer0_Node = new Avril_NNAI.Node[1];

        public MetaData() 
        {
            Set_NumberOfPraiseInputs(0);

            Avril_NNAI.Node newEmpty = new Avril_NNAI.Node();
            while (newEmpty == null) { }

            _Layer4_Nodes = new Avril_NNAI.Node[1];
            _Layer4_Nodes[0] = newEmpty;

            _Layer3_Nodes = new Avril_NNAI.Node[1];
            _Layer3_Nodes[0] = newEmpty;

            _Layer2_Nodes = new Avril_NNAI.Node[1];
            _Layer2_Nodes[0] = newEmpty;

            _Layer1_Nodes = new Avril_NNAI.Node[1];
            _Layer1_Nodes[0] = newEmpty;

            _Layer0_Node = new Avril_NNAI.Node[1];
            _Layer0_Node[0] = newEmpty;
        }

        public void Create_Nodes(Avril_NNAI.Framework_NNAI obj, ulong numberOfPraiseInputValues)
        {
            if ((numberOfPraiseInputValues > 0) && (numberOfPraiseInputValues <= 9223372036854775807))
            {
                var newEmpty_Node_For_Layer4 = new Avril_NNAI.Node();
                while (newEmpty_Node_For_Layer4 == null) { }
                newEmpty_Node_For_Layer4.Set_NumberOfInputs(numberOfPraiseInputValues);
                newEmpty_Node_For_Layer4.Create_REGISTERED_Inputs(new double[numberOfPraiseInputValues]);
                for (ulong index = 0; index < numberOfPraiseInputValues; index++)
                {
                    newEmpty_Node_For_Layer4.Set_REGISTERED_Inputs(index, 0.0);
                }
                var newLinearPathway = new Avril_NNAI.Linear();
                newLinearPathway.Set_Number_Of_Inputs_For_Algorithm(obj, newEmpty_Node_For_Layer4.Get_NumberOfInputs());

                newEmpty_Node_For_Layer4.Create_Array_NeuralPathOfInput_SubSet(new Avril_NNAI.Linear[newEmpty_Node_For_Layer4.Get_NumberOfInputs()]);
                for (ulong index = 0; index < newEmpty_Node_For_Layer4.Get_NumberOfInputs(); index++)
                {
                    // assigne bias and weight default values.
                }
                //ToDo
            }
        }

        public void Generate_Input_List(Avril_NNAI.Framework_NNAI obj)
        {
            ulong praiseID = 0;
            var subset_Input_Praise_0 = (Avril_NNAI.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(praiseID);
            obj.Get_Neural_Networks().Get_Data().Get_MachineAI().Get_MetaData().Set_NumberOfPraiseInputValues(subset_Input_Praise_0.Get_NumberOfInputValues());

            praiseID = 1;
            var subset_Input_Praise_1 = (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(praiseID);
            obj.Get_Neural_Networks().Get_Data().Get_MachineAI().Get_MetaData().Set_NumberOfPraiseInputValues(obj.Get_Neural_Networks().Get_Data().Get_MachineAI().Get_MetaData().Get_NumberOfPraiseInputValues() + subset_Input_Praise_1.Get_NumberOfInputValues());

            praiseID = 2;
            var subset_Input_Praise_2 = (Avril_NNAI.Input_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(praiseID);
            obj.Get_Neural_Networks().Get_Data().Get_MachineAI().Get_MetaData().Set_NumberOfPraiseInputValues(obj.Get_Neural_Networks().Get_Data().Get_MachineAI().Get_MetaData().Get_NumberOfPraiseInputValues() + subset_Input_Praise_2.Get_NumberOfInputValues());

        }

        public ulong Get_NumberOfPraiseInputs()
        {
            return _NumberOfPraises;
        }

        public ulong Get_NumberOfPraiseInputValues()
        {
            return _NumberOfPraiseInputValues;
        }

        public void Set_NumberOfPraiseInputs(ulong numberOfPraiseInputs)
        {
            _NumberOfPraises = numberOfPraiseInputs;
        }

        private void Set_NumberOfPraiseInputValues(ulong numberOfPraiseInputValues)
        {
            _NumberOfPraiseInputValues = numberOfPraiseInputValues;
        }
    }
}

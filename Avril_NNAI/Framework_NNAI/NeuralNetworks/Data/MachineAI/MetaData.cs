
namespace Avril_NNAI
{
    public class MetaData
    {
        public enum PraiseID : ulong
        {
            Praise_0 = (ulong)0,
            Praise_1 = (ulong)1,
            Praise_2 = (ulong)2
        }
        ulong _NumberOfPraises;
        ulong _NumberOfPraiseInputValues;
        double[] _REGISTERED_Inputs;
        Avril_NNAI.Node[] _Layer4_Nodes;
        Avril_NNAI.Node[] _Layer3_Nodes;
        Avril_NNAI.Node[] _Layer2_Nodes;
        Avril_NNAI.Node[] _Layer1_Nodes;
        Avril_NNAI.Node _Layer0_Node;

        public MetaData() 
        {
            Set_NumberOfPraises(3);
            _NumberOfPraiseInputValues = 0;

            _REGISTERED_Inputs = new double[1];

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

            _Layer0_Node = new Avril_NNAI.Node();
            _Layer0_Node = newEmpty;
        }

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
                        var objValue_Praise1= (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(1);
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

        private void Create_Layer4_Nodes(ulong numberOfNodes, Avril_NNAI.Node newEmpty_Node)
        {
            _Layer4_Nodes = new Avril_NNAI.Node[numberOfNodes];
            for (ulong index = 0; index < numberOfNodes; index++)
            {
                _Layer4_Nodes[index] = newEmpty_Node;
            }
        }

        private void Create_Layer3_Nodes(ulong numberOfNodes, Avril_NNAI.Node newEmpty_Node)
        {
            _Layer3_Nodes = new Avril_NNAI.Node[numberOfNodes];
            for (ulong index = 0; index < numberOfNodes; index++)
            {
                _Layer3_Nodes[index] = newEmpty_Node;
            }
        }

        private void Create_Layer2_Nodes(ulong numberOfNodes, Avril_NNAI.Node newEmpty_Node)
        {
            _Layer2_Nodes = new Avril_NNAI.Node[numberOfNodes];
            for (ulong index = 0; index < numberOfNodes; index++)
            {
                _Layer2_Nodes[index] = newEmpty_Node;
            }
        }

        private void Create_Layer1_Nodes(ulong numberOfNodes, Avril_NNAI.Node newEmpty_Node)
        {
            _Layer1_Nodes = new Avril_NNAI.Node[numberOfNodes];
            for (ulong index = 0; index < numberOfNodes; index++)
            {
                _Layer1_Nodes[index] = newEmpty_Node;
            }
        }

        private void Create_Layer0_Node(Avril_NNAI.Node newEmpty_Node)
        {
            _Layer0_Node = newEmpty_Node;
        }

        public void Create_Nodes(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong numberOfPraiseInputValues)
        {   // layer 4.
            var newEmpty_Node_For_Layer4 = new Avril_NNAI.Node();
            while (newEmpty_Node_For_Layer4 == null) { }

            ulong numberOfNodesForLayer_4;
            if (objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues() <= 5) numberOfNodesForLayer_4 = 5;
            else numberOfNodesForLayer_4 = (ulong)(numberOfPraiseInputValues * (double)(4 / 5));
            
            newEmpty_Node_For_Layer4.Set_NumberOfInputs(numberOfPraiseInputValues);

            newEmpty_Node_For_Layer4.Create_REGISTERED_Inputs(new double[numberOfPraiseInputValues]);
            for (ulong index = 0; index < numberOfPraiseInputValues; index++)
            {
                newEmpty_Node_For_Layer4.Set_REGISTERED_Inputs(index, 0.0);
            }

            var newLinearPathway = new Avril_NNAI.Linear();
            newLinearPathway.Set_Number_Of_Inputs_For_Algorithm(obj, numberOfPraiseInputValues);
            for (ulong index = 0; index < numberOfPraiseInputValues; index++)
            {
                // assigne bias and weight default values.
            }

            newEmpty_Node_For_Layer4.Create_NeuralPathOfInput_SubSet(new Avril_NNAI.Linear[numberOfPraiseInputValues]);
            for (ulong index = 0; index < numberOfPraiseInputValues; index++)
            {
                newEmpty_Node_For_Layer4.Set_NeuralPathOfInput_SubSet(index, newLinearPathway);
            }

            objNNAI.Get_MetaData().Create_Layer4_Nodes(numberOfNodesForLayer_4, newEmpty_Node_For_Layer4);
            

            // layer 3.
            var newEmpty_Node_For_Layer3 = new Avril_NNAI.Node();
            while (newEmpty_Node_For_Layer3 == null) { }

            ulong numberOfNodesForLayer_3;
            if (objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues() < 5) numberOfNodesForLayer_3 = 4;
            else numberOfNodesForLayer_3 = (ulong)(numberOfPraiseInputValues * (double)(3 / 5));

            newEmpty_Node_For_Layer3.Set_NumberOfInputs(numberOfNodesForLayer_4);
            newEmpty_Node_For_Layer3.Create_REGISTERED_Inputs(new double[numberOfNodesForLayer_4]);
            for (ulong index = 0; index < numberOfNodesForLayer_4; index++)
            {
                newEmpty_Node_For_Layer3.Set_REGISTERED_Inputs(index, 0.0);
            }

            newLinearPathway = new Avril_NNAI.Linear();
            newLinearPathway.Set_Number_Of_Inputs_For_Algorithm(obj, numberOfNodesForLayer_4);
            for (ulong index = 0; index < numberOfNodesForLayer_4; index++)
            {
                // assigne bias and weight default values.
            }

            newEmpty_Node_For_Layer4.Create_NeuralPathOfInput_SubSet(new Avril_NNAI.Linear[numberOfNodesForLayer_4]);
            for (ulong index = 0; index < numberOfNodesForLayer_4; index++)
            {
                newEmpty_Node_For_Layer4.Set_NeuralPathOfInput_SubSet(index, newLinearPathway);
            }

            objNNAI.Get_MetaData().Create_Layer3_Nodes(numberOfNodesForLayer_3, newEmpty_Node_For_Layer3);

            // layer 2.
            var newEmpty_Node_For_Layer2 = new Avril_NNAI.Node();
            while (newEmpty_Node_For_Layer2 == null) { }

            ulong numberOfNodesForLayer_2;
            if (objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues() < 5) numberOfNodesForLayer_2 = 3;
            else numberOfNodesForLayer_2 = (ulong)(numberOfPraiseInputValues * (double)(2 / 5));

            newEmpty_Node_For_Layer2.Set_NumberOfInputs(numberOfNodesForLayer_3);
            newEmpty_Node_For_Layer2.Create_REGISTERED_Inputs(new double[numberOfNodesForLayer_3]);
            for (ulong index = 0; index < numberOfNodesForLayer_3; index++)
            {
                newEmpty_Node_For_Layer2.Set_REGISTERED_Inputs(index, 0.0);
            }

            newLinearPathway = new Avril_NNAI.Linear();
            newLinearPathway.Set_Number_Of_Inputs_For_Algorithm(obj, numberOfNodesForLayer_3);
            for (ulong index = 0; index < numberOfNodesForLayer_3; index++)
            {
                // assigne bias and weight default values.
            }

            newEmpty_Node_For_Layer2.Create_NeuralPathOfInput_SubSet(new Avril_NNAI.Linear[numberOfNodesForLayer_3]);
            for (ulong index = 0; index < numberOfNodesForLayer_3; index++)
            {
                newEmpty_Node_For_Layer2.Set_NeuralPathOfInput_SubSet(index, newLinearPathway);
            }

            objNNAI.Get_MetaData().Create_Layer2_Nodes(numberOfNodesForLayer_2, newEmpty_Node_For_Layer2);

            // layer 1.
            var newEmpty_Node_For_Layer1 = new Avril_NNAI.Node();
            while (newEmpty_Node_For_Layer1 == null) { }

            ulong numberOfNodesForLayer_1;
            if (objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues() < 5) numberOfNodesForLayer_1 = 2;
            else numberOfNodesForLayer_1 = (ulong)(numberOfPraiseInputValues * (double)(1 / 5));

            newEmpty_Node_For_Layer1.Set_NumberOfInputs(numberOfNodesForLayer_2);
            newEmpty_Node_For_Layer1.Create_REGISTERED_Inputs(new double[numberOfNodesForLayer_2]);
            for (ulong index = 0; index < numberOfNodesForLayer_2; index++)
            {
                newEmpty_Node_For_Layer1.Set_REGISTERED_Inputs(index, 0.0);
            }

            newLinearPathway = new Avril_NNAI.Linear();
            newLinearPathway.Set_Number_Of_Inputs_For_Algorithm(obj, numberOfNodesForLayer_2);
            for (ulong index = 0; index < numberOfNodesForLayer_2; index++)
            {
                // assigne bias and weight default values.
            }

            newEmpty_Node_For_Layer1.Create_NeuralPathOfInput_SubSet(new Avril_NNAI.Linear[numberOfNodesForLayer_2]);
            for (ulong index = 0; index < numberOfNodesForLayer_2; index++)
            {
                newEmpty_Node_For_Layer1.Set_NeuralPathOfInput_SubSet(index, newLinearPathway);
            }

            objNNAI.Get_MetaData().Create_Layer1_Nodes(numberOfNodesForLayer_1, newEmpty_Node_For_Layer1);

            // layer 0.
            var newEmpty_Node_For_Layer0 = new Avril_NNAI.Node();
            while (newEmpty_Node_For_Layer0 == null) { }

            //ulong numberOfNodesForLayer_0 = 1;

            newEmpty_Node_For_Layer0.Set_NumberOfInputs(numberOfNodesForLayer_1);
            newEmpty_Node_For_Layer0.Create_REGISTERED_Inputs(new double[numberOfNodesForLayer_1]);
            for (ulong index = 0; index < numberOfNodesForLayer_1; index++)
            {
                newEmpty_Node_For_Layer0.Set_REGISTERED_Inputs(index, 0.0);
            }

            newLinearPathway = new Avril_NNAI.Linear();
            newLinearPathway.Set_Number_Of_Inputs_For_Algorithm(obj, numberOfNodesForLayer_1);
            for (ulong index = 0; index < numberOfNodesForLayer_1; index++)
            {
                // assigne bias and weight default values.
            }

            newEmpty_Node_For_Layer0.Create_NeuralPathOfInput_SubSet(new Avril_NNAI.Linear[numberOfNodesForLayer_1]);
            for (ulong index = 0; index < numberOfNodesForLayer_1; index++)
            {
                newEmpty_Node_For_Layer0.Set_NeuralPathOfInput_SubSet(index, newLinearPathway);
            }

            objNNAI.Get_MetaData().Create_Layer0_Node(newEmpty_Node_For_Layer0);
        }
        
        public void Create_REGISTERED_Inputs(ulong numberOfPraiseInputValues)
        {
            _REGISTERED_Inputs = new double[numberOfPraiseInputValues];
        }

        public void Generate_REGISTERED_Inputs_List(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong[] praiseID)
        {
            objNNAI.Get_MetaData().Create_REGISTERED_Inputs(objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues());

            for (ulong index_A = 0; index_A < (ulong)praiseID.LongLength; index_A++)
            {
                switch (praiseID[index_A])
                {
                    case (ulong)PraiseID.Praise_0:
                        var subsetOfInput_Praise_0 = (Avril_NNAI.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(index_A);
                        for (byte index = 0; index < objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues(); index++)
                        {
                            subsetOfInput_Praise_0.Set_Item_Of_Input_Praise(index, 0);
                        }
                        break;

                    case (ulong)PraiseID.Praise_1:
                        var subsetOfInput_Praise_1 = (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(index_A);
                        for (byte index = 0; index < subsetOfInput_Praise_1.Get_NumberOfInputValues(); index++)
                        {
                            subsetOfInput_Praise_1.Set_Item_Of_Input_Praise(index, 0);
                        }
                        break;

                    case (ulong)PraiseID.Praise_2:
                        var subsetOfInput_Praise_2 = (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(index_A);
                        for (byte index = 0; index < subsetOfInput_Praise_2.Get_NumberOfInputValues(); index++)
                        {
                            subsetOfInput_Praise_2.Set_Item_Of_Input_Praise(index, 0);
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        public void Initialise_Node_WEIGHT_and_BIAS(Avril_NNAI.Framework_NNAI obj)
        {
            for(ulong index_A = 0; index_A < (ulong)this.Get_Layer4_Nodes().LongLength; index_A++)
            {
                for (ulong index_B = 0; index_B < this.Get_NumberOfPraiseInputValues(); index_B++)
                {
                    Avril_NNAI.Linear objNode = this.Get_Layer4_Nodes()[index_A].Get_NeuralPathOfInput_SubSet(index_B);
                    objNode.Set_Number_Of_Inputs_For_Algorithm(obj, this.Get_NumberOfPraiseInputValues());
                    // assign weight and bias default values.
                }
            }

            for (ulong index_A = 0; index_A < (ulong)this.Get_Layer3_Nodes().LongLength; index_A++)
            {
                for (ulong index_B = 0; index_B < (ulong)this.Get_Layer4_Nodes().LongLength; index_B++)
                {
                    Avril_NNAI.Linear objNode = this.Get_Layer3_Nodes()[index_A].Get_NeuralPathOfInput_SubSet(index_B);
                    objNode.Set_Number_Of_Inputs_For_Algorithm(obj, (ulong)this.Get_Layer4_Nodes().LongLength);
                    // assign weight and bias default values.
                }
            }

            for (ulong index_A = 0; index_A < (ulong)this.Get_Layer2_Nodes().LongLength; index_A++)
            {
                for (ulong index_B = 0; index_B < (ulong)this.Get_Layer3_Nodes().LongLength; index_B++)
                {
                    Avril_NNAI.Linear objNode = this.Get_Layer2_Nodes()[index_A].Get_NeuralPathOfInput_SubSet(index_B);
                    objNode.Set_Number_Of_Inputs_For_Algorithm(obj, (ulong)this.Get_Layer3_Nodes().LongLength);
                    // assign weight and bias default values.
                }
            }

            for (ulong index_A = 0; index_A < (ulong)this.Get_Layer1_Nodes().LongLength; index_A++)
            {
                for (ulong index_B = 0; index_B < (ulong)this.Get_Layer2_Nodes().LongLength; index_B++)
                {
                    Avril_NNAI.Linear objNode = this.Get_Layer1_Nodes()[index_A].Get_NeuralPathOfInput_SubSet(index_B);
                    objNode.Set_Number_Of_Inputs_For_Algorithm(obj, (ulong)this.Get_Layer2_Nodes().LongLength);
                    // assign weight and bias default values.
                }
            }

                for (ulong index_B = 0; index_B < (ulong)this.Get_Layer1_Nodes().LongLength; index_B++)
                {
                    Avril_NNAI.Linear objNode = this.Get_Layer0_Node().Get_NeuralPathOfInput_SubSet(index_B);
                    objNode.Set_Number_Of_Inputs_For_Algorithm(obj, (ulong)this.Get_Layer1_Nodes().LongLength);
                    // assign weight and bias default values.
                }
        }

        private Avril_NNAI.Node[] Get_Layer4_Nodes()
        {
            return _Layer4_Nodes;
        }

        private Avril_NNAI.Node[] Get_Layer3_Nodes()
        {
            return _Layer3_Nodes;
        }

        private Avril_NNAI.Node[] Get_Layer2_Nodes()
        {
            return _Layer2_Nodes;
        }

        private Avril_NNAI.Node[] Get_Layer1_Nodes()
        {
            return _Layer1_Nodes;
        }

        private Avril_NNAI.Node Get_Layer0_Node()
        {
            return _Layer0_Node;
        }

        public ulong Get_NumberOfPraises()
        {
            return _NumberOfPraises;
        }

        public ulong Get_NumberOfPraiseInputValues()
        {
            return _NumberOfPraiseInputValues;
        }

        public double[] Get_REGISTERED_Inputs()
        {
            return _REGISTERED_Inputs;
        }

        public void Set_NumberOfPraises(ulong numberOfPraiseInputs)
        {
            _NumberOfPraises = numberOfPraiseInputs;
        }

        private void Set_NumberOfPraiseInputValues(ulong numberOfPraiseInputValues)
        {
            _NumberOfPraiseInputValues = numberOfPraiseInputValues;
        }

        public void Set_REGISTERED_Inputs(byte registerID, double value)
        {
            _REGISTERED_Inputs[registerID] = value;
        }
    }
}

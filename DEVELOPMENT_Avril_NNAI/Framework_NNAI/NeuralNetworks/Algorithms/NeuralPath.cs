
namespace Avril_NNAI
{
    public class NeuralPath
    {
// definitionns.

// classes.
        private Avril_NNAI.Constant _New_Constant;
        private Avril_NNAI.Linear _New_Linear;
            
// registers.

// constructor.
        public NeuralPath() 
        {
            //System.Console.WriteLine("entered NeuralPath.");
            Create_New_Linear();
            Create_New_Constant();
            //System.Console.WriteLine("exiting NeuralPath.");
        }

// destructor
        ~NeuralPath()
        {

        }

// public.
        public void Calculate_Neural_Network_Parameters(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong praiseID)
        {
            Calculate_NumberOfPraiseInputValues(obj, objNNAI, praiseID);
            System.Console.WriteLine("NumberOfPraiseInputValues = " + objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues());

            Calculate_NumberOfPraiseOutputValues(obj, objNNAI, praiseID);
            System.Console.WriteLine("NumberOfPraiseOutputValues = " + objNNAI.Get_MetaData().Get_NumberOfPraiseOutputValues());

            Calculate_NumberOfResetToConstantValues_INPUT(obj, objNNAI, praiseID);
            System.Console.WriteLine("NumberOfResetToConstantValues_INPUT = " + objNNAI.Get_MetaData().Get_NumberOfResetToConstantValues_INPUT());

            Calculate_NumberOfResetToConstantValues_OUTPUT(obj, objNNAI, praiseID);
            System.Console.WriteLine("NumberOfResetToConstantValues_OUTPUT = " + objNNAI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT());
        }
        public void Create_Layer_Nodes(Avril_NNAI.MachineAI objNNAI, byte outputID, byte layerID)
        {
            var newEmptyNode = new Avril_NNAI.Node();
            while (newEmptyNode == null) { }

            switch (layerID)
            {
                case (byte)Avril_NNAI.Global.NodeLayer.Layer_4:
                    objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer4_Nodes(objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                    break;

                case (byte)Avril_NNAI.Global.NodeLayer.Layer_3:
                    objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer3_Nodes(objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                    break;

                case (byte)Avril_NNAI.Global.NodeLayer.Layer_2:
                    objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer2_Nodes(objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                    break;

                case (byte)Avril_NNAI.Global.NodeLayer.Layer_1:
                    objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer1_Nodes(objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                    break;

                case (byte)Avril_NNAI.Global.NodeLayer.Layer_0:
                    objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer0_Node(newEmptyNode);
                    break;
            }
            for (ulong nodeID = 0; nodeID < objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID); nodeID++)
            {
                objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Set_Node(layerID, nodeID, newEmptyNode);
            }
            
        }
        public double Generate_Initial_Random_Small_Value(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
        public void Generate_REGISTERED_Inputs_List(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong praiseID)
        {
            switch (praiseID)
            {
                case (ulong)Avril_NNAI.Global.PraiseID.Praise_0:
                    Avril_NNAI.Input_Praise_0 subsetOfInput_Praise_0 = (Avril_NNAI.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(0);
                    objNNAI.Create_List_Of_REGISTERED_Inputs(new double[subsetOfInput_Praise_0.Get_NumberOfInputValues()]);
                    for (byte index = 0; index < subsetOfInput_Praise_0.Get_NumberOfInputValues(); index++)
                    {
                        subsetOfInput_Praise_0.Set_Item_On_List_Of_Input_Praise(index, 0.0);
                    }
                    break;

                case (ulong)Avril_NNAI.Global.PraiseID.Praise_1:
                    Avril_NNAI.Input_Praise_1 subsetOfInput_Praise_1 = (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(1);
                    objNNAI.Create_List_Of_REGISTERED_Inputs(new double[subsetOfInput_Praise_1.Get_NumberOfInputValues()]);
                    for (byte index = 0; index < subsetOfInput_Praise_1.Get_NumberOfInputValues(); index++)
                    {
                        subsetOfInput_Praise_1.Set_Item_On_List_Of_Input_Praise(index, 0.0);
                    }
                    break;

                case (ulong)Avril_NNAI.Global.PraiseID.Praise_2:
                    Avril_NNAI.Input_Praise_2 subsetOfInput_Praise_2 = (Avril_NNAI.Input_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(2);
                    objNNAI.Create_List_Of_REGISTERED_Inputs(new double[subsetOfInput_Praise_2.Get_NumberOfInputValues()]);
                    for (byte index = 0; index < subsetOfInput_Praise_2.Get_NumberOfInputValues(); index++)
                    {
                        subsetOfInput_Praise_2.Set_Item_On_List_Of_Input_Praise(index, 0.0);
                    }
                    break;

                default:
                    break;
            }
        }
        public void Generate_REGISTERED_Outputs_List(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong praiseID)
        {
            switch (praiseID)
            {
                case (ulong)Avril_NNAI.Global.PraiseID.Praise_0:
                    Avril_NNAI.Output_Praise_0 subsetOfOutput_Praise_0 = (Avril_NNAI.Output_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(0);
                    objNNAI.Create_List_Of_REGISTERED_Outputs(new double[subsetOfOutput_Praise_0.Get_NumberOfOutputValues()]);
                    for (byte index = 0; index < subsetOfOutput_Praise_0.Get_NumberOfOutputValues(); index++)
                    {
                        subsetOfOutput_Praise_0.Set_Item_On_List_Of_Input_Praise(index, 0.0);
                    }
                    break;

                case (ulong)Avril_NNAI.Global.PraiseID.Praise_1:
                    Avril_NNAI.Output_Praise_1 subsetOfOutput_Praise_1 = (Avril_NNAI.Output_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(1);
                    objNNAI.Create_List_Of_REGISTERED_Outputs(new double[subsetOfOutput_Praise_1.Get_NumberOfOutputValues()]);
                    for (byte index = 0; index < subsetOfOutput_Praise_1.Get_NumberOfOutputValues(); index++)
                    {
                        subsetOfOutput_Praise_1.Set_Item_On_List_Of_Input_Praise(index, 0.0);
                    }
                    break;

                case (ulong)Avril_NNAI.Global.PraiseID.Praise_2:
                    Avril_NNAI.Output_Praise_2 subsetOfOutput_Praise_2 = (Avril_NNAI.Output_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(2);
                    objNNAI.Create_List_Of_REGISTERED_Outputs(new double[subsetOfOutput_Praise_2.Get_NumberOfOutputValues()]);
                    for (byte index = 0; index < subsetOfOutput_Praise_2.Get_NumberOfOutputValues(); index++)
                    {
                        subsetOfOutput_Praise_2.Set_Item_On_List_Of_Input_Praise(index, 0.0);
                    }
                    break;

                default:
                    break;
            }
        }
    // get.
        public Avril_NNAI.Constant Get_New_Constant()
        {
            return _New_Constant;
        }
        public Avril_NNAI.Linear Get_New_Linear()
        {
            return _New_Linear;
        }
    // set.
        public void Set_Constant_Path_To_Output(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, byte outputID, byte constantID)
        {
            byte numberOfInputsForNode = new byte();
            numberOfInputsForNode = objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues();
            
            switch (objNNAI.Get_MetaData().Get_PraiseID())
            {
                case (byte)Avril_NNAI.Global.PraiseID.Praise_0:
                    Avril_NNAI.Output_Praise_0 objobjOutputSubset_Praise0 = (Avril_NNAI.Output_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(outputID);
                    for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
                    {
                        objNNAI.Get_Item_On_List_Of_Constant(constantID).Set_Constant_REGISTERED_Output(objobjOutputSubset_Praise0.Get_Item_On_List_Of_Input_Praise(inputID)); ;
                    }
                    break;

                case (byte)Avril_NNAI.Global.PraiseID.Praise_1:
                    Avril_NNAI.Output_Praise_1 objOutputSubset_Praise1 = (Avril_NNAI.Output_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(outputID);
                    for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
                    {
                        objNNAI.Get_Item_On_List_Of_Constant(constantID).Set_Constant_REGISTERED_Output(objOutputSubset_Praise1.Get_Item_On_List_Of_Input_Praise(inputID)); ;
                    }
                    break;

                case (byte)Avril_NNAI.Global.PraiseID.Praise_2:
                    Avril_NNAI.Output_Praise_2 objobjOutputSubset_Praise2 = (Avril_NNAI.Output_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(outputID);
                    for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
                    {
                        objNNAI.Get_Item_On_List_Of_Constant(constantID).Set_Constant_REGISTERED_Output(objobjOutputSubset_Praise2.Get_Item_On_List_Of_Input_Praise(inputID)); ;
                    }
                    break;
            }

        }
        public void Set_Neural_Path_For_Input(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, byte outputID, byte layerID, ulong nodeID)
        {
            System.Console.WriteLine("entered Create_Nodes.");

            var newLinearPath = new Avril_NNAI.Linear();
            while (newLinearPath == null) { }

            ulong numberOfInputsForNode = new ulong();
            numberOfInputsForNode = 0;
            if (layerID == (byte)4)
            {
                numberOfInputsForNode = objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues();
            }
            else
            {
                numberOfInputsForNode = objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(layerID + (byte)1));
            }
            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Set_NumberOfInputs(numberOfInputsForNode);
            System.Console.WriteLine("NumberOfInputs = " + objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_NumberOfInputs());

            for (ulong inputID = 0; inputID < numberOfInputsForNode; inputID++)
            {
                objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Set_NeuralPathOfInput_SubSet(inputID, newLinearPath);
                objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_Item_On_List_Of_NeuralPathOfInput(inputID).Set_Weight(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_Random_Small_Value(-0.5, 0.5));
                objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_Item_On_List_Of_NeuralPathOfInput(inputID).Set_Bias(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_Random_Small_Value(-0.5, 0.5));
                System.Console.WriteLine("outputID = " + outputID + "  layerID = " + layerID + "  nodeID = " + nodeID + "  inputID = " + inputID + "  bias = " + objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_Item_On_List_Of_NeuralPathOfInput(inputID).Get_Bias() + "  weight = " + objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_Item_On_List_Of_NeuralPathOfInput(inputID).Get_Weight());
            }
            System.Console.WriteLine("exiting Create_Nodes.");
        }
        public void Set_NumberOfNodesInHiddenLayer(Avril_NNAI.MachineAI objNNAI, byte outputID, byte layerID)
        {
            ulong numberOfNodesInLayer = new ulong();
            numberOfNodesInLayer = 0;
            switch (layerID)
            {
                case (byte)Avril_NNAI.Global.NodeLayer.Layer_4:
                    numberOfNodesInLayer = (ulong)Math.Round((double)objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues() * (double)0.8);
                    break;

                case (byte)Avril_NNAI.Global.NodeLayer.Layer_3:
                    numberOfNodesInLayer = (ulong)Math.Round((double)objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues() * (double)0.6);
                    break;

                case (byte)Avril_NNAI.Global.NodeLayer.Layer_2:
                    numberOfNodesInLayer = (ulong)Math.Round((double)objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues() * (double)0.4);
                    break;

                case (byte)Avril_NNAI.Global.NodeLayer.Layer_1:
                    numberOfNodesInLayer = (ulong)Math.Round((double)objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues() * (double)0.2);
                    break;

                case (byte)Avril_NNAI.Global.NodeLayer.Layer_0:
                    numberOfNodesInLayer = (ulong)1;
                    break;
            }
            objNNAI.Get_MetaData().Set_NumberOfNodesInHiddenLayer(layerID, numberOfNodesInLayer);
            System.Console.WriteLine("outputID = " + outputID + "  layerID == " + layerID + "  Set_NumberOfNodesInLayer = " + objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID));
        }

// private.
        private void Create_New_Constant()
        {
            _New_Constant = new Avril_NNAI.Constant();
            while (Get_New_Constant() == null) { }
        }
        private void Create_New_Linear()
        {
            _New_Linear = new Avril_NNAI.Linear();
            while (Get_New_Linear() == null) { }
        }
        private void Calculate_NumberOfPraiseInputValues(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong praiseID)
        {
            switch (praiseID)
            {
                case (ulong)Avril_NNAI.Global.PraiseID.Praise_0:
                    Avril_NNAI.Input_Praise_0 objValue_Praise0 = (Avril_NNAI.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(0);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(objValue_Praise0.Get_NumberOfInputValues());
                    break;

                case (ulong)Avril_NNAI.Global.PraiseID.Praise_1:
                    Avril_NNAI.Input_Praise_1 objValue_Praise1 = (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(1);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(objValue_Praise1.Get_NumberOfInputValues());
                    break;

                case (ulong)Avril_NNAI.Global.PraiseID.Praise_2:
                    Avril_NNAI.Input_Praise_2 objValue_Praise2 = (Avril_NNAI.Input_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(2);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(objValue_Praise2.Get_NumberOfInputValues());
                    break;
            }
        }
        private void Calculate_NumberOfPraiseOutputValues(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong praiseID)
        {
            switch (praiseID)
            {
                case (ulong)Avril_NNAI.Global.PraiseID.Praise_0:
                    var objValue_Praise0 = (Avril_NNAI.Output_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(0);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseOutputValues(objValue_Praise0.Get_NumberOfOutputValues());
                    break;

                case (ulong)Avril_NNAI.Global.PraiseID.Praise_1:
                    var objValue_Praise1 = (Avril_NNAI.Output_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(1);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseOutputValues(objValue_Praise1.Get_NumberOfOutputValues());
                    break;

                case (ulong)Avril_NNAI.Global.PraiseID.Praise_2:
                    var objValue_Praise2 = (Avril_NNAI.Output_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(2);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseOutputValues(objValue_Praise2.Get_NumberOfOutputValues());
                    break;
            }
        }
        private void Calculate_NumberOfResetToConstantValues_INPUT(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong praiseID)
        {
            switch (praiseID)
            {
                case (ulong)Avril_NNAI.Global.PraiseID.Praise_0:
                    Avril_NNAI.Input_Praise_0 objValue_Praise0 = (Avril_NNAI.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(0);
                    objNNAI.Get_MetaData().Set_NumberOfResetToConstantValues_INPUT(objValue_Praise0.Get_NumberOfResetToConstantValues());
                    break;

                case (ulong)Avril_NNAI.Global.PraiseID.Praise_1:
                    Avril_NNAI.Input_Praise_1 objValue_Praise1 = (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(1);
                    objNNAI.Get_MetaData().Set_NumberOfResetToConstantValues_INPUT(objValue_Praise1.Get_NumberOfResetToConstantValues());
                    break;

                case (ulong)Avril_NNAI.Global.PraiseID.Praise_2:
                    Avril_NNAI.Input_Praise_2 objValue_Praise2 = (Avril_NNAI.Input_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(2);
                    objNNAI.Get_MetaData().Set_NumberOfResetToConstantValues_INPUT(objValue_Praise2.Get_NumberOfResetToConstantValues());
                    break;
            }
        }
        private void Calculate_NumberOfResetToConstantValues_OUTPUT(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong praiseID)
        {
            switch (praiseID)
            {
                case (ulong)Avril_NNAI.Global.PraiseID.Praise_0:
                    var objValue_Praise0 = (Avril_NNAI.Output_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(0);
                    objNNAI.Get_MetaData().Set_NumberOfResetToConstantValues_OUTPUT(objValue_Praise0.Get_NumberOfResetToConstantValues());
                    break;

                case (ulong)Avril_NNAI.Global.PraiseID.Praise_1:
                    var objValue_Praise1 = (Avril_NNAI.Output_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(1);
                    objNNAI.Get_MetaData().Set_NumberOfResetToConstantValues_OUTPUT(objValue_Praise1.Get_NumberOfResetToConstantValues());
                    break;

                case (ulong)Avril_NNAI.Global.PraiseID.Praise_2:
                    var objValue_Praise2 = (Avril_NNAI.Output_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(2);
                    objNNAI.Get_MetaData().Set_NumberOfResetToConstantValues_OUTPUT(objValue_Praise2.Get_NumberOfResetToConstantValues());
                    break;
            }
        }
    // get.
    // set.

    }
}


namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class NeuralPath
    {
// definitionns.

// classes.
        private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Constant _New_Constant;
        private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear _New_Linear;
            
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
        public void Calculate_Neural_Network_Parameters(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj, OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI, byte praiseID)
        {
    // generate input parameters.
            switch (praiseID)
            {
                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.PraiseID.Praise_0:
                    OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Input_Praise_0 objValue_Praise0 = (OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(0);
                    objNNI.Get_MetaData().Set_NumberOfPraiseInputValues(objValue_Praise0.Get_NumberOfInputValues());
                    objNNI.Get_MetaData().Set_NumberOfResetToConstantValues_INPUT(objValue_Praise0.Get_NumberOfResetToConstantValues());
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.PraiseID.Praise_1:
                    OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Input_Praise_1 objValue_Praise1 = (OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(1);
                    objNNI.Get_MetaData().Set_NumberOfPraiseInputValues(objValue_Praise1.Get_NumberOfInputValues());
                    objNNI.Get_MetaData().Set_NumberOfResetToConstantValues_INPUT(objValue_Praise1.Get_NumberOfResetToConstantValues());
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.PraiseID.Praise_2:
                    OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Input_Praise_2 objValue_Praise2 = (OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Input_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(2);
                    objNNI.Get_MetaData().Set_NumberOfPraiseInputValues(objValue_Praise2.Get_NumberOfInputValues());
                    objNNI.Get_MetaData().Set_NumberOfResetToConstantValues_INPUT(objValue_Praise2.Get_NumberOfResetToConstantValues());
                    break;
            }
    // generate output parameters.
            switch (praiseID)
            {
                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.PraiseID.Praise_0:
                    var objValue_Praise0 = (OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(0);
                    objNNI.Get_MetaData().Set_NumberOfPraiseOutputValues(objValue_Praise0.Get_NumberOfOutputValues());
                    objNNI.Get_MetaData().Set_NumberOfResetToConstantValues_OUTPUT(objValue_Praise0.Get_NumberOfResetToConstantValues());
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.PraiseID.Praise_1:
                    var objValue_Praise1 = (OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(1);
                    objNNI.Get_MetaData().Set_NumberOfPraiseOutputValues(objValue_Praise1.Get_NumberOfOutputValues());
                    objNNI.Get_MetaData().Set_NumberOfResetToConstantValues_OUTPUT(objValue_Praise1.Get_NumberOfResetToConstantValues());
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.PraiseID.Praise_2:
                    var objValue_Praise2 = (OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(2);
                    objNNI.Get_MetaData().Set_NumberOfPraiseOutputValues(objValue_Praise2.Get_NumberOfOutputValues());
                    objNNI.Get_MetaData().Set_NumberOfResetToConstantValues_OUTPUT(objValue_Praise2.Get_NumberOfResetToConstantValues());
                    break;
            }
            System.Console.WriteLine("NumberOfPraiseInputValues = " + objNNI.Get_MetaData().Get_NumberOfPraiseInputValues());
            System.Console.WriteLine("NumberOfPraiseOutputValues = " + objNNI.Get_MetaData().Get_NumberOfPraiseOutputValues());
            System.Console.WriteLine("NumberOfResetToConstantValues_INPUT = " + objNNI.Get_MetaData().Get_NumberOfResetToConstantValues_INPUT());
            System.Console.WriteLine("NumberOfResetToConstantValues_OUTPUT = " + objNNI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT());
    // generate nodes in hidden layers.
            for (Int16 layerID = 4; layerID > -1; layerID--)
            {
                byte hiddenlayerID = Convert.ToByte(layerID);
                Set_NumberOfNodesInHiddenLayer(objNNI, hiddenlayerID);
            }
        }
        public void Create_Layer_Nodes(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI, byte outputID, byte layerID)
        {
            var newEmptyNode = new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Node();
            while (newEmptyNode == null) { }

            switch (layerID)
            {
                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.NodeLayer.Layer_4:
                    objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer4_Nodes(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.NodeLayer.Layer_3:
                    objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer3_Nodes(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.NodeLayer.Layer_2:
                    objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer2_Nodes(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.NodeLayer.Layer_1:
                    objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer1_Nodes(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.NodeLayer.Layer_0:
                    objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer0_Node(newEmptyNode);
                    break;
            }
            for (byte nodeID = 0; nodeID < objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID); nodeID++)
            {
                objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Set_Node(layerID, nodeID, newEmptyNode);
            }
            
        }
        public double Generate_Initial_Random_Small_Value(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
        public void Generate_REGISTERED_Inputs_List(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj, OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI, byte praiseID)
        {
            switch (praiseID)
            {
                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.PraiseID.Praise_0:
                    OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Input_Praise_0 subsetOfInput_Praise_0 = (OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(0);
                    objNNI.Create_List_Of_REGISTERED_Inputs(subsetOfInput_Praise_0.Get_NumberOfInputValues());
                    for (byte index = 0; index < subsetOfInput_Praise_0.Get_NumberOfInputValues(); index++)
                    {
                        subsetOfInput_Praise_0.Set_Item_On_List_Of_Input_Praise(index, 0.0);
                    }
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.PraiseID.Praise_1:
                    OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Input_Praise_1 subsetOfInput_Praise_1 = (OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(1);
                    objNNI.Create_List_Of_REGISTERED_Inputs(subsetOfInput_Praise_1.Get_NumberOfInputValues());
                    for (byte index = 0; index < subsetOfInput_Praise_1.Get_NumberOfInputValues(); index++)
                    {
                        subsetOfInput_Praise_1.Set_Item_On_List_Of_Input_Praise(index, 0.0);
                    }
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.PraiseID.Praise_2:
                    OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Input_Praise_2 subsetOfInput_Praise_2 = (OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Input_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(2);
                    objNNI.Create_List_Of_REGISTERED_Inputs(subsetOfInput_Praise_2.Get_NumberOfInputValues());
                    for (byte index = 0; index < subsetOfInput_Praise_2.Get_NumberOfInputValues(); index++)
                    {
                        subsetOfInput_Praise_2.Set_Item_On_List_Of_Input_Praise(index, 0.0);
                    }
                    break;

                default:
                    break;
            }
        }
        public void Generate_REGISTERED_Outputs_List(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj, OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI, byte praiseID)
        {
            switch (praiseID)
            {
                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.PraiseID.Praise_0:
                    OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output_Praise_0 subsetOfOutput_Praise_0 = (OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(0);
                    objNNI.Create_List_Of_REGISTERED_Outputs(subsetOfOutput_Praise_0.Get_NumberOfOutputValues());
                    for (byte index = 0; index < subsetOfOutput_Praise_0.Get_NumberOfOutputValues(); index++)
                    {
                        subsetOfOutput_Praise_0.Set_Item_On_List_Of_Praise_Output(index, 0.0);
                    }
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.PraiseID.Praise_1:
                    OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output_Praise_1 subsetOfOutput_Praise_1 = (OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(1);
                    objNNI.Create_List_Of_REGISTERED_Outputs(subsetOfOutput_Praise_1.Get_NumberOfOutputValues());
                    for (byte index = 0; index < subsetOfOutput_Praise_1.Get_NumberOfOutputValues(); index++)
                    {
                        subsetOfOutput_Praise_1.Set_Item_On_List_Of_Praise_Output(index, 0.0);
                    }
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.PraiseID.Praise_2:
                    OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output_Praise_2 subsetOfOutput_Praise_2 = (OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(2);
                    objNNI.Create_List_Of_REGISTERED_Outputs(subsetOfOutput_Praise_2.Get_NumberOfOutputValues());
                    for (byte index = 0; index < subsetOfOutput_Praise_2.Get_NumberOfOutputValues(); index++)
                    {
                        subsetOfOutput_Praise_2.Set_Item_On_List_Of_Praise_Output(index, 0.0);
                    }
                    break;

                default:
                    break;
            }
        }
    // get.
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Constant Get_New_Constant()
        {
            return _New_Constant;
        }
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear Get_New_Linear()
        {
            return _New_Linear;
        }
    // set.
        public void Set_Constant_From_Output_Subset(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj, OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI, byte outputID)
        {
            byte numberOfInputsForNode = new byte();
            numberOfInputsForNode = objNNI.Get_MetaData().Get_NumberOfPraiseInputValues();
            
            switch (objNNI.Get_MetaData().Get_PraiseID())
            {
                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.PraiseID.Praise_0:
                    OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output_Praise_0 objobjOutputSubset_Praise0 = (OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(outputID);
                    for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
                    {
                        objNNI.Get_Item_On_List_Of_Constant(inputID).Set_Constant(objobjOutputSubset_Praise0.Get_Item_On_List_Of_Praise_Output(inputID));
                    }
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.PraiseID.Praise_1:
                    OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output_Praise_1 objOutputSubset_Praise1 = (OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(outputID);
                    for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
                    {
                        objNNI.Get_Item_On_List_Of_Constant(inputID).Set_Constant(objOutputSubset_Praise1.Get_Item_On_List_Of_Praise_Output(inputID));
                    }
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.PraiseID.Praise_2:
                    OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output_Praise_2 objobjOutputSubset_Praise2 = (OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(outputID);
                    for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
                    {
                        objNNI.Get_Item_On_List_Of_Constant(inputID).Set_Constant(objobjOutputSubset_Praise2.Get_Item_On_List_Of_Praise_Output(inputID));
                    }
                    break;
            }

        }
        public void Set_Neural_Path_For_Input(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj, OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI, byte outputID, byte layerID, byte nodeID)
        {
            System.Console.WriteLine("entered Create_Nodes.");

            var newLinearPath = new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear();
            while (newLinearPath == null) { }

            byte numberOfInputsForNode = new byte();
            numberOfInputsForNode = 0;
            if (layerID == (byte)4)
            {
                numberOfInputsForNode = objNNI.Get_MetaData().Get_NumberOfPraiseInputValues();
            }
            else
            {
                numberOfInputsForNode = objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(layerID + (byte)1));
            }
            objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Set_NumberOfInputs(numberOfInputsForNode);
            System.Console.WriteLine("NumberOfInputs = " + objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_NumberOfInputs());

            for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
            {
                objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Set_NeuralPathOfInput_SubSet(inputID, newLinearPath);
                objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_Item_On_List_Of_NeuralPathOfInput(inputID).Set_Weight(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_Random_Small_Value(-0.5, 0.5));
                objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_Item_On_List_Of_NeuralPathOfInput(inputID).Set_Bias(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_Random_Small_Value(-0.5, 0.5));
                System.Console.WriteLine("outputID = " + outputID + "  layerID = " + layerID + "  nodeID = " + nodeID + "  inputID = " + inputID + "  bias = " + objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_Item_On_List_Of_NeuralPathOfInput(inputID).Get_Bias() + "  weight = " + objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_Item_On_List_Of_NeuralPathOfInput(inputID).Get_Weight());
            }
            System.Console.WriteLine("exiting Create_Nodes.");
        }
        

// private.
        private void Create_New_Constant()
        {
            _New_Constant = new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Constant();
            while (Get_New_Constant() == null) { }
        }
        private void Create_New_Linear()
        {
            _New_Linear = new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear();
            while (Get_New_Linear() == null) { }
        }
    // get.
    // set.
        private void Set_NumberOfNodesInHiddenLayer(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI, byte layerID)
        {
            byte numberOfNodesInLayer = new byte();
            numberOfNodesInLayer = 0;
            switch (layerID)
            {
                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.NodeLayer.Layer_4:
                    numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberOfPraiseInputValues() * (double)0.8);
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.NodeLayer.Layer_3:
                    numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberOfPraiseInputValues() * (double)0.6);
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.NodeLayer.Layer_2:
                    numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberOfPraiseInputValues() * (double)0.4);
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.NodeLayer.Layer_1:
                    numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberOfPraiseInputValues() * (double)0.2);
                    break;

                case (byte)OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Global.NodeLayer.Layer_0:
                    numberOfNodesInLayer = (byte)1;
                    break;
            }
            objNNI.Get_MetaData().Set_NumberOfNodesInHiddenLayer(layerID, numberOfNodesInLayer);
            System.Console.WriteLine("layerID == " + layerID + "  Set_NumberOfNodesInLayer = " + objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID));
        }
    }
}

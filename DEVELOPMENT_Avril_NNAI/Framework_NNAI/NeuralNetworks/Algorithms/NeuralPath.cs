
namespace OpenAvrilNNI
{
    public class NeuralPath
    {
// definitionns.

// classes.
        private OpenAvrilNNI.Binary _New_Binary;
        private OpenAvrilNNI.Constant _New_Constant;
        private OpenAvrilNNI.Linear _New_Linear;
        private OpenAvrilNNI.Linear_NeuralPath _New_Linear_NeuralPath;

        // registers.

        // constructor.
        public NeuralPath() 
        {
            //System.Console.WriteLine("entered NeuralPath.");
            Create_New_Linear();
            Create_New_Constant();
            Create_New_Boolean();
            Create_New_Linear_NeuralPath();
            //System.Console.WriteLine("exiting NeuralPath.");
        }

// destructor
        ~NeuralPath()
        {

        }

// public.
        public void Generate_MetaData_For_Neural_Network(OpenAvrilNNI.Framework_NNI obj, OpenAvrilNNI.MachineAI objNNI, byte praiseID)
        {
    // io id.
            objNNI.Get_MetaData().Set_PraiseID(praiseID);
    // generate io parameters.
            switch (objNNI.Get_MetaData().Get_PraiseID())
            {
                case (byte)OpenAvrilNNI.Global.PraiseID.Praise_0:
                    OpenAvrilNNI.Input_Praise_0 objValue_Praise0_I = (OpenAvrilNNI.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(0);
                    objNNI.Get_MetaData().Set_NumberInputRegisters(objValue_Praise0_I.Get_NumberInputRegisters());
                    objNNI.Get_MetaData().Set_NumberOfLinearInputs(objValue_Praise0_I.Get_NumberOfLinearInputs());
                    objNNI.Get_MetaData().Set_NumberOfBooleanInputs(objValue_Praise0_I.Get_NumberOfBooleanInputs());
                    objNNI.Get_MetaData().Set_NumberOfConstantInputs(objValue_Praise0_I.Get_NumberOfConstantInputs());
                    OpenAvrilNNI.Output_Praise_0 objValue_Praise0_O = (OpenAvrilNNI.Output_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(0);
                    objNNI.Get_MetaData().Set_NumberOutputRegisters(objValue_Praise0_O.Get_NumberOutputRegisters());
                    objNNI.Get_MetaData().Set_NumberOfLinearOutputs(objValue_Praise0_O.Get_NumberOfLinearOutputs());
                    objNNI.Get_MetaData().Set_NumberOfBooleanOutputs(objValue_Praise0_O.Get_NumberOfBooleanOutputs());
                    objNNI.Get_MetaData().Set_NumberOfConstantOutputs(objValue_Praise0_O.Get_NumberOfConstantOutputs());
                    break;

                case (byte)OpenAvrilNNI.Global.PraiseID.Praise_1:
                    OpenAvrilNNI.Input_Praise_1 objValue_Praise1_I = (OpenAvrilNNI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(1);
                    objNNI.Get_MetaData().Set_NumberInputRegisters(objValue_Praise1_I.Get_NumberInputRegisters());
                    objNNI.Get_MetaData().Set_NumberOfLinearInputs(objValue_Praise1_I.Get_NumberOfLinearInputs());
                    objNNI.Get_MetaData().Set_NumberOfBooleanInputs(objValue_Praise1_I.Get_NumberOfBooleanInputs());
                    objNNI.Get_MetaData().Set_NumberOfConstantInputs(objValue_Praise1_I.Get_NumberOfConstantInputs());
                    OpenAvrilNNI.Output_Praise_1 objValue_Praise1_O = (OpenAvrilNNI.Output_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(1);
                    objNNI.Get_MetaData().Set_NumberOutputRegisters(objValue_Praise1_O.Get_NumberOutputRegisters());
                    objNNI.Get_MetaData().Set_NumberOfLinearOutputs(objValue_Praise1_O.Get_NumberOfLinearOutputs());
                    objNNI.Get_MetaData().Set_NumberOfBooleanOutputs(objValue_Praise1_O.Get_NumberOfBooleanOutputs());
                    objNNI.Get_MetaData().Set_NumberOfConstantOutputs(objValue_Praise1_O.Get_NumberOfConstantOutputs());
                    break;

                case (byte)OpenAvrilNNI.Global.PraiseID.Praise_2:
                    OpenAvrilNNI.Input_Praise_2 objValue_Praise2_I = (OpenAvrilNNI.Input_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Item_On_List_Of_Input_Subsets(2);
                    objNNI.Get_MetaData().Set_NumberInputRegisters(objValue_Praise2_I.Get_NumberInputRegisters());
                    objNNI.Get_MetaData().Set_NumberOfLinearInputs(objValue_Praise2_I.Get_NumberOfLinearInputs());
                    objNNI.Get_MetaData().Set_NumberOfBooleanInputs(objValue_Praise2_I.Get_NumberOfBooleanInputs());
                    objNNI.Get_MetaData().Set_NumberOfConstantInputs(objValue_Praise2_I.Get_NumberOfConstantInputs());
                    OpenAvrilNNI.Output_Praise_2 objValue_Praise2_O = (OpenAvrilNNI.Output_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(2);
                    objNNI.Get_MetaData().Set_NumberOutputRegisters(objValue_Praise2_O.Get_NumberOutputRegisters());
                    objNNI.Get_MetaData().Set_NumberOfLinearOutputs(objValue_Praise2_O.Get_NumberOfLinearOutputs());
                    objNNI.Get_MetaData().Set_NumberOfBooleanOutputs(objValue_Praise2_O.Get_NumberOfBooleanOutputs());
                    objNNI.Get_MetaData().Set_NumberOfConstantOutputs(objValue_Praise2_O.Get_NumberOfConstantOutputs());
                    break;

                case byte.MaxValue:
                    objNNI.Get_MetaData().Set_NumberInputRegisters(0);
                    objNNI.Get_MetaData().Set_NumberOfLinearInputs(0);
                    objNNI.Get_MetaData().Set_NumberOfBooleanInputs(0);
                    objNNI.Get_MetaData().Set_NumberOfConstantInputs(0);
                    objNNI.Get_MetaData().Set_NumberOutputRegisters(0);
                    objNNI.Get_MetaData().Set_NumberOfLinearOutputs(0);
                    objNNI.Get_MetaData().Set_NumberOfBooleanOutputs(0);
                    objNNI.Get_MetaData().Set_NumberOfConstantOutputs(0);
                    break;
            }
            System.Console.WriteLine("_NumberInputRegisters = " + objNNI.Get_MetaData().Get_NumberInputRegisters());
            System.Console.WriteLine("_NumberOfLinearInputs = " + objNNI.Get_MetaData().Get_NumberOfLinearInputs());
            System.Console.WriteLine("_NumberOfBooleanInputs = " + objNNI.Get_MetaData().Get_NumberOfBooleanInputs());
            System.Console.WriteLine("_NumberOfConstantInputs = " + objNNI.Get_MetaData().Get_NumberOfConstantInputs());
            System.Console.WriteLine("_NumberOutputRegisters = " + objNNI.Get_MetaData().Get_NumberOutputRegisters());
            System.Console.WriteLine("_NumberOfLinearOutputs = " + objNNI.Get_MetaData().Get_NumberOfLinearOutputs());
            System.Console.WriteLine("_NumberOfBooleanOutputs = " + objNNI.Get_MetaData().Get_NumberOfBooleanOutputs());
            System.Console.WriteLine("_NumberOfConstantOutputs = " + objNNI.Get_MetaData().Get_NumberOfConstantOutputs());
    // generate nodes in hidden layers.
            for (Int16 layerID = 4; layerID > -1; layerID--)
            {
                byte hiddenlayerID = Convert.ToByte(layerID);
                Set_NumberOfNodesInHiddenLayer(objNNI, hiddenlayerID);
            }

		}
        public void Create_Layer_Nodes(OpenAvrilNNI.MachineAI objNNI, byte outputID, byte layerID)
        {
            var newEmptyNode = new OpenAvrilNNI.Node();
            while (newEmptyNode == null) { }

            switch (layerID)
            {
                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_4:
                    objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Create_Layer4_Nodes(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                    break;

                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_3:
                    objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Create_Layer3_Nodes(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                    break;

                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_2:
                    objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Create_Layer2_Nodes(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                    break;

                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_1:
                    objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Create_Layer1_Nodes(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                    break;

                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_0:
                    objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Create_Layer0_Node(newEmptyNode);
                    break;
            }
            for (byte nodeID = 0; nodeID < objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID); nodeID++)
            {
                objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Set_Node(layerID, nodeID, newEmptyNode);
            }
            
        }
        public double Generate_Initial_Random_Small_Value(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
        public void Generate_REGISTERED_Inputs_List(OpenAvrilNNI.Framework_NNI obj, OpenAvrilNNI.MachineAI objNNI)
        {
            objNNI.Create_List_Of_REGISTERED_Inputs(objNNI.Get_MetaData().Get_NumberInputRegisters());
            for (byte index = 0; index < objNNI.Get_MetaData().Get_NumberInputRegisters(); index++)
            {
                objNNI.Set_Item_On_List_Of_REGISTERED_Input(index, 0.0);
            }
        }
        public void Generate_REGISTERED_Outputs_List(OpenAvrilNNI.Framework_NNI obj, OpenAvrilNNI.MachineAI objNNI)
        {
            objNNI.Create_List_Of_REGISTERED_Outputs(objNNI.Get_MetaData().Get_NumberOutputRegisters());
            for (byte index = 0; index < objNNI.Get_MetaData().Get_NumberOutputRegisters(); index++)
            {
                objNNI.Set_Item_On_List_Of_REGISTERED_Output(index, 0.0);
            }
        }
    // get.
        public OpenAvrilNNI.Binary Get_New_Boolean()
        {
            return _New_Binary;
        }
        public OpenAvrilNNI.Constant Get_New_Constant()
        {
            return _New_Constant;
        }
        public OpenAvrilNNI.Linear Get_New_Linear()
        {
            return _New_Linear;
        }
        public OpenAvrilNNI.Linear_NeuralPath Get_New_Linear_NeuralPath()
        {
            return _New_Linear_NeuralPath;
        }
    // set.
        public void Set_Constant_From_Output_Subset(OpenAvrilNNI.Framework_NNI obj, OpenAvrilNNI.MachineAI objNNI, byte outputID)
        {
            switch (objNNI.Get_MetaData().Get_PraiseID())
            {
                case (byte)OpenAvrilNNI.Global.PraiseID.Praise_0:
                    OpenAvrilNNI.Output_Praise_0 objobjOutputSubset_Praise0 = (OpenAvrilNNI.Output_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(outputID);
                    for (byte index = 0; index < objNNI.Get_MetaData().Get_NumberOutputRegisters(); index++)
                    {
                        objNNI.Get_Item_On_List_Of_Constant_Paths(index).Set_Constant(objobjOutputSubset_Praise0.Get_Item_On_List_Of_Praise_Output(index));
                    }
                    break;

                case (byte)OpenAvrilNNI.Global.PraiseID.Praise_1:
                    OpenAvrilNNI.Output_Praise_1 objOutputSubset_Praise1 = (OpenAvrilNNI.Output_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(outputID);
                    for (byte index = 0; index < objNNI.Get_MetaData().Get_NumberOutputRegisters(); index++)
                    {
                        objNNI.Get_Item_On_List_Of_Constant_Paths(index).Set_Constant(objOutputSubset_Praise1.Get_Item_On_List_Of_Praise_Output(index));
                    }
                    break;

                case (byte)OpenAvrilNNI.Global.PraiseID.Praise_2:
                    OpenAvrilNNI.Output_Praise_2 objobjOutputSubset_Praise2 = (OpenAvrilNNI.Output_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Item_On_List_Of_OutputSubsets(outputID);
                    for (byte index = 0; index < objNNI.Get_MetaData().Get_NumberOutputRegisters(); index++)
                    {
                        objNNI.Get_Item_On_List_Of_Constant_Paths(index).Set_Constant(objobjOutputSubset_Praise2.Get_Item_On_List_Of_Praise_Output(index));
                    }
                    break;
            }

        }
        public void Set_Neural_Path_For_Input(OpenAvrilNNI.Framework_NNI obj, OpenAvrilNNI.MachineAI objNNI, byte outputID, byte layerID, byte nodeID)
        {
            System.Console.WriteLine("entered Create_Nodes.");
            byte numberOfInputsForNode = new byte();
            numberOfInputsForNode = 0;
            if (layerID == (byte)4)
            {
                numberOfInputsForNode = objNNI.Get_MetaData().Get_NumberInputRegisters();
            }
            else
            {
                numberOfInputsForNode = objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(layerID + (byte)1));
            }
            objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(layerID, nodeID).Set_NumberOfInputs(numberOfInputsForNode);
            System.Console.WriteLine("NumberOfInputs = " + objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(layerID, nodeID).Get_NumberOfInputs());

            for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
            {
                objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(layerID, nodeID).Set_Item_On_List_Of_Linear_NeuralPath(inputID, obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Get_New_Linear_NeuralPath());
                objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(layerID, nodeID).Get_Item_On_List_Of_Linear_NeuralPath(inputID).Set_Weight(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_Random_Small_Value(-0.5, 0.5));
                objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(layerID, nodeID).Get_Item_On_List_Of_Linear_NeuralPath(inputID).Set_Bias(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_Random_Small_Value(-0.5, 0.5));
                System.Console.WriteLine("outputID = " + outputID + "  layerID = " + layerID + "  nodeID = " + nodeID + "  inputID = " + inputID + "  bias = " + objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(layerID, nodeID).Get_Item_On_List_Of_Linear_NeuralPath(inputID).Get_Bias() + "  weight = " + objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(layerID, nodeID).Get_Item_On_List_Of_Linear_NeuralPath(inputID).Get_Weight());
            }
            System.Console.WriteLine("exiting Create_Nodes.");
        }


// private.
        private void Create_New_Boolean()
        {
            _New_Binary = new OpenAvrilNNI.Binary();
            while (Get_New_Boolean() == null) { }
        }
        private void Create_New_Constant()
        {
            _New_Constant = new OpenAvrilNNI.Constant();
            while (Get_New_Constant() == null) { }
        }
        private void Create_New_Linear()
        {
            _New_Linear = new OpenAvrilNNI.Linear();
            while (Get_New_Linear() == null) { }
        }
        private void Create_New_Linear_NeuralPath()
        {
            _New_Linear_NeuralPath = new OpenAvrilNNI.Linear_NeuralPath();
            while (Get_New_Linear_NeuralPath() == null) { }
        }
    // get.
    // set.
        private void Set_New_Boolean(OpenAvrilNNI.Binary newValue)
        {
            _New_Binary = newValue;
        }
        private void Set_New_Constant(OpenAvrilNNI.Constant newValue)
        {
            _New_Constant = newValue;
        }
        private void Set_New_Linear(OpenAvrilNNI.Linear newValue)
        {
            _New_Linear = newValue;
        }
        private void Set_New_Linear_NeuralPath(OpenAvrilNNI.Linear_NeuralPath newValue)
        {
            _New_Linear_NeuralPath = newValue;
        }
        private void Set_NumberOfNodesInHiddenLayer(OpenAvrilNNI.MachineAI objNNI, byte layerID)
        {
            byte numberOfNodesInLayer = new byte();
            numberOfNodesInLayer = 0;
            switch (layerID)
            {
                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_4:
                    numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberOfLinearInputs() * (double)0.8);
                    break;

                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_3:
                    numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberOfLinearInputs() * (double)0.6);
                    break;

                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_2:
                    numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberOfLinearInputs() * (double)0.4);
                    break;

                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_1:
                    numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberOfLinearInputs() * (double)0.2);
                    break;

                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_0:
                    numberOfNodesInLayer = (byte)1;
                    break;
            }
            objNNI.Get_MetaData().Set_NumberOfNodesInHiddenLayer(layerID, numberOfNodesInLayer);
            System.Console.WriteLine("layerID == " + layerID + "  Set_NumberOfNodesInLayer = " + objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID));
        }
    }
}

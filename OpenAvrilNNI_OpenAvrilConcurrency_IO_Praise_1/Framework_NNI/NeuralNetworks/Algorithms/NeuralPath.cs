
namespace OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1
{
    public class NeuralPath
    {
// definitionns.

// classes.
        private Binary _New_Boolean;
        private Constant _New_Constant;
        private Linear _New_Linear;
        private Linear_NeuralPath _New_Linear_NeuralPath;
        private Node _New_Node;

// registers.

// constructor.
        public NeuralPath() 
        {
            //System.Console.WriteLine("entered NeuralPath.");
            Create_New_Linear();
            Create_New_Constant();
            Create_New_Boolean();
            Create_New_Linear_NeuralPath();
            Create_New_Node();
            //System.Console.WriteLine("exiting NeuralPath.");
        }

// destructor
        ~NeuralPath()
        {

        }

// public.
        public void Generate_MetaData_For_Neural_Network(Framework_NNI obj, MachineAI objNNI, byte praiseID)
        {
    // io id.
            objNNI.Get_MetaData().Set_PraiseID(praiseID);
    // generate io parameters.
            objNNI.Get_MetaData().Set_NumberInputRegisters(obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Input_Praise_1().Get_NumberInputRegisters());
            objNNI.Get_MetaData().Set_NumberOfLinearInputs(obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Input_Praise_1().Get_NumberOfLinearInputs());
            objNNI.Get_MetaData().Set_NumberOfBooleanInputs(obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Input_Praise_1().Get_NumberOfBooleanInputs());
            objNNI.Get_MetaData().Set_NumberOfConstantInputs(obj.Get_Neural_Networks().Get_Data().Get_Input().Get_Input_Praise_1().Get_NumberOfConstantInputs());
            objNNI.Get_MetaData().Set_NumberOutputRegisters(obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Output_Praise_1().Get_NumberOutputRegisters());
            objNNI.Get_MetaData().Set_NumberOfLinearOutputs(obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Output_Praise_1().Get_NumberOfLinearOutputs());
            objNNI.Get_MetaData().Set_NumberOfBooleanOutputs(obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Output_Praise_1().Get_NumberOfBooleanOutputs());
            objNNI.Get_MetaData().Set_NumberOfConstantOutputs(obj.Get_Neural_Networks().Get_Data().Get_Output().Get_Output_Praise_1().Get_NumberOfConstantOutputs());
                   
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
        public double Generate_Initial_Random_Small_Value(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
        public void Generate_REGISTERED_Inputs_List(OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Framework_NNI obj, OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.MachineAI objNNI)
        {
            objNNI.Create_List_Of_REGISTERED_Inputs(objNNI.Get_MetaData().Get_NumberInputRegisters());
            for (byte index = 0; index < objNNI.Get_MetaData().Get_NumberInputRegisters(); index++)
            {
                objNNI.Set_Item_On_List_Of_REGISTERED_Input(index, 0.0);
            }
        }
        public void Generate_REGISTERED_Outputs_List(OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Framework_NNI obj, OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.MachineAI objNNI)
        {
            objNNI.Create_List_Of_REGISTERED_Outputs(objNNI.Get_MetaData().Get_NumberOutputRegisters());
            for (byte index = 0; index < objNNI.Get_MetaData().Get_NumberOutputRegisters(); index++)
            {
                objNNI.Set_Item_On_List_Of_REGISTERED_Output(index, 0.0);
            }
        }
    // get.
        public OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Binary Get_New_Boolean()
        {
            return _New_Boolean;
        }
        public OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Constant Get_New_Constant()
        {
            return _New_Constant;
        }
        public OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Linear Get_New_Linear()
        {
            return _New_Linear;
        }
        public OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Linear_NeuralPath Get_New_Linear_NeuralPath()
        {
            return _New_Linear_NeuralPath;
        }
        public OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Node Get_New_Node()
        {
            return _New_Node;
        }
    // set.
        public void Set_Constant_From_Output_Subset(OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Framework_NNI obj, OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.MachineAI objNNI, byte outputID)
        {
            for (byte index = 0; index < objNNI.Get_MetaData().Get_NumberOutputRegisters(); index++)
            {
                //Todo
            }
        }
        public void Set_Linear_NeuralPath_For_Input(OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Framework_NNI obj, OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.MachineAI objNNI, byte outputID, byte layerID, byte nodeID)
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
            Set_New_Boolean(new OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Binary());
            while (Get_New_Boolean() == null) { }
        }
        private void Create_New_Constant()
        {
            Set_New_Constant(new OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Constant());
            while (Get_New_Constant() == null) { }
        }
        private void Create_New_Linear()
        {
            Set_New_Linear(new OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Linear());
            while (Get_New_Linear() == null) { }
        }
        private void Create_New_Linear_NeuralPath()
        {
            Set_New_Linear_NeuralPath(new OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Linear_NeuralPath());
            while (Get_New_Linear_NeuralPath() == null) { }
        }
        private void Create_New_Node()
        {
            Set_New_Node(new OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Node());
            while (Get_New_Node() == null) { }
        }
        // get.
        // set.
        private void Set_New_Boolean(OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Binary newValue)
        {
            _New_Boolean = newValue;
        }
        private void Set_New_Constant(OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Constant newValue)
        {
            _New_Constant = newValue;
        }
        private void Set_New_Linear(OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Linear newValue)
        {
            _New_Linear = newValue;
        }
        private void Set_New_Linear_NeuralPath(OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Linear_NeuralPath newValue)
        {
            _New_Linear_NeuralPath = newValue;
        }
        private void Set_New_Node(OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Node newValue)
        {
            _New_Node = newValue;
        }
        private void Set_NumberOfNodesInHiddenLayer(OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.MachineAI objNNI, byte layerID)
        {
            byte numberOfNodesInLayer = new byte();
            numberOfNodesInLayer = 0;
            switch (layerID)
            {
                case (byte)OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Global.NodeLayer.Layer_4:
                    numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberInputRegisters() * (double)0.8);
                    break;

                case (byte)OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Global.NodeLayer.Layer_3:
                    numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberInputRegisters() * (double)0.6);
                    break;

                case (byte)OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Global.NodeLayer.Layer_2:
                    numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberInputRegisters() * (double)0.4);
                    break;

                case (byte)OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Global.NodeLayer.Layer_1:
                    numberOfNodesInLayer = (byte)Math.Round((double)objNNI.Get_MetaData().Get_NumberInputRegisters() * (double)0.2);
                    break;

                case (byte)OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1.Global.NodeLayer.Layer_0:
                    numberOfNodesInLayer = (byte)1;
                    break;
            }
            objNNI.Get_MetaData().Set_NumberOfNodesInHiddenLayer(layerID, numberOfNodesInLayer);
            System.Console.WriteLine("layerID == " + layerID + "  Set_NumberOfNodesInLayer = " + objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID));
        }
    }
}

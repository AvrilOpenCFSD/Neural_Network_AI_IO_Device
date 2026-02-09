
namespace OpenAvrilNNI
{
    public class MachineAI
    {
// classes.
        private Binary[] _List_Of_Binary_Paths;
        private Constant[] _List_Of_Constant_Paths;
        private Linear[] _List_Of_Linear_Paths;
        private OpenAvrilNNI.MetaData _MetaData;

// registers.
        private bool _isNewDataReady;
        private double[] _REGISTERED_Inputs;
        private double[] _REGISTERED_Outputs;

// constructor.
        public MachineAI()
        {
            //System.Console.WriteLine("entered MachineAI.");
            Create_MetaData();
            Create_List_Of_REGISTERED_Inputs(Get_MetaData().Get_NumberInputRegisters());
            Create_List_Of_Linear_Paths(Get_MetaData().Get_NumberOfLinearOutputs());
            Create_List_Of_Binary_Paths(Get_MetaData().Get_NumberOfBooleanOutputs());
            Create_List_Of_Constant_Paths(Get_MetaData().Get_NumberOfConstantOutputs());
            Create_List_Of_REGISTERED_Outputs(Get_MetaData().Get_NumberOutputRegisters());
            Create_IsNewDataReady();
        }

// destructor.
        ~MachineAI()
        {
        }

// public.
        public void Create_List_Of_Binary_Paths(byte numberOfBinaryValues)
        {
            _List_Of_Binary_Paths = new Binary[numberOfBinaryValues];
            while (Get_List_Of_Binary_Paths() == null) { }
            for (byte index =0; index < numberOfBinaryValues; index++)
            {
                Set_Item_On_List_Of_Binary_Paths(index, new Binary());
            }
        }
        public void Create_List_Of_Constant_Paths(byte numberOfResetToConstantValues)
        {
            _List_Of_Constant_Paths = new Constant[numberOfResetToConstantValues];
            while (Get_List_Of_Constant_Paths() == null) { }
            for(byte index = 0; index < numberOfResetToConstantValues; index++)
            {
                Set_Item_On_List_Of_Constant_Paths(index, new Constant());
            }
        }
        public void Create_List_Of_Linear_Paths(byte numberOfInputValuesForNode)
        {
            _List_Of_Linear_Paths = new Linear[numberOfInputValuesForNode];
            while (Get_List_Of_Linear_Paths() == null) { }
            for (byte index = 0; index < numberOfInputValuesForNode; index++)
            {
                Set_Item_On_List_Of_Linear_Paths(index, new Linear());
            }
        }
        public void Create_List_Of_REGISTERED_Inputs(byte numberOfInputValues)
        {
            _REGISTERED_Inputs = new double[numberOfInputValues];
            for (byte index = 0; index < numberOfInputValues; index++)
            {
                Set_Item_On_List_Of_REGISTERED_Input(index, 0.0);
            }
        }
        public void Create_List_Of_REGISTERED_Outputs(byte numberOfOutputValues)
        {
            _REGISTERED_Outputs = new double[numberOfOutputValues];
            for (byte index = 0; index < numberOfOutputValues; index++)
            {
                Set_Item_On_List_Of_REGISTERED_Output(index, 0.0);
            }
        }
        public bool Run_Neural_Network_Inteligence(OpenAvrilNNI.MachineAI objNNI)
        {
            if (objNNI.Get_IsNewDataReady() == false)
            {
                for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfLinearOutputs(); outputID++)
                {
                    for (Int16 layerID = 4; layerID > -1; layerID--)
                    {
                        byte hiddenLayerID = Convert.ToByte(layerID);
                        for (byte nodeID = 0; nodeID < objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                        {
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
                            objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Run_All_Neural_Path_Calculation(objNNI, outputID, hiddenLayerID, nodeID, numberOfInputsForNode);
                        }
                    }
                    objNNI.Set_Item_On_List_Of_REGISTERED_Output(outputID, objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(0, 1).Get_REGISTERED_Output());
                }
                for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfBooleanOutputs(); outputID++)
                {

                    objNNI.Set_Item_On_List_Of_REGISTERED_Output(outputID, 0/*ToDo*/);
                }
                for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfConstantOutputs(); outputID++)
                {

                    objNNI.Set_Item_On_List_Of_REGISTERED_Output(outputID, 0/*ToDo*/);
                }
            }
            objNNI.Set_IsNewDataReady(true);
            return objNNI.Get_IsNewDataReady();
        }
    // get.
        public bool Get_IsNewDataReady()
        {
            return _isNewDataReady;
        }
        public Binary[] Get_List_Of_Binary_Paths()
        {
            return _List_Of_Binary_Paths;
        }
        public Constant[] Get_List_Of_Constant_Paths()
        {
            return _List_Of_Constant_Paths;
        }
        public Linear[] Get_List_Of_Linear_Paths()
        {
            return _List_Of_Linear_Paths;
        }
        public double[] Get_List_Of_REGISTERED_Inputs()
        {
            return _REGISTERED_Inputs;
        }
        public double[] Get_List_Of_REGISTERED_Outputs()
        {
            return _REGISTERED_Outputs;
        }
        public Binary Get_Item_On_List_Of_Binary_Paths(byte binaryID)
        {
            return _List_Of_Binary_Paths[binaryID];
        }
        public Constant Get_Item_On_List_Of_Constant_Paths(byte constantID)
        {
            return _List_Of_Constant_Paths[constantID];
        }
        public Linear Get_Item_On_List_Of_Linear_Paths(byte praiseTreeID)
        {
            return _List_Of_Linear_Paths[praiseTreeID];
        }
        public double Get_Item_On_List_Of_REGISTERED_Inputs(byte registerID)
        {
            return _REGISTERED_Inputs[registerID];
        }
        public double Get_Item_On_List_Of_REGISTERED_Outputs(byte registerID)
        {
            return _REGISTERED_Outputs[registerID];
        }
        public OpenAvrilNNI.MetaData Get_MetaData()
        {
            return _MetaData;
        }

    // set.
        public void Set_IsNewDataReady(bool value)
        {
            _isNewDataReady = value;
        }
        public void Set_Item_On_List_Of_Binary_Paths(byte binaryID, Binary value)
        {
            _List_Of_Binary_Paths[binaryID] = value;
        }
        public void Set_Item_On_List_Of_Constant_Paths(byte constantID, Constant value)
        {
            _List_Of_Constant_Paths[constantID] = value;
        }
        public void Set_Item_On_List_Of_Linear_Paths(byte praiseTreeID, Linear value)
        {
            _List_Of_Linear_Paths[praiseTreeID] = value;
        }
        public void Set_Item_On_List_Of_REGISTERED_Input(byte registerID, double value)
        {
            _REGISTERED_Inputs[registerID] = value;
        }
        public void Set_Item_On_List_Of_REGISTERED_Output(byte registerID, double value)
        {
            _REGISTERED_Outputs[registerID] = value;
        }

// private.

        private void Create_IsNewDataReady()
        {
            _isNewDataReady = new bool();
            Set_IsNewDataReady(false);
        }
        private void Create_MetaData()
        {
            Set_MetaData(new OpenAvrilNNI.MetaData());
            while (Get_MetaData() == null) { }
            Get_MetaData().Set_NameOfNNI("OpenNNI_" + System.DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss"));
            Get_MetaData().Set_PraiseID(byte.MaxValue);
        }
    // get.
    // set.
        private void Set_MetaData(OpenAvrilNNI.MetaData value)
        {
            _MetaData = value;
        }
    }
}

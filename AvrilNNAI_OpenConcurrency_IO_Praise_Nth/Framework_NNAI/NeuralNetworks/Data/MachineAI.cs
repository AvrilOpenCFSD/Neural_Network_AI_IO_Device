namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class MachineAI
    {
// classes.
        private Constant[] _constants;
        private MetaData _metaData;
        private PraiseSet[] _praiseSet;

// registers.
        private bool _isNewDataReady;
        private double[] _REGISTERED_Inputs;
        private double[] _REGISTERED_Outputs;

// constructor.
        public MachineAI()
        {
            //System.Console.WriteLine("entered MachineAI.");
            Create_MetaData(new MetaData());
            while (Get_MetaData() == null) { }

            Create_List_Of_REGISTERED_Inputs(new double[Get_MetaData().Get_NumberOfPraiseInputValues()]);
            for (ulong index = 0; index < Get_MetaData().Get_NumberOfPraiseInputValues(); index++)
            {
                Set_Item_On_List_Of_REGISTERED_Input(index, 0.0);
            }

            Create_List_Of_PraiseSet(new PraiseSet[Get_MetaData().Get_NumberOfPraiseInputValues() - Get_MetaData().Get_NumberOfResetToConstantValues_INPUT()]);
            while (Get_List_Of_PraiseSet() == null) { }

            Create_List_Of_Constants(new Constant[Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT()]);
            while(Get_List_Of_Constant() == null) { }

            Create_List_Of_REGISTERED_Outputs(new double[Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT()]);
            for (ulong index = 0; index < Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT(); index++)
            {
                Set_Item_On_List_Of_REGISTERED_Output(index, 0.0);
            }
        }

// destructor.
        ~MachineAI()
        {
        }

// public.
        public void Create_List_Of_Constants(Constant[] value)
        {
            _constants = value;
        }
        public void Create_List_Of_REGISTERED_Inputs(double[] value)
        {
            _REGISTERED_Inputs = value;
        }
        public void Create_List_Of_REGISTERED_Outputs(double[] value)
        {
            _REGISTERED_Outputs = value;
        }
        public void Create_List_Of_PraiseSet(PraiseSet[] value)
        {
            _praiseSet = value;
        }
        public bool Run_Neural_Network_Inteligence(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI objNNAI)
        {
            if (objNNAI.Get_IsNewDataReady() == false)
            {
                byte numberOfPraiseSets = (byte)(objNNAI.Get_MetaData().Get_NumberOfPraiseOutputValues() - objNNAI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT());
                byte numberOfResetToConstant = objNNAI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT();
                for (byte outputID = 0; outputID < numberOfPraiseSets; outputID++)
                {
                    for (sbyte layerID = 4; layerID > -1; layerID--)
                    {
                        byte hiddenLayerID = Convert.ToByte(layerID);
                        for (ulong nodeID = 0; nodeID < objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                        {
                            ulong numberOfInputsForNode = new ulong();
                            numberOfInputsForNode = 0;
                            if (layerID == 4)
                            {
                                numberOfInputsForNode = objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues();
                            }
                            else
                            {
                                numberOfInputsForNode = objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(layerID + 1));
                            }
                            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Run_Neural_Path_Calculation(objNNAI, outputID, hiddenLayerID, nodeID, numberOfInputsForNode);
                        }
                    }
                    objNNAI.Set_Item_On_List_Of_REGISTERED_Output(outputID, objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(0, 1).Get_REGISTERED_Output());
                }
            }
            objNNAI.Set_IsNewDataReady(true);
            return objNNAI.Get_IsNewDataReady();
        }
    // get.
        public bool Get_IsNewDataReady()
        {
            return _isNewDataReady;
        }
        public Constant[] Get_List_Of_Constant()
        {
            return _constants;
        }
        public PraiseSet[] Get_List_Of_PraiseSet()
        {
            return _praiseSet;
        }
        public double[] Get_List_Of_REGISTERED_Inputs()
        {
            return _REGISTERED_Inputs;
        }
        public double[] Get_List_Of_REGISTERED_Outputs()
        {
            return _REGISTERED_Outputs;
        }

        public Constant Get_Item_On_List_Of_Constant(byte constantID)
        {
            return _constants[constantID];
        }
        public PraiseSet Get_Item_On_List_Of_PraiseSets(byte praiseTreeID)
        {
            return _praiseSet[praiseTreeID];
        }
        public double Get_Item_On_List_Of_REGISTERED_Inputs(ulong registerID)
        {
            return _REGISTERED_Inputs[registerID];
        }
        public double Get_Item_On_List_Of_REGISTERED_Outputs(ulong registerID)
        {
            return _REGISTERED_Outputs[registerID];
        }
        public MetaData Get_MetaData()
        {
            return _metaData;
        }

    // set.
        public void Set_IsNewDataReady(bool value)
        {
            _isNewDataReady = value;
        }
        public void Set_Item_On_List_Of_Constant(byte constantID, Constant value)
        {
            _constants[constantID] = value;
        }
        public void Set_Item_On_List_Of_PraiseSets(byte praiseTreeID, PraiseSet value)
        {
            _praiseSet[praiseTreeID] = value;
        }
        public void Set_Item_On_List_Of_REGISTERED_Input(ulong registerID, double value)
        {
            _REGISTERED_Inputs[registerID] = value;
        }
        public void Set_Item_On_List_Of_REGISTERED_Output(ulong registerID, double value)
        {
            _REGISTERED_Outputs[registerID] = value;
        }

// private.
        private void Create_IsNewDataReady(bool value)
        {
            _isNewDataReady = value;
        }
        private void Create_MetaData(MetaData value)
        {
            _metaData = value;
        }

    // get.
        
    // set.
    }
}

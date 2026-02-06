
namespace Avril_NNAI
{
    public class MachineAI
    {
// classes.
        private Avril_NNAI.Constant[] _constants;
        private Avril_NNAI.MetaData _metaData;
        private Avril_NNAI.PraiseSet[] _praiseSet;

// registers.
        private double[] _REGISTERED_Inputs;
        private double[] _REGISTERED_Outputs;

// constructor.
        public MachineAI()
        {
            //System.Console.WriteLine("entered MachineAI.");
            Create_MetaData(new Avril_NNAI.MetaData());
            while (Get_MetaData() == null) { }

            Create_List_Of_REGISTERED_Inputs(new double[Get_MetaData().Get_NumberOfPraiseInputValues()]);
            for (ulong index = 0; index < Get_MetaData().Get_NumberOfPraiseInputValues(); index++)
            {
                Set_Item_On_List_Of_REGISTERED_Input(index, 0.0);
            }

            Create_List_Of_PraiseSet(new Avril_NNAI.PraiseSet[Get_MetaData().Get_NumberOfPraiseInputValues() - Get_MetaData().Get_NumberOfResetToConstantValues_INPUT()]);
            while (Get_List_Of_PraiseSet() == null) { }

            Create_List_Of_Constants(new Avril_NNAI.Constant[Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT()]);
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
        public void Create_List_Of_Constants(Avril_NNAI.Constant[] value)
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
        public void Create_List_Of_PraiseSet(Avril_NNAI.PraiseSet[] value)
        {
            _praiseSet = value;
        }

        // get.
        public Avril_NNAI.Constant[] Get_List_Of_Constant()
        {
            return _constants;
        }
        public Avril_NNAI.PraiseSet[] Get_List_Of_PraiseSet()
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

        public Avril_NNAI.Constant Get_Item_On_List_Of_Constant(byte constantID)
        {
            return _constants[constantID];
        }
        public Avril_NNAI.PraiseSet Get_Item_On_List_Of_PraiseSets(byte praiseTreeID)
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
        public Avril_NNAI.MetaData Get_MetaData()
        {
            return _metaData;
        }

    // set.
        public void Set_Item_On_List_Of_Constant(byte constantID, Avril_NNAI.Constant value)
        {
            _constants[constantID] = value;
        }
        public void Set_Item_On_List_Of_PraiseSets(byte praiseTreeID, Avril_NNAI.PraiseSet value)
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
        private void Create_MetaData(Avril_NNAI.MetaData value)
        {
            _metaData = value;
        }

    // get.
        
    // set.
    }
}

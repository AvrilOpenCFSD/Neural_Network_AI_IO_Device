
namespace Avril_NNAI
{
    public class MachineAI
    {
// classes.
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
            
            Create_PraiseSet(new Avril_NNAI.PraiseSet[Get_MetaData().Get_NumberOfPraiseOutputValues()]);
            while (_praiseSet == null) { }

            Create_REGISTERED_Inputs(new double[Get_MetaData().Get_NumberOfPraiseInputValues()]);
            for (ulong index = 0; index < Get_MetaData().Get_NumberOfPraiseInputValues(); index++)
            {
                Set_REGISTERED_Input(index, 0.0);
            }
            Create_REGISTERED_Outputs(new double[Get_MetaData().Get_NumberOfPraiseOutputValues()]);
            for (ulong index = 0; index < Get_MetaData().Get_NumberOfPraiseOutputValues(); index++)
            {
                Set_REGISTERED_Output(index, 0.0);
            }

        }

// destructor.
        ~MachineAI()
        {
        }

// public.
        public void Create_REGISTERED_Inputs(double[] value)
        {
            _REGISTERED_Inputs = value;
        }
        public void Create_REGISTERED_Outputs(double[] value)
        {
            _REGISTERED_Outputs = value;
        }
        public void Create_PraiseSet(Avril_NNAI.PraiseSet[] value)
        {
            _praiseSet = value;
        }

    // get.
        public double[] Get_List_Of_REGISTERED_Inputs()
        {
            return _REGISTERED_Inputs;
        }
        public double[] Get_List_Of_REGISTERED_Outputs()
        {
            return _REGISTERED_Outputs;
        }
        public Avril_NNAI.PraiseSet[] Get_PraiseSet()
        {
            return _praiseSet;
        }
        public double Get_REGISTERED_Inputs(ulong registerID)
        {
            return _REGISTERED_Inputs[registerID];
        }
        public double Get_REGISTERED_Outputs(ulong registerID)
        {
            return _REGISTERED_Outputs[registerID];
        }
        public Avril_NNAI.MetaData Get_MetaData()
        {
            return _metaData;
        }
        public Avril_NNAI.PraiseSet Get_Item_On_List_Of_PraiseSets(byte index)
        {
            return _praiseSet[index];
        }

    // set.
        public void Set_REGISTERED_Input(ulong registerID, double value)
        {
            _REGISTERED_Inputs[registerID] = value;
        }
        public void Set_REGISTERED_Output(ulong registerID, double value)
        {
            _REGISTERED_Outputs[registerID] = value;
        }
        public void Set_Item_On_List_Of_PraiseSets(byte index, Avril_NNAI.PraiseSet value)
        {
            _praiseSet[index] = value;
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

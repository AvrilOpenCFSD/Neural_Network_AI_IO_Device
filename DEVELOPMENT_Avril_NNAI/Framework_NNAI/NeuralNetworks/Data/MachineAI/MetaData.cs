
namespace Avril_NNAI
{
    public class MetaData
    {
// classes.

// registers.
        private string _nameOfNNAI;
        ulong _NumberOfPraiseInputValues;
        ulong _NumberOfPraiseOutputValues;
        double[] _REGISTERED_Inputs;
        double[] _REGISTERED_Outputs;
        private ulong _PraiseID;

// constructor.
        public MetaData()
        {
            //System.Console.WriteLine("entered MetaData.");

            Create_NameOfNNAI(new string("nil"));
            Set_NameOfNNAI("Undefined_NNAI");
            
            Create_PraiseID(new ulong());
            Set_PraiseID(ulong.MaxValue);

            Create_NumberOfPraiseInputValues(new ulong());
            Set_NumberOfPraiseInputValues(2);

            Create_NumberOfPraiseOutputValues(new ulong());
            Set_NumberOfPraiseOutputValues(2);

            Create_REGISTERED_Inputs(new double[Get_NumberOfPraiseInputValues()]);
            for (ulong index = 0; index < Get_NumberOfPraiseInputValues(); index++)
            {
                Set_REGISTERED_Input(index, 0.0);
            }
            Create_REGISTERED_Output(new double[Get_NumberOfPraiseOutputValues()]);
            for (ulong index = 0; index < Get_NumberOfPraiseOutputValues(); index++)
            {
                Set_REGISTERED_Output(index, 0.0);
            }
        }

// destructor.
        ~MetaData()
        {

        }

// public.
// get.
        public string Get_NameOfNNAI()
        {
            return _nameOfNNAI;
        }
        public ulong Get_NumberOfPraiseInputValues()
        {
            return _NumberOfPraiseInputValues;
        }
        public ulong Get_NumberOfPraiseOutputValues()
        {
            return _NumberOfPraiseOutputValues;
        }
        public double[] Get_List_Of_REGISTERED_Inputs()
        {
            return _REGISTERED_Inputs;
        }
        public double[] Get_List_Of_REGISTERED_Outputs()
        {
            return _REGISTERED_Outputs;
        }
        public ulong Get_PraiseID()
        {
            return _PraiseID;
        }

    // set.
        private void Set_NumberOfPraiseInputValues(ulong value)
        {
            _NumberOfPraiseInputValues = value;
        }
        private void Set_NumberOfPraiseOutputValues(ulong value)
        {
            _NumberOfPraiseOutputValues = value;
        }

// private.
        private void Create_NameOfNNAI(string value)
        {
            _nameOfNNAI = value;
        }
        private void Create_NumberOfPraiseInputValues(ulong value)
        {
            _NumberOfPraiseInputValues = value;
        }
        private void Create_NumberOfPraiseOutputValues(ulong value)
        {
            _NumberOfPraiseOutputValues = value;
        }
        private void Create_REGISTERED_Inputs(double[] value)
        {
            _REGISTERED_Inputs = value;
        }
        private void Create_REGISTERED_Output(double[] value)
        {
            _REGISTERED_Outputs = value;
        }
        private void Create_PraiseID(ulong value)
        {
            _PraiseID = value;
        }
        
    // get.
        private double Get_REGISTERED_Inputs(ulong registerID)
        {
            return _REGISTERED_Inputs[registerID];
        }
        private double Get_REGISTERED_Outputs(ulong registerID)
        {
            return _REGISTERED_Outputs[registerID];
        }

    // set.
        public void Set_NameOfNNAI(string nameOfNNAI)
        {
            _nameOfNNAI = nameOfNNAI;
        }
        private void Set_REGISTERED_Input(ulong registerID, double value)
        {
            _REGISTERED_Inputs[registerID] = value;
        }
        private void Set_REGISTERED_Output(ulong registerID, double value)
        {
            _REGISTERED_Outputs[registerID] = value;
        }
        private void Set_PraiseID(ulong praiseID)
        {
            _PraiseID = praiseID;
        }
    }
}
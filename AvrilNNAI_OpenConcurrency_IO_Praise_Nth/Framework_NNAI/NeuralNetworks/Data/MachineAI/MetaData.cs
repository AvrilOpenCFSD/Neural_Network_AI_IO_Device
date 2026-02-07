
namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class MetaData
    {
// classes.

// registers.
        private string _nameOfNNAI;
        private ulong[] _NumberOfNodesInLayer;
        private byte _NumberOfResetToConstantValues_INPUT;
        private byte _NumberOfResetToConstantValues_OUTPUT;
        private byte _NumberOfPraiseValues_INPUT;
        private byte _NumberOfPraiseValues_OUTPUT;
        private ulong _PraiseID;

// constructor.
        public MetaData()
        {
            //System.Console.WriteLine("entered MetaData.");

            Create_NameOfNNAI(new string("nil"));
            Set_NameOfNNAI("Undefined_NNAI");
            
            Create_PraiseID(new ulong());
            Set_PraiseID(ulong.MaxValue);

            Create_NumberOfPraiseInputValues(new byte());
            Set_NumberOfPraiseInputValues(2);

            Create_NumberOfResetToConstantValues_INPUT(new byte());
            Set_NumberOfResetToConstantValues_INPUT(0);

            Create_NumberOfPraiseOutputValues(new byte());
            Set_NumberOfPraiseOutputValues(2);

            Create_NumberOfResetToConstantValues_OUTPUT(new byte());
            Set_NumberOfResetToConstantValues_OUTPUT(0);

            Create_NumberOfNodesInLayer(new ulong[5]);
            Set_NumberOfNodesInHiddenLayer(4, 5);
            Set_NumberOfNodesInHiddenLayer(3, 4);
            Set_NumberOfNodesInHiddenLayer(2, 3);
            Set_NumberOfNodesInHiddenLayer(1, 2);
            Set_NumberOfNodesInHiddenLayer(0, 1);
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
        public ulong Get_NumberOfNodesInHiddenLayer(byte hiddenLayerID)
        {
            return _NumberOfNodesInLayer[hiddenLayerID];
        }

        public byte Get_NumberOfResetToConstantValues_INPUT()
        {
            return _NumberOfResetToConstantValues_INPUT;
        }
        public byte Get_NumberOfResetToConstantValues_OUTPUT()
        {
            return _NumberOfResetToConstantValues_OUTPUT;
        }
        public byte Get_NumberOfPraiseInputValues()
        {
            return _NumberOfPraiseValues_INPUT;
        }
        public byte Get_NumberOfPraiseOutputValues()
        {
            return _NumberOfPraiseValues_OUTPUT;
        }
        public ulong Get_PraiseID()
        {
            return _PraiseID;
        }

    // set.
        public void Set_NumberOfNodesInHiddenLayer(byte layerID, ulong numberOfNodes)
        {
            _NumberOfNodesInLayer[layerID] = numberOfNodes;
        }
        public void Set_NumberOfNodesInLayer(byte layerID, ulong numberOfNodeInLayer)
        {
            _NumberOfNodesInLayer[layerID] = numberOfNodeInLayer;
        }
        public void Set_NumberOfResetToConstantValues_INPUT(byte value)
        {
            _NumberOfResetToConstantValues_INPUT = value;
        }
        public void Set_NumberOfResetToConstantValues_OUTPUT(byte value)
        {
            _NumberOfResetToConstantValues_OUTPUT = value;
        }
        public void Set_NumberOfPraiseInputValues(byte value)
        {
            _NumberOfPraiseValues_INPUT = value;
        }
        public void Set_NumberOfPraiseOutputValues(byte value)
        {
            _NumberOfPraiseValues_OUTPUT = value;
        }
        public void Set_NameOfNNAI(string nameOfNNAI)
        {
            _nameOfNNAI = nameOfNNAI;
        }
        public void Set_PraiseID(ulong praiseID)
        {
            _PraiseID = praiseID;
        }

// private.
        private void Create_NameOfNNAI(string value)
        {
            _nameOfNNAI = value;
        }
        private void Create_NumberOfNodesInLayer(ulong[] liatOfNumberOfNodesInLayer)
        {
            _NumberOfNodesInLayer = liatOfNumberOfNodesInLayer;
        }
        private void Create_NumberOfResetToConstantValues_INPUT(byte value)
        {
            _NumberOfResetToConstantValues_INPUT = value;
        }
        private void Create_NumberOfResetToConstantValues_OUTPUT(byte value)
        {
            _NumberOfResetToConstantValues_OUTPUT = value;
        }
        private void Create_NumberOfPraiseInputValues(byte value)
        {
            _NumberOfPraiseValues_INPUT = value;
        }
        private void Create_NumberOfPraiseOutputValues(byte value)
        {
            _NumberOfPraiseValues_OUTPUT = value;
        }

        private void Create_PraiseID(ulong value)
        {
            _PraiseID = value;
        }

    // get.
        private ulong[] Get_List_Of_NumberOfNodesInLayer()
        {
            return _NumberOfNodesInLayer;
        }
        
    // set.

    }
}
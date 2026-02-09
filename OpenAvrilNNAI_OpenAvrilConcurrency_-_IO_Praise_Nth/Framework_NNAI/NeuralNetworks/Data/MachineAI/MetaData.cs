
namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class MetaData
    {
// classes.

// registers.
        private string _nameOfNNI;
        private byte[] _NumberOfNodesInLayer;
        private byte _NumberOfResetToConstantValues_INPUT;
        private byte _NumberOfResetToConstantValues_OUTPUT;
        private byte _NumberOfPraiseValues_INPUT;
        private byte _NumberOfPraiseValues_OUTPUT;
        private byte _PraiseID;

// constructor.
        public MetaData()
        {
            //System.Console.WriteLine("entered MetaData.");

            Create_NameOfNNI(new string("nil"));
            Set_NameOfNNI("Undefined_NNI");
            
            Create_PraiseID(new byte());
            Set_PraiseID(byte.MaxValue);

            Create_NumberOfPraiseInputValues(new byte());
            Set_NumberOfPraiseInputValues(2);

            Create_NumberOfResetToConstantValues_INPUT(new byte());
            Set_NumberOfResetToConstantValues_INPUT(0);

            Create_NumberOfPraiseOutputValues(new byte());
            Set_NumberOfPraiseOutputValues(2);

            Create_NumberOfResetToConstantValues_OUTPUT(new byte());
            Set_NumberOfResetToConstantValues_OUTPUT(0);

            Create_NumberOfNodesInLayer(new byte[5]);
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
        public string Get_NameOfNNI()
        {
            return _nameOfNNI;
        }
        public byte Get_NumberOfNodesInHiddenLayer(byte hiddenLayerID)
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
        public byte Get_PraiseID()
        {
            return _PraiseID;
        }

    // set.
        public void Set_NumberOfNodesInHiddenLayer(byte layerID, byte numberOfNodes)
        {
            _NumberOfNodesInLayer[layerID] = numberOfNodes;
        }
        public void Set_NumberOfNodesInLayer(byte layerID, byte numberOfNodeInLayer)
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
        public void Set_NameOfNNI(string nameOfNNI)
        {
            _nameOfNNI = nameOfNNI;
        }
        public void Set_PraiseID(byte praiseID)
        {
            _PraiseID = praiseID;
        }

// private.
        private void Create_NameOfNNI(string value)
        {
            _nameOfNNI = value;
        }
        private void Create_NumberOfNodesInLayer(byte[] liatOfNumberOfNodesInLayer)
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

        private void Create_PraiseID(byte value)
        {
            _PraiseID = value;
        }

    // get.
        private byte[] Get_List_Of_NumberOfNodesInLayer()
        {
            return _NumberOfNodesInLayer;
        }
        
    // set.

    }
}
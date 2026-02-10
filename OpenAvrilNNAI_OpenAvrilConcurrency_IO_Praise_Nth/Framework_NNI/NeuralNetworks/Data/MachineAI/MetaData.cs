
using System;

namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class MetaData
    {
// classes.

// registers.
    // metadata.
        private string _nameOfNNI;
        private byte _PraiseID;
    // input.
        private byte _NumberOfBooleanInputs;
        private byte _NumberOfConstantInputs;
        private byte _NumberOfLinearInputs;
        private byte _NumberInputRegisters;
    // outputs.
        private byte _NumberOfBooleanOutputs;
        private byte _NumberOfConstantOutputs;
        private byte _NumberOfLinearOutputs;
        private byte _NumberOutputRegisters;
    // internal.
        private byte[] _NumberOfNodesInLayer;
        

// constructor.
        public MetaData()
        {
            //System.Console.WriteLine("entered MetaData.");

            Create_NameOfNNI();
            Create_PraiseID();
            Create_NumberInputRegisters();
            Create_NumberOfLinearInputs();
            Create_NumberOfBooleanInputs();
            Create_NumberOfConstantInputs();
            Create_NumberOutputRegisters();
            Create_NumberOfLinearOutputs();
            Create_NumberOfBooleanOutputs();
            Create_NumberOfConstantOutputs();
            Create_NumberOfNodesInLayer();
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
        public byte Get_PraiseID()
        {
            return _PraiseID;
        }
        public byte Get_NumberOfBooleanInputs()
        {
            return _NumberOfBooleanInputs;
        }
        public byte Get_NumberOfBooleanOutputs()
        {
            return _NumberOfBooleanOutputs;
        }
        public byte Get_NumberOfConstantInputs()
        {
            return _NumberOfConstantInputs;
        }
        public byte Get_NumberOfConstantOutputs()
        {
            return _NumberOfConstantOutputs;
        }
        public byte Get_NumberInputRegisters()
        {
            return _NumberInputRegisters;
        }
        public byte Get_NumberOfLinearInputs()
        {
            return _NumberOfLinearInputs;
        }
        public byte Get_NumberOfLinearOutputs()
        {
            return _NumberOfLinearOutputs;
        }
        public byte Get_NumberOfNodesInHiddenLayer(byte hiddenLayerID)
        {
            return _NumberOfNodesInLayer[hiddenLayerID];
        }
        public byte Get_NumberOutputRegisters()
        {
            return _NumberOutputRegisters;
        }

    // set.
        public void Set_NameOfNNI(string nameOfNNI)
        {
            _nameOfNNI = nameOfNNI;
        }
        public void Set_PraiseID(byte value)
        {
            _PraiseID = value;
        }
        public void Set_NumberOfBooleanInputs(byte numberOfBinaryValues)
        {
            _NumberOfBooleanInputs = numberOfBinaryValues;
        }
        public void Set_NumberOfBooleanOutputs(byte numberOfBinaryValues)
        {
            _NumberOfBooleanOutputs = numberOfBinaryValues;
        }
        public void Set_NumberOfConstantInputs(byte numberOfResetToConstantValues)
        {
            _NumberOfConstantInputs = numberOfResetToConstantValues;
        }
        public void Set_NumberOfConstantOutputs(byte numberOfResetToConstantValues)
        {
            _NumberOfConstantOutputs = numberOfResetToConstantValues;
        }
        public void Set_NumberInputRegisters(byte numberOfInputValues)
        {
            _NumberInputRegisters = numberOfInputValues;
        }
        public void Set_NumberOfLinearInputs(byte numberOfLinearValues)
        {
            _NumberOfLinearInputs = numberOfLinearValues;
        }
        public void Set_NumberOfLinearOutputs(byte numberOfLinearValues)
        {
            _NumberOfLinearOutputs = numberOfLinearValues;
        }
        public void Set_NumberOfNodesInHiddenLayer(byte layerID, byte numberOfNodes)
        {
            _NumberOfNodesInLayer[layerID] = numberOfNodes;
        }
        public void Set_NumberOutputRegisters(byte numberOfInputValues)
        {
            _NumberOutputRegisters = numberOfInputValues;
        }

// private.
        private void Create_NameOfNNI()
        {
            _nameOfNNI = new string("nil");
        }
        private void Create_PraiseID()
        {
            Set_PraiseID(new byte());
            Set_PraiseID(byte.MaxValue);
        }
        private void Create_NumberOfBooleanInputs()
        {
            Set_NumberOfBooleanInputs(new byte());
            Set_NumberOfBooleanInputs(0);
        }
        private void Create_NumberOfBooleanOutputs()
        {
            Set_NumberOfBooleanOutputs(new byte());
            Set_NumberOfBooleanOutputs(0);
        }
        private void Create_NumberOfConstantInputs()
        {
            Set_NumberOfConstantInputs(new byte());
            Set_NumberOfConstantInputs(0);
        }
        private void Create_NumberOfConstantOutputs()
        {
            Set_NumberOfConstantOutputs(new byte());
            Set_NumberOfConstantOutputs(0);
        }
        private void Create_NumberInputRegisters()
        {
            Set_NumberInputRegisters(new byte());
            Set_NumberInputRegisters(0);
        }
        private void Create_NumberOfLinearInputs()
        {
            Set_NumberOfLinearInputs(new byte());
            Set_NumberOfLinearInputs(0);
        }
        private void Create_NumberOfLinearOutputs()
        {
            Set_NumberOfLinearOutputs(new byte());
            Set_NumberOfLinearOutputs(0);
        }
        private void Create_NumberOfNodesInLayer()
        {
            Set_List_Of_NumberOfNodesInHiddenLayer(new byte[5]);
            while (Get_List_Of_NumberOfNodesInHiddenLayer() == null) { }
            for(byte layerID = 0; layerID < 5; layerID++)
            {
                Set_NumberOfNodesInHiddenLayer(layerID, new byte());
                Set_NumberOfNodesInHiddenLayer(layerID, 0);
            }
        }
        private void Create_NumberOutputRegisters()
        {
            Set_NumberOutputRegisters(new byte());
            Set_NumberOutputRegisters(0);
        }
    // get.
        private byte[] Get_List_Of_NumberOfNodesInHiddenLayer()
        {
            return _NumberOfNodesInLayer;
        }
    // set.
        private void Set_List_Of_NumberOfNodesInHiddenLayer(byte[] newList)
        {
            _NumberOfNodesInLayer = newList;
        }
    }
}
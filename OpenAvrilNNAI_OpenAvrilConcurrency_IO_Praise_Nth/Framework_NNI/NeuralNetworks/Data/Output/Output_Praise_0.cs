
namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class Output_Praise_0
    {
// definitions.
        private enum PRAISE_0 : byte
        {
            Ping
        }

        // classes.

        // registers.
        private byte _NumberOfBooleanOutputs;
        private byte _NumberOfConstantOutputs;
        private byte _NumberOfLinearOutputs;
        private byte _NumberOutputRegisters;
        // custom user defined.

        private double _Ping;

// constructor.
        public Output_Praise_0()
        {
            Create_NumberOfBooleanOutputs();
            Create_NumberOfLinearOutputs();
            Create_NumberOfConstantOutputs();
            Create_NumberOutputRegisters();
            // custom user defined.
            Create_Ping(new double());
        }

// destructor.
        ~Output_Praise_0() 
        {
        
        }

// public.
    // get.
        public byte Get_NumberOfBooleanOutputs()
        {
            return _NumberOfBooleanOutputs;
        }
        public byte Get_NumberOfConstantOutputs()
        {
            return _NumberOfConstantOutputs;
        }
        public byte Get_NumberOfLinearOutputs()
        {
            return _NumberOfLinearOutputs;
        }
        public byte Get_NumberOutputRegisters()
        {
            return _NumberOutputRegisters;
        }
        // custom user defined.
        public double Get_Item_On_List_Of_Praise_Output(byte index)
        {
            switch (index)
            {
                case 0:
                    return Get_Ping();
                default:
                    return 0;
            }
        }
    // set.
        public void Set_Item_On_List_Of_Praise_Output(byte index, double value)
        {
            switch (index)
            {
                case 0:
                    Set_Ping(value);
                    break;
                default:
                    break;
            }
        }

        // private.
        private void Create_NumberOfBooleanOutputs()
        {
            Set_NumberOfBooleanOutputs(new byte());
            Set_NumberOfBooleanOutputs(0);
        }
        private void Create_NumberOfConstantOutputs()
        {
            Set_NumberOfConstantOutputs(new byte());
            Set_NumberOfConstantOutputs(0);
        }
        private void Create_NumberOfLinearOutputs()
        {
            Set_NumberOfLinearOutputs(new byte());
            Set_NumberOfLinearOutputs(0);
        }
        private void Create_NumberOutputRegisters()
        {
            Set_NumberOutputRegisters(new byte());
            Set_NumberOutputRegisters(0);
        }
        // custom user defined.

        private void Create_Ping(double ping)
        {
            _Ping = ping;
        }
    // get.
        private double Get_Ping()
        {
            return _Ping;
        }

    // set.
        private void Set_NumberOfBooleanOutputs(byte numberOfBinaryValues)
        {
            _NumberOfBooleanOutputs = numberOfBinaryValues;
        }
        private void Set_NumberOfConstantOutputs(byte numberOfResetToConstantValues)
        {
            _NumberOfConstantOutputs = numberOfResetToConstantValues;
        }
        private void Set_NumberOfLinearOutputs(byte numberOfLinearValues)
        {
            _NumberOfLinearOutputs = numberOfLinearValues;
        }
        private void Set_NumberOutputRegisters(byte numberOfOutputValues)
        {
            _NumberOutputRegisters = numberOfOutputValues;
        }
        // custom user defined.
        private void Set_Ping(double value)
        {
            _Ping = value;
        }
    }
}
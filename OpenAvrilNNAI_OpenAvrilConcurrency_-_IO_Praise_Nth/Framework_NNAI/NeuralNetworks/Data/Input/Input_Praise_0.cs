
namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class Input_Praise_0
    {
// deinitions.
        private enum PRAISE_0 : byte
        {
            Ping
        }

// classes.

// registers.
        private byte _NumberOfResetToConstantValues;
        private byte _numberOfInputValues;
        private double _Ping;

// constructor.
        public Input_Praise_0()
        {
            Create_NumberOfInputValues();
            Set_NumberOfResetToConstantValues(0);
            Create_Ping();
        }

// destructor
        ~Input_Praise_0()
        {

        }

// public.
    // get.
        public double Get_Item_On_List_Of_Input_Praise(byte index)
        {
            switch (index)
            {
                case (byte)PRAISE_0.Ping:
                    return Get_Ping();
                default:
                    return 0;
            }
        }
        public byte Get_NumberOfResetToConstantValues()
        {
            return _NumberOfResetToConstantValues;
        }
        public byte Get_NumberOfInputValues()
        {
            return _numberOfInputValues;
        }
    // set.
        public void Set_Item_On_List_Of_Input_Praise(byte index, double value)
        {
            switch (index)
            {
                case (byte)PRAISE_0.Ping:
                    Set_Ping(value);
                    break;
                default:
                    break;
            }
        }

// private.
        private void Create_NumberOfResetToConstantValues()
        {
            _NumberOfResetToConstantValues = new byte();
            Set_NumberOfResetToConstantValues(0);
        }
        private void Create_NumberOfInputValues()
        {
            _numberOfInputValues = new byte();
            Set_NumberOfInputValues(1);
        }
        private void Create_Ping()
        {
            _Ping = new double();
            Set_Ping(0.0);
        }
    // get.
        private double Get_Ping()
        {
            return _Ping;
        }
    // set.
        private void Set_NumberOfResetToConstantValues(byte numberOfResetToConstantValues)
        {
            _NumberOfResetToConstantValues = numberOfResetToConstantValues;
        }
        private void Set_NumberOfInputValues(byte numberOfInputValues)
        {
            _numberOfInputValues = numberOfInputValues;
        }
        private void Set_Ping(double value)
        {
            _Ping = value;
        }
    }
}

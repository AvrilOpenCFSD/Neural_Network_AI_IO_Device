
namespace Avril_NNAI
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
        private byte _numberOfOutputValues;
        private byte _NumberOfResetToConstantValues;
        private double _Ping;

// constructor.
        public Output_Praise_0()
        {
            Create_NumberOfOutputValues(new byte());
            Set_NumberOfOutputValues(1);

            Create_NumberOfResetToConstantValues(new byte());
            Set_NumberOfResetToConstantValues(0);

            Create_Ping(new double());
            Set_Ping(0.0);
        }

// destructor.
        ~Output_Praise_0() 
        {
        
        }

// public.
    // get.
        public double Get_Item_On_List_Of_Input_Praise(byte index)
        {
            switch (index)
            {
                case 0:
                    return Get_Ping();
                default:
                    return 0;
            }
        }
        public byte Get_NumberOfResetToConstantValues()
        {
            return _NumberOfResetToConstantValues;
        }
        public byte Get_NumberOfOutputValues()
        {
            return _numberOfOutputValues;
        }

    // set.
        public void Set_Item_On_List_Of_Input_Praise(byte index, double value)
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
        private void Create_NumberOfResetToConstantValues(byte value)
        {
            _NumberOfResetToConstantValues = value;
        }
        private void Create_NumberOfOutputValues(byte value)
        {
            _numberOfOutputValues = value;
        }

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
        private void Set_NumberOfResetToConstantValues(byte value)
        {
            _NumberOfResetToConstantValues = value;
        }
        private void Set_NumberOfOutputValues(byte numberOfOutputValues)
        {
            _numberOfOutputValues = numberOfOutputValues;
        }
        private void Set_Ping(double value)
        {
            _Ping = value;
        }
    }
}
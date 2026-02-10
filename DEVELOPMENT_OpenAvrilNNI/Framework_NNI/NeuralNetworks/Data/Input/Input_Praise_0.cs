
namespace OpenAvrilNNI
{
    public class Input_Praise_0
    {
// deinitions.

// classes.

// registers.
        private byte _NumberOfBooleanInputs;
        private byte _NumberOfConstantInputs;
        private byte _NumberInputRegisters;
        private byte _NumberOfLinearInputs;
        // custom user defined.
        private double _Ping;

// constructor.
        public Input_Praise_0()
        {
			Create_NumberInputRegisters();
            Create_NumberOfLinearInputs();
            Create_NumberOfBooleanInputs();
            Create_NumberOfConstantInputs();
            // custom user defined.
            Create_Ping();
        }

// destructor
        ~Input_Praise_0()
        {

        }

// public.
    // get.
        public byte Get_NumberOfBooleanInputs()
        {
            return _NumberOfBooleanInputs;
        }
        public byte Get_NumberOfConstantInputs()
        {
            return _NumberOfConstantInputs;
        }
        public byte Get_NumberInputRegisters()
        {
            return _NumberInputRegisters;
        }
        public byte Get_NumberOfLinearInputs()
        {
            return _NumberOfLinearInputs;
        }
        // custom user defined.
        public double Get_Item_On_List_Of_Input_Praise(byte index)
        {
            switch (index)
            {
                case (byte)Global.PRAISE_0.Ping:
                    return Get_Ping();
                default:
                    return 0;
            }
        }
    // set.
        // custom user defined.
        public void Set_Item_On_List_Of_Input_Praise(byte index, double value)
        {
            switch (index)
            {
                case (byte)Global.PRAISE_0.Ping:
                    Set_Ping(value);
                    break;
                default:
                    break;
            }
        }

// private.
        private void Create_NumberOfBooleanInputs()
        {
            Set_NumberOfBooleanInputs(new byte());
            Set_NumberOfBooleanInputs(0);
        }
        private void Create_NumberOfConstantInputs()
        {
            Set_NumberOfConstantInputs(new byte());
            Set_NumberOfConstantInputs(0);
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
        // custom user defined.
        private void Create_Ping()
        {
            _Ping = new double();
            Set_Ping(0.0);
        }
    // get.
        // custom user defined.
        private double Get_Ping()
        {
            return _Ping;
        }
    // set.
        private void Set_NumberOfBooleanInputs(byte numberOfbooleanInputs)
        {
            _NumberOfBooleanInputs = numberOfbooleanInputs;
        }
        private void Set_NumberOfConstantInputs(byte numberOfConstantInputs)
        {
            _NumberOfConstantInputs = numberOfConstantInputs;
        }
        private void Set_NumberInputRegisters(byte numberOfInputValues)
        {
            _NumberInputRegisters = numberOfInputValues;
        }
        private void Set_NumberOfLinearInputs(byte numberOfLinearInputs)
        {
            _NumberOfLinearInputs = numberOfLinearInputs;
        }
        // custom user defined.
        private void Set_Ping(double value)
        {
            _Ping = value;
        }
    }
}

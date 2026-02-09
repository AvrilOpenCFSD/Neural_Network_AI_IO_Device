
namespace OpenAvrilNNI
{
    public class Input_Praise_2
    {
// definitions.

// classes.

// registers.
        private byte _NumberOfBooleanInputs;
        private byte _NumberOfConstantInputs;
        private byte _NumberInputRegisters;
        private byte _NumberOfLinearInputs;
        // custom user defined.
        private double _direction_X;
        private double _direction_y;
        private double _direction_Z;
        private double _period;
        private double _Capsule_Position_X;
        private double _Capsule_Position_Y;
        private double _Capsule_Position_Z;
        private double _Capsule_Fowards_X;
        private double _Capsule_Fowards_Y;
        private double _Capsule_Fowards_Z;
        private double _Capsule_Up_X;
        private double _Capsule_Up_Y;
        private double _Capsule_Up_Z;
        private double _Capsule_Right_X;
        private double _Capsule_Right_Y;
        private double _Capsule_Right_Z;
        
// constructor.
        public Input_Praise_2()
        {
            Create_NumberInputRegisters();
            Create_NumberOfLinearInputs();
            Create_NumberOfBooleanInputs();
            Create_NumberOfConstantInputs();
            // custom user defined.
        }

        // destructor.
        ~Input_Praise_2()
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
                case (byte)Global.PRAISE_2.Direction_X:
                    return Get_Direction_X();

                case (byte)Global.PRAISE_2.Direction_Y:
                    return Get_Direction_Y();

                case (byte)Global.PRAISE_2.Direction_Z:
                    return Get_Direction_Z();

                case (byte)Global.PRAISE_2.Period:
                    return Get_Period();

                case (byte)Global.PRAISE_2.Capsule_Position_X:
                    return Get_Capsule_Position_X();

                case (byte)Global.PRAISE_2.Capsule_Position_Y:
                    return Get_Capsule_Position_Y();

                case (byte)Global.PRAISE_2.Capsule_Position_Z:
                    return Get_Capsule_Position_Z();

                case (byte)Global.PRAISE_2.Capsule_Fowards_X:
                    return Get_Capsule_Fowards_X();

                case (byte)Global.PRAISE_2.Capsule_Fowards_Y:
                    return Get_Capsule_Fowards_Y();

                case (byte)Global.PRAISE_2.Capsule_Fowards_Z:
                    return Get_Capsule_Fowards_Z();

                case (byte)Global.PRAISE_2.Capsule_Up_X:
                    return Get_Capsule_Up_X();

                case (byte)Global.PRAISE_2.Capsule_Up_Y:
                    return Get_Capsule_Up_Y();

                case (byte)Global.PRAISE_2.Capsule_Up_Z:
                    return Get_Capsule_Up_Z();

                case (byte)Global.PRAISE_2.Capsule_Right_X:
                    return Get_Capsule_Right_X();

                case (byte)Global.PRAISE_2.Capsule_Right_Y:
                    return Get_Capsule_Right_Y();

                case (byte)Global.PRAISE_2.Capsule_Right_Z:
                    return Get_Capsule_Right_Z();

                default:
                    return 0;
            }
        }
    // set.
        public void Set_Item_On_List_Of_Input_Praise(byte index, double value)
        {
            switch (index)
            {
                case (byte)Global.PRAISE_2.Direction_X:
                    this.Set_Direction_X(value);
                    break;

                case (byte)Global.PRAISE_2.Direction_Y:
                    this.Set_Direction_Y(value);
                    break;

                case (byte)Global.PRAISE_2.Direction_Z:
                    this.Set_Direction_Z(value);
                    break;

                case (byte)Global.PRAISE_2.Period:
                    this.Set_Period(value);
                    break;

                case (byte)Global.PRAISE_2.Capsule_Position_X:
                    this.Set_Capsule_Position_X(value);
                    break;

                case (byte)Global.PRAISE_2.Capsule_Position_Y:
                    this.Set_Capsule_Position_Y(value);
                    break;

                case (byte)Global.PRAISE_2.Capsule_Position_Z:
                    this.Set_Capsule_Position_Z(value);
                    break;

                case (byte)Global.PRAISE_2.Capsule_Fowards_X:
                    this.Set_Capsule_Fowards_X(value);
                    break;

                case (byte)Global.PRAISE_2.Capsule_Fowards_Y:
                    this.Set_Capsule_Fowards_Y(value);
                    break;

                case (byte)Global.PRAISE_2.Capsule_Fowards_Z:
                    this.Set_Capsule_Fowards_Z(value);
                    break;

                case (byte)Global.PRAISE_2.Capsule_Up_X:
                    this.Set_Capsule_Up_X(value);
                    break;

                case (byte)Global.PRAISE_2.Capsule_Up_Y:
                    this.Set_Capsule_Up_Y(value);
                    break;

                case (byte)Global.PRAISE_2.Capsule_Up_Z:
                    this.Set_Capsule_Up_Z(value);
                    break;

                case (byte)Global.PRAISE_2.Capsule_Right_X:
                    this.Set_Capsule_Right_X(value);
                    break;

                case (byte)Global.PRAISE_2.Capsule_Right_Y:
                    this.Set_Capsule_Right_Y(value);
                    break;

                case (byte)Global.PRAISE_2.Capsule_Right_Z:
                    this.Set_Capsule_Right_Z(value);
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
        private void Create_Direction_X(double direction_X)
        {
            _direction_X = direction_X;
        }
        private void Create_Direction_Y(double direction_Y)
        {
            _direction_y = direction_Y;
        }
        private void Create_Direction_Z(double direction_Z)
        {
            _direction_Z = direction_Z;
        }
        private void Create_Period(double period)
        {
            _period = period;
        }
        private void Create_Capsule_Position_X(double capsule_Position_X)
        {
            _Capsule_Position_X = capsule_Position_X;
        }
        private void Create_Capsule_Position_Y(double capsule_Position_Y)
        {
            _Capsule_Position_Y = capsule_Position_Y;
        }
        private void Create_Capsule_Position_Z(double capsule_Position_Z)
        {
            _Capsule_Position_Z = capsule_Position_Z;
        }
        private void Create_Capsule_Fowards_X(double capsule_Fowards_X)
        {
            _Capsule_Fowards_X = capsule_Fowards_X;
        }
        private void Create_Capsule_Fowards_Y(double capsule_Fowards_Y)
        {
            _Capsule_Fowards_Y = capsule_Fowards_Y;
        }
        private void Create_Capsule_Fowards_Z(double capsule_Fowards_Z)
        {
            _Capsule_Fowards_Z = capsule_Fowards_Z;
        }
        private void Create_Capsule_Up_X(double capsule_Up_X)
        {
            _Capsule_Up_X = capsule_Up_X;
        }
        private void Create_Capsule_Up_Y(double capsule_Up_Y)
        {
            _Capsule_Up_Y = capsule_Up_Y;
        }
        private void Create_Capsule_Up_Z(double capsule_Up_Z)
        {
            _Capsule_Up_Z = capsule_Up_Z;
        }
        private void Create_Capsule_Right_X(double capsule_Right_X)
        {
            _Capsule_Right_X = capsule_Right_X;
        }
        private void Create_Capsule_Right_Y(double capsule_Right_Y)
        {
            _Capsule_Right_Y = capsule_Right_Y;
        }
        private void Create_Capsule_Right_Z(double capsule_Right_Z)
        {
            _Capsule_Right_Z = capsule_Right_Z;
        }

    // get.
        private double Get_Direction_X()
        {
            return _direction_X;
        }
        private double Get_Direction_Y()
        {
            return _direction_y;
        }
        private double Get_Direction_Z()
        {
            return _direction_Z;
        }
        private double Get_Period()
        {
            return _period;
        }
        private double Get_Capsule_Position_X()
        {
            return _Capsule_Position_X;
        }
        private double Get_Capsule_Position_Y()
        {
            return _Capsule_Position_Y;
        }
        private double Get_Capsule_Position_Z()
        {
            return _Capsule_Position_Z;
        }
        private double Get_Capsule_Fowards_X()
        {
            return _Capsule_Fowards_X;
        }
        private double Get_Capsule_Fowards_Y()
        {
            return _Capsule_Fowards_Y;
        }
        private double Get_Capsule_Fowards_Z()
        {
            return _Capsule_Fowards_Z;
        }
        private double Get_Capsule_Up_X()
        {
            return _Capsule_Up_X;
        }
        private double Get_Capsule_Up_Y()
        {
            return _Capsule_Up_Y;
        }
        private double Get_Capsule_Up_Z()
        {
            return _Capsule_Up_Z;
        }
        private double Get_Capsule_Right_X()
        {
            return _Capsule_Right_X;
        }
        private double Get_Capsule_Right_Y()
        {
            return _Capsule_Right_Y;
        }
        private double Get_Capsule_Right_Z()
        {
            return _Capsule_Right_Z;
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
        private void Set_Direction_X(double value)
        {
            _direction_X = value;
        }
        private void Set_Direction_Y(double value)
        {
            _direction_y = value;
        }
        private void Set_Direction_Z(double value)
        {
            _direction_Z = value;
        }
        private void Set_Period(double value)
        {
            _period = value;
        }
        private void Set_Capsule_Position_X(double value)
        {
            _Capsule_Position_X = value;
        }
        private void Set_Capsule_Position_Y(double value)
        {
            _Capsule_Position_Y = value;
        }
        private void Set_Capsule_Position_Z(double value)
        {
            _Capsule_Position_Z = value;
        }
        private void Set_Capsule_Fowards_X(double value)
        {
            _Capsule_Fowards_X = value;
        }
        private void Set_Capsule_Fowards_Y(double value)
        {
            _Capsule_Fowards_Y = value;
        }
        private void Set_Capsule_Fowards_Z(double value)
        {
            _Capsule_Fowards_Z = value;
        }
        private void Set_Capsule_Up_X(double value)
        {
            _Capsule_Up_X = value;
        }
        private void Set_Capsule_Up_Y(double value)
        {
            _Capsule_Up_Y = value;
        }
        private void Set_Capsule_Up_Z(double value)
        {
            _Capsule_Up_Z = value;
        }
        private void Set_Capsule_Right_X(double value)
        {
            _Capsule_Right_X = value;
        }
        private void Set_Capsule_Right_Y(double value)
        {
            _Capsule_Right_Y = value;
        }
        private void Set_Capsule_Right_Z(double value)
        {
            _Capsule_Right_Z = value;
        }
    }
}

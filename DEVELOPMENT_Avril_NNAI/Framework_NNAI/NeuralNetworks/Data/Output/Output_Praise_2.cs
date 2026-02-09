
namespace OpenAvrilNNI
{
    public class Output_Praise_2
    {
// definitions.
        private enum PRAISE_2 : byte
        {
            Capsule_Position_X,
            Capsule_Position_Y,
            Capsule_Position_Z,
            Capsule_Fowards_X,
            Capsule_Fowards_Y,
            Capsule_Fowards_Z,
            Capsule_Up_X,
            Capsule_Up_Y,
            Capsule_Up_Z,
            Capsule_Right_X,
            Capsule_Right_Y,
            Capsule_Right_Z
        }

        // classes.

        // registers.
        private byte _NumberOfBooleanOutputs;
        private byte _NumberOfConstantOutputs;
        private byte _NumberOfLinearOutputs;
        private byte _NumberOutputRegisters;
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
        public Output_Praise_2()
        {
            Create_NumberOfBooleanOutputs();
            Create_NumberOfLinearOutputs();
            Create_NumberOfConstantOutputs();
            Create_NumberOutputRegisters();
            // custom user defined.
        }

        // destructor.
        ~Output_Praise_2()
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
                case (byte)PRAISE_2.Capsule_Position_X:
                    return Get_Capsule_Position_X();

                case (byte)PRAISE_2.Capsule_Position_Y:
                    return Get_Capsule_Position_Y();

                case (byte)PRAISE_2.Capsule_Position_Z:
                    return Get_Capsule_Position_Z();

                case (byte)PRAISE_2.Capsule_Fowards_X:
                    return Get_Capsule_Fowards_X();

                case (byte)PRAISE_2.Capsule_Fowards_Y:
                    return Get_Capsule_Fowards_Y();

                case (byte)PRAISE_2.Capsule_Fowards_Z:
                    return Get_Capsule_Fowards_Z();

                case (byte)PRAISE_2.Capsule_Up_X:
                    return Get_Capsule_Up_X();

                case (byte)PRAISE_2.Capsule_Up_Y:
                    return Get_Capsule_Up_Y();

                case (byte)PRAISE_2.Capsule_Up_Z:
                    return Get_Capsule_Up_Z();

                case (byte)PRAISE_2.Capsule_Right_X:
                    return Get_Capsule_Right_X();

                case (byte)PRAISE_2.Capsule_Right_Y:
                    return Get_Capsule_Right_Y();

                case (byte)PRAISE_2.Capsule_Right_Z:
                    return Get_Capsule_Right_Z();

                default:
                    return 0;
            }
        }
    // set.
        public void Set_Item_On_List_Of_Praise_Output(byte index, double value)
        {
            switch (index)
            {
                case (byte)PRAISE_2.Capsule_Position_X:
                    this.Set_Capsule_Position_X(value);
                    break;

                case (byte)PRAISE_2.Capsule_Position_Y:
                    this.Set_Capsule_Position_Y(value);
                    break;

                case (byte)PRAISE_2.Capsule_Position_Z:
                    this.Set_Capsule_Position_Z(value);
                    break;

                case (byte)PRAISE_2.Capsule_Fowards_X:
                    this.Set_Capsule_Fowards_X(value);
                    break;

                case (byte)PRAISE_2.Capsule_Fowards_Y:
                    this.Set_Capsule_Fowards_Y(value);
                    break;

                case (byte)PRAISE_2.Capsule_Fowards_Z:
                    this.Set_Capsule_Fowards_Z(value);
                    break;

                case (byte)PRAISE_2.Capsule_Up_X:
                    this.Set_Capsule_Up_X(value);
                    break;

                case (byte)PRAISE_2.Capsule_Up_Y:
                    this.Set_Capsule_Up_Y(value);
                    break;

                case (byte)PRAISE_2.Capsule_Up_Z:
                    this.Set_Capsule_Up_Z(value);
                    break;

                case (byte)PRAISE_2.Capsule_Right_X:
                    this.Set_Capsule_Right_X(value);
                    break;

                case (byte)PRAISE_2.Capsule_Right_Y:
                    this.Set_Capsule_Right_Y(value);
                    break;

                case (byte)PRAISE_2.Capsule_Right_Z:
                    this.Set_Capsule_Right_Z(value);
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
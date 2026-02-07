namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
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
        private byte _numberOfOutputValues;
        private byte _NumberOfResetToConstantValues;
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
            CreateGet_NumberOfResetToConstantValues(new byte());
            Set_NumberOfResetToConstantValues(0);
        }

// destructor.
        ~Output_Praise_2()
        {
            
        }

// public.
    // get.
        public double Get_Item_Of_Output_Praise(byte index)
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
        public byte Get_NumberOfResetToConstantValues()
        {
            return _NumberOfResetToConstantValues;
        }
        public byte Get_NumberOfOutputValues()
        {
            return _numberOfOutputValues;
        }
        
    // set.
        public void Set_Item_Of_Output_Praise(byte index, double value)
        {
            switch (index)
            {
                case (byte)PRAISE_2.Capsule_Position_X:
                    Set_Capsule_Position_X(value);
                    break;

                case (byte)PRAISE_2.Capsule_Position_Y:
                    Set_Capsule_Position_Y(value);
                    break;

                case (byte)PRAISE_2.Capsule_Position_Z:
                    Set_Capsule_Position_Z(value);
                    break;

                case (byte)PRAISE_2.Capsule_Fowards_X:
                    Set_Capsule_Fowards_X(value);
                    break;

                case (byte)PRAISE_2.Capsule_Fowards_Y:
                    Set_Capsule_Fowards_Y(value);
                    break;

                case (byte)PRAISE_2.Capsule_Fowards_Z:
                    Set_Capsule_Fowards_Z(value);
                    break;

                case (byte)PRAISE_2.Capsule_Up_X:
                    Set_Capsule_Up_X(value);
                    break;

                case (byte)PRAISE_2.Capsule_Up_Y:
                    Set_Capsule_Up_Y(value);
                    break;

                case (byte)PRAISE_2.Capsule_Up_Z:
                    Set_Capsule_Up_Z(value);
                    break;

                case (byte)PRAISE_2.Capsule_Right_X:
                    Set_Capsule_Right_X(value);
                    break;

                case (byte)PRAISE_2.Capsule_Right_Y:
                    Set_Capsule_Right_Y(value);
                    break;

                case (byte)PRAISE_2.Capsule_Right_Z:
                    Set_Capsule_Right_Z(value);
                    break;

                default:
                    break;
            }
        }

// private.
        private void CreateGet_NumberOfResetToConstantValues(byte value)
        {
            _NumberOfResetToConstantValues = value;
        }
        private void Create_NumberOfOutputValues(byte numberOfOutputValues)
        {
            _numberOfOutputValues = numberOfOutputValues;
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
        private void Set_NumberOfResetToConstantValues(byte value)
        {
            _NumberOfResetToConstantValues = value;
        }
        private void Set_NumberOfOutputValues(byte numberOfOutputValues)
        {
            _numberOfOutputValues = numberOfOutputValues;
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
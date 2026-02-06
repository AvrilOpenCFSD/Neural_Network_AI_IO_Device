
namespace Avril_NNAI
{
    public class Input_Praise_1
    {
// definitions.
        private enum PRAISE_1 : byte
        {
            Mouse_Screen_X,
            Mouse_Screen_Y,
            Capsule_Fowards_X,
            Capsule_Fowards_Y,
            Capsule_Fowards_Z,
            Capsule_Up_X,
            Capsule_Up_Y,
            Capsule_Up_Z,
            Capsule_Right_X,
            Capsule_Right_Y,
            Capsule_Right_Z,
        }
        
// classes.

// registers.
        private byte _NumberOfResetToConstantValues;
        private byte _numberOfInputValues;
        private double _Mouse_Screen_X;
        private double _Mouse_Screen_Y;
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
        public Input_Praise_1()
        {
            Create_NumberOfInputValues(new byte());
            Set_NumberOfInputValues(11);

            Create_NumberOfResetToConstantValues(new byte());
            Set_NumberOfResetToConstantValues(3);

            Create_Mouse_Screen_X(new double());
            Set_Mouse_Screen_X(0.0);

            Create_Mouse_Screen_Y(new double());
            Set_Mouse_Screen_Y(0.0);

            Create_Capsule_Fowards_X(new double());
            Set_Capsule_Fowards_X(0.0);

            Create_Capsule_Fowards_Y(new double());
            Set_Capsule_Fowards_Y(0.0);

            Create_Capsule_Fowards_Z(new double());
            Set_Capsule_Fowards_Z(0.0);

            Create_Capsule_Up_X(new double());
            Set_Capsule_Up_X(0.0);

            Create_Capsule_Up_Y(new double());
            Set_Capsule_Up_Y(0.0);

            Create_Capsule_Up_Z(new double());
            Set_Capsule_Up_Z(0.0);

            Create_Capsule_Right_X(new double());
            Set_Capsule_Right_X(0.0);

            Create_Capsule_Right_Y(new double());
            Set_Capsule_Right_Y(0.0);

            Create_Capsule_Right_Z(new double());
            Set_Capsule_Right_Z(0.0);
        }

// destructor.
        ~Input_Praise_1()
        {
        }

// public.
    // get.
        public double Get_Item_Of_Input_Praise(byte index)
        {
            switch (index)
            {
                case (byte)PRAISE_1.Mouse_Screen_X:
                    return Get_Mouse_Screen_X();

                case (byte)PRAISE_1.Mouse_Screen_Y:
                    return Get_Mouse_Screen_Y();

                case (byte)PRAISE_1.Capsule_Fowards_X:
                    return Get_Capsule_Fowards_X();

                case (byte)PRAISE_1.Capsule_Fowards_Y:
                    return Get_Capsule_Fowards_Y();

                case (byte)PRAISE_1.Capsule_Fowards_Z:
                    return Get_Capsule_Fowards_Z();

                case (byte)PRAISE_1.Capsule_Up_X:
                    return Get_Capsule_Up_X();

                case (byte)PRAISE_1.Capsule_Up_Y:
                    return Get_Capsule_Up_Y();

                case (byte)PRAISE_1.Capsule_Up_Z:
                    return Get_Capsule_Up_Z();

                case (byte)PRAISE_1.Capsule_Right_X:
                    return Get_Capsule_Right_X();

                case (byte)PRAISE_1.Capsule_Right_Y:
                    return Get_Capsule_Right_Y();

                case (byte)PRAISE_1.Capsule_Right_Z:
                    return Get_Capsule_Right_Z();

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
        public void Set_Item_Of_Input_Praise(byte index, double value)
        {
            switch (index)
            {
                case (byte)PRAISE_1.Mouse_Screen_X:
                    Set_Mouse_Screen_X(value);
                    break;

                case (byte)PRAISE_1.Mouse_Screen_Y:
                    Set_Mouse_Screen_Y(value);
                    break;

                case (byte)PRAISE_1.Capsule_Fowards_X:
                    Set_Capsule_Fowards_X(value);
                    break;

                case (byte)PRAISE_1.Capsule_Fowards_Y:
                    Set_Capsule_Fowards_Y(value);
                    break;

                case (byte)PRAISE_1.Capsule_Fowards_Z:
                    Set_Capsule_Fowards_Z(value);
                    break;

                case (byte)PRAISE_1.Capsule_Up_X:
                    Set_Capsule_Up_X(value);
                    break;

                case (byte)PRAISE_1.Capsule_Up_Y:
                    Set_Capsule_Up_Y(value);
                    break;

                case (byte)PRAISE_1.Capsule_Up_Z:
                    Set_Capsule_Up_Z(value);
                    break;

                case (byte)PRAISE_1.Capsule_Right_X:
                    Set_Capsule_Right_X(value);
                    break;

                case (byte)PRAISE_1.Capsule_Right_Y:
                    Set_Capsule_Right_Y(value);
                    break;

                case (byte)PRAISE_1.Capsule_Right_Z:
                    Set_Capsule_Right_Z(value);
                    break;

                default:
                    break;
            }
        }

// private.
        private void Create_NumberOfResetToConstantValues(byte numberOfResetToConstantValues)
        {
            _NumberOfResetToConstantValues = numberOfResetToConstantValues;
        }
        private void Create_NumberOfInputValues(byte numberOfInputValues)
        {
            _numberOfInputValues = numberOfInputValues;
        }
        private void Create_Mouse_Screen_X(double mouseX)
        {
            _Mouse_Screen_X = mouseX;
        }
        private void Create_Mouse_Screen_Y(double mouseY)
        {
            _Mouse_Screen_Y = mouseY;
        }
        private void Create_Capsule_Fowards_X(double capsualeFowardsX)
        {
            _Capsule_Fowards_X = capsualeFowardsX;
        }
        private void Create_Capsule_Fowards_Y(double capsualeFowardsY)
        {
            _Capsule_Fowards_Y = capsualeFowardsY;
        }
        private void Create_Capsule_Fowards_Z(double capsualeFowardsZ)
        {
            _Capsule_Fowards_Z = capsualeFowardsZ;
        }
        private void Create_Capsule_Up_X(double capsualeUpX)
        {
            _Capsule_Up_X = capsualeUpX;
        }
        private void Create_Capsule_Up_Y(double capsualeUpY)
        {
            _Capsule_Up_Y = capsualeUpY;
        }
        private void Create_Capsule_Up_Z(double capsualeUpZ)
        {
            _Capsule_Up_Z = capsualeUpZ;
        }
        private void Create_Capsule_Right_X(double capsualeRightX)
        {
            _Capsule_Right_X = capsualeRightX;
        }
        private void Create_Capsule_Right_Y(double capsualeRightY)
        {
            _Capsule_Right_Y = capsualeRightY;
        }
        private void Create_Capsule_Right_Z(double capsualeRightZ)
        {
            _Capsule_Right_Z = capsualeRightZ;
        }

    // get.
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
        private double Get_Mouse_Screen_X()
        {
            return _Mouse_Screen_X;
        }
        private double Get_Mouse_Screen_Y()
        {
            return _Mouse_Screen_Y;
        }

    // set.
        private void Set_Capsule_Fowards_X(double capsualeFowardsX)
        {
            _Capsule_Fowards_X = capsualeFowardsX;
        }
        private void Set_Capsule_Fowards_Y(double capsualeFowardsY)
        {
            _Capsule_Fowards_Y = capsualeFowardsY;
        }
        private void Set_Capsule_Fowards_Z(double capsualeFowardsZ)
        {
            _Capsule_Fowards_Z = capsualeFowardsZ;
        }
        private void Set_Capsule_Up_X(double capsualeUpX)
        {
            _Capsule_Up_X = capsualeUpX;
        }
        private void Set_Capsule_Up_Y(double capsualeUpY)
        {
            _Capsule_Up_Y = capsualeUpY;
        }
        private void Set_Capsule_Up_Z(double capsualeUpZ)
        {
            _Capsule_Up_Z = capsualeUpZ;
        }
        private void Set_Capsule_Right_X(double capsualeRightX)
        {
            _Capsule_Right_X = capsualeRightX;
        }
        private void Set_Capsule_Right_Y(double capsualeRightY)
        {
            _Capsule_Right_Y = capsualeRightY;
        }
        private void Set_Capsule_Right_Z(double capsualeRightZ)
        {
            _Capsule_Right_Z = capsualeRightZ;
        }
        private void Set_Mouse_Screen_X(double mouseX)
        {
            _Mouse_Screen_X = mouseX;
        }
        private void Set_Mouse_Screen_Y(double mouseY)
        {
            _Mouse_Screen_Y = mouseY;
        }
        private void Set_NumberOfResetToConstantValues(byte numberOfResetToConstantValues)
        {
            _NumberOfResetToConstantValues = numberOfResetToConstantValues;
        }
        private void Set_NumberOfInputValues(byte numberOfInputValues)
        {
            _numberOfInputValues = numberOfInputValues;
        }
    }
}

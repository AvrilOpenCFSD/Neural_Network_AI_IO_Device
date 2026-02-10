
namespace OpenAvrilNNI
{
    public class Input_Praise_1
    {
// definitions.

// classes.

// registers.
        private byte _NumberOfBooleanInputs;
        private byte _NumberOfConstantInputs;
        private byte _NumberInputRegisters;
        private byte _NumberOfLinearInputs;
        // custom user defined.
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
            Create_NumberInputRegisters();
            Set_NumberInputRegisters(11);
            Create_NumberOfLinearInputs();
            Set_NumberOfLinearInputs(9);
            Create_NumberOfBooleanInputs();
            Set_NumberOfBooleanInputs(0);
            Create_NumberOfConstantInputs();
            Set_NumberOfConstantInputs(3);
            // custom user defined.
            Create_Mouse_Screen_X();
            Create_Mouse_Screen_Y();
            Create_Capsule_Fowards_X();
            Create_Capsule_Fowards_Y();
            Create_Capsule_Fowards_Z();
            Create_Capsule_Up_X_CONST();
            Create_Capsule_Up_Y_CONST();
            Create_Capsule_Up_Z_CONST();
            Create_Capsule_Right_X();
            Create_Capsule_Right_Y();
            Create_Capsule_Right_Z();
        }

// destructor.
        ~Input_Praise_1()
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
                case (byte)Global.PRAISE_1.Mouse_Screen_X:
                    return Get_Mouse_Screen_X();

                case (byte)Global.PRAISE_1.Mouse_Screen_Y:
                    return Get_Mouse_Screen_Y();

                case (byte)Global.PRAISE_1.Capsule_Fowards_X:
                    return Get_Capsule_Fowards_X();

                case (byte)Global.PRAISE_1.Capsule_Fowards_Y:
                    return Get_Capsule_Fowards_Y();

                case (byte)Global.PRAISE_1.Capsule_Fowards_Z:
                    return Get_Capsule_Fowards_Z();

                case (byte)Global.PRAISE_1.Capsule_Up_X:
                    return Get_Capsule_Up_X_CONST();

                case (byte)Global.PRAISE_1.Capsule_Up_Y:
                    return Get_Capsule_Up_Y_CONST();

                case (byte)Global.PRAISE_1.Capsule_Up_Z:
                    return Get_Capsule_Up_Z_CONST();

                case (byte)Global.PRAISE_1.Capsule_Right_X:
                    return Get_Capsule_Right_X();

                case (byte)Global.PRAISE_1.Capsule_Right_Y:
                    return Get_Capsule_Right_Y();

                case (byte)Global.PRAISE_1.Capsule_Right_Z:
                    return Get_Capsule_Right_Z();

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
                case (byte)Global.PRAISE_1.Mouse_Screen_X:
                    Set_Mouse_Screen_X(value);
                    break;

                case (byte)Global.PRAISE_1.Mouse_Screen_Y:
                    Set_Mouse_Screen_Y(value);
                    break;

                case (byte)Global.PRAISE_1.Capsule_Fowards_X:
                    Set_Capsule_Fowards_X(value);
                    break;

                case (byte)Global.PRAISE_1.Capsule_Fowards_Y:
                    Set_Capsule_Fowards_Y(value);
                    break;

                case (byte)Global.PRAISE_1.Capsule_Fowards_Z:
                    Set_Capsule_Fowards_Z(value);
                    break;

                case (byte)Global.PRAISE_1.Capsule_Right_X:
                    Set_Capsule_Right_X(value);
                    break;

                case (byte)Global.PRAISE_1.Capsule_Right_Y:
                    Set_Capsule_Right_Y(value);
                    break;

                case (byte)Global.PRAISE_1.Capsule_Right_Z:
                    Set_Capsule_Right_Z(value);
                    break;

                case (byte)Global.PRAISE_1.Capsule_Up_X:
                    Set_Capsule_Up_X_CONST(0.0);
                    break;

                case (byte)Global.PRAISE_1.Capsule_Up_Y:
                    Set_Capsule_Up_Y_CONST(1.0);
                    break;

                case (byte)Global.PRAISE_1.Capsule_Up_Z:
                    Set_Capsule_Up_Z_CONST(0.0);
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
        private void Create_Mouse_Screen_X()
        {
            Set_Mouse_Screen_X(new double());
            Set_Mouse_Screen_X(0.0);
        }
        private void Create_Mouse_Screen_Y()
        {
            Set_Mouse_Screen_Y(new double());
            Set_Mouse_Screen_Y(0.0);
        }
        private void Create_Capsule_Fowards_X()
        {
            Set_Capsule_Fowards_X(new double());
            Set_Capsule_Fowards_X(1.0);
        }
        private void Create_Capsule_Fowards_Y()
        {
            Set_Capsule_Fowards_Y(new double());
            Set_Capsule_Fowards_Y(0.0);
        }
        private void Create_Capsule_Fowards_Z()
        {
            Set_Capsule_Fowards_Z(new double());
            Set_Capsule_Fowards_Z(0.0);
        }
        private void Create_Capsule_Up_X_CONST()
        {
            Set_Capsule_Up_X_CONST(new double());
            Set_Capsule_Up_X_CONST(0.0);
        }
        private void Create_Capsule_Up_Y_CONST()
        {
            Set_Capsule_Up_Y_CONST(new double());
            Set_Capsule_Up_Y_CONST(0.0);
        }
        private void Create_Capsule_Up_Z_CONST()
        {
            Set_Capsule_Up_Z_CONST(new double());
            Set_Capsule_Up_Z_CONST(0.0);
        }
        private void Create_Capsule_Right_X()
        {
            Set_Capsule_Right_X(new double());
            Set_Capsule_Right_X(0.0);
        }
        private void Create_Capsule_Right_Y()
        {
            Set_Capsule_Right_Y(new double());
            Set_Capsule_Right_Y(0.0);
        }
        private void Create_Capsule_Right_Z()
        {
            Set_Capsule_Right_Z(new double());
            Set_Capsule_Right_Z(1.0);
        }
    // get.
        // custom user defined.
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
        private double Get_Capsule_Up_X_CONST()
        {
            return _Capsule_Up_X;
        }
        private double Get_Capsule_Up_Y_CONST()
        {
            return _Capsule_Up_Y;
        }
        private double Get_Capsule_Up_Z_CONST()
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
        private void Set_Capsule_Up_X_CONST(double capsualeUpX)
        {
            _Capsule_Up_X = capsualeUpX;
        }
        private void Set_Capsule_Up_Y_CONST(double capsualeUpY)
        {
            _Capsule_Up_Y = capsualeUpY;
        }
        private void Set_Capsule_Up_Z_CONST(double capsualeUpZ)
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

    }
}

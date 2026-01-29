
using System;

namespace Avril_NNAI
{
    public class Input_Praise_0
    {
        enum PRAISE_0
        {
            Ping
        }
        private byte _numberOfInputValues;
        private double _Ping;

        public Input_Praise_0()
        {
            Set_NumberOfInputValues(1);
            
        }

        public double Get_Item_Of_Input_Praise(byte index)
        {
            switch (index)
            {
                case 0:
                    return Get_Ping();
                default:
                    return 0;
            }
        }

        public double Get_Ping()
        {
            return _Ping;
        }

        public ulong Get_NumberOfInputValues()
        {
            return _numberOfInputValues;
        }

        public void Set_Item_Of_Input_Praise(byte index, double value)
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

        private void Set_Ping(double value)
        {
            _Ping = value;
        }

        private void Set_NumberOfInputValues(byte numberOfInputValues)
        {
            _numberOfInputValues = numberOfInputValues;
        }
    }
}

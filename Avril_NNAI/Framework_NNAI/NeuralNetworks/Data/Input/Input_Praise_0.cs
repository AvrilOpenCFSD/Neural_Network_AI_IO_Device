
namespace Avril_NNAI
{
    public class Input_Praise_0
    {
        private byte _numberOfInputValues;
        private long _Ping;

        public Input_Praise_0()
        {
            Set_NumberOfInputValues(1);
            
        }

        public long Get_Item_Of_Input_Praise(byte index)
        {
            switch (index)
            {
                case 0:
                    return Get_Ping();
                default:
                    return 0;
            }
        }

        public long Get_Ping()
        {
            return _Ping;
        }

        public ulong Get_NumberOfInputValues()
        {
            return _numberOfInputValues;
        }

        private void Set_NumberOfInputValues(byte numberOfInputValues)
        {
            _numberOfInputValues = numberOfInputValues;
        }
    }
}

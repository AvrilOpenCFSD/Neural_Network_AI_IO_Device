
namespace Avril_NNAI
{
    public class Input_Praise_1
    {
        private byte _numberOfInputValues;
        private double _mouseX;
        private double _mouseY;

        public Input_Praise_1()
        {
            Set_NumberOfInputValues(2);
            Set_MouseX(0);
            Set_MouseY(0);
        }

        public double Get_Item_Of_Input_Praise(byte index)
        {
            switch(index)
            {
                case 0:
                    return Get_MouseX();
                case 1:
                    return Get_MouseY();
                default:
                    return 0;
            }
        }

        public double Get_MouseX()
        {
            return _mouseX;
        }

        public double Get_MouseY()
        {
            return _mouseY;
        }

        public ulong Get_NumberOfInputValues()
        {
            return _numberOfInputValues;
        }

        private void Set_MouseX(double mouseX)
        {
            _mouseX = mouseX;
        }

        private void Set_MouseY(double mouseY)
        {
            _mouseY = mouseY;
        }

        private void Set_NumberOfInputValues(byte numberOfInputValues)
        {
            _numberOfInputValues = numberOfInputValues;
        }
    }
}

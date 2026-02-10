
namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class Data
    {
// classes.
        private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI[] _List_Of_Neural_Network;
        private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Input _input;
        private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI _newMachineAI;
        private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output _output;

// registers.
        private bool _isFirstSave;

// constructor.
        public Data()
        {
            System.Console.WriteLine("entered Data.");
            Create_Input();
            System.Console.WriteLine("ALPHA.");
            Create_Output();
            System.Console.WriteLine("BRAVO.");
            Create_NewMachineAI();
            System.Console.WriteLine("CHARLIE.");
            Create_List_Of_Neural_Network(1);
            System.Console.WriteLine("ECHO.");
            Create_IsFirstSave();
        }

// destructor.
        ~Data()
        {
            //System.Console.WriteLine("exited Data.");
        }

// public.
        public void Preserve_New_Neural_Network(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI newNeuralNetwork)
        {
            if (Get_IsFirstSave())
            {
                Set_Item_On_List_Of_Neural_Network(0, newNeuralNetwork);
                Set_IsFirstSave(false);
            }
            else
            {
                OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI[] old_NeuralNetworkList = Get_List_Of_Neural_Network_Preservation();
                Create_List_Of_Neural_Network((byte)(Get_List_Of_Neural_Network_Preservation().LongLength + (long)1));
                for (byte index = 0; index < (byte)old_NeuralNetworkList.LongLength; index++)
                {
                    Set_Item_On_List_Of_Neural_Network(index, old_NeuralNetworkList[index]);
                }
                Set_Item_On_List_Of_Neural_Network((byte)Get_List_Of_Neural_Network_Preservation().LongLength, newNeuralNetwork);
            }
        }
    // get.
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI Get_Item_On_List_Of_Neural_Network_Preservation(byte praiseID)
        {
            return _List_Of_Neural_Network[praiseID];
        }
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Input Get_Input()
        {
            return _input;
        }
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI[] Get_List_Of_Neural_Network_Preservation()
        {
            return _List_Of_Neural_Network;
        }
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI Get_NewMachineAI()
        {
            return _newMachineAI;
        }
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output Get_Output()
        {
            return _output;
        }
    // set.

// private.
        private void Create_List_Of_Neural_Network(byte numberOfNNI)
        {
            _List_Of_Neural_Network = new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI[numberOfNNI];
            while (Get_List_Of_Neural_Network_Preservation() == null) { }
            for (byte index = 0; index < numberOfNNI; index++)
            {
                Set_Item_On_List_Of_Neural_Network(index, Get_NewMachineAI());
            }
        }
        private void Create_IsFirstSave()
        {
            _isFirstSave = new bool();
            Set_IsFirstSave(true);
        }
        private void Create_Input()
        {
            _input = new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Input();
            while (Get_Input() == null) { }
        }
        private void Create_NewMachineAI()
        {
            _newMachineAI = new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI();
            while (Get_NewMachineAI() == null) { }
        }
        private void Create_Output()
        {
            _output = new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Output();
            while (Get_Output() == null) { }
        }
    // get.
        private bool Get_IsFirstSave()
        {
            return _isFirstSave;
        }
    // set.
        private void Set_Item_On_List_Of_Neural_Network(byte praiseID, OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI newMachineAI)
        {
            _List_Of_Neural_Network[praiseID] = newMachineAI;
        }
        private void Set_IsFirstSave(bool newIsFirstSave)
        {
            _isFirstSave = newIsFirstSave;
        }
    }
}

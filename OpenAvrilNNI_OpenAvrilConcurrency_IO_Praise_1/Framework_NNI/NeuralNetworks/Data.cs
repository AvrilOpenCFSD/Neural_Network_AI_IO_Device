
namespace OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1
{
    public class Data
    {
// classes.
        private MachineAI[] _List_Of_Neural_Network;
        private Input _input;
        private MachineAI _newMachineAI;
        private Output _output;

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
        public void Preserve_New_Neural_Network(MachineAI newNeuralNetwork)
        {
            if (Get_IsFirstSave())
            {
                Set_Item_On_List_Of_Neural_Network(0, newNeuralNetwork);
                Set_IsFirstSave(false);
            }
            else
            {
                MachineAI[] old_NeuralNetworkList = Get_List_Of_Neural_Network_Preservation();
                Create_List_Of_Neural_Network((byte)(Get_List_Of_Neural_Network_Preservation().LongLength + (long)1));
                for (byte index = 0; index < (byte)old_NeuralNetworkList.LongLength; index++)
                {
                    Set_Item_On_List_Of_Neural_Network(index, old_NeuralNetworkList[index]);
                }
                Set_Item_On_List_Of_Neural_Network((byte)Get_List_Of_Neural_Network_Preservation().LongLength, newNeuralNetwork);
            }
        }
    // get.
        public MachineAI Get_Item_On_List_Of_Neural_Network_Preservation(byte praiseID)
        {
            return _List_Of_Neural_Network[praiseID];
        }
        public Input Get_Input()
        {
            return _input;
        }
        public MachineAI[] Get_List_Of_Neural_Network_Preservation()
        {
            return _List_Of_Neural_Network;
        }
        public MachineAI Get_NewMachineAI()
        {
            return _newMachineAI;
        }
        public Output Get_Output()
        {
            return _output;
        }
    // set.

// private.
        private void Create_List_Of_Neural_Network(byte numberOfNNI)
        {
            _List_Of_Neural_Network = new MachineAI[numberOfNNI];
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
            _input = new Input();
            while (Get_Input() == null) { }
        }
        private void Create_NewMachineAI()
        {
            _newMachineAI = new MachineAI();
            while (Get_NewMachineAI() == null) { }
        }
        private void Create_Output()
        {
            _output = new Output();
            while (Get_Output() == null) { }
        }
    // get.
        private bool Get_IsFirstSave()
        {
            return _isFirstSave;
        }
    // set.
        private void Set_Item_On_List_Of_Neural_Network(byte praiseID, MachineAI newMachineAI)
        {
            _List_Of_Neural_Network[praiseID] = newMachineAI;
        }
        private void Set_IsFirstSave(bool newIsFirstSave)
        {
            _isFirstSave = newIsFirstSave;
        }
    }
}

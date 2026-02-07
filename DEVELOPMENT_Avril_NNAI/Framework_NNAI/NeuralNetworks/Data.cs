
namespace Avril_NNAI
{
    public class Data
    {
// classes.
        private Avril_NNAI.MachineAI[] _List_Of_Neural_Network;
        private Avril_NNAI.Input _input;
        private Avril_NNAI.MachineAI _newMachineAI;
        private Avril_NNAI.Output _output;

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
        public void Preserve_New_Neural_Network(Avril_NNAI.MachineAI newNeuralNetwork)
        {
            if (Get_IsFirstSave())
            {
                Set_Item_On_List_Of_Neural_Network(0, newNeuralNetwork);
                Set_IsFirstSave(false);
            }
            else
            {
                Avril_NNAI.MachineAI[] old_NeuralNetworkList = Get_List_Of_Neural_Network_Preservation();
                Create_List_Of_Neural_Network((ulong)(Get_List_Of_Neural_Network_Preservation().LongLength + (long)1));
                for (ulong index = 0; index < (ulong)old_NeuralNetworkList.LongLength; index++)
                {
                    Set_Item_On_List_Of_Neural_Network(index, old_NeuralNetworkList[index]);
                }
                Set_Item_On_List_Of_Neural_Network((ulong)Get_List_Of_Neural_Network_Preservation().LongLength, newNeuralNetwork);
            }
        }
    // get.
        public Avril_NNAI.MachineAI Get_Item_On_List_Of_Neural_Network_Preservation(ulong praiseID)
        {
            return _List_Of_Neural_Network[praiseID];
        }
        public Avril_NNAI.Input Get_Input()
        {
            return _input;
        }
        public Avril_NNAI.MachineAI[] Get_List_Of_Neural_Network_Preservation()
        {
            return _List_Of_Neural_Network;
        }
        public Avril_NNAI.MachineAI Get_NewMachineAI()
        {
            return _newMachineAI;
        }
        public Avril_NNAI.Output Get_Output()
        {
            return _output;
        }
    // set.

// private.
        private void Create_List_Of_Neural_Network(ulong numberOfNNAI)
        {
            _List_Of_Neural_Network = new Avril_NNAI.MachineAI[numberOfNNAI];
            while (Get_List_Of_Neural_Network_Preservation() == null) { }
            for (ulong index = 0; index < numberOfNNAI; index++)
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
            _input = new Avril_NNAI.Input();
            while (Get_Input() == null) { }
        }
        private void Create_NewMachineAI()
        {
            _newMachineAI = new Avril_NNAI.MachineAI();
            while (Get_NewMachineAI() == null) { }
        }
        private void Create_Output()
        {
            _output = new Avril_NNAI.Output();
            while (Get_Output() == null) { }
        }
    // get.
        private bool Get_IsFirstSave()
        {
            return _isFirstSave;
        }
    // set.
        private void Set_Item_On_List_Of_Neural_Network(ulong praiseID, Avril_NNAI.MachineAI newMachineAI)
        {
            _List_Of_Neural_Network[praiseID] = newMachineAI;
        }
        private void Set_IsFirstSave(bool newIsFirstSave)
        {
            _isFirstSave = newIsFirstSave;
        }
    }
}

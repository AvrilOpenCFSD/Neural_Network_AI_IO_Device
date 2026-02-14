
using System;

namespace OpenAvrilNNI
{
    public class Data
    {
// classes.
        private Input _Input;
        private Output _Output;

// registers.
    // lists.
        private MachineAI[] _list_Of_MachineAI;
    // bool.
        private bool _isFirstSave;


// constructor.
        public Data()
        {
            System.Console.WriteLine("entered Data.");
            Create_Input();
            Create_Output();
            Create_list_Of_MachineAI();
            Create_isFirstSave();
        }

// destructor.
        ~Data()
        {
            //System.Console.WriteLine("exited Data.");
        }

// public.
        public void Initialise_DEFAULT_list_Of_MachineAI(MachineAI _DEFAULT_MachineAI)
        {
            Set_list_Of_MachineAI(new MachineAI[1]);
            while (Get_list_Of_MachineAI_Preservation() == null) { }
            Set_Item_On_list_Of_MachineAI(0, _DEFAULT_MachineAI);
        }
        public void Preserve_New_Neural_Network(MachineAI newNeuralNetwork)
        {
            MachineAI[] oldList = Get_list_Of_MachineAI_Preservation();
            Set_list_Of_MachineAI(new MachineAI[(byte)Get_list_Of_MachineAI_Preservation().LongLength + 1]);
            for (byte index = 0; index < oldList.LongLength; index++)
            {
                Set_Item_On_list_Of_MachineAI(index, oldList[index]);
            }
            Set_Item_On_list_Of_MachineAI((byte)Get_list_Of_MachineAI_Preservation().LongLength, newNeuralNetwork);
        }
    // get.
        public MachineAI Get_Item_On_list_Of_MachineAI(byte praiseID)
        {
            return _list_Of_MachineAI[praiseID];
        }
        public Input Get_Input()
        {
            return _Input;
        }
        public MachineAI[] Get_list_Of_MachineAI_Preservation()
        {
            return _list_Of_MachineAI;
        }
        public Output Get_Output()
        {
            return _Output;
        }
    // set.

// private.
        private void Create_isFirstSave()
        {
            Set_isFirstSave(new bool());
            Set_isFirstSave(true);
        }
        private void Create_Input()
        {
            Set_Input(new Input());
            while (Get_Input() == null) { }
        }
        private void Create_Output()
        {
            Set_Output(new Output());
            while (Get_Output() == null) { }
        }
        private void Create_list_Of_MachineAI()
        {
            Set_list_Of_MachineAI(new MachineAI[1]);
            while (Get_list_Of_MachineAI_Preservation() == null) { }
            Set_Item_On_list_Of_MachineAI(0, new MachineAI());
            while (Get_Item_On_list_Of_MachineAI(0) == null) { }
        }
        private void Initialise_New_list_Of_MachineAI()
        {
            
            while (Get_list_Of_MachineAI_Preservation() == null) { }
        }
    // get.
        private bool Get_isFirstSave()
        {
            return _isFirstSave;
        }
    // set.
        private void Set_Item_On_list_Of_MachineAI(byte praiseID, MachineAI newMachineAI)
        {
            _list_Of_MachineAI[praiseID] = newMachineAI;
        }
        private void Set_isFirstSave(bool new_isFirstSave)
        {
            _isFirstSave = new_isFirstSave;
        }
        private void Set_Input(Input newInput)
        {
            _Input = newInput;
        }
        private void Set_list_Of_MachineAI(MachineAI[] newList_Of_Neural_Network)
        {
            _list_Of_MachineAI = newList_Of_Neural_Network;
        }
        private void Set_Output(Output newOutput)
        {
            _Output = newOutput;
        }
    }
}

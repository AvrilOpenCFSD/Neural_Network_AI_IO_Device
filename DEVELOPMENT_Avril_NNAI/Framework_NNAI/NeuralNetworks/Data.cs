
namespace Avril_NNAI
{
    public class Data
    {
// classes.
        private Avril_NNAI.MachineAI[] _AvrilNNAI_OpenCFSD_Praise_IO;
        private Avril_NNAI.Input _input;
        private Avril_NNAI.MachineAI _newMachineAI;
        private Avril_NNAI.Output _output;

// registers.
        private bool _isFirstSave;

// constructor.
        public Data()
        {
            //System.Console.WriteLine("entered Data.");
            Create_Input(new Avril_NNAI.Input());
            while (Get_Input() == null) { }
            //System.Console.WriteLine("ALPHA.");
            Create_Output(new Avril_NNAI.Output());
            while (Get_Output() == null) { }
            //System.Console.WriteLine("BRAVO.");
            Create_NewMachineAI(new Avril_NNAI.MachineAI());
            while (Get_NewMachineAI() == null) { }
            //System.Console.WriteLine("CHARLIE.");
            Create_Neural_Network_Preservation_List(new Avril_NNAI.MachineAI[1]);
            while (Get_List_Of_Neural_Network_Preservation() == null) { }
            Set_NewMachineAI(0, Get_NewMachineAI());
            //System.Console.WriteLine("ECHO.");
            _isFirstSave = true;
        }

// destructor.
        ~Data()
        {
            //System.Console.WriteLine("exited Data.");
        }

// public.
        private void Create_Neural_Network_Preservation_List(Avril_NNAI.MachineAI[] machineAIs)
        {
            _AvrilNNAI_OpenCFSD_Praise_IO = machineAIs;
        }
        private void Create_Input(Avril_NNAI.Input input)
        {
            _input = input;
        }
        private void Create_NewMachineAI(Avril_NNAI.MachineAI machineAI)
        {
            _newMachineAI = machineAI;
        }
        private void Create_Output(Avril_NNAI.Output output)
        {
            _output = output;
        }

        public void Preserve_New_Neural_Network(Avril_NNAI.MachineAI newNeuralNetwork)
        {
            if (_isFirstSave)
            {
                _AvrilNNAI_OpenCFSD_Praise_IO[0] = newNeuralNetwork;
                _isFirstSave = false;
            }
            else
            {
                Avril_NNAI.MachineAI[] old_NeuralNetworkList = _AvrilNNAI_OpenCFSD_Praise_IO;
                _AvrilNNAI_OpenCFSD_Praise_IO = new Avril_NNAI.MachineAI[(ulong)(_AvrilNNAI_OpenCFSD_Praise_IO.LongLength + 1)];
                for (ulong index = 0; index < (ulong)old_NeuralNetworkList.LongLength; index++)
                {
                    _AvrilNNAI_OpenCFSD_Praise_IO[index] = old_NeuralNetworkList[index];
                }
                _AvrilNNAI_OpenCFSD_Praise_IO[(ulong)_AvrilNNAI_OpenCFSD_Praise_IO.LongLength] = newNeuralNetwork;
            }
        }
    
    // get.
        public Avril_NNAI.MachineAI Get_Item_Of_Neural_Network_Preservation_List(ulong praiseID)
        {
            return _AvrilNNAI_OpenCFSD_Praise_IO[praiseID];
        }
        public Avril_NNAI.Input Get_Input()
        {
            return _input;
        }
        public Avril_NNAI.MachineAI[] Get_List_Of_Neural_Network_Preservation()
        {
            return _AvrilNNAI_OpenCFSD_Praise_IO;
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
        public void Set_NewMachineAI(ulong index, Avril_NNAI.MachineAI machineAI)
        {
            _AvrilNNAI_OpenCFSD_Praise_IO[index] = machineAI;
        }

// private.
    // get.
    // set.
    }
}

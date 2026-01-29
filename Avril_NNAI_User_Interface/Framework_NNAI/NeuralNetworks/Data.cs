
using System.Linq;
using System.Windows.Markup;
using static Avril_NNAI.MetaData;

namespace Avril_NNAI
{
    public class Data
    {
        private Avril_NNAI.MachineAI[] _AvrilNNAI_OpenCFSD_Praise_IO;
        private Avril_NNAI.Input _input;
        private Avril_NNAI.MachineAI _newMachineAI;
        private Avril_NNAI.Output _output;
        private bool _isFirstSave;

        public Data()
        {
            Create_Input(new Avril_NNAI.Input());
            while (Get_Input() == null) { }

            Create_Output(new Avril_NNAI.Output());
            while (Get_Output() == null) { }

            Create_NewMachineAI(new Avril_NNAI.MachineAI());
            while (Get_NewMachineAI() == null) { }

            Create_AvrilNNAI_OpenCFSD_Praise_IO(new Avril_NNAI.MachineAI[1]);
            while (Get_AvrilNNAI_OpenCFSD_Praise_IO(0) == null) { }

            _isFirstSave = true;
        }

        public void Create_AvrilNNAI_OpenCFSD_Praise_IO(Avril_NNAI.MachineAI[] machineAIs)
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
        public void Save_New_Neural_Network(Avril_NNAI.MachineAI newNeuralNetwork)
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

        public Avril_NNAI.MachineAI Get_AvrilNNAI_OpenCFSD_Praise_IO(ulong praiseID)
        {
            return _AvrilNNAI_OpenCFSD_Praise_IO[praiseID];
        }
        public Avril_NNAI.Input Get_Input()
        {
            return _input;
        }
        public Avril_NNAI.MachineAI Get_NewMachineAI()
        {
            return _newMachineAI;
        }
        public Avril_NNAI.Output Get_Output()
        {
            return _output;
        }

        public void Set_AvrilNNAI_OpenCFSD_Praise_IO(ulong index, Avril_NNAI.MachineAI machineAI)
        {
            _AvrilNNAI_OpenCFSD_Praise_IO[index] = machineAI;
        }
        public void Set_Input(Avril_NNAI.Input input)
        {
            _input = input;
        }
        public void Set_NewMachineAI(ulong index, Avril_NNAI.MachineAI machineAI)
        {
            _AvrilNNAI_OpenCFSD_Praise_IO[index] = machineAI;
        }
        public void Set_Output(Avril_NNAI.Output output)
        {
            _output = output;
        }
    }
}

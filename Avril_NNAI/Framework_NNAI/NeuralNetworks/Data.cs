
using System.Linq;

namespace Avril_NNAI
{
    public class Data
    {
        private Avril_NNAI.Input _input;
        private Avril_NNAI.MachineAI _machineAI;
        private Avril_NNAI.Output _output;
        
        public Data()
        {
            Set_Input(new Avril_NNAI.Input());
            while (Get_Input() == null) { }

            Set_Output(new Avril_NNAI.Output());
            while (Get_Output() == null) { }

            Set_MachineAI(new Avril_NNAI.MachineAI());
            while (Get_MachineAI() == null) { }
        }

        public Avril_NNAI.Input Get_Input()
        {
            return _input;
        }

        public Avril_NNAI.MachineAI Get_MachineAI()
        {
            return _machineAI;
        }

        public Avril_NNAI.Output Get_Output()
        {
            return _output;
        }

        private void Set_Input(Avril_NNAI.Input input)
        {
            _input = input;
        }

        private void Set_MachineAI(Avril_NNAI.MachineAI machineAI)
        {
            _machineAI = machineAI;
        }

        private void Set_Output(Avril_NNAI.Output output)
        {
            _output = output;
        }
    }
}


namespace Avril_NNAI
{
    public class Data
    {
// classes.
        private Avril_NNAI.Input _input;
        private Avril_NNAI.MachineAI _newMachineAI;
        private Avril_NNAI.Output _output;

// registers.

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
        }

// destructor.
        ~Data()
        {
            //System.Console.WriteLine("exited Data.");
        }

// public.
    
    // get.
        public Avril_NNAI.MachineAI Get_NewMachineAI()
        {
            return _newMachineAI;
        }
        public Avril_NNAI.Input Get_Input()
        {
            return _input;
        }
        public Avril_NNAI.Output Get_Output()
        {
            return _output;
        }

    // set.


// private.
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
    // get.
        
    // set.

    }
}

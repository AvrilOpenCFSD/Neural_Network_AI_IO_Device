
namespace Avril_NNAI
{
    public class Node
    {
// classes.
        private Avril_NNAI.Node_Control _Node_Control;

        // registers.
        private Avril_NNAI.Linear[] _List_Of_NeuralPathOfNodeInputs;
        private ulong _NumberOfInputs;
        private double _REGISTERED_Output;

// constructor.
        public Node()
        {
            //System.Console.WriteLine("entered Node.");
            Create_List_Of_NeuralPathOfNodeInputs(new Avril_NNAI.Linear[2]);
            while (Get_List_Of_NeuralPathOfInput_SubSet() == null) { }
            Set_NeuralPathOfInput_SubSet(0, new Avril_NNAI.Linear());
            Set_NeuralPathOfInput_SubSet(1, new Avril_NNAI.Linear());

            Create_NumberOfInputs(new ulong());
            Set_NumberOfInputs(2);

            Create_REGISTERED_Output(new double());
            Set_REGISTERED_Output(0.0);
            //System.Console.WriteLine("exiting Node.");
        }

// destructor.
        ~Node()
        {

        }

// public.
        public void Create_List_Of_NeuralPathOfNodeInputs(Avril_NNAI.Linear[] list_Of_NeuralPathOfNodeInputsneuralPathOfInputs)
        {
            _List_Of_NeuralPathOfNodeInputs = list_Of_NeuralPathOfNodeInputsneuralPathOfInputs;
        }
    
    // get.
        public Avril_NNAI.Linear Get_NeuralPathOfInput_SubSet(ulong nodeID)
        {
            return _List_Of_NeuralPathOfNodeInputs[nodeID];
        }
        public ulong Get_NumberOfInputs()
        {
            return _NumberOfInputs;
        }
        public double Get_REGISTERED_Output()
        {
            return _REGISTERED_Output;
        }

    // set.
        public void Set_NeuralPathOfInput_SubSet(ulong inputID, Avril_NNAI.Linear neuralPathOfInput_SubSet)
        {
            _List_Of_NeuralPathOfNodeInputs[inputID] = neuralPathOfInput_SubSet;
        }
        public void Set_NumberOfInputs(ulong numberOfInputs)
        {
            _NumberOfInputs = numberOfInputs;
        }
        public void Set_REGISTERED_Output(double registered_Output)
        {
            _REGISTERED_Output = registered_Output;
        }

// private.
        private void Create_NumberOfInputs(ulong value)
        {
            _NumberOfInputs = value;
        }
        private void Create_REGISTERED_Output(double registered_Output)
        {
            _REGISTERED_Output = registered_Output;
        }

    // get.
        private Avril_NNAI.Linear[] Get_List_Of_NeuralPathOfInput_SubSet()
        {
            return _List_Of_NeuralPathOfNodeInputs;
        }
    // set.
    }
}

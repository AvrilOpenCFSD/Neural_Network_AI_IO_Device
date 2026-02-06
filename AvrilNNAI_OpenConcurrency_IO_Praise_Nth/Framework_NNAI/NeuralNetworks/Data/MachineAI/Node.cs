
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

            Create_NumberOfInputs(new ulong());
            Set_NumberOfInputs(2);

            Create_REGISTERED_Output(new double());
            Set_REGISTERED_Output(0.0);

            Create_List_Of_NeuralPathOfNodeInputs(new Avril_NNAI.Linear[Get_NumberOfInputs()]);
            while (Get_List_Of_NeuralPathOfInput() == null) { }
            Set_NeuralPathOfInput_SubSet(0, new Avril_NNAI.Linear());
            while (Get_List_Of_NeuralPathOfInput()[0] == null) { }
            Set_NeuralPathOfInput_SubSet(1, new Avril_NNAI.Linear());
            while (Get_List_Of_NeuralPathOfInput()[1] == null) { }

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
        public Avril_NNAI.Linear Get_Item_On_List_Of_NeuralPathOfInput(ulong inputID)
        {
            return _List_Of_NeuralPathOfNodeInputs[inputID];
        }
        public Avril_NNAI.Linear[] Get_List_Of_NeuralPathOfInput()
        {
            return _List_Of_NeuralPathOfNodeInputs;
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

    // set.
    }
}

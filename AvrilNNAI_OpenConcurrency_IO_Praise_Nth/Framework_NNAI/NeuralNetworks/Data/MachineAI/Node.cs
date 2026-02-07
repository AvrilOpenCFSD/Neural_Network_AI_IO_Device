
namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
{
    public class Node
    {
// classes.
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Node_Control _Node_Control;

        // registers.
        private AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Linear[] _List_Of_NeuralPathOfNodeInputs;
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

            Create_List_Of_NeuralPathOfNodeInputs(new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Linear[Get_NumberOfInputs()]);
            while (Get_List_Of_NeuralPathOfInput() == null) { }
            Set_NeuralPathOfInput_SubSet(0, new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Linear());
            while (Get_List_Of_NeuralPathOfInput()[0] == null) { }
            Set_NeuralPathOfInput_SubSet(1, new AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Linear());
            while (Get_List_Of_NeuralPathOfInput()[1] == null) { }

            //System.Console.WriteLine("exiting Node.");
        }

// destructor.
        ~Node()
        {

        }

// public.
        public void Create_List_Of_NeuralPathOfNodeInputs(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Linear[] list_Of_NeuralPathOfNodeInputsneuralPathOfInputs)
        {
            _List_Of_NeuralPathOfNodeInputs = list_Of_NeuralPathOfNodeInputsneuralPathOfInputs;
        }
        public void Run_Neural_Path_Calculation(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI objNNAI, byte outputID, byte hiddenLayerID, ulong nodeID, ulong numberOfInputsForNode)
        {
            double sum_Bias = 0.0;
            double sum_weight = 0.0;
            double outputValue = 0.0;
            for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
            {
                sum_Bias = sum_Bias + objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Get_Item_On_List_Of_NeuralPathOfInput(inputID).Get_Bias();
            }
            for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
            {
                sum_weight = sum_weight + (objNNAI.Get_Item_On_List_Of_REGISTERED_Inputs(inputID) * objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Get_Item_On_List_Of_NeuralPathOfInput(inputID).Get_Weight());
            }
            outputValue = sum_Bias + sum_weight;
            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Set_REGISTERED_Output(outputValue);
        }
    // get.
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Linear Get_Item_On_List_Of_NeuralPathOfInput(ulong inputID)
        {
            return _List_Of_NeuralPathOfNodeInputs[inputID];
        }
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Linear[] Get_List_Of_NeuralPathOfInput()
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
        public void Set_NeuralPathOfInput_SubSet(ulong inputID, AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Linear neuralPathOfInput_SubSet)
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

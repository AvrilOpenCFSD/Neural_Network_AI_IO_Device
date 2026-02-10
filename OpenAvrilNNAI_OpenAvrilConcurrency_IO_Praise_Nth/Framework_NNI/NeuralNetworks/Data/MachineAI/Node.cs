
namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class Node
    {
// classes.

// registers.
        private Linear[] _List_Of_NeuralPathOfNodeInputs;
        private byte _NumberOfInputs;
        private double _REGISTERED_Output;

// constructor.
        public Node()
        {
            //System.Console.WriteLine("entered Node.");

            Create_NumberOfInputs(new byte());
            Set_NumberOfInputs(2);

            Create_REGISTERED_Output(new double());
            Set_REGISTERED_Output(0.0);

            Create_List_Of_NeuralPathOfNodeInputs(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear[Get_NumberOfInputs()]);
            while (Get_List_Of_NeuralPathOfInput() == null) { }
            Set_NeuralPathOfInput_SubSet(0, new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear());
            while (Get_List_Of_NeuralPathOfInput()[0] == null) { }
            Set_NeuralPathOfInput_SubSet(1, new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear());
            while (Get_List_Of_NeuralPathOfInput()[1] == null) { }

            //System.Console.WriteLine("exiting Node.");
        }

// destructor.
        ~Node()
        {

        }

// public.
        public void Create_List_Of_NeuralPathOfNodeInputs(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear[] list_Of_NeuralPathOfNodeInputsneuralPathOfInputs)
        {
            _List_Of_NeuralPathOfNodeInputs = list_Of_NeuralPathOfNodeInputsneuralPathOfInputs;
        }
        public void Run_Neural_Path_Calculation(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI, byte outputID, byte hiddenLayerID, byte nodeID, byte numberOfInputsForNode)
        {
            double sum_Bias = 0.0;
            double sum_weight = 0.0;
            double outputValue = 0.0;
            for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
            {
                sum_Bias = sum_Bias + objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Get_Item_On_List_Of_NeuralPathOfInput(inputID).Get_Bias();
            }
            for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
            {
                sum_weight = sum_weight + (objNNI.Get_Item_On_List_Of_REGISTERED_Inputs(inputID) * objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Get_Item_On_List_Of_NeuralPathOfInput(inputID).Get_Weight());
            }
            outputValue = sum_Bias + sum_weight;
            objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Set_REGISTERED_Output(outputValue);
        }
    // get.
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear Get_Item_On_List_Of_NeuralPathOfInput(byte inputID)
        {
            return _List_Of_NeuralPathOfNodeInputs[inputID];
        }
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear[] Get_List_Of_NeuralPathOfInput()
        {
            return _List_Of_NeuralPathOfNodeInputs;
        }
        public byte Get_NumberOfInputs()
        {
            return _NumberOfInputs;
        }
        public double Get_REGISTERED_Output()
        {
            return _REGISTERED_Output;
        }

    // set.
        public void Set_NeuralPathOfInput_SubSet(byte inputID, OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear neuralPathOfInput_SubSet)
        {
            _List_Of_NeuralPathOfNodeInputs[inputID] = neuralPathOfInput_SubSet;
        }
        public void Set_NumberOfInputs(byte numberOfInputs)
        {
            _NumberOfInputs = numberOfInputs;
        }
        public void Set_REGISTERED_Output(double registered_Output)
        {
            _REGISTERED_Output = registered_Output;
        }

// private.
        private void Create_NumberOfInputs(byte value)
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

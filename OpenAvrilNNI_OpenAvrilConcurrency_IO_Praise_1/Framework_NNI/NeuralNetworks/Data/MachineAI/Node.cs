
namespace OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1
{
    public class Node
    {
// classes.

// registers.
        private Linear_NeuralPath[] _List_Of_Linear_NeuralPath;
        private byte _NumberOfInputs;
        private double _REGISTERED_Output;

// constructor.
        public Node()
        {
            //System.Console.WriteLine("entered Node.");
            Create_NumberOfInputs();
            Create_List_Of_Linear_NeuralPath(Get_NumberOfInputs());
            Create_REGISTERED_Output();
            //System.Console.WriteLine("exiting Node.");
        }

// destructor.
        ~Node()
        {

        }

// public.
        public void Create_List_Of_Linear_NeuralPath(byte numberOfInputs)
        {
            Set_List_Of_Linear_NeuralPath(new Linear_NeuralPath[numberOfInputs]);
            while (Get_List_Of_Linear_NeuralPath() == null) { }
            for (byte index = 0; index < numberOfInputs; index++)
            {
                Set_Item_On_List_Of_Linear_NeuralPath(index, new Linear_NeuralPath());
            }
        }
        public void Run_All_Neural_Path_Calculations(MachineAI objNNI, byte outputID, byte hiddenLayerID, byte nodeID, byte numberOfInputsForNode)
        {
            double sum_Bias = 0.0;
            double sum_weight = 0.0;
            double outputValue = 0.0;
            for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
            {
                sum_Bias = sum_Bias + objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_List_Of_Linear_NeuralPath(inputID).Get_Bias();
            }
            for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
            {
                sum_weight = sum_weight + (objNNI.Get_Item_On_List_Of_REGISTERED_Inputs(inputID) * objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_List_Of_Linear_NeuralPath(inputID).Get_Weight());
            }
            outputValue = sum_Bias + sum_weight;
            objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_REGISTERED_Output(outputValue);
        }
    // get.
        public Linear_NeuralPath Get_Item_On_List_Of_Linear_NeuralPath(byte inputID)
        {
            return _List_Of_Linear_NeuralPath[inputID];
        }
        public Linear_NeuralPath[] Get_List_Of_Linear_NeuralPath()
        {
            return _List_Of_Linear_NeuralPath;
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
        public void Set_List_Of_Linear_NeuralPath(Linear_NeuralPath[] newList)
        {
            _List_Of_Linear_NeuralPath = newList;
        }
        public void Set_Item_On_List_Of_Linear_NeuralPath(byte inputID, Linear_NeuralPath newItem)
        {
            _List_Of_Linear_NeuralPath[inputID] = newItem;
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
        private void Create_NumberOfInputs()
        {
            Set_NumberOfInputs(new byte());
            Set_NumberOfInputs(0);
        }
        private void Create_REGISTERED_Output()
        {
            Set_REGISTERED_Output(new double());
            Set_REGISTERED_Output(0.0);
        }

    // get.

    // set.
    }
}

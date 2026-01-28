
using System;

namespace Avril_NNAI
{
    public class Node
    {
        ulong _NumberOfInputs;
        double[] _REGISTERED_Inputs = new double[1];
        Avril_NNAI.Linear[] _NeuralPathOfInput_SubSet;
        double _REGISTERED_Output;

        public Node()
        {
            Set_NumberOfInputs(1);
            Create_REGISTERED_Inputs(new double[1]);
            Create_Array_NeuralPathOfInput_SubSet(new Avril_NNAI.Linear[1]);
        }

        public void Create_REGISTERED_Inputs(double[] registered_Inputs)
        {
            _REGISTERED_Inputs = registered_Inputs;
        }

        public void Create_Array_NeuralPathOfInput_SubSet(Avril_NNAI.Linear[] neuralPathOfInput_SubSet)
        {
            _NeuralPathOfInput_SubSet = neuralPathOfInput_SubSet;
        }

        public ulong Get_NumberOfInputs()
        {
            return _NumberOfInputs;
        }

        public double Get_REGISTERED_Inputs(ulong praiseID)
        {
            return _REGISTERED_Inputs[praiseID];
        }

        public void Set_NumberOfInputs(ulong numberOfInputs)
        {
            _NumberOfInputs = numberOfInputs;
        }

        public void Set_REGISTERED_Inputs(ulong praiseID, double registered_Input)
        {
            _REGISTERED_Inputs[praiseID] = registered_Input;
        }
    }
}

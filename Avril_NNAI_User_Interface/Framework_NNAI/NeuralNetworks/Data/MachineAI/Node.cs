
using System;

namespace Avril_NNAI
{
    public class Node
    {
        ulong _NumberOfInputs;
        Avril_NNAI.Linear[] _NeuralPathOfInput_SubSet;
        double[] _REGISTERED_Inputs = new double[1];
        double _REGISTERED_Output;

        public Node()
        {
            Set_NumberOfInputs(1);
            Create_REGISTERED_Inputs(new double[1]);
            Create_NeuralPathOfInput_SubSet(new Avril_NNAI.Linear[1]);
            Create_REGISTERED_Output(new double());
        }

        public void Create_NeuralPathOfInput_SubSet(Avril_NNAI.Linear[] neuralPathOfInput_SubSet)
        {
            _NeuralPathOfInput_SubSet = neuralPathOfInput_SubSet;
        }

        public void Create_REGISTERED_Inputs(double[] registered_Inputs)
        {
            _REGISTERED_Inputs = registered_Inputs;
        }

        private void Create_REGISTERED_Output(double registered_Output)
        {
            _REGISTERED_Output = registered_Output;
        }

        public ulong Get_NumberOfInputs()
        {
            return _NumberOfInputs;
        }

        public Avril_NNAI.Linear Get_NeuralPathOfInput_SubSet(ulong nodeID)
        {
            return _NeuralPathOfInput_SubSet[nodeID];
        }

        public double Get_REGISTERED_Input(ulong praiseID)
        {
            return _REGISTERED_Inputs[praiseID];
        }

        public double Get_REGISTERED_Output()
        {
            return _REGISTERED_Output;
        }

        public void Set_NumberOfInputs(ulong numberOfInputs)
        {
            _NumberOfInputs = numberOfInputs;
        }

        public void Set_NeuralPathOfInput_SubSet(ulong inputID, Avril_NNAI.Linear neuralPathOfInput_SubSet)
        {
            _NeuralPathOfInput_SubSet[inputID] = neuralPathOfInput_SubSet;
        }

        public void Set_REGISTERED_Inputs(ulong praiseID, double registered_Input)
        {
            _REGISTERED_Inputs[praiseID] = registered_Input;
        }
        public void Set_REGISTERED_Output(double registered_Output)
        {
            _REGISTERED_Output = registered_Output;
        }
    }
}

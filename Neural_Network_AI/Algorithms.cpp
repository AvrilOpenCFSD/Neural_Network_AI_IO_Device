#include "pch.h"
#include "Algorithms.h"

class Avril_NNAI::NeuralPath* ptr_NeuralPaths = NULL;
class Avril_NNAI::SolutionLogic* ptr_SolutionLogic = NULL;

Avril_NNAI::Algorithms::Algorithms()
{
    ptr_NeuralPaths = new class Avril_NNAI::NeuralPath();
    while (ptr_NeuralPaths == NULL) {}

    ptr_SolutionLogic = new class Avril_NNAI::SolutionLogic();
    while (ptr_SolutionLogic == NULL) {}
}

Avril_NNAI::Algorithms::~Algorithms()
{
    //delete ;
}

void Avril_NNAI::Algorithms::ConstructNeuralNetworkAI_Frame(Avril_NNAI::Framework_NNAI* obj, INT64 _numberOfTotalInputs)
{
    obj->Get_Neural_Networks()->Get_Data()->Set_NumberOTotalInputs(_numberOfTotalInputs);

    for (INT64 index_A = 0; index_A < _numberOfTotalInputs; index_A++)
    {
        //layer 4 - input layer
        obj->Get_Neural_Networks()->Get_Data()->Get_Nodes(index_A)->Set_NumberOfNodeInputs(_numberOfTotalInputs);
        // ToDo: set input sub set for praise 
        // obj->Get_Neural_Networks()->Get_Data()->Get_Nodes(index_A)->Get_Node_Input(index_A)

        //layer 3: hidden layer
        for (INT64 index_B = 0; index_B < _numberOfTotalInputs; index_B++)
        {
            obj->Get_Neural_Networks()->Get_Data()->Get_Nodes(index_A)->Set_Input_SubSet(index_B, obj->Get_Neural_Networks()->Get_Data()->Get_Inputs(index_B));
            obj->Get_Neural_Networks()->Get_Data()->Get_Nodes(index_A)->Set_NeuralPathOfInput_SubSet(index_B, obj->Get_Neural_Networks()->Get_Algorithms()->Get_NeuralPath());
            obj->Get_Neural_Networks()->Get_Data()->Get_Nodes(index_A)->Get_NeuralPathOfInput_SubSet(index_B)->Set_NatureOfThePath_LINEAR((Avril_NNAI::Linear*)obj->Get_Neural_Networks()->Get_Algorithms()->Get_NeuralPath()->Get_NatureOfThePath(obj));
        }

        //ToDo: layer 2: hidden layer

        //ToDo: layer 1: hidden layer

        //layer 0 - output layer
        obj->Get_Neural_Networks()->Get_Data()->Get_Nodes(index_A)->Set_Node_Output(obj->Get_Neural_Networks()->Get_Data()->Get_Output());
    }
}

void Avril_NNAI::Algorithms::Initialise_Control()
{
  
}

Avril_NNAI::NeuralPath* Avril_NNAI::Algorithms::Get_NeuralPath()
{
    return ptr_NeuralPaths;
}

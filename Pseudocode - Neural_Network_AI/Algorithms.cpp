#include "pch.h"
#include "Algorithms.h"

class OpenAvrilNNI::NeuralPath* ptr_NeuralPaths = NULL;
class OpenAvrilNNI::SolutionLogic* ptr_SolutionLogic = NULL;

OpenAvrilNNI::Algorithms::Algorithms()
{
    ptr_NeuralPaths = new class OpenAvrilNNI::NeuralPath();
    while (ptr_NeuralPaths == NULL) {}

    ptr_SolutionLogic = new class OpenAvrilNNI::SolutionLogic();
    while (ptr_SolutionLogic == NULL) {}
}

OpenAvrilNNI::Algorithms::~Algorithms()
{
    //delete ;
}

void OpenAvrilNNI::Algorithms::ConstructNeuralNetworkAI_Frame(OpenAvrilNNI::Framework_NNI* obj, INT64 _numberOfTotalInputs)
{
    obj->Get_Neural_Networks()->Get_Data()->Set_NumberOfTotalInputs(_numberOfTotalInputs);

    for (INT64 index_A = 0; index_A < _numberOfTotalInputs; index_A++)
    {
        //layer 4 - input layer
		obj->Get_Neural_Networks()->Get_Data()->
        // ToDo: set input sub set for praise 
        // obj->Get_Neural_Networks()->Get_Data()->Get_Nodes(index_A)->Get_Node_Input(index_A)

        //ToDo: layer 3: hidden layer

        //ToDo: layer 2: hidden layer

        //ToDo: layer 1: hidden layer

        //layer 0 - output layer
        obj->Get_Neural_Networks()->Get_Data()->Get_Nodes(index_A)->Set_Node_Output(obj->Get_Neural_Networks()->Get_Data()->Get_Output());
    }
}

void OpenAvrilNNI::Algorithms::Initialise_Control()
{
  
}

OpenAvrilNNI::NeuralPath* OpenAvrilNNI::Algorithms::Get_NeuralPath()
{
    return ptr_NeuralPaths;
}

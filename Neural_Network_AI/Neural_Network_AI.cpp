// Neural_Network_AI.cpp : Defines the exported functions for the DLL.
//

#include "pch.h"
#include "framework.h"
#include "Neural_Network_AI.h"

class Avril_NNAI::Framework_NNAI* _Neural_Networks_AI = NULL;

// This is an example of an exported variable
NEURALNETWORKAI_API int nNeuralNetworkAI=0;

// This is the constructor of a class that has been exported.
Avril_NNAI::CNeuralNetworkAI_IOs::CNeuralNetworkAI_IOs()
{
}

void* Avril_NNAI::CNeuralNetworkAI_IOs::InitialiseThisNeuralNetworkAI()
{
    _Neural_Networks_AI = new class Avril_NNAI::Framework_NNAI();
    while (_Neural_Networks_AI == NULL) {}
    return (void*)_Neural_Networks_AI;
}

void Avril_NNAI::CNeuralNetworkAI_Training::ConstructNeuralNetworkAI_Frame(Avril_NNAI::Framework_NNAI* obj, INT64 _numberOfTotalInputs)
{
	obj->Get_Neural_Networks()->Get_Algorithms()->ConstructNeuralNetworkAI_Frame(obj, _numberOfTotalInputs);
}

// This is an example of an exported function.
NEURALNETWORKAI_API int fnNeuralNetworkAI(void)
{
    return 0;
}
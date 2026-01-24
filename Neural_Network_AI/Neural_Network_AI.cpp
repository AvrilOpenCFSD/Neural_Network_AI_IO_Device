// Neural_Network_AI.cpp : Defines the exported functions for the DLL.
//

#include "pch.h"
#include "framework.h"
#include "Neural_Network_AI.h"

class Avril_NNAI::Framework_NNAI* _Neural_Networks_AI = NULL;

// This is an example of an exported variable
NEURALNETWORKAI_API int nNeuralNetworkAI=0;

void* Avril_NNAI::CNeuralNetworkAI::InitialiseThisNeuralNetworkAI()
{
    _Neural_Networks_AI = new class Avril_NNAI::Framework_NNAI();
    while (_Neural_Networks_AI == NULL) {}
    return (void*)_Neural_Networks_AI;
}

// This is an example of an exported function.
NEURALNETWORKAI_API int fnNeuralNetworkAI(void)
{
    return 0;
}

// This is the constructor of a class that has been exported.
Avril_NNAI::CNeuralNetworkAI::CNeuralNetworkAI()
{
    return;
}

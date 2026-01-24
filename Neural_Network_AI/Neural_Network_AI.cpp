// Neural_Network_AI.cpp : Defines the exported functions for the DLL.
//

#include "pch.h"
#include "framework.h"
#include "Neural_Network_AI.h"


// This is an example of an exported variable
NEURALNETWORKAI_API int nNeuralNetworkAI=0;

// This is an example of an exported function.
NEURALNETWORKAI_API int fnNeuralNetworkAI(void)
{
    return 0;
}

// This is the constructor of a class that has been exported.
CNeuralNetworkAI::CNeuralNetworkAI()
{
    return;
}

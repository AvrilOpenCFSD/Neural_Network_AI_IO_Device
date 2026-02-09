#include "pch.h"
#include "Framework_NNI.h"


class OpenAvrilNNI::NeuralNetworks* ptr_NeuralNetworks = NULL;

OpenAvrilNNI::Framework_NNI::Framework_NNI()
{
	std::cout << "entered => Framework_Server::Framework_NNI()" << std::endl;

	Set_Neural_Networks(new class OpenAvrilNNI::NeuralNetworks());
	while (Get_Neural_Networks() == NULL) { }
	std::cout << "Created => Created Server Assembly()" << std::endl;

}

OpenAvrilNNI::Framework_NNI::~Framework_NNI()
{

}

OpenAvrilNNI::Framework_NNI::~Framework_NNI()
{
	delete ptr_NeuralNetworks;
}

class OpenAvrilNNI::NeuralNetworks* OpenAvrilNNI::Framework_NNI::Get_Neural_Networks()
{
	return ptr_NeuralNetworks;
}

void OpenAvrilNNI::Framework_NNI::Set_Neural_Networks(OpenAvrilNNI::NeuralNetworks* neuralNetworks)
{
	ptr_NeuralNetworks = neuralNetworks;
}
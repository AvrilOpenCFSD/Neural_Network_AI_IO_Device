#include "pch.h"
#include "Framework_NNAI.h"


class Avril_NNAI::NeuralNetworks* ptr_NeuralNetworks = NULL;

Avril_NNAI::Framework_NNAI::Framework_NNAI()
{
	std::cout << "entered => Framework_Server::Framework_NNAI()" << std::endl;

	Set_Neural_Networks(new class Avril_NNAI::NeuralNetworks());
	while (Get_Neural_Networks() == NULL) { }
	std::cout << "Created => Created Server Assembly()" << std::endl;

}

Avril_NNAI::Framework_NNAI::~Framework_NNAI()
{

}

Avril_NNAI::Framework_NNAI::~Framework_NNAI()
{
	delete ptr_NeuralNetworks;
}

class Avril_NNAI::NeuralNetworks* Avril_NNAI::Framework_NNAI::Get_Neural_Networks()
{
	return ptr_NeuralNetworks;
}

void Avril_NNAI::Framework_NNAI::Set_Neural_Networks(Avril_NNAI::NeuralNetworks* neuralNetworks)
{
	ptr_NeuralNetworks = neuralNetworks;
}
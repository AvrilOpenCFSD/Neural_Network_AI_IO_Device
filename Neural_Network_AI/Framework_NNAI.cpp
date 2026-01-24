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

void Avril_NNAI::Framework_NNAI::Initialise_Program(Avril_NNAI::Framework_NNAI* obj)
{
	std::cout << "entered => Avril_FSD::Framework_Server::Initialise_Program()" << std::endl;

	obj->Get_Neural_Networks()->Get_Algorithms()->Initialise(ptr_NeuralNetworks->Get_Global()->Get_NumCores());
	std::cout << "Created => INIT Server" << std::endl;

	obj->Get_Neural_Networks()->Get_Data()->Initialise(ptr_NeuralNetworks->Get_Global()->Get_NumCores());

	obj->Get_Neural_Networks()->Get_Execute()->Initialise_Libraries();
	std::cout << "Created => INIT Libraries" << std::endl;

	obj->Get_Neural_Networks()->Get_Data()->Initialise_GameInstance();
	std::cout << "Created => Game Instance" << std::endl;

	obj->Get_Neural_Networks()->Get_Execute()->Initialise_Threads(obj);
	std::cout << "Created => Thread(s)" << std::endl;
}

class Avril_NNAI::NeuralNetworks* Avril_NNAI::Framework_NNAI::Get_Neural_Networks()
{
	return ptr_NeuralNetworks;
}

void Avril_NNAI::Framework_NNAI::Set_Neural_Networks(Avril_NNAI::NeuralNetworks* neuralNetworks)
{
	ptr_NeuralNetworks = neuralNetworks;
}
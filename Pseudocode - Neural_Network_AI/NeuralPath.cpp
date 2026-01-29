#include "pch.h"
#include "NeuralPath.h"

class Object* ptr_NatureOfInputEquation = NULL;
class Avril_NNAI::Linear* ptr_Linear = NULL;

Avril_NNAI::NeuralPath::NeuralPath()
{
	ptr_Linear = new class Avril_NNAI::Linear();
	while (ptr_Linear == NULL) {}
}

Avril_NNAI::NeuralPath::~NeuralPath()
{
	//delete ;
}

Object* Avril_NNAI::NeuralPath::Get_NatureOfThePath(Avril_NNAI::Framework_NNAI* obj)
{
	return ptr_NatureOfInputEquation;
}

void Avril_NNAI::NeuralPath::Set_NatureOfThePath_NIL()
{
	ptr_NatureOfInputEquation = (Object*)INT64(0);
}

void Avril_NNAI::NeuralPath::Set_NatureOfThePath_LINEAR(Avril_NNAI::Linear* natureOfInputEquation)
{
	ptr_NatureOfInputEquation = (Object*)natureOfInputEquation;
}


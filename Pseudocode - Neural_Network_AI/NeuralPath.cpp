#include "pch.h"
#include "NeuralPath.h"

class Object* ptr_NatureOfInputEquation = NULL;
class OpenAvrilNNI::Linear* ptr_Linear = NULL;

OpenAvrilNNI::NeuralPath::NeuralPath()
{
	ptr_Linear = new class OpenAvrilNNI::Linear();
	while (ptr_Linear == NULL) {}
}

OpenAvrilNNI::NeuralPath::~NeuralPath()
{
	//delete ;
}

Object* OpenAvrilNNI::NeuralPath::Get_NatureOfThePath(OpenAvrilNNI::Framework_NNI* obj)
{
	return ptr_NatureOfInputEquation;
}

void OpenAvrilNNI::NeuralPath::Set_NatureOfThePath_NIL()
{
	ptr_NatureOfInputEquation = (Object*)INT64(0);
}

void OpenAvrilNNI::NeuralPath::Set_NatureOfThePath_LINEAR(OpenAvrilNNI::Linear* natureOfInputEquation)
{
	ptr_NatureOfInputEquation = (Object*)natureOfInputEquation;
}


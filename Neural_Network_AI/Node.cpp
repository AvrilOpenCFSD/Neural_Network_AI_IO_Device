#include "pch.h"
#include "Node.h"

INT64 _numberOfNodeInputs;
std::vector<class Object*>* ptr_Input_SubSet;
std::vector<class Object*>* ptr_NeuralPathOfInput_SubSet;
class Object* ptr_Node_Output_SubSet = NULL;

Avril_NNAI::Node::Node()
{
	_numberOfNodeInputs = 0;

	ptr_Input_SubSet->clear();

	ptr_NeuralPathOfInput_SubSet->clear();
}

Avril_NNAI::Node::~Node()
{
	//delete ;
}

class Object* Avril_NNAI::Node::Get_Input_SubSet(INT64 nodeID)
{
	return ptr_Input_SubSet->at(nodeID);
}

class Object* Avril_NNAI::Node::Get_NeuralPathOfInput_SubSet(INT64 nodeID)
{
	return ptr_NeuralPathOfInput_SubSet->at(nodeID);
}

Object* Avril_NNAI::Node::Get_Output_SubSet()
{
	return nullptr;
}


INT64 Avril_NNAI::Node::Get_NumberOfNodeInputs()
{
	return _numberOfNodeInputs;
}

void Avril_NNAI::Node::Set_Input_SubSet(INT64 nodeID, Avril_NNAI::Input* input)
{
	ptr_Input_SubSet->at(nodeID) = (Object*)input;
}

void Avril_NNAI::Node::Set_NeuralPathOfInput_SubSet(INT64 nodeID, Avril_NNAI::NeuralPath* neuralPath)
{
	ptr_NeuralPathOfInput_SubSet->at(nodeID) = (Object*)neuralPath;
}

void Avril_NNAI::Node::Set_Output_SubSet(class Avril_NNAI::Output* output)
{
	ptr_Node_Output_SubSet = (Object*)output;
}

void Avril_NNAI::Node::Set_NumberOfNodeInputs(INT64 numberOfNodeInputs)
{
	_numberOfNodeInputs = numberOfNodeInputs;
	if ((_numberOfNodeInputs > INT64(0)) && (_numberOfNodeInputs < INT64(9223372036854775807)))
	{
		ptr_Input_SubSet->resize(_numberOfNodeInputs);
		//todo
		ptr_NeuralPathOfInput_SubSet->resize(_numberOfNodeInputs);
		//todo
	}
	
}

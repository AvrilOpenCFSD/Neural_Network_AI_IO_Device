#include "pch.h"
#include "Node.h"

INT64 ptr_numberOfNodeInputs;
std::vector<INT64*>* ptr_VALUE_Input;
std::vector<class Object*>* ptr_NeuralPathOfInput_SubSet;
INT64 ptr_VALUE_Output;

OpenAvrilNNI::Node::Node()
{
	ptr_numberOfNodeInputs = INT64(0);

	ptr_VALUE_Input->clear();

	ptr_NeuralPathOfInput_SubSet->clear();

	ptr_VALUE_Output = INT64(0);
}

OpenAvrilNNI::Node::~Node()
{
	//delete ;
}

INT64 OpenAvrilNNI::Node::Get_NumberOfNodeInputs()
{
	return ptr_numberOfNodeInputs;
}

void OpenAvrilNNI::Node::Set_NumberOfNodeInputs(INT64 numberOfNodeInputs)
{
	Set_NumberOfNodeInputs(numberOfNodeInputs);
	if ((Get_NumberOfNodeInputs() > INT64(0)) && (Get_NumberOfNodeInputs() < INT64(9223372036854775807)))
	{
		ptr_VALUE_Input->resize(Get_NumberOfNodeInputs());
		//todo
		ptr_NeuralPathOfInput_SubSet->resize(Get_NumberOfNodeInputs());
		//todo
	}
	
}

void OpenAvrilNNI::Node::Set_Input_SubSet(INT64 nodeID, class OpenAvrilNNI::Input_Praise_0* inputSubSet)
{
	for (INT64 index = 0; index < inputSubSet->Get_Number_Of_Values_In_Praise(); index++)
	{
		ptr_VALUE_Input->at(nodeID) = inputSubSet->Get_ping_Active();
	}
}

void OpenAvrilNNI::Node::Set_NeuralPathOfInput_SubSet(INT64 nodeID, class OpenAvrilNNI::Linear* neuralPathNature)
{
	ptr_NeuralPathOfInput_SubSet->at(nodeID) = (Object*)neuralPathNature;
}

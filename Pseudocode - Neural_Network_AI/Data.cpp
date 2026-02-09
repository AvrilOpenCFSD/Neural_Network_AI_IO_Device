#include "pch.h"
#include "Data.h"

class OpenAvrilNNI::Input* ptr_Input = NULL;
class OpenAvrilNNI::Output* ptr_Output = NULL;

INT64 _numberOfTotalInputs;
//std::vector<class Object*>* ptr_REGISTERED_Input_List;
std::vector<class OpenAvrilNNI::Node*>* ptr_Layer4_Node_Inputs;
std::vector<class OpenAvrilNNI::Node*>* ptr_Layer3_Node_Inputs;
std::vector<class OpenAvrilNNI::Node*>* ptr_Layer2_Node_Inputs;
std::vector<class OpenAvrilNNI::Node*>* ptr_Layer1_Node_Inputs;
class OpenAvrilNNI::Node* ptr_Layer0_Node_Output;
class Object* ptr_REGISTERED_Output;

OpenAvrilNNI::Data::Data()
{
	Set_Input(new class OpenAvrilNNI::Input());
	while (ptr_Input == NULL) {}

	Set_Output(new class OpenAvrilNNI::Output());
	while (ptr_Output == NULL) {}

	Set_NumberOfTotalInputs(INT64(0));

	OpenAvrilNNI::Node* newEmptyNode = new class OpenAvrilNNI::Node();

	ptr_Layer4_Node_Inputs->clear();
	ptr_Layer4_Node_Inputs->at(INT64(0)) = newEmptyNode;
	while (ptr_Layer4_Node_Inputs->at(INT64(0)) == NULL) {}
	
	ptr_Layer3_Node_Inputs->clear();
	ptr_Layer3_Node_Inputs->at(0) = newEmptyNode;
	while (ptr_Layer3_Node_Inputs->at(0) == NULL) {}

	ptr_Layer2_Node_Inputs->clear();
	ptr_Layer2_Node_Inputs->at(0) = newEmptyNode;
	while (ptr_Layer2_Node_Inputs->at(0) == NULL) {}

	ptr_Layer1_Node_Inputs->clear();
	ptr_Layer1_Node_Inputs->at(0) = newEmptyNode;
	while (ptr_Layer1_Node_Inputs->at(0) == NULL) {}

	ptr_Layer0_Node_Output = newEmptyNode;
	while (ptr_Layer0_Node_Output == NULL) {}
}

OpenAvrilNNI::Data::~Data()
{
    //delete ;
}

void OpenAvrilNNI::Data::Initialise_Control()
{

}

OpenAvrilNNI::Input* OpenAvrilNNI::Data::Get_Input()
{
	return ptr_Input;
}

OpenAvrilNNI::Output* OpenAvrilNNI::Data::Get_Output()
{
	return ptr_Output;
}

class Object* OpenAvrilNNI::Data::Get_Item_At_REGISTERED_Output()
{
	return ptr_REGISTERED_Output;
}

INT64 OpenAvrilNNI::Data::Get_NumberOfTotalInputs()
{
	return _numberOfTotalInputs;
}

void OpenAvrilNNI::Data::Set_Input(class OpenAvrilNNI::Input* input)
{
	ptr_Input = input;
}

void OpenAvrilNNI::Data::Set_Output(class OpenAvrilNNI::Output* output)
{
	ptr_Output = output;
}

void OpenAvrilNNI::Data::Set_NumberOfTotalInputs(INT64 numberOfTotalInputs)
{
	_numberOfTotalInputs = numberOfTotalInputs;

	if ((Get_NumberOfTotalInputs() > INT64(0)) && (Get_NumberOfTotalInputs() < INT64(9223372036854775807)))
	{
		ptr_Layer4_Node_Inputs->resize(INT64(Get_NumberOfTotalInputs()));
		for (INT64 index = 0; index < (INT64(Get_NumberOfTotalInputs())); index++)
		{
			ptr_Layer4_Node_Inputs->at(index)->Set_NumberOfNodeInputs(ptr_Layer4_Node_Inputs->size());
		}

		ptr_Layer3_Node_Inputs->resize(INT64(Get_NumberOfTotalInputs() / double(4 / 5)));
		for (INT64 index = 0; index < (INT64(Get_NumberOfTotalInputs() / double(5 / 5))); index++)
		{
			ptr_Layer3_Node_Inputs->at(index)->Set_NumberOfNodeInputs(ptr_Layer3_Node_Inputs->size());
		}

		ptr_Layer2_Node_Inputs->resize(INT64(Get_NumberOfTotalInputs() / double(3 / 5)));
		for (INT64 index = 0; index < (INT64(Get_NumberOfTotalInputs() / double(5 / 5))); index++)
		{
			ptr_Layer2_Node_Inputs->at(index)->Set_NumberOfNodeInputs(ptr_Layer2_Node_Inputs->size());
		}

		ptr_Layer1_Node_Inputs->resize(INT64(Get_NumberOfTotalInputs() / double(2 / 5)));
		for (INT64 index = 0; index < (INT64(Get_NumberOfTotalInputs() / double(5 / 5))); index++)
		{
			ptr_Layer1_Node_Inputs->at(index)->Set_NumberOfNodeInputs(ptr_Layer1_Node_Inputs->size());
		}

		ptr_Layer0_Node_Output->Set_NumberOfNodeInputs(INT64(Get_NumberOfTotalInputs() / double(1 / 5)));
	}
}

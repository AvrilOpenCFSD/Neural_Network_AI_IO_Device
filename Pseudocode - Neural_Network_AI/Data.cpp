#include "pch.h"
#include "Data.h"

class Avril_NNAI::Input* ptr_Input = NULL;
class Avril_NNAI::Output* ptr_Output = NULL;

INT64 _numberOfTotalInputs;
//std::vector<class Object*>* ptr_REGISTERED_Input_List;
std::vector<class Avril_NNAI::Node*>* ptr_Layer4_Node_Inputs;
std::vector<class Avril_NNAI::Node*>* ptr_Layer3_Node_Inputs;
std::vector<class Avril_NNAI::Node*>* ptr_Layer2_Node_Inputs;
std::vector<class Avril_NNAI::Node*>* ptr_Layer1_Node_Inputs;
class Avril_NNAI::Node* ptr_Layer0_Node_Output;
class Object* ptr_REGISTERED_Output;

Avril_NNAI::Data::Data()
{
	Set_Input(new class Avril_NNAI::Input());
	while (ptr_Input == NULL) {}

	Set_Output(new class Avril_NNAI::Output());
	while (ptr_Output == NULL) {}

	Set_NumberOfTotalInputs(INT64(0));

	Avril_NNAI::Node* newEmptyNode = new class Avril_NNAI::Node();

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

Avril_NNAI::Data::~Data()
{
    //delete ;
}

void Avril_NNAI::Data::Initialise_Control()
{

}

Avril_NNAI::Input* Avril_NNAI::Data::Get_Input()
{
	return ptr_Input;
}

Avril_NNAI::Output* Avril_NNAI::Data::Get_Output()
{
	return ptr_Output;
}

class Object* Avril_NNAI::Data::Get_Item_At_REGISTERED_Output()
{
	return ptr_REGISTERED_Output;
}

INT64 Avril_NNAI::Data::Get_NumberOfTotalInputs()
{
	return _numberOfTotalInputs;
}

void Avril_NNAI::Data::Set_Input(class Avril_NNAI::Input* input)
{
	ptr_Input = input;
}

void Avril_NNAI::Data::Set_Output(class Avril_NNAI::Output* output)
{
	ptr_Output = output;
}

void Avril_NNAI::Data::Set_NumberOfTotalInputs(INT64 numberOfTotalInputs)
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

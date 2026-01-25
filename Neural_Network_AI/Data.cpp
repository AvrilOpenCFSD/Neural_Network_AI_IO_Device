#include "pch.h"
#include "Data.h"
#include <cstddef>

INT64 _numberOfTotalInputs = 0;

std::vector<class Avril_NNAI::Node*> ptr_Layer4_Node_Inputs;
std::vector<class Avril_NNAI::Node*> ptr_Layer3_Node_Inputs;
std::vector<class Avril_NNAI::Node*> ptr_Layer2_Node_Inputs;
std::vector<class Avril_NNAI::Node*> ptr_Layer1_Node_Inputs;
class Avril_NNAI::Node* ptr_Layer0_Node_Output;

Avril_NNAI::Data::Data()
{
	Avril_NNAI::Node* newEmptyNode = new class Avril_NNAI::Node();

	ptr_Layer4_Node_Inputs.clear();
	ptr_Layer4_Node_Inputs.at(0) = newEmptyNode;
	while (ptr_Layer4_Node_Inputs.at(0) == NULL) {}

	ptr_Layer3_Node_Inputs.clear();
	ptr_Layer3_Node_Inputs.at(0) = newEmptyNode;
	while (ptr_Layer3_Node_Inputs.at(0) == NULL) {}

	ptr_Layer2_Node_Inputs.clear();
	ptr_Layer2_Node_Inputs.at(0) = newEmptyNode;
	while (ptr_Layer2_Node_Inputs.at(0) == NULL) {}

	ptr_Layer1_Node_Inputs.clear();
	ptr_Layer1_Node_Inputs.at(0) = newEmptyNode;
	while (ptr_Layer1_Node_Inputs.at(0) == NULL) {}

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

void Avril_NNAI::Data::Set_NumberOTotalInputs(INT64 numberOfNodeInputs)
{
	_numberOfTotalInputs = numberOfNodeInputs;

	std::vector<class Avril_NNAI::Node*> ptr_Nodes;

	if ((_numberOfTotalInputs > INT64(0)) && (_numberOfTotalInputs < INT64(9223372036854775807)))
	{
		ptr_Layer4_Node_Inputs.resize(INT64(_numberOfTotalInputs));
		for (INT64 index = 0; index < (INT64(_numberOfTotalInputs)); index++)
		{
			ptr_Layer4_Node_Inputs.at(index)->Set_NumberOfNodeInputs(ptr_Layer4_Node_Inputs.size());
		}

		ptr_Layer3_Node_Inputs.resize(INT64(_numberOfTotalInputs / double(4 / 5)));
		for (INT64 index = 0; index < (INT64(_numberOfTotalInputs / double(5 / 5))); index++)
		{
			ptr_Layer3_Node_Inputs.at(index)->Set_NumberOfNodeInputs(ptr_Layer3_Node_Inputs.size());
		}

		ptr_Layer2_Node_Inputs.resize(INT64(_numberOfTotalInputs / double(3 / 5)));
		for (INT64 index = 0; index < (INT64(_numberOfTotalInputs / double(5 / 5))); index++)
		{
			ptr_Layer2_Node_Inputs.at(index)->Set_NumberOfNodeInputs(ptr_Layer2_Node_Inputs.size());
		}

		ptr_Layer1_Node_Inputs.resize(INT64(_numberOfTotalInputs / double(2 / 5)));
		for (INT64 index = 0; index < (INT64(_numberOfTotalInputs / double(5 / 5))); index++)
		{
			ptr_Layer1_Node_Inputs.at(index)->Set_NumberOfNodeInputs(ptr_Layer1_Node_Inputs.size());
		}

		ptr_Layer0_Node_Output->Set_NumberOfNodeInputs(INT64(_numberOfTotalInputs / double(1 / 5)));
	}
}
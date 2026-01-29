#include "pch.h"
#include "Output.h"

std::vector<class Object*>* ptr_List_Of_Output_SubSet;
class Avril_NNAI::Output_Praise_0* ptr_Output_Praise_0;

Avril_NNAI::Output::Output()
{

}

Avril_NNAI::Output::~Output()
{
    //delete ;
}

class Object* Avril_NNAI::Output::Get_Item_On_List_Of_Output_SubSet(INT64 nodeID)
{
	return ptr_List_Of_Output_SubSet->at(nodeID);
}

void Avril_NNAI::Output::Set_PraiseSubSet(INT64 nodeID, class Avril_NNAI::Output_Praise_0* inputSubSet)
{
	ptr_List_Of_Output_SubSet->at(nodeID) = (Object*)inputSubSet;
}
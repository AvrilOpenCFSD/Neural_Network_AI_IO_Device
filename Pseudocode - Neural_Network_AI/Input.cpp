#include "pch.h"
#include "Input.h"

std::vector<class Object*>* ptr_List_Of_Input_SubSet;
class Avril_NNAI::Input_Praise_0* ptr_Input_Praise_0;

Avril_NNAI::Input::Input()
{
	ptr_List_Of_Input_SubSet->clear();

	Set_PraiseSubSet(INT64(0), new class Avril_NNAI::Input_Praise_0());
	while (ptr_List_Of_Input_SubSet->at(0) == NULL) {}
}

Avril_NNAI::Input::~Input()
{
    //delete ;
}

class Object* Avril_NNAI::Input::Get_Item_On_List_Of_Input_SubSet(INT64 nodeID)
{
	return ptr_List_Of_Input_SubSet->at(nodeID);
}

void Avril_NNAI::Input::Set_PraiseSubSet(INT64 nodeID, class Avril_NNAI::Input_Praise_0* inputSubSet)
{
	ptr_List_Of_Input_SubSet->at(nodeID) = (Object*)inputSubSet;
}

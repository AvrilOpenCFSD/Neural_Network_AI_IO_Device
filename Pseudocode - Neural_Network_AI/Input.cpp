#include "pch.h"
#include "Input.h"

std::vector<class Object*>* ptr_List_Of_Input_SubSet;
class OpenAvrilNNI::Input_Praise_0* ptr_Input_Praise_0;

OpenAvrilNNI::Input::Input()
{
	ptr_List_Of_Input_SubSet->clear();

	Set_PraiseSubSet(INT64(0), new class OpenAvrilNNI::Input_Praise_0());
	while (ptr_List_Of_Input_SubSet->at(0) == NULL) {}
}

OpenAvrilNNI::Input::~Input()
{
    //delete ;
}

class Object* OpenAvrilNNI::Input::Get_Item_On_List_Of_Input_SubSet(INT64 nodeID)
{
	return ptr_List_Of_Input_SubSet->at(nodeID);
}

void OpenAvrilNNI::Input::Set_PraiseSubSet(INT64 nodeID, class OpenAvrilNNI::Input_Praise_0* inputSubSet)
{
	ptr_List_Of_Input_SubSet->at(nodeID) = (Object*)inputSubSet;
}

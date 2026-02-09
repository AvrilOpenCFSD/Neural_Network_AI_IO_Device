#include "pch.h"
#include "Output.h"

std::vector<class Object*>* ptr_List_Of_Output_SubSet;
class OpenAvrilNNI::Output_Praise_0* ptr_Output_Praise_0;

OpenAvrilNNI::Output::Output()
{

}

OpenAvrilNNI::Output::~Output()
{
    //delete ;
}

class Object* OpenAvrilNNI::Output::Get_Item_On_List_Of_Output_SubSet(INT64 nodeID)
{
	return ptr_List_Of_Output_SubSet->at(nodeID);
}

void OpenAvrilNNI::Output::Set_PraiseSubSet(INT64 nodeID, class OpenAvrilNNI::Output_Praise_0* inputSubSet)
{
	ptr_List_Of_Output_SubSet->at(nodeID) = (Object*)inputSubSet;
}
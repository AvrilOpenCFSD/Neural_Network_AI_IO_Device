#include "pch.h"
#include "SolutionLogic_Praise_0.h"

OpenAvrilNNI::SolutionLogic_Praise_0::SolutionLogic_Praise_0()
{

}

OpenAvrilNNI::SolutionLogic_Praise_0::~SolutionLogic_Praise_0()
{

}

void OpenAvrilNNI::SolutionLogic_Praise_0::Do_Algorithm(Object* inputSubSet, Object* outputSubSet)
{
	OpenAvrilNNI::Input_Praise_0* ptr_In = (OpenAvrilNNI::Input_Praise_0*)inputSubSet;
	OpenAvrilNNI::Output_Praise_0* ptr_Out = (OpenAvrilNNI::Output_Praise_0*)outputSubSet;
	ptr_Out->Set_ping_Active(ptr_In->Get_ping_Active());
}

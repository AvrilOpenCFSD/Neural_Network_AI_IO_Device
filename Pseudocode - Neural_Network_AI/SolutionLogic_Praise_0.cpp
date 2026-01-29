#include "pch.h"
#include "SolutionLogic_Praise_0.h"

Avril_NNAI::SolutionLogic_Praise_0::SolutionLogic_Praise_0()
{

}

Avril_NNAI::SolutionLogic_Praise_0::~SolutionLogic_Praise_0()
{

}

void Avril_NNAI::SolutionLogic_Praise_0::Do_Algorithm(Object* inputSubSet, Object* outputSubSet)
{
	Avril_NNAI::Input_Praise_0* ptr_In = (Avril_NNAI::Input_Praise_0*)inputSubSet;
	Avril_NNAI::Output_Praise_0* ptr_Out = (Avril_NNAI::Output_Praise_0*)outputSubSet;
	ptr_Out->Set_ping_Active(ptr_In->Get_ping_Active());
}

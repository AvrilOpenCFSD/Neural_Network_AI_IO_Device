#include "pch.h"
#include "Output_Praise_0.h"

INT8 pingOut_Active;

Avril_NNAI::Output_Praise_0::Output_Praise_0()
{

}

Avril_NNAI::Output_Praise_0::~Output_Praise_0()
{
    //delete ;
}

INT8 Avril_NNAI::Input_Praise_0::Get_ping_Active()
{
	return pingOut_Active;
}

void Avril_NNAI::Input_Praise_0::Set_ping_Active(INT8 value)
{
	pingOut_Active = value;
}
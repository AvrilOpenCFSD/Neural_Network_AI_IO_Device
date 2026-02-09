#include "pch.h"
#include "Output_Praise_0.h"

INT8 pingOut_Active;

OpenAvrilNNI::Output_Praise_0::Output_Praise_0()
{

}

OpenAvrilNNI::Output_Praise_0::~Output_Praise_0()
{
    //delete ;
}

INT8 OpenAvrilNNI::Input_Praise_0::Get_ping_Active()
{
	return pingOut_Active;
}

void OpenAvrilNNI::Input_Praise_0::Set_ping_Active(INT8 value)
{
	pingOut_Active = value;
}
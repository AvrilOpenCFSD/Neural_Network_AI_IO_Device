#include "pch.h"
#include "Input_Praise_0.h"

INT8 _numberOfValluesInPraise;
INT8 pingIn_Active;

OpenAvrilNNI::Input_Praise_0::Input_Praise_0()
{
	_numberOfValluesInPraise = INT8(1);
	pingIn_Active = INT8(0);
}

OpenAvrilNNI::Input_Praise_0::~Input_Praise_0()
{

}

INT8 OpenAvrilNNI::Input_Praise_0::Get_ping_Active()
{
	return pingIn_Active;
}

void OpenAvrilNNI::Input_Praise_0::Set_ping_Active(INT8 value)
{
	pingIn_Active = value;
}
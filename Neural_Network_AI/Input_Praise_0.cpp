#include "pch.h"
#include "Input_Praise_0.h"

bool pingIn_Active;

Avril_NNAI::Input_Praise_0::Input_Praise_0()
{
	pingIn_Active = false;
}

Avril_NNAI::Input_Praise_0::~Input_Praise_0()
{

}

bool Avril_NNAI::Input_Praise_0::Get_ping_Active()
{
	return pingIn_Active;
}

void Avril_NNAI::Input_Praise_0::Set_ping_Active(bool value)
{
	pingIn_Active = value;
}
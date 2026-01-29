#pragma once
namespace Avril_NNAI
{
	class Input
	{
	public:
		Input();
		virtual ~Input();

		class Object* Get_Item_On_List_Of_Input_SubSet(INT64 nodeID);

	private:
		
		void Set_PraiseSubSet(INT64 nodeID, class Input_Praise_0* inputSubSet);
	};
}
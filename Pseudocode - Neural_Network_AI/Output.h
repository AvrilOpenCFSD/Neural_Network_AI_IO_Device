#pragma once

namespace Avril_NNAI
{
	class Output
	{
	public:
		Output();
		virtual ~Output();

		class Object* Get_Item_On_List_Of_Output_SubSet(INT64 nodeID);

	private:

		void Set_PraiseSubSet(INT64 nodeID, class Output_Praise_0* outputSubSet);
	};
}
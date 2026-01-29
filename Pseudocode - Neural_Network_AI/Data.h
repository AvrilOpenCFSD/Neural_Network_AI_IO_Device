#pragma once

namespace Avril_NNAI
{
	class Data
	{
	public:
		Data();
		virtual ~Data();
		void Initialise_Control();
		
		class Input* Get_Input();
		class Output* Get_Output();
		//class Object* Get_Item_On_REGISTERED_Input_List(INT64 nodeID);
		class Object* Get_Item_At_REGISTERED_Output();

		//void Set_Input_List(std::vector<class Object*>* inputList);
		void Set_NumberOfTotalInputs(INT64 numberOfTotalInputs);

	private:
		INT64 Get_NumberOfTotalInputs();

		void Set_Input(class Input* input);
		void Set_Output(class Output* output);
	};
}
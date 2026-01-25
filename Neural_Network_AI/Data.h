#pragma once
namespace Avril_NNAI
{
	class Data
	{
	public:
		Data();
		virtual ~Data();
		void Initialise_Control();
		
		class Avril_NNAI::Input* Get_Inputs(INT64 nodeID);
		class Avril_NNAI::Node* Get_Nodes(INT64 nodeID);
		class Avril_NNAI::Output* Get_Output();

		void Set_NumberOTotalInputs(INT64 numberOfNodeInputs);
	};
}
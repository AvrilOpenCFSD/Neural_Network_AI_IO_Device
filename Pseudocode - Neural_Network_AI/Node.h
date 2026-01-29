#pragma once
namespace Avril_NNAI
{
	class Node
	{
	public:
		Node();
		virtual ~Node();

		class Object* Get_Input_SubSet(INT64 nodeID);
		class Object* Get_Output_SubSet();
		class Object* Get_NeuralPathOfInput_SubSet(INT64 nodeID);
		INT64 Get_NumberOfNodeInputs();

		void Set_Input_SubSet(INT64 nodeID, class Avril_NNAI::Input_Praise_0* inputSubSet);
		void Set_NeuralPathOfInput_SubSet(INT64 nodeID, class Avril_NNAI::Linear* neuralPathNature);
		void Set_NumberOfNodeInputs(INT64 numberOfNodeInputs);

	private:

	};
}
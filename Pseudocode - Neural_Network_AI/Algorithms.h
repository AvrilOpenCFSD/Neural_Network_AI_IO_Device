#pragma once
namespace Avril_NNAI
{
	class Algorithms
	{
	public:
		Algorithms();
		virtual ~Algorithms();
		void Initialise_Control();

		void ConstructNeuralNetworkAI_Frame(Avril_NNAI::Framework_NNAI* obj, INT64 _numberOfTotalInputs);

		class NeuralPath* Get_NeuralPath();
	};
}
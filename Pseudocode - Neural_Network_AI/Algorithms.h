#pragma once
namespace OpenAvrilNNI
{
	class Algorithms
	{
	public:
		Algorithms();
		virtual ~Algorithms();
		void Initialise_Control();

		void ConstructNeuralNetworkAI_Frame(OpenAvrilNNI::Framework_NNI* obj, INT64 _numberOfTotalInputs);

		class NeuralPath* Get_NeuralPath();
	};
}
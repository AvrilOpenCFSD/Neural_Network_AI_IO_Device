#pragma once

namespace OpenAvrilNNI
{
	class NeuralPath
	{
	public:
		NeuralPath();
		virtual ~NeuralPath();

		class Object* Get_NatureOfThePath(OpenAvrilNNI::Framework_NNI* obj);

		void Set_NatureOfThePath_NIL();
		void Set_NatureOfThePath_LINEAR(class Linear* natureOfInputEquation);
	};
}
// The following ifdef block is the standard way of creating macros which make exporting
// from a DLL simpler. All files within this DLL are compiled with the NEURALNETWORKAI_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see
// NEURALNETWORKAI_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
/*
*  Class Tree.
* -------------
* 
*			Neural_Network_AI
*					|
*	 _______________|
*	 |				|
*	pch		Framework_NNAI
*					|
*					|
*					|
*			NeuralNetworks
*					|
*			   _____|__________________________________________________________________________________________________________________________________________________________________________________________________
*			   |                    |																 |																												  |
* 			Global				Algorithms															Data																											Execute
*									|																 |
*									|____________________________________________					 |____________________________________________________________________________
*									|											|					 |									  |										 |		
*								SolutionLogic								NeuralPath				Input								Output									Node (dynamic)
*									|											|					 |									  |										 |				
*									L------------	Algorithms_Praise_0		 ___|__________			 L------------	Input_Praise_0		  L------------	Output_Praise_0			 |_______________________________________________
*									L------------	Algorithms_Praise_1		 |			  |			 L------------	Input_Praise_1		  L------------	Output_Praise_1			 |					        |					|
*									L------------	Algorithms_Praise_2		Linear		//ToDo		 L------------	Intput_Praise_1		  L------------	Output_Praise_1			NeuralPathSubSet	InputPraiseSubSet	OuputPraiseSubSet
*																																																
*																																																
*																																																
* 																																															
*/
#ifdef NEURALNETWORKAI_EXPORTS
#define NEURALNETWORKAI_API __declspec(dllexport)
#else
#define NEURALNETWORKAI_API __declspec(dllimport)
#endif

namespace Avril_NNAI
{
	// This class is exported from the dll
	class NEURALNETWORKAI_API CNeuralNetworkAI_IOs {
	public:
		CNeuralNetworkAI_IOs(void);
		// TODO: add your methods here.
		static void* InitialiseThisNeuralNetworkAI();
	};

	class NEURALNETWORKAI_API CNeuralNetworkAI_Training {
	public:
		CNeuralNetworkAI_Training(void);
		// TODO: add your methods here.
		static void ConstructNeuralNetworkAI_Frame(Avril_NNAI::Framework_NNAI* obj, INT64 _numberOfTotalInputs);
	};

	extern NEURALNETWORKAI_API int nNeuralNetworkAI;

	NEURALNETWORKAI_API int fnNeuralNetworkAI(void);
}
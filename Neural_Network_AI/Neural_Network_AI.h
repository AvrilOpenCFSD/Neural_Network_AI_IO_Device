// The following ifdef block is the standard way of creating macros which make exporting
// from a DLL simpler. All files within this DLL are compiled with the NEURALNETWORKAI_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see
// NEURALNETWORKAI_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef NEURALNETWORKAI_EXPORTS
#define NEURALNETWORKAI_API __declspec(dllexport)
#else
#define NEURALNETWORKAI_API __declspec(dllimport)
#endif

// This class is exported from the dll
class NEURALNETWORKAI_API CNeuralNetworkAI {
public:
	CNeuralNetworkAI(void);
	// TODO: add your methods here.
};

extern NEURALNETWORKAI_API int nNeuralNetworkAI;

NEURALNETWORKAI_API int fnNeuralNetworkAI(void);

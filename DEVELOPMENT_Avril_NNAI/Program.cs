/*
*  Class Tree.
* -------------
* 
*			    Program
*					|
*                   |
*                   |
*   		Framework_NNAI
*					|
*					|________________
*					|               |
*			NeuralNetworks      SIMULATION
*					|
*			   _____|__________________________________________________________________________________________________________________________________________________________________________________________________
*			   |                    |																 |																												  |
* 			Global				Algorithms															Data																											Execute
*									|																 |
*									|____________________________________________					 |_______________________________________________________________________________
*									|											|					 |									  |										    |		
*								SolutionLogic								NeuralPath				Input								Output									MachineAI (Data File)
*									|											|					 |									  |										    |				
*									L------------	Algorithms_Praise_0		 ___|__________			 L------------	Input_Praise_0		  L------------	Output_Praise_0			    |_______________________
*									L------------	Algorithms_Praise_1		 |			  |			 L------------	Input_Praise_1		  L------------	Output_Praise_1			    |                       |
*									L------------	Algorithms_Praise_2		Linear		//ToDo		 L------------	Intput_Praise_1		  L------------	Output_Praise_1		    PraiseSet               MetaData 
*																																												    |
*																																												    |
*																																												    |                      
*																																												   Node                 
*																																												    |			
*																																													|_______________________________________________
*																																												    |					    |					|				
* 																																												NeuralPathSubSet	InputPraiseSubSet	OuputPraiseSubSet	
*/
namespace Avril_NNAI
{
    public static class Program
    {
        static private Avril_NNAI.Framework_NNAI framework = null;

        static void Main()
        {
            System.Console.WriteLine("started program entry.");
            framework = new Avril_NNAI.Framework_NNAI();
            System.Console.WriteLine("created Avril_NNAI.Framework_NNAI()");
            while (framework == null) { /* wait untill is created */ }
            System.Console.WriteLine("Framework_NNAI ready.");
            framework.Initialise(framework);
            System.Console.WriteLine("framework initialised.");

// SIMULATION

            ulong[] praiseIDs = new ulong[1];
            praiseIDs[0] = 1;
            Avril_NNAI.MachineAI myNeuralNetwork = framework.Get_Neural_Networks().Get_Aglorithms().ConstructNeuralNetworkAI_Frame(framework, "Avril_NNAI_OpenCFSD_Praise_1_IO.nnai", praiseIDs);
/*
            for (byte layerID = 6; layerID >= 0; layerID--)
            {
                for (ulong nodeID = 0; nodeID < myNeuralNetwork.Get_MetaData().Get_NumberOfNodesInLayer(layerID); nodeID++)
                {
                    if (layerID <= 5)
                    {
                        for (ulong inputValuID = 0; inputValuID < myNeuralNetwork.Get_MetaData().Get_NumberOfNodesInLayer((ulong)(layerID + 1)); inputValuID++)
                        {
                            System.Console.WriteLine("weight = " + myNeuralNetwork.Get_MetaData().Get_Node(layerID, nodeID).Get_NeuralPathOfInput_SubSet(inputValuID).Get_Weight());
                            System.Console.WriteLine("bias" + myNeuralNetwork.Get_MetaData().Get_Node(layerID, nodeID).Get_NeuralPathOfInput_SubSet(inputValuID).Get_Bias());
                        }
                    }
                }
            }
*/
            //ToDO: train network
        }

        static public Avril_NNAI.Framework_NNAI Get_Framework_NNAI()
        {
            return framework;
        }
    }
}
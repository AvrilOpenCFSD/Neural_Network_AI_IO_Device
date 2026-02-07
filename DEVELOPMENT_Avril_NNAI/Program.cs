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
*			   _____|______________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
*			   |                    |																 |																												                                                                              |
* 			Global				Algorithms															Data																											                                                                            Execute
*			   |					|																 |                                                                                                                                                                                            |
*			   |					|____________________________________________					 |______________________________________________________________________________                                                                                                              |                              
*			   |					|											|					 |									  |										    |                                                                                                             |                          
*			MyEnumExtensions    SolutionLogic								NeuralPath				Input								Output									MachineAI (Data File)                                                                                           FileReadWrite (.nnai)
*									|											|					 |									  |										    |				
*									L------------	Algorithms_Praise_0		 ___|__________			 L------------	Input_Praise_0		  L------------	Output_Praise_0			    |_______________________________________________________________________________
*									L------------	Algorithms_Praise_1		 |			  |			 L------------	Input_Praise_1		  L------------	Output_Praise_1			    |                  |                   |                    |                   |
*									L------------	Algorithms_Praise_2		Linear		Constant	 L------------	Intput_Praise_1		  L------------	Output_Praise_1		    InputPraiseSubSet   PraiseSet           Constant            MetaData        	OuputPraiseSubSet
*																																												                       |
*																															  												                           |
*                   																																												   |                      
*					                    																																							  Node                 
*										                    																																		   |			
*															                    																													   |
*																				                    																								   |
* 																									                       																			NeuralPathSubSet		
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
            ulong praiseID = new ulong();
            praiseID = 1;
            Avril_NNAI.MachineAI myNeuralNetwork = framework.Get_Neural_Networks().Get_Aglorithms().Create_Instance_Of_MachineAI(framework, "Avril_NNAI_OpenCFSD_Praise_1_IO.nnai", praiseID);
            framework.Get_Neural_Networks().Get_Data().Preserve_New_Neural_Network(myNeuralNetwork);
            //ToDO: train network
            framework.Get_Neural_Networks().Get_Execute().Get_FileReadWrite().WriteValuesToFile(framework, framework.Get_Neural_Networks().Get_Data().Get_Item_On_List_Of_Neural_Network_Preservation(0), myNeuralNetwork.Get_MetaData().Get_NameOfNNAI());
        }
        static public Avril_NNAI.Framework_NNAI Get_Framework_NNAI()
        {
            return framework;
        }
    }
}
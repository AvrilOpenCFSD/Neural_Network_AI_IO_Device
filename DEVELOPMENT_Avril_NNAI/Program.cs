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
*					|
*					|        
*			NeuralNetworks
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
// definitions.

// classes.

// registers.
        static private Avril_NNAI.Framework_NNAI framework = null;

// main.
        static void Main()
        {
            System.Console.WriteLine("started program entry.");
            Create_Framework_NNAI();
            System.Console.WriteLine("created Avril_NNAI.Framework_NNAI()");
            //framework.Initialise(framework);
            System.Console.WriteLine("framework initialised.");
    // SIMULATION
            Avril_NNAI.MachineAI myNeuralNetwork = framework.Get_Neural_Networks().Get_Aglorithms().Create_Instance_Of_MachineAI(framework, "Avril_NNAI_OpenCFSD_Praise_1_IO.nnai", (ulong)1);
            framework.Get_Neural_Networks().Get_Data().Preserve_New_Neural_Network(myNeuralNetwork);
            //ToDO: train network
            framework.Get_Neural_Networks().Get_Execute().Get_FileReadWrite().WriteValuesToFile(framework, framework.Get_Neural_Networks().Get_Data().Get_Item_On_List_Of_Neural_Network_Preservation(0), myNeuralNetwork.Get_MetaData().Get_NameOfNNAI());
        }

// public.
        static private void Create_Framework_NNAI()
        {
            framework = new Avril_NNAI.Framework_NNAI();
            while (framework == null) { }
        }
    // get.
        static public Avril_NNAI.Framework_NNAI Get_Framework_NNAI()
        {
                return framework;
        }
    // set.

// private.
    // get.
    // set.
    }
}
/*
*  Class Tree.
* -----------------
* | * -> register |
* -----------------
* 
*			    Program
*					|
*                   |
*                   |
*   		Framework_NNI
*					|
*					|
*					|        
*			NeuralNetworks
*					|
*			   _____|_____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
*			   |                    |																         |																												                                                                              |
* 			Global				Algorithms															        Data																											                                                                            Execute
*			   |					|																         |                                                                                                                                                                                            |
*			   |					|____________________________________________					         |______________________________________________________________________________                                                                                                              |                              
*			   |					|											|					         |									  |										    |                                                                                                             |                          
*			MyEnumExtensions    SolutionLogic								NeuralPath				        Input								Output									MachineAI (Data File)                                                                                           FileReadWrite (.nni)
*									|											|					          |									  |										    |				
*									L------------	Algorithms_Praise_0		    |_____________________		  L------------	Input_Praise_0		  L------------	Output_Praise_0			    |_______________________________________________________________________________
*									L------------	Algorithms_Praise_1		    |		    |		  |       L------------	Input_Praise_1		  L------------	Output_Praise_1			    |                  |                   |                    |                   |
*									L------------	Algorithms_Praise_2	    Linear		Constant    Binary	  L------------	Intput_Praise_1		  L------------	Output_Praise_1		    MetaData        *ListOfLinear       *ListOfConstant         *ListOfBinary
*																			    |                                               
*													                            |           
*                   													        |                       
*					                    		                            PraiseSet   
*					                    					                    |
*					                    							            |
*					                    							            |
*					                    									  Node                 
*										                    																																		           			
*															                    																													           
*																				                    																								           
* 																									                       																			        		
*/
namespace OpenAvrilNNI
{
    public static class Program
    {
// definitions.

// classes.

// registers.
        static private OpenAvrilNNI.Framework_NNI framework = null;

// main.
        static void Main()
        {
            System.Console.WriteLine("started program entry.");
            Create_Framework_NNI();
            System.Console.WriteLine("created OpenAvrilNNI.Framework_NNI()");
            //framework.Initialise(framework);
            System.Console.WriteLine("framework initialised.");
    // SIMULATION
            OpenAvrilNNI.MachineAI myNeuralNetwork = framework.Get_Neural_Networks().Get_Aglorithms().Create_Instance_Of_MachineAI(framework, "OpenAvrilNNI_OpenCconcurrency_IO_Praise_1", (byte)1);

            framework.Get_Neural_Networks().Get_Data().Preserve_New_Neural_Network(myNeuralNetwork);
            //ToDO: train network
            framework.Get_Neural_Networks().Get_Execute().Get_FileReadWrite().WriteValuesToFile(framework, framework.Get_Neural_Networks().Get_Data().Get_Item_On_List_Of_Neural_Network_Preservation(0), myNeuralNetwork.Get_MetaData().Get_NameOfNNI());
        }

// public.
        static private void Create_Framework_NNI()
        {
            framework = new OpenAvrilNNI.Framework_NNI();
            while (framework == null) { }
        }
    // get.
        static public OpenAvrilNNI.Framework_NNI Get_Framework_NNI()
        {
                return framework;
        }
    // set.

// private.
    // get.
    // set.
    }
}
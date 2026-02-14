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
using OpenAvrilNNI_OpenAvrilConcurrency_IO;

namespace OpenAvrilNNI
{
    public static class Program
    {
// definitions.

// classes.

// registers.
        static private Framework_NNI _instance_Of_Framework_NNI = null;

// main.
        static void Main()
        {
            System.Console.WriteLine("started program entry.");
            var obj = IO.Create_OpenAvrilNNI_OpenAvrilConcurrency_NNI();
          
            System.Console.WriteLine("created DEFAULT datafile .nni (class MachineAI).");

            // SIMULATION - output testbench.
            var objNNI_DEFAULT = obj.Get_NeuralNetwork().Get_Data().Get_Item_On_list_Of_MachineAI(0);

            System.Console.WriteLine("started SIMULATION - output default data file.");
            for (byte linearOutputID = 0; linearOutputID < objNNI_DEFAULT.Get_MetaData().Get_NumberOfLinearOutputs(); linearOutputID++)
            {
                for (Int16 layerID = 4; layerID > -1; layerID--)
                {
                    byte hiddenLayerID = Convert.ToByte(layerID);
                    for (byte nodeID = 0; nodeID < objNNI_DEFAULT.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                    {
                        for (byte inputID = 0; inputID < objNNI_DEFAULT.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_NumberOfInputs(); inputID++)
                        {
                            System.Console.WriteLine("outputID = " + linearOutputID + "  hiddenLayerID = " + hiddenLayerID + "  nodeID = " + nodeID + "  inputID = " + inputID + "  bias = " + objNNI_DEFAULT.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(linearOutputID).Get_bias() + "  weight = " + objNNI_DEFAULT.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(linearOutputID).Get_weight());
                        }
                    }
                }
            }
            for (byte booleanOutputID = 0; booleanOutputID < objNNI_DEFAULT.Get_MetaData().Get_NumberOfBooleanOutputs(); booleanOutputID++)
            {
                //ToDo: boolean preperation.
            }
            for (byte constantOutputID = 0; constantOutputID < objNNI_DEFAULT.Get_MetaData().Get_NumberOfConstantOutputs(); constantOutputID++)
            {
                //ToDo: constant preperation.
            }
            System.Console.WriteLine("ending SIMULATION - output default data file.");
    // end SIMULATION - output testbench.
/*
            MachineAI objNNI = IO.Initialise_instance_Of_MachineAI(obj);

    // SIMULATION - output testbench.
            System.Console.WriteLine("started SIMULATION - output default data file.");
            for (byte linearOutputID = 0; linearOutputID < objNNI.Get_MetaData().Get_NumberOfLinearOutputs(); linearOutputID++)
            {
                for (Int16 layerID = 4; layerID > -1; layerID--)
                {
                    byte hiddenLayerID = Convert.ToByte(layerID);
                    for (byte nodeID = 0; nodeID < objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                    {
                        for (byte inputID = 0; inputID < (byte)(objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_NumberOfInputs() + (byte)1); inputID++)
                        { 
                            System.Console.WriteLine("outputID = " + linearOutputID + "  hiddenLayerID = " + hiddenLayerID + "  nodeID = " + nodeID + "  inputID = " + inputID + "  bias = " + objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(linearOutputID).Get_bias() + "  weight = " + objNNI.Get_Item_On_list_Of_Linear_Paths(linearOutputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_list_Of_Linear_NeuralPath(linearOutputID).Get_weight());
                        }
                    }
                }
            }
            for (byte booleanOutputID = 0; booleanOutputID < objNNI.Get_MetaData().Get_NumberOfBooleanOutputs(); booleanOutputID++)
            {

            }
            for (byte constantOutputID = 0; constantOutputID < objNNI.Get_MetaData().Get_NumberOfConstantOutputs(); constantOutputID++)
            {

            }
            System.Console.WriteLine("ending SIMULATION - output default data file.");
    // end SIMULATION - output testbench.
*/
            //obj.Get_NeuralNetwork().Get_Data().Preserve_New_Neural_Network(objNNI);
            //obj.Initialise(obj, objNNI.Get_MetaData());
            //ToDO: train network
            //obj.Get_NeuralNetwork().Get_Execute().Get_FileReadWrite().WriteValuesToFile(obj, obj.Get_NeuralNetwork().Get_Data().Get_Item_On_list_Of_MachineAI_Preservation(0), objNNI.Get_MetaData().Get_NameOfNNI());
        }

        // public.
        static private Framework_NNI Create_instance_Of_Framework_NNI()
        {
            Set_instance_Of_Framework_NNI(new Framework_NNI());
            while (Get_instance_Of_Framework_NNI() == null) { }
            return Get_instance_Of_Framework_NNI();
        }
    // get.
        static public Framework_NNI Get_instance_Of_Framework_NNI()
        {
                return _instance_Of_Framework_NNI;
        }
    // set.

// private.
    // get.
    // set.
        static private Framework_NNI Set_instance_Of_Framework_NNI(Framework_NNI newFramework)
        {
            return _instance_Of_Framework_NNI = newFramework;
        }
    }
}
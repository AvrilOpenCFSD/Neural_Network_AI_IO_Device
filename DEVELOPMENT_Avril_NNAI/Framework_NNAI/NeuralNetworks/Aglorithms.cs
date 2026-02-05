
namespace Avril_NNAI
{
    public class Aglorithms
    {
// classes.
        private Avril_NNAI.NeuralPath _NeuralPath;
        private Avril_NNAI.SolutionLogic _SolutionLogic;

// registers.

// constructor.
        public Aglorithms()
        {
            //System.Console.WriteLine("entered Aglorithms.");
            Create_NeuralPath(new Avril_NNAI.NeuralPath());
            while (Get_NeuralPath() == null) { }

            Create_SolutionLogic(new Avril_NNAI.SolutionLogic());
            while (Get_SolutionLogic() == null) { }
        }

// destructor.
        ~Aglorithms()
        {
            //System.Console.WriteLine("exited Aglorithms.");
        }

// public.
        public Avril_NNAI.MachineAI Create_Instance_Of_MachineAI(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, string nameOfNNAI, ulong praiseID)
        {
            System.Console.WriteLine("entering ConstructNeuralNetworkAI_Frame.");
            Avril_NNAI.MachineAI _AvrilNNAI = obj.Get_Neural_Networks().Get_Data().Get_NewMachineAI();
            while (_AvrilNNAI == null) { }
            _AvrilNNAI.Get_MetaData().Set_NameOfNNAI(nameOfNNAI);

            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Calculate_Neural_Network_Parameters(obj, objNNAI, praiseID);

            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_REGISTERED_Inputs_List(obj, objNNAI, praiseID);

            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_REGISTERED_Outputs_List(obj, objNNAI, praiseID);

            objNNAI.Create_PraiseSet(new Avril_NNAI.PraiseSet[(byte)(objNNAI.Get_MetaData().Get_NumberOfPraiseOutputValues() - objNNAI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT())]);
            while(objNNAI.Get_PraiseSet() == null)
            {

            }
            for (byte outputID = 0; outputID < (ulong)(objNNAI.Get_MetaData().Get_NumberOfPraiseOutputValues() - objNNAI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT()) ; outputID++)
            {
                objNNAI.Set_Item_On_List_Of_PraiseSets(outputID, new Avril_NNAI.PraiseSet());
                while (objNNAI.Get_PraiseSet()[outputID] == null)
                {

                }
                for (byte layerID = 4; layerID >= 0; layerID--)
                {
                    obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_NumberOfNodesInHiddenLayer(objNNAI, outputID, layerID);
                    obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_Layer_Nodes(objNNAI, outputID, layerID);
                    System.Console.WriteLine("outputID = " + outputID + "  layerID = " + layerID);
                //}
            //}
            //for (byte outputID = 0; outputID < objNNAI.Get_MetaData().Get_NumberOfPraiseOutputValues(); outputID++)
            //{
                //for (byte layerID = 4; layerID >= 0; layerID--)
               // {
                    for (ulong nodeID = 0; nodeID < objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_NumberOfNodesInHiddenLayer(layerID); nodeID++)
                    {
                        if (layerID == (ulong)(4))
                        {
                            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Create_List_Of_NeuralPathOfNodeInputs(new Avril_NNAI.Linear[objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues()]);
                            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_Neural_Path_For_Input(obj, objNNAI, outputID, layerID, nodeID);
                        }
                        else if ((layerID < (ulong)(4)) && (layerID >= (ulong)(0)))
                        {
                            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Create_List_Of_NeuralPathOfNodeInputs(new Avril_NNAI.Linear[objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_NumberOfNodesInHiddenLayer((byte)(layerID + (byte)1))]);
                            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_Neural_Path_For_Input(obj, objNNAI, outputID, layerID, nodeID);
                        }
                    }
                }
            }
            //ToDo
            obj.Get_Neural_Networks().Get_Data().Preserve_New_Neural_Network(_AvrilNNAI);
            return _AvrilNNAI;
        }

    // get.
        public Avril_NNAI.NeuralPath Get_NeuralPath()
        {
            return _NeuralPath;
        }
        public Avril_NNAI.SolutionLogic Get_SolutionLogic()
        {
            return _SolutionLogic;
        }
    // set.

// private.
        private void Create_NeuralPath(Avril_NNAI.NeuralPath neuralPath)
        {
            _NeuralPath = neuralPath;
        }
        private void Create_SolutionLogic(Avril_NNAI.SolutionLogic solutionLogic)
        {
            _SolutionLogic = solutionLogic;
        }
    // get.
    // set.
    }
}

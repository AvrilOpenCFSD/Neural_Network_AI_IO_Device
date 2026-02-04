
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

            objNNAI.Create_PraiseSet(new Avril_NNAI.PraiseSet[objNNAI.Get_MetaData().Get_NumberOfPraiseOutputValues()]);
            for (byte index = 0; index < objNNAI.Get_MetaData().Get_NumberOfPraiseOutputValues(); index++)
            {
                objNNAI.Set_Item_On_List_Of_PraiseSets(index, new Avril_NNAI.PraiseSet());
            }
            for (byte outputID = 0; outputID < objNNAI.Get_MetaData().Get_NumberOfPraiseOutputValues() - objNNAI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT(); outputID++)
            {
                var praiseOutputTree = objNNAI.Get_Item_On_List_Of_PraiseSets(outputID);
                for (byte layerID = 4; layerID < 5; layerID--)
                {
                    obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_NumberOfNodesInHiddenLayer(objNNAI, outputID, layerID);
                    obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_Layer_Nodes(objNNAI, outputID, layerID);

                    for(ulong nodeID = 0; nodeID < objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_NumberOfInputs(); nodeID++)
                    {
                        obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_Neural_Path_For_Input(obj, objNNAI, outputID, layerID, nodeID);
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


using System.ComponentModel;

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
            System.Console.WriteLine("entered Aglorithms.");
            Create_NeuralPath();
            Create_SolutionLogic();
        }

// destructor.
        ~Aglorithms()
        {
            //System.Console.WriteLine("exited Aglorithms.");
        }

// public.
        public Avril_NNAI.MachineAI Create_Instance_Of_MachineAI(Avril_NNAI.Framework_NNAI obj, string nameOfNNAI, ulong praiseID)
        {
            System.Console.WriteLine("entering ConstructNeuralNetworkAI_Frame.");
            Avril_NNAI.MachineAI _AvrilNNAI = obj.Get_Neural_Networks().Get_Data().Get_NewMachineAI();
            while (_AvrilNNAI == null) { }
            _AvrilNNAI.Get_MetaData().Set_NameOfNNAI(nameOfNNAI);

            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Calculate_Neural_Network_Parameters(obj, _AvrilNNAI, praiseID);
            System.Console.WriteLine("alpha");
            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_REGISTERED_Inputs_List(obj, _AvrilNNAI, praiseID);
            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_REGISTERED_Outputs_List(obj, _AvrilNNAI, praiseID);
            System.Console.WriteLine("bravo");
            byte numberOfPraiseSets = (byte)(_AvrilNNAI.Get_MetaData().Get_NumberOfPraiseOutputValues() - _AvrilNNAI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT());
            byte numberOfResetToConstant = _AvrilNNAI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT();
            System.Console.WriteLine("charlie");
            _AvrilNNAI.Create_List_Of_PraiseSet(new Avril_NNAI.PraiseSet[numberOfPraiseSets]);
            while (_AvrilNNAI.Get_List_Of_PraiseSet() == null) { }
            System.Console.WriteLine("delta");
            for (byte outputID = 0; outputID < numberOfPraiseSets; outputID++)
            {
                System.Console.WriteLine("echo");

                _AvrilNNAI.Set_Item_On_List_Of_PraiseSets(outputID, new Avril_NNAI.PraiseSet());
                while (_AvrilNNAI.Get_List_Of_PraiseSet()[outputID] == null) { }

                for (sbyte layerID = 4; layerID > -1; layerID--)
                {
                    byte hiddenLayerID = Convert.ToByte(layerID);
                    System.Console.WriteLine("foxtrot");
                    obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_NumberOfNodesInHiddenLayer(_AvrilNNAI, outputID, hiddenLayerID);
                    obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Create_Layer_Nodes(_AvrilNNAI, outputID, hiddenLayerID);

                    for (ulong nodeID = 0; nodeID < _AvrilNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                    {
                        System.Console.WriteLine("delta");
                        if (layerID == (byte)(4))
                        {
                            _AvrilNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Create_List_Of_NeuralPathOfNodeInputs(new Avril_NNAI.Linear[_AvrilNNAI.Get_MetaData().Get_NumberOfPraiseInputValues()]);
                            while (_AvrilNNAI.Get_List_Of_PraiseSet()[outputID].Get_Node(hiddenLayerID, nodeID).Get_List_Of_NeuralPathOfInput() == null) { }

                            _AvrilNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Set_NeuralPathOfInput_SubSet(hiddenLayerID, obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Get_New_Linear());
                            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_Neural_Path_For_Input(obj, _AvrilNNAI, outputID, hiddenLayerID, nodeID);
                        }
                        else
                        {
                            _AvrilNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Create_List_Of_NeuralPathOfNodeInputs(new Avril_NNAI.Linear[_AvrilNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(hiddenLayerID + (byte)1))]);
                            while (_AvrilNNAI.Get_List_Of_PraiseSet()[outputID].Get_Node(hiddenLayerID, nodeID).Get_List_Of_NeuralPathOfInput() == null) { }

                            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_Neural_Path_For_Input(obj, _AvrilNNAI, outputID, hiddenLayerID, nodeID);
                        }
                    }
                }
            }
            for (byte outputID = 0; outputID < numberOfResetToConstant; outputID++)
            {
                _AvrilNNAI.Create_List_Of_Constants(new Avril_NNAI.Constant[numberOfResetToConstant]);
                while (_AvrilNNAI.Get_List_Of_Constant() == null) { }
                _AvrilNNAI.Set_Item_On_List_Of_Constant(outputID, obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Get_New_Constant());
                obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_Constant_Path_To_Output(obj, _AvrilNNAI, outputID, outputID);
            }
            return _AvrilNNAI;
        }
        public void Save_Instance_Of_MachineAI_To_File(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI)
        {
            obj.Get_Neural_Networks().Get_Execute().Get_FileReadWrite().WriteValuesToFile(obj, objNNAI, objNNAI.Get_MetaData().Get_NameOfNNAI());
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
        private void Create_NeuralPath()
        {
            _NeuralPath = new Avril_NNAI.NeuralPath();
            while (Get_NeuralPath() == null) { }
        }
        private void Create_SolutionLogic()
        {
            _SolutionLogic = new Avril_NNAI.SolutionLogic();
            while (Get_SolutionLogic() == null) { }
        }
    // get.
    // set.
    }
}

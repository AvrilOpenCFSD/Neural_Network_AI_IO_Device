
using System.ComponentModel;

namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class Aglorithms
    {
// classes.
        private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.NeuralPath _NeuralPath;

// registers.

// constructor.
        public Aglorithms()
        {
            System.Console.WriteLine("entered Aglorithms.");
            Create_NeuralPath();
        }

// destructor.
        ~Aglorithms()
        {
            //System.Console.WriteLine("exited Aglorithms.");
        }

// public.
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI Create_Instance_Of_MachineAI(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj, string nameOfNNI, byte praiseID)
        {
            System.Console.WriteLine("entering ConstructNeuralNetworkAI_Frame.");
            OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI _AvrilNNI = obj.Get_Neural_Networks().Get_Data().Get_NewMachineAI();
            while (_AvrilNNI == null) { }
            _AvrilNNI.Get_MetaData().Set_NameOfNNI(nameOfNNI);

            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Calculate_Neural_Network_Parameters(obj, _AvrilNNI, praiseID);
            System.Console.WriteLine("alpha");
            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_REGISTERED_Inputs_List(obj, _AvrilNNI, praiseID);
            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_REGISTERED_Outputs_List(obj, _AvrilNNI, praiseID);
            System.Console.WriteLine("bravo");
            byte numberOfPraiseSets = (byte)(_AvrilNNI.Get_MetaData().Get_NumberOfPraiseOutputValues() - _AvrilNNI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT());
            byte numberOfResetToConstant = _AvrilNNI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT();
            System.Console.WriteLine("charlie");
            _AvrilNNI.Create_List_Of_PraiseSet(numberOfPraiseSets);
            while (_AvrilNNI.Get_List_Of_PraiseSet() == null) { }
            System.Console.WriteLine("delta");
            for (byte outputID_A = 0; outputID_A < numberOfPraiseSets; outputID_A++)
            {
                System.Console.WriteLine("echo");

                _AvrilNNI.Set_Item_On_List_Of_PraiseSets(outputID_A, new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.PraiseSet());
                while (_AvrilNNI.Get_List_Of_PraiseSet()[outputID_A] == null) { }

                for (Int16 layerID = 4; layerID > -1; layerID--)
                {
                    byte hiddenLayerID = Convert.ToByte(layerID);
                    System.Console.WriteLine("foxtrot");
                    //obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_NumberOfNodesInHiddenLayer(_AvrilNNI, hiddenLayerID);
                    obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Create_Layer_Nodes(_AvrilNNI, outputID_A, hiddenLayerID);

                    for (byte nodeID = 0; nodeID < _AvrilNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                    {
                        System.Console.WriteLine("delta");
                        if (layerID == (byte)(4))
                        {
                            _AvrilNNI.Get_Item_On_List_Of_PraiseSets(outputID_A).Get_Node(hiddenLayerID, nodeID).Create_List_Of_NeuralPathOfNodeInputs(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear[_AvrilNNI.Get_MetaData().Get_NumberOfPraiseInputValues()]);
                            while (_AvrilNNI.Get_List_Of_PraiseSet()[outputID_A].Get_Node(hiddenLayerID, nodeID).Get_List_Of_NeuralPathOfInput() == null) { }
                        }
                        else
                        {
                            _AvrilNNI.Get_Item_On_List_Of_PraiseSets(outputID_A).Get_Node(hiddenLayerID, nodeID).Create_List_Of_NeuralPathOfNodeInputs(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear[_AvrilNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(hiddenLayerID + (byte)1))]);
                            while (_AvrilNNI.Get_List_Of_PraiseSet()[outputID_A].Get_Node(hiddenLayerID, nodeID).Get_List_Of_NeuralPathOfInput() == null) { }
                        }
                        _AvrilNNI.Get_Item_On_List_Of_PraiseSets(outputID_A).Get_Node(hiddenLayerID, nodeID).Set_NeuralPathOfInput_SubSet(hiddenLayerID, obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Get_New_Linear());
                        System.Console.WriteLine("outputID_A = " + outputID_A + "  hiddenLayerID = " + hiddenLayerID + "  nodeID = " + nodeID);
                        obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_Neural_Path_For_Input(obj, _AvrilNNI, outputID_A, hiddenLayerID, nodeID);
                    }
                }
            }
            for (byte outputID_B = 0; outputID_B < numberOfResetToConstant; outputID_B++)
            {
                _AvrilNNI.Create_List_Of_Constants(numberOfResetToConstant);
                while (_AvrilNNI.Get_List_Of_Constant() == null) { }
                _AvrilNNI.Set_Item_On_List_Of_Constant(outputID_B, obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Get_New_Constant());
                obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_Constant_From_Output_Subset(obj, _AvrilNNI, outputID_B);
            }
            return _AvrilNNI;
        }
        public void Save_Instance_Of_MachineAI_To_File(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj, OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI)
        {
            obj.Get_Neural_Networks().Get_Execute().Get_FileReader().ReadValuesFromFile(obj, objNNI.Get_MetaData().Get_NameOfNNI());
        }
    // get.
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.NeuralPath Get_NeuralPath()
        {
            return _NeuralPath;
        }
    // set.

// private.
        private void Create_NeuralPath()
        {
            _NeuralPath = new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.NeuralPath();
            while (Get_NeuralPath() == null) { }
        }
    // get.
    // set.
        private void Set_IO_Defaults(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI, byte praiseID)
        {
            switch (praiseID)
            {
                case (byte)Global.PraiseID.Praise_0:

                    break;

                case (byte)Global.PraiseID.Praise_1:
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Mouse_Screen_X, 0.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Mouse_Screen_Y, 0.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Fowards_X, 1.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Fowards_Y, 0.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Fowards_Z, 0.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Up_X, 0.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Up_Y, 1.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Up_Z, 0.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Right_X, 0.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Right_Y, 0.0);
                    objNNI.Set_Item_On_List_Of_REGISTERED_Input((byte)Global.PRAISE_1.Capsule_Right_Z, 1.0);
                    break;


                case (byte)Global.PraiseID.Praise_2:

                    break;
            }
        }
    }
}

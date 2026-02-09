
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
            OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI = obj.Get_Neural_Networks().Get_Data().Get_NewMachineAI();
            while (objNNI == null) { }
            objNNI.Get_MetaData().Set_NameOfNNI(nameOfNNI);

            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Calculate_Neural_Network_Parameters(obj, objNNI, praiseID);
            System.Console.WriteLine("alpha");
            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_REGISTERED_Inputs_List(obj, objNNI, praiseID);
            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_REGISTERED_Outputs_List(obj, objNNI, praiseID);
            System.Console.WriteLine("bravo");
            byte numberOfPraiseSets = (byte)(objNNI.Get_MetaData().Get_NumberOfPraiseOutputValues() - objNNI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT());
            byte numberOfResetToConstant = objNNI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT();
            System.Console.WriteLine("charlie");
            objNNI.Create_List_Of_PraiseSet(numberOfPraiseSets);
            while (objNNI.Get_List_Of_PraiseSet() == null) { }
            System.Console.WriteLine("delta");
            for (byte outputID_A = 0; outputID_A < numberOfPraiseSets; outputID_A++)
            {
                System.Console.WriteLine("echo");

                objNNI.Set_Item_On_List_Of_PraiseSets(outputID_A, new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.PraiseSet());
                while (objNNI.Get_List_Of_PraiseSet()[outputID_A] == null) { }

                for (Int16 layerID = 4; layerID > -1; layerID--)
                {
                    byte hiddenLayerID = Convert.ToByte(layerID);
                    System.Console.WriteLine("foxtrot");
                    //obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_NumberOfNodesInHiddenLayer(objNNI, hiddenLayerID);
                    obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Create_Layer_Nodes(objNNI, outputID_A, hiddenLayerID);

                    for (byte nodeID = 0; nodeID < objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                    {
                        System.Console.WriteLine("delta");
                        if (layerID == (byte)(4))
                        {
                            objNNI.Get_Item_On_List_Of_PraiseSets(outputID_A).Get_Node(hiddenLayerID, nodeID).Create_List_Of_NeuralPathOfNodeInputs(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear[objNNI.Get_MetaData().Get_NumberOfPraiseInputValues()]);
                            while (objNNI.Get_List_Of_PraiseSet()[outputID_A].Get_Node(hiddenLayerID, nodeID).Get_List_Of_NeuralPathOfInput() == null) { }
                        }
                        else
                        {
                            objNNI.Get_Item_On_List_Of_PraiseSets(outputID_A).Get_Node(hiddenLayerID, nodeID).Create_List_Of_NeuralPathOfNodeInputs(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Linear[objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(hiddenLayerID + (byte)1))]);
                            while (objNNI.Get_List_Of_PraiseSet()[outputID_A].Get_Node(hiddenLayerID, nodeID).Get_List_Of_NeuralPathOfInput() == null) { }
                        }
                        objNNI.Get_Item_On_List_Of_PraiseSets(outputID_A).Get_Node(hiddenLayerID, nodeID).Set_NeuralPathOfInput_SubSet(hiddenLayerID, obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Get_New_Linear());
                        System.Console.WriteLine("outputID_A = " + outputID_A + "  hiddenLayerID = " + hiddenLayerID + "  nodeID = " + nodeID);
                        obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_Neural_Path_For_Input(obj, objNNI, outputID_A, hiddenLayerID, nodeID);
                    }
                }
            }
            for (byte outputID_B = 0; outputID_B < numberOfResetToConstant; outputID_B++)
            {
                objNNI.Create_List_Of_Constants(numberOfResetToConstant);
                while (objNNI.Get_List_Of_Constant() == null) { }
                objNNI.Set_Item_On_List_Of_Constant(outputID_B, obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Get_New_Constant());
                obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_Constant_From_Output_Subset(obj, objNNI, outputID_B);
            }
            return objNNI;
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

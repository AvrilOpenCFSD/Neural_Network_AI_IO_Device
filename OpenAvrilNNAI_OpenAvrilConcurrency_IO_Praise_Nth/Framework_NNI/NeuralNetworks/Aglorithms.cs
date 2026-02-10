

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
            System.Console.WriteLine("entering Create_Instance_Of_MachineAI.");
            OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI = obj.Get_Neural_Networks().Get_Data().Get_NewMachineAI();
            while (objNNI == null) { }
            
            System.Console.WriteLine("alpha");
            objNNI.Get_MetaData().Set_NameOfNNI(nameOfNNI);

            System.Console.WriteLine("bravo");
            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_MetaData_For_Neural_Network(obj, objNNI, praiseID);
            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_REGISTERED_Inputs_List(obj, objNNI);
            obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_REGISTERED_Outputs_List(obj, objNNI);

            System.Console.WriteLine("charlie");
            objNNI.Create_List_Of_Linear_Paths(objNNI.Get_MetaData().Get_NumberOfLinearOutputs());
            while (objNNI.Get_List_Of_Linear_Paths() == null) { }
            //objNNI.Create_List_Of_Binary_Paths(objNNI.Get_MetaData().Get_NumberOfBooleanOutputs());
            //while (objNNI.Get_List_Of_Binary_Paths() == null) { }
            //objNNI.Create_List_Of_Constant_Paths(objNNI.Get_MetaData().Get_NumberOfConstantOutputs());
           // while (objNNI.Get_List_Of_Constant_Paths() == null) { }

            System.Console.WriteLine("delta");
            for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfLinearOutputs(); outputID++)
            {
                System.Console.WriteLine("echo loop.");
                objNNI.Set_Item_On_List_Of_Linear_Paths(outputID, obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Get_New_Linear());
                objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Create_Tree_Of_Nodes(objNNI, outputID);
                for (Int16 layerID = 4; layerID > -1; layerID--)
                {
                    byte hiddenLayerID = Convert.ToByte(layerID);
                    System.Console.WriteLine("foxtrot loop. outputID = " + outputID + "  hiddenLayerID = " + hiddenLayerID);
                    for (byte nodeID = 0; nodeID < objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                    {
						System.Console.WriteLine("giga loop.");
                        if (layerID == (byte)(4))
                        {
							objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(objNNI.Get_MetaData().Get_NumberInputRegisters());
                        }
                        else
                        {
							objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(hiddenLayerID + (byte)1)));
                        }
						objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Create_List_Of_Linear_NeuralPath();
						objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_Item_On_List_Of_Linear_NeuralPath(hiddenLayerID, obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Get_New_Linear_NeuralPath());
                        System.Console.WriteLine("outputID = " + outputID + "  hiddenLayerID = " + hiddenLayerID + "  nodeID = " + nodeID);
                        obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Set_Linear_NeuralPath_For_Input(obj, objNNI, outputID, hiddenLayerID, nodeID);
                    }
                }
            }
            for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfBooleanOutputs(); outputID++)
            {

            }
            for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfConstantOutputs(); outputID++)
            {

            }
            return objNNI;
        }
        public void Save_Instance_Of_MachineAI_To_File(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj, OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI)
        {
            obj.Get_Neural_Networks().Get_Execute().Get_FileReadWrite().WriteValuesToFile(obj, objNNI, objNNI.Get_MetaData().Get_NameOfNNI());
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

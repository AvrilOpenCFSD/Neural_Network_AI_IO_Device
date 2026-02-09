namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class IO
    {
// classes.

// registers.
        static private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI _framework_NNI;
        static private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI _machineAI;

// constructor.
        public IO()
        {
            Create_framework_NNI(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI());
            while (Get_framework_NNI() == null) { }

            Create_machineAI(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI());
            while (Get_machineAI() == null) { }
        }

// destructor.
        ~IO()
        {

        }

// public.
        static public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI Create_Neural_Network()
        {
            Set_framework_NNI(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI());
            while (Get_framework_NNI() == null) { }
            return Get_framework_NNI();

        }
        static public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI Initialise_Instance_Of_MachineAI(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj)
        {
            Set_machineAI(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI());
            while (Get_machineAI() == null) { }
            Set_machineAI(obj.Get_Neural_Networks().Get_Aglorithms().Create_Instance_Of_MachineAI(obj, "AvrilNNI_OpenConcurrency_IO_Praise_Nth_OpenCFSD_Praise_1_IO.nni", (byte)1));
            return Get_machineAI();
        }
        static public bool Run_Neural_Network_Inteligence(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI)
        {
            return objNNI.Run_Neural_Network_Inteligence(objNNI);
        }
    // get.
        static public double[] Get_Output_Values(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI)
        {
            return objNNI.Get_List_Of_REGISTERED_Outputs();
        }
    // set.
        static public void Set_Input_Values(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI, double[] inputValues)
        {
            for (byte inputID = 0; inputID < objNNI.Get_MetaData().Get_NumberOfPraiseInputValues(); inputID++)
            {
                objNNI.Set_Item_On_List_Of_REGISTERED_Input(inputID, inputValues[inputID]);
            }
        }
// private.
        static private void Create_framework_NNI(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI newFramework)
        {
            _framework_NNI = newFramework;
        }
        static private void Create_machineAI(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI newMachineAI)
        {
            _machineAI = newMachineAI;
        }
        // get.
        static private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI Get_framework_NNI()
        {
            return _framework_NNI;
        }
        static private OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI Get_machineAI()
        {
            return _machineAI;
        }
        // set.
        static private void Set_framework_NNI(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI newFramework)
        {
            _framework_NNI = newFramework;
        }
        static private void Set_machineAI(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI newMachineAI)
        {
            _machineAI = newMachineAI;
        }
    }
}

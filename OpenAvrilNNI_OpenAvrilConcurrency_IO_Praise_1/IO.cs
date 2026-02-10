namespace OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1
{
    public class IO
    {
// classes.

// registers.
        static private Framework_NNI _framework_NNI;
        static private MachineAI _machineAI;

// constructor.
        public IO()
        {
            Create_framework_NNI(new Framework_NNI());
            while (Get_framework_NNI() == null) { }

            Create_machineAI(new MachineAI());
            while (Get_machineAI() == null) { }
        }

// destructor.
        ~IO()
        {

        }

// public.
        static public Framework_NNI Create_Neural_Network()
        {
            Set_framework_NNI(new Framework_NNI());
            while (Get_framework_NNI() == null) { }
            return Get_framework_NNI();

        }
        static public MachineAI Initialise_Instance_Of_MachineAI(Framework_NNI obj)
        {
            Set_machineAI(new MachineAI());
            while (Get_machineAI() == null) { }
            Set_machineAI(obj.Get_Neural_Networks().Get_Aglorithms().Create_Instance_Of_MachineAI(obj, "AvrilNNI_OpenConcurrency_IO_Praise_Nth_OpenCFSD_Praise_1_IO.nni", (byte)1));
            return Get_machineAI();
        }
        static public bool Run_Neural_Network_Inteligence(MachineAI objNNI)
        {
            return objNNI.Run_Neural_Network_Inteligence(objNNI);
        }
    // get.
        static public double[] Get_Output_Values(MachineAI objNNI)
        {
            return objNNI.Get_List_Of_REGISTERED_Outputs();
        }
    // set.
        static public void Set_Input_Values(MachineAI objNNI, double[] inputValues)
        {
            for (byte inputID = 0; inputID < objNNI.Get_MetaData().Get_NumberInputRegisters(); inputID++)
            {
                objNNI.Set_Item_On_List_Of_REGISTERED_Input(inputID, inputValues[inputID]);
            }
        }
// private.
        static private void Create_framework_NNI(Framework_NNI newFramework)
        {
            _framework_NNI = newFramework;
        }
        static private void Create_machineAI(MachineAI newMachineAI)
        {
            _machineAI = newMachineAI;
        }
        // get.
        static private Framework_NNI Get_framework_NNI()
        {
            return _framework_NNI;
        }
        static private MachineAI Get_machineAI()
        {
            return _machineAI;
        }
        // set.
        static private void Set_framework_NNI(Framework_NNI newFramework)
        {
            _framework_NNI = newFramework;
        }
        static private void Set_machineAI(MachineAI newMachineAI)
        {
            _machineAI = newMachineAI;
        }
    }
}

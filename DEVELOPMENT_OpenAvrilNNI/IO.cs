
using OpenAvrilNNI;

namespace OpenAvrilNNI_OpenAvrilConcurrency_IO
{
    public class IO
    {
// classes.

// registers.
        static private Framework_NNI _Framework_NNI;

// constructor.
        public IO()
        {
            Create_Framework_NNI();
        }

// destructor.
        ~IO()
        {

        }

// public.
        static public Framework_NNI Create_OpenAvrilNNI_OpenAvrilConcurrency_NNI()
        {
            Set_Framework_NNI(new Framework_NNI());
            while (Get_Framework_NNI() == null) { }
            Get_Framework_NNI().Initialise_Framework_NNI(Get_Framework_NNI());
            return Get_Framework_NNI();

        }
        static public bool Run_Neural_Network_Inteligence(MachineAI objNNI)
        {
            return objNNI.Run_Neural_Network_Inteligence(objNNI);
        }
    // get.
        static public double[] Get_Output_Values(MachineAI objNNI)
        {
            return objNNI.Get_list_Of_REGISTERED_Outputs();
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
        static private void Create_Framework_NNI()
        {
            Set_Framework_NNI(new Framework_NNI());
            while (Get_Framework_NNI() == null) { }
        }
    // get.
        static private Framework_NNI Get_Framework_NNI()
        {
            return _Framework_NNI;
        }
    // set.
        static private void Set_Framework_NNI(Framework_NNI newFramework)
        {
            _Framework_NNI = newFramework;
        }
    }
}

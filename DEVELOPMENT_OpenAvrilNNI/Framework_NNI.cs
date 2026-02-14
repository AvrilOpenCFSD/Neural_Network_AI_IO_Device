
namespace OpenAvrilNNI
{
    public class Framework_NNI
    {
// classes.
        private NeuralNetworks _NeuralNetwork;

// registers.

// constructor.
        public Framework_NNI()
        {
            System.Console.WriteLine("entered Framework_NNI.");
            Create_NeuralNetworks();
        }

// destructor.
        ~Framework_NNI()
        {
            //System.Console.WriteLine("exited Framework_NNI.");
        }

// public.
        public void Initialise_Framework_NNI(Framework_NNI obj)
        {
            //Create_And_Run_UI(obj);
            MachineAI machineAI = obj.Get_NeuralNetwork().Get_Data().Get_Item_On_list_Of_MachineAI(0);
            Initialise_instance_Of_MachineAI(obj, machineAI, "OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_DEFAULT", byte.MaxValue);
            obj.Get_NeuralNetwork().Get_Data().Initialise_DEFAULT_list_Of_MachineAI(machineAI);
        }
        public void Initialise_instance_Of_MachineAI(Framework_NNI obj, MachineAI objNNI, string nameOfNNI, byte praiseID)
        {
            obj.Get_NeuralNetwork().Get_Aglorithms().Initialise_instance_Of_MachineAI(obj, objNNI, nameOfNNI, praiseID);

        }
        // get.
        public NeuralNetworks Get_NeuralNetwork()
        {
            return _NeuralNetwork;
        }
    // set.

// private.
        private void Create_And_Run_UI(Framework_NNI obj)
        {
            obj.Get_NeuralNetwork().Get_Execute().Create_And_Run_UI();
        }
        private void Create_NeuralNetworks()
        {
            Set_NeuralNetwork(new NeuralNetworks());
            while(Get_NeuralNetwork() == null) { }
        }
    // get.
    // set.
        private void Set_NeuralNetwork(NeuralNetworks newNeuralNetowrk)
        {
            _NeuralNetwork = newNeuralNetowrk;
        }
    }
}


using OpenAvrilNNI_OpenAvrilConcurrency_IO_Praise_1;

Console.WriteLine("entering TESTBANCH: OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.");

var obj = IO.Create_Neural_Network();
var newMachineAI = IO.Initialise_Instance_Of_MachineAI(obj);

double[] inputValues = new double[newMachineAI.Get_MetaData().Get_NumberInputRegisters()];
for (byte inputID = 0; inputID < newMachineAI.Get_List_Of_REGISTERED_Inputs().Length; inputID++)
{
    Console.WriteLine("inputID[" + inputID + "] = " + newMachineAI.Get_Item_On_List_Of_REGISTERED_Inputs(inputID));
}
IO.Set_Input_Values(newMachineAI, inputValues);

bool isDone = IO.Run_Neural_Network_Inteligence(newMachineAI);
while (!isDone) { }

double[] outputValues = new double[newMachineAI.Get_MetaData().Get_NumberOutputRegisters()];
outputValues = IO.Get_Output_Values(newMachineAI);
for (byte outputID = 0; outputID < newMachineAI.Get_List_Of_REGISTERED_Outputs().Length; outputID++)
{
    Console.WriteLine("outputID[" + outputID + "] = " + newMachineAI.Get_Item_On_List_Of_REGISTERED_Outputs(outputID));
}

Console.WriteLine("exiting TESTBANCH: OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.");
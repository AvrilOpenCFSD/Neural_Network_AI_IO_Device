
using AvrilNNAI_OpenConcurrency_IO_Praise_Nth;

Console.WriteLine("entering TESTBANCH: AvrilNNAI_OpenConcurrency_IO_Praise_Nth.");
Framework_NNAI obj = IO.Create_Neural_Network();
Console.WriteLine("alpha.");
MachineAI newMachineAI = IO.Initialise_Instance_Of_MachineAI(obj);
Console.WriteLine("bravo.");
double[] inputValues = new double[newMachineAI.Get_MetaData().Get_NumberOfPraiseInputValues()];
Console.WriteLine("charlie.");
for (ulong inputID = 0; inputID < (ulong)inputValues.LongLength; inputID++)
{
    Console.WriteLine("delta loop.");
    inputValues[inputID] = 0.0;
}
Console.WriteLine("echo.");
bool isDone = IO.Run_Neural_Network_Inteligence(newMachineAI);
Console.WriteLine("foxtrot.");
while (!isDone)
{
 
}
Console.WriteLine("giga.");
double[] outputValues = new double[newMachineAI.Get_MetaData().Get_NumberOfPraiseOutputValues()];
Console.WriteLine("hex.");
outputValues = IO.Get_Output_Values(newMachineAI);
Console.WriteLine("indigo.");
for (byte outputID = 0; outputID < outputValues.Length; outputID++)
{
    Console.WriteLine("outputID[" + outputID + "] = " + outputValues[outputID]);
}
Console.WriteLine("exiting TESTBANCH: AvrilNNAI_OpenConcurrency_IO_Praise_Nth.");

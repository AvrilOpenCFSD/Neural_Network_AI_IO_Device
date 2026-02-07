
using AvrilNNAI_OpenConcurrency_IO_Praise_Nth;

Console.WriteLine("entering TESTBANCH: AvrilNNAI_OpenConcurrency_IO_Praise_Nth.");
Framework_NNAI obj = IO.Create_Neural_Network();
Console.WriteLine("alpha.");
MachineAI newMachineAI = IO.Initialise_Instance_Of_MachineAI(obj);
Console.WriteLine("bravo.");
double[] inputValues = new double[newMachineAI.Get_MetaData().Get_NumberOfPraiseInputValues()];
Console.WriteLine("charlie.");
inputValues[(byte)Global.PRAISE_1.Mouse_Screen_X] = 0.0;
inputValues[(byte)Global.PRAISE_1.Mouse_Screen_Y] = 0.0;
inputValues[(byte)Global.PRAISE_1.Capsule_Fowards_X] = 1.0;
inputValues[(byte)Global.PRAISE_1.Capsule_Fowards_Y] = 0.0;
inputValues[(byte)Global.PRAISE_1.Capsule_Fowards_Z] = 0.0;
inputValues[(byte)Global.PRAISE_1.Capsule_Up_X] = 0.0;
inputValues[(byte)Global.PRAISE_1.Capsule_Up_Y] = 1.0;
inputValues[(byte)Global.PRAISE_1.Capsule_Up_Z] = 0.0;
inputValues[(byte)Global.PRAISE_1.Capsule_Right_X] = 0.0;
inputValues[(byte)Global.PRAISE_1.Capsule_Right_Y] = 0.0;
inputValues[(byte)Global.PRAISE_1.Capsule_Right_Z] = 1.0;

Console.WriteLine("echo.");

IO.Set_Input_Values(newMachineAI, inputValues);
bool isDone = IO.Run_Neural_Network_Inteligence(newMachineAI);
Console.WriteLine("foxtrot.");
while (!isDone)
{
 
}
for (byte inputID = 0; inputID < newMachineAI.Get_List_Of_REGISTERED_Inputs().Length; inputID++)
{
    Console.WriteLine("inputID[" + inputID + "] = " + newMachineAI.Get_Item_On_List_Of_REGISTERED_Inputs(inputID));
}
Console.WriteLine("giga.");
double[] outputValues = new double[newMachineAI.Get_MetaData().Get_NumberOfPraiseOutputValues()];
Console.WriteLine("hex.");
outputValues = IO.Get_Output_Values(newMachineAI);
Console.WriteLine("indigo.");
for (byte outputID = 0; outputID < newMachineAI.Get_List_Of_REGISTERED_Outputs().Length; outputID++)
{
    Console.WriteLine("outputID[" + outputID + "] = " + newMachineAI.Get_Item_On_List_Of_REGISTERED_Outputs(outputID));
}
Console.WriteLine("exiting TESTBANCH: AvrilNNAI_OpenConcurrency_IO_Praise_Nth.");

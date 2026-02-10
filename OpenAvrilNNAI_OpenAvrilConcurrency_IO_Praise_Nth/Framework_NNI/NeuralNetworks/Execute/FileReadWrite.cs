using System.Reflection.PortableExecutable;
using System.Text;

namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class FileReadWrite
    {
 // definitions.

        // classes.

        // constructor.
        public FileReadWrite()
        {

        }

// destructor.
        ~FileReadWrite() 
        {
        
        }

// public.
        public void WriteValuesToFile(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj, OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI, string fileName)
        {
            string pathName = new string("..\\..\\..\\..\\nnai_extension_files\\" + fileName + ".nni");
            using (var stream = File.Open(pathName, FileMode.Create))
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {
    // write class MachineAI.
	    // write class MachineAI\MetaData.
		    // write register _NameOfNNI.
					writer.Write(objNNI.Get_MetaData().Get_NameOfNNI());
		    // write register _PraiseID.
					writer.Write(objNNI.Get_MetaData().Get_PraiseID());
		    // write register _NumberOfPraiseInputValues.
					writer.Write(objNNI.Get_MetaData().Get_NumberInputRegisters());
		    // write register _NumberOfLinearInputs
					writer.Write(objNNI.Get_MetaData().Get_NumberOfLinearInputs());
		    // write register _NumberOfLinearInputs
					writer.Write(objNNI.Get_MetaData().Get_NumberOfBooleanInputs());
		    // write register _NumberOfBooleanInputs
					writer.Write(objNNI.Get_MetaData().Get_NumberOfConstantInputs());
		    // write register _NumberOfPraiseOutputValues.
					writer.Write(objNNI.Get_MetaData().Get_NumberOutputRegisters());
		    // write register _NumberOutputRegisters
					writer.Write(objNNI.Get_MetaData().Get_NumberOfBooleanOutputs());
		    // write register _NumberOfBooleanOutputs
					writer.Write(objNNI.Get_MetaData().Get_NumberOfLinearOutputs());
		    // write register _NumberOfLinearOutputs
					writer.Write(objNNI.Get_MetaData().Get_NumberOfConstantOutputs());
		    // write register _NumberOfNodesInLayer.
					for (Int16 layerID = 4; layerID < -1; layerID--)
                    {
                        byte hidenLayerID = Convert.ToByte(layerID);
                        writer.Write(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hidenLayerID));
                    }
            // write register _REGISTERED_Inputs.
                    for (byte inputID = 0; inputID < objNNI.Get_MetaData().Get_NumberInputRegisters(); inputID++)
                    {
                        System.Console.WriteLine("NumberOfPraiseInputValues = " + objNNI.Get_MetaData().Get_NumberInputRegisters() + "  inputID = " + inputID); 
                        writer.Write(objNNI.Get_Item_On_List_Of_REGISTERED_Inputs(inputID));
                    }
            // write register _REGISTERED_Outputs.
                    for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOutputRegisters(); outputID++)
                    {
                        writer.Write(objNNI.Get_Item_On_List_Of_REGISTERED_Outputs(outputID));
                    }
		// write class MachineAI\Linear.
			// write class MachineAI\Linear\PraiseSet
				// write class MachineAI\Linear\PraiseSet\Node.
					for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfLinearOutputs(); outputID++)
                    {
                        for (Int16 layerID = 4; layerID > -1; layerID--)
                        {
                            byte hiddenLayerID = Convert.ToByte(layerID);
                            for (byte nodeID = 0; nodeID < objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                            {
                    // write register _NumberOfInputs.
                                writer.Write(objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_NumberOfInputs());
                    // write register _REGISTERED_Output.
                                writer.Write(objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_REGISTERED_Output());
                    // write class MachineAI\PraiseSet\Node\Linear.
                                byte numberOfInputsForNode = new byte();
                                numberOfInputsForNode = 0;
                                if (layerID == (byte)4)
                                {
                                    numberOfInputsForNode = objNNI.Get_MetaData().Get_NumberInputRegisters();
                                }
                                else
                                {
                                    numberOfInputsForNode = objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(layerID + (byte)1));
                                }
                                for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
                                {
                    // write register _bias.
                                    writer.Write(objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_List_Of_Linear_NeuralPath(inputID).Get_Bias());
                    // write register _weight.
                                    writer.Write(objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_List_Of_Linear_NeuralPath(inputID).Get_Weight());
                                }
                            }
                        }
                    }
	    // write class MachineAI\Boolean.
					for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfBooleanOutputs(); outputID++)
					{

					}
	    // write class MachineAI\Constants.
					for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfConstantOutputs(); outputID++)
                    {

                    }
                }
            }
        }

        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI ReadValuesFromFile(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj, string fileName)
        {
            OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI = obj.Get_Neural_Networks().Get_Data().Get_NewMachineAI();
            while (objNNI == null) { }

            string pathName = new string("..\\..\\..\\..\\nnai_extension_files\\" + fileName + ".nni");
            if (File.Exists(pathName))
            {
                using (var stream = File.Open(pathName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
    // write class MachineAI.
        // write class MachineAI\MetaData.
            // write register _NameOfNNI.
                        objNNI.Get_MetaData().Set_NameOfNNI(reader.ReadString());
            // write register _PraiseID.
                        objNNI.Get_MetaData().Set_PraiseID(reader.ReadByte());
            // write register _NumberOfPraiseInputValues.
                        objNNI.Get_MetaData().Set_NumberInputRegisters(reader.ReadByte());
			// write register _NumberOfLinearInputs
						objNNI.Get_MetaData().Set_NumberOfLinearInputs(reader.ReadByte());
			// write register _NumberOfLinearInputs
						objNNI.Get_MetaData().Set_NumberOfBooleanInputs(reader.ReadByte());
			// write register _NumberOfBooleanInputs
						objNNI.Get_MetaData().Set_NumberOfConstantInputs(reader.ReadByte());
			// write register _NumberOfPraiseOutputValues.
						objNNI.Get_MetaData().Set_NumberOutputRegisters(reader.ReadByte());
			// write register _NumberOutputRegisters
						objNNI.Get_MetaData().Set_NumberOfBooleanOutputs(reader.ReadByte());
			// write register _NumberOfBooleanOutputs
						objNNI.Get_MetaData().Set_NumberOfLinearOutputs(reader.ReadByte());
			// write register _NumberOfLinearOutputs
						objNNI.Get_MetaData().Set_NumberOfConstantOutputs(reader.ReadByte());
            // write register _NumberOfNodesInLayer.
                        for (Int16 layerID = 4; layerID < -1; layerID--)
                        {
                            byte hidenLayerID = Convert.ToByte(layerID);
                            objNNI.Get_MetaData().Set_NumberOfNodesInHiddenLayer(hidenLayerID, reader.ReadByte());
                        }
        // write register _REGISTERED_Inputs.
                        for (byte inputID = 0; inputID < objNNI.Get_MetaData().Get_NumberInputRegisters(); inputID++)
                        {
                            objNNI.Set_Item_On_List_Of_REGISTERED_Input(inputID, reader.ReadDouble());
                        }
        // write register _REGISTERED_Outputs.
                        for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOutputRegisters(); outputID++)
                        {
                            objNNI.Set_Item_On_List_Of_REGISTERED_Output(outputID, reader.ReadDouble());
                        }
		// write class MachineAI\Linear.
			// write class MachineAI\Linear\PraiseSet
				// write class MachineAI\Linear\PraiseSet\Node.
						for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOutputRegisters(); outputID++)
                        {
                            for (Int16 layerID = 4; layerID > -1; layerID--)
                            {
                                byte hiddenLayerID = Convert.ToByte(layerID);
                                for (byte nodeID = 0; nodeID < objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                                {
                    // write register _NumberOfInputs.
                                    objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(reader.ReadByte());
                    // write register _REGISTERED_Output.
                                    objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Set_REGISTERED_Output(reader.ReadDouble());
                    // write class MachineAI\PraiseSet\Node\Linear.
                                    byte numberOfInputsForNode = new byte();
                                    numberOfInputsForNode = 0;
                                    if (layerID == (byte)4)
                                    {
                                        numberOfInputsForNode = objNNI.Get_MetaData().Get_NumberInputRegisters();
                                    }
                                    else
                                    {
                                        numberOfInputsForNode = objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(layerID + (byte)1));
                                    }
                                    for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
                                    {
                    // write register _bias.
                                        objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_List_Of_Linear_NeuralPath(inputID).Set_Bias(reader.ReadDouble());
                    // write register _weight.
                                        objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Get_Node(hiddenLayerID, nodeID).Get_Item_On_List_Of_Linear_NeuralPath(inputID).Set_Weight(reader.ReadDouble());
                                    }
                                }
                            }
                        }
		// write class MachineAI\Boolean.
						for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfBooleanOutputs(); outputID++)
						{

						}
		// write class MachineAI\Constants.
						for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfConstantOutputs(); outputID++)
						{

						}
					}
				}
            }
            return objNNI;
        }
    // get.

    // set.

// private.

    // get.

    // set.
    }
}

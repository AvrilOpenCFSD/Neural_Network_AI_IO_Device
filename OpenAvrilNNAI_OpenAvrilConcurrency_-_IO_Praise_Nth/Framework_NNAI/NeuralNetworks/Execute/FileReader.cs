using System.ComponentModel;
using System.Text;

namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class FileReader
    {
 // definitions.

        // classes.

        // constructor.
        public FileReader()
        {

        }

// destructor.
        ~FileReader() 
        {
        
        }

// public.
        public OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI ReadValuesFromFile(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Framework_NNI obj, string fileName)
        {
            OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI = obj.Get_Neural_Networks().Get_Data().Get_NewMachineAI();
            while (objNNI == null) { }

            string pathName = new string("..\\..\\..\\..\\nnai_extension_files\\" + fileName);
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
                        objNNI.Get_MetaData().Set_NumberOfPraiseInputValues(reader.ReadByte());
            // write register _NumberOfPraiseOutputValues.
                        objNNI.Get_MetaData().Set_NumberOfPraiseOutputValues(reader.ReadByte());
            // write register _NumberOfResetToConstantValues_INPUT.
                        objNNI.Get_MetaData().Set_NumberOfResetToConstantValues_INPUT(reader.ReadByte());
            // write register _NumberOfResetToConstantValues_OUTPUT.           
                        objNNI.Get_MetaData().Set_NumberOfResetToConstantValues_OUTPUT(reader.ReadByte());
            // write register _NumberOfNodesInLayer.
                        for (Int16 layerID = 4; layerID < -1; layerID--)
                        {
                            byte hidenLayerID = Convert.ToByte(layerID);
                            objNNI.Get_MetaData().Set_NumberOfNodesInHiddenLayer(hidenLayerID, reader.ReadByte());
                        }

                        byte numberOfPraiseSets = (byte)(objNNI.Get_MetaData().Get_NumberOfPraiseOutputValues() - objNNI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT());
                        byte numberOfResetToConstant = objNNI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT();

        // write register _REGISTERED_Inputs.
                        for (byte inputID = 0; inputID < objNNI.Get_MetaData().Get_NumberOfPraiseInputValues(); inputID++)
                        {
                            objNNI.Set_Item_On_List_Of_REGISTERED_Input(inputID, reader.ReadDouble());
                        }
        // write register _REGISTERED_Outputs.
                        for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfPraiseOutputValues(); outputID++)
                        {
                            objNNI.Set_Item_On_List_Of_REGISTERED_Output(outputID, reader.ReadDouble());
                        }
        // write class MachineAI\PraiseSet.
            // write class MachineAI\PraiseSet\Node.
                        for (byte outputID = 0; outputID < objNNI.Get_MetaData().Get_NumberOfPraiseInputValues(); outputID++)
                        {
                            if (outputID < numberOfPraiseSets)
                            {
                                for (Int16 layerID = 4; layerID > -1; layerID--)
                                {
                                    byte hiddenLayerID = Convert.ToByte(layerID);
                                    for (byte nodeID = 0; nodeID < objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                                    {
                // write register _NumberOfInputs.
                                        objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(reader.ReadByte());
                // write register _REGISTERED_Output.
                                        objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Set_REGISTERED_Output(reader.ReadDouble());
                // write class MachineAI\PraiseSet\Node\Linear.
                                        byte numberOfInputsForNode = new byte();
                                        numberOfInputsForNode = 0;
                                        if (layerID == (byte)4)
                                        {
                                            numberOfInputsForNode = objNNI.Get_MetaData().Get_NumberOfPraiseInputValues();
                                        }
                                        else
                                        {
                                            numberOfInputsForNode = objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(layerID + (byte)1));
                                        }
                                        for (byte inputID = 0; inputID < numberOfInputsForNode; inputID++)
                                        {
                    // write register _bias.
                                            objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Get_Item_On_List_Of_NeuralPathOfInput(inputID).Set_Bias(reader.ReadDouble());
                    // write register _weight.
                                            objNNI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Get_Item_On_List_Of_NeuralPathOfInput(inputID).Set_Weight(reader.ReadDouble());
                                        }
                                    }
                                }
                            }
                        }
        // write class MachineAI\Constants.
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

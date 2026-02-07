using System.ComponentModel;
using System.Text;

namespace AvrilNNAI_OpenConcurrency_IO_Praise_Nth
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
        public AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI ReadValuesFromFile(AvrilNNAI_OpenConcurrency_IO_Praise_Nth.Framework_NNAI obj, string fileName)
        {
            AvrilNNAI_OpenConcurrency_IO_Praise_Nth.MachineAI _AvrilNNAI = obj.Get_Neural_Networks().Get_Data().Get_NewMachineAI();
            while (_AvrilNNAI == null) { }

            string pathName = new string("..\\..\\..\\..\\nnai_extension_files\\" + fileName);
            if (File.Exists(pathName))
            {
                using (var stream = File.Open(pathName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
    // write class MachineAI.
        // write class MachineAI\MetaData.
            // write register _NameOfNNAI.
                        _AvrilNNAI.Get_MetaData().Set_NameOfNNAI(reader.ReadString());
            // write register _PraiseID.
                        _AvrilNNAI.Get_MetaData().Set_PraiseID(reader.ReadUInt64());
            // write register _NumberOfPraiseInputValues.
                        _AvrilNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(reader.ReadByte());
            // write register _NumberOfPraiseOutputValues.
                        _AvrilNNAI.Get_MetaData().Set_NumberOfPraiseOutputValues(reader.ReadByte());
            // write register _NumberOfResetToConstantValues_INPUT.
                        _AvrilNNAI.Get_MetaData().Set_NumberOfResetToConstantValues_INPUT(reader.ReadByte());
            // write register _NumberOfResetToConstantValues_OUTPUT.           
                        _AvrilNNAI.Get_MetaData().Set_NumberOfResetToConstantValues_OUTPUT(reader.ReadByte());
            // write register _NumberOfNodesInLayer.
                        for (sbyte layerID = 4; layerID < -1; layerID--)
                        {
                            byte hidenLayerID = Convert.ToByte(layerID);
                            _AvrilNNAI.Get_MetaData().Set_NumberOfNodesInHiddenLayer(hidenLayerID, reader.ReadUInt64());
                        }

                        byte numberOfPraiseSets = (byte)(_AvrilNNAI.Get_MetaData().Get_NumberOfPraiseOutputValues() - _AvrilNNAI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT());
                        byte numberOfResetToConstant = _AvrilNNAI.Get_MetaData().Get_NumberOfResetToConstantValues_OUTPUT();

        // write register _REGISTERED_Inputs.
                        for (ulong inputID = 0; inputID < _AvrilNNAI.Get_MetaData().Get_NumberOfPraiseInputValues(); inputID++)
                        {
                            _AvrilNNAI.Set_Item_On_List_Of_REGISTERED_Input(inputID, reader.ReadDouble());
                        }
        // write register _REGISTERED_Outputs.
                        for (ulong outputID = 0; outputID < _AvrilNNAI.Get_MetaData().Get_NumberOfPraiseOutputValues(); outputID++)
                        {
                            _AvrilNNAI.Set_Item_On_List_Of_REGISTERED_Output(outputID, reader.ReadDouble());
                        }
        // write class MachineAI\PraiseSet.
            // write class MachineAI\PraiseSet\Node.
                        for (byte outputID = 0; outputID < _AvrilNNAI.Get_MetaData().Get_NumberOfPraiseInputValues(); outputID++)
                        {
                            if (outputID < numberOfPraiseSets)
                            {
                                for (sbyte layerID = 4; layerID > -1; layerID--)
                                {
                                    byte hiddenLayerID = Convert.ToByte(layerID);
                                    for (ulong nodeID = 0; nodeID < _AvrilNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(hiddenLayerID); nodeID++)
                                    {
                // write register _NumberOfInputs.
                                        _AvrilNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Set_NumberOfInputs(reader.ReadUInt64());
                // write register _REGISTERED_Output.
                                        _AvrilNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Set_REGISTERED_Output(reader.ReadDouble());
                // write class MachineAI\PraiseSet\Node\Linear.
                                        ulong numberOfInputsForNode = new ulong();
                                        numberOfInputsForNode = 0;
                                        if (layerID == (byte)4)
                                        {
                                            numberOfInputsForNode = _AvrilNNAI.Get_MetaData().Get_NumberOfPraiseInputValues();
                                        }
                                        else
                                        {
                                            numberOfInputsForNode = _AvrilNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(layerID + (byte)1));
                                        }
                                        for (ulong inputID = 0; inputID < numberOfInputsForNode; inputID++)
                                        {
                    // write register _bias.
                                            _AvrilNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Get_Item_On_List_Of_NeuralPathOfInput(inputID).Set_Bias(reader.ReadDouble());
                    // write register _weight.
                                            _AvrilNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(hiddenLayerID, nodeID).Get_Item_On_List_Of_NeuralPathOfInput(inputID).Set_Weight(reader.ReadDouble());
                                        }
                                    }
                                }
                            }
                        }
        // write class MachineAI\Constants.
                    }
                }
            }
            return _AvrilNNAI;
        }
    // get.

    // set.

// private.

    // get.

    // set.
    }
}


using System;

namespace Avril_NNAI
{
    public class NeuralPath
    {
// classes.
        private Avril_NNAI.Linear _New_Linear;
            
// registers.

// constructor.
        public NeuralPath() 
        {
            //System.Console.WriteLine("entered NeuralPath.");
            Create_New_Linear(new Avril_NNAI.Linear());
            while (Get_New_Linear() == null) { }
            //System.Console.WriteLine("exiting NeuralPath.");
        }

// destructor
        ~NeuralPath()
        {

        }

        // public.
        public void Create_Nodes(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, byte numberOfPraiseInputValues, byte numberOfPraiseOutputValues)
        {
            System.Console.WriteLine("entered Create_Nodes.");

            objNNAI.Create_REGISTERED_Inputs(new double[numberOfPraiseInputValues]);
            for (byte inputID = 0; inputID < numberOfPraiseInputValues; inputID++)
            {
                objNNAI.Set_REGISTERED_Input(inputID, 0.0);
            }

            objNNAI.Create_REGISTERED_Outputs(new double[numberOfPraiseOutputValues]);
            for (byte inputID = 0; inputID < numberOfPraiseOutputValues; inputID++)
            {
                objNNAI.Set_REGISTERED_Output(inputID, 0.0);
            }

            objNNAI.Create_PraiseSet(new Avril_NNAI.PraiseSet[numberOfPraiseOutputValues]);
            for (byte outputTree = 0; outputTree < numberOfPraiseOutputValues; outputTree++)
            {
                objNNAI.Set_Item_On_List_Of_PraiseSets(outputTree, new Avril_NNAI.PraiseSet());
            }

            ulong numberOfNodesInLayer = new ulong();
            double temp = new double();
            for (byte outputID = 0; outputID < (byte)numberOfPraiseOutputValues; outputID++)
            {
                for (byte layerID = 4; layerID < 5; layerID--)
                {
                    numberOfNodesInLayer = 0;
                    temp = 0.0;
                    switch (layerID)
                    {
                        case (byte)Global.NodeLayer.Layer_4:
                            temp = (double)4 / (double)5;
                            temp = ((double)numberOfPraiseInputValues * (double)temp);
                            numberOfNodesInLayer = (ulong)Math.Round(temp);
                            break;

                        case (byte)Global.NodeLayer.Layer_3:
                            temp = (double)3 / (double)5;
                            temp = ((double)numberOfPraiseInputValues * (double)temp);
                            numberOfNodesInLayer = (ulong)Math.Round(temp);
                            break;

                        case (byte)Global.NodeLayer.Layer_2:
                            temp = (double)2 / (double)5;
                            temp = ((double)numberOfPraiseInputValues * (double)temp);
                            numberOfNodesInLayer = (ulong)Math.Round(temp);
                            break;

                        case (byte)Global.NodeLayer.Layer_1:
                            temp = (double)1 / (double)5;
                            temp = ((double)numberOfPraiseInputValues * (double)temp);
                            numberOfNodesInLayer = (ulong)Math.Round(temp);
                            break;

                        case (byte)Global.NodeLayer.Layer_0:
                            numberOfNodesInLayer = (ulong)1;
                            break;

                        default:
                            break;
                    }
                    System.Console.WriteLine("temp = " + temp + "numberOfNodesInLayer = " + layerID);
                    objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Set_NumberOfNodesInHiddenLayer(layerID, numberOfNodesInLayer);
                    System.Console.WriteLine("outputID = " + outputID + "(layerID == " + layerID + ") Set_NumberOfNodesInLayer = " + objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_NumberOfNodesInHiddenLayer(layerID));


                }

                var newEmptyNode = new Avril_NNAI.Node();
                while (newEmptyNode == null) { }

                var newLinearPath = new Avril_NNAI.Linear();
                while (newLinearPath == null) { }

                for (byte layerID = 4; layerID < 5; layerID--)
                {
                    switch (layerID)
                    {
                        case (byte)Global.NodeLayer.Layer_4:
                            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer4_Nodes(objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                            break;

                        case (byte)Global.NodeLayer.Layer_3:
                            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer3_Nodes(objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                            break;

                        case (byte)Global.NodeLayer.Layer_2:
                            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer2_Nodes(objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                            break;

                        case (byte)Global.NodeLayer.Layer_1:
                            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer1_Nodes(objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                            break;

                        case (byte)Global.NodeLayer.Layer_0:
                            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer0_Node(newEmptyNode);
                            break;
                    }

                    ulong numberOfInputsForNode = new ulong();
                    numberOfInputsForNode = 0;
                    if (layerID == 4)
                    {
                        numberOfInputsForNode = objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues();
                    }
                    else
                    {
                        numberOfInputsForNode = objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_NumberOfNodesInHiddenLayer((byte)(layerID + (byte)1));
                    }
                    for (ulong nodeID = 0; nodeID < objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_NumberOfNodesInHiddenLayer(layerID); nodeID++)
                    {
                        objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Set_NumberOfInputs(numberOfInputsForNode);
                    }

                    for (ulong nodeID = 0; nodeID < objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_NumberOfNodesInHiddenLayer(layerID); nodeID++)
                    {
                        objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Create_List_Of_NeuralPathOfNodeInputs(new Avril_NNAI.Linear[objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_NumberOfInputs()]);
                        for (ulong inputID = 0; inputID < objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_NumberOfInputs(); inputID++)
                        {
                            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Set_NeuralPathOfInput_SubSet(inputID, newLinearPath);
                            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_NeuralPathOfInput_SubSet(inputID).Set_Weight(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_Random_Small_Value(-0.5, 0.5));
                            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_NeuralPathOfInput_SubSet(inputID).Set_Bias(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_Random_Small_Value(-0.5, 0.5));
                            System.Console.WriteLine("outputID = " + outputID + "  layerID = " + layerID + "  nodeID = " + nodeID + "  inputID = " + inputID + "  bias = " + objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_NeuralPathOfInput_SubSet(inputID).Get_Bias() + "  weight = " + objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_NeuralPathOfInput_SubSet(inputID).Get_Weight());
                        }
                    }
                }
            }
            System.Console.WriteLine("exiting Create_Nodes.");
        }
        public void Create_PraiseSet( Avril_NNAI.MachineAI objNNAI, Avril_NNAI.PraiseSet[] value)
        {
            objNNAI.Create_PraiseSet(value);
        }
        public void Calculate_NumberOfPraiseInputValues(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong praiseID)
        {
            objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(0);
            switch (praiseID)
            {
                case 0:
                    var objValue_Praise0 = (Avril_NNAI.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(0);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(objValue_Praise0.Get_NumberOfInputValues());
                    break;

                case 1:
                    var objValue_Praise1 = (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(1);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(objValue_Praise1.Get_NumberOfInputValues());
                    break;

                case 2:
                    var objValue_Praise2 = (Avril_NNAI.Input_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(2);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(objValue_Praise2.Get_NumberOfInputValues());
                    break;
                default:
                    break;
            }
        }
        public void Calculate_NumberOfPraiseOutputValues(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong praiseID)
        {
            objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(0);
            switch (praiseID)
            {
                case 0:
                    var objValue_Praise0 = (Avril_NNAI.Output_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(0);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseOutputValues(objValue_Praise0.Get_NumberOfOutputValues());
                    break;

                case 1:
                    var objValue_Praise1 = (Avril_NNAI.Output_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(1);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseOutputValues(objValue_Praise1.Get_NumberOfOutputValues());
                    break;

                case 2:
                    var objValue_Praise2 = (Avril_NNAI.Output_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(2);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseOutputValues(objValue_Praise2.Get_NumberOfOutputValues());
                    break;

                default:
                    break;
            }
        }
        public double Generate_Initial_Random_Small_Value(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
        public void Generate_REGISTERED_Inputs_List(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong praiseID)
        {
            switch (praiseID)
            {
                case (ulong)Global.PraiseID.Praise_0:
                    Avril_NNAI.Input_Praise_0 subsetOfInput_Praise_0 = (Avril_NNAI.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(0);
                    objNNAI.Create_REGISTERED_Inputs(new double[subsetOfInput_Praise_0.Get_NumberOfInputValues()]);
                    for (byte index = 0; index < subsetOfInput_Praise_0.Get_NumberOfInputValues(); index++)
                    {
                        subsetOfInput_Praise_0.Set_Item_Of_Input_Praise(index, 0.0);
                    }
                    break;

                case (ulong)Global.PraiseID.Praise_1:
                    Avril_NNAI.Input_Praise_1 subsetOfInput_Praise_1 = (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(1);
                    objNNAI.Create_REGISTERED_Inputs(new double[subsetOfInput_Praise_1.Get_NumberOfInputValues()]);
                    for (byte index = 0; index < subsetOfInput_Praise_1.Get_NumberOfInputValues(); index++)
                    {
                        subsetOfInput_Praise_1.Set_Item_Of_Input_Praise(index, 0.0);
                    }
                    break;

                case (ulong)Global.PraiseID.Praise_2:
                    Avril_NNAI.Input_Praise_2 subsetOfInput_Praise_2 = (Avril_NNAI.Input_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(2);
                    objNNAI.Create_REGISTERED_Inputs(new double[subsetOfInput_Praise_2.Get_NumberOfInputValues()]);
                    for (byte index = 0; index < subsetOfInput_Praise_2.Get_NumberOfInputValues(); index++)
                    {
                        subsetOfInput_Praise_2.Set_Item_Of_Input_Praise(index, 0.0);
                    }
                    break;

                default:
                    break;
            }
        }
        public void Generate_REGISTERED_Outputs_List(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong praiseID)
        {
            switch (praiseID)
            {
                case (ulong)Global.PraiseID.Praise_0:
                    Avril_NNAI.Output_Praise_0 subsetOfOutput_Praise_0 = (Avril_NNAI.Output_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(0);
                    objNNAI.Create_REGISTERED_Outputs(new double[subsetOfOutput_Praise_0.Get_NumberOfOutputValues()]);
                    for (byte index = 0; index < subsetOfOutput_Praise_0.Get_NumberOfOutputValues(); index++)
                    {
                        subsetOfOutput_Praise_0.Set_Item_Of_Output_Praise(index, 0.0);
                    }
                    break;

                case (ulong)Global.PraiseID.Praise_1:
                    Avril_NNAI.Output_Praise_1 subsetOfOutput_Praise_1 = (Avril_NNAI.Output_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(1);
                    objNNAI.Create_REGISTERED_Outputs(new double[subsetOfOutput_Praise_1.Get_NumberOfOutputValues()]);
                    for (byte index = 0; index < subsetOfOutput_Praise_1.Get_NumberOfOutputValues(); index++)
                    {
                        subsetOfOutput_Praise_1.Set_Item_Of_Output_Praise(index, 0.0);
                    }
                    break;

                case (ulong)Global.PraiseID.Praise_2:
                    Avril_NNAI.Output_Praise_2 subsetOfOutput_Praise_2 = (Avril_NNAI.Output_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(2);
                    objNNAI.Create_REGISTERED_Outputs(new double[subsetOfOutput_Praise_2.Get_NumberOfOutputValues()]);
                    for (byte index = 0; index < subsetOfOutput_Praise_2.Get_NumberOfOutputValues(); index++)
                    {
                        subsetOfOutput_Praise_2.Set_Item_Of_Output_Praise(index, 0.0);
                    }
                    break;

                default:
                    break;
            }
        }

    // get.
        public Avril_NNAI.Linear Get_New_Linear()
        {
            return _New_Linear;
        }
    // set.

// private.
        private void Create_New_Linear(Avril_NNAI.Linear linear)
        {
            _New_Linear = linear;
        }
    // get.

    // set.
    }
}

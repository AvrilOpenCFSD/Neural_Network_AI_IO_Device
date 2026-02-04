
using System;

namespace Avril_NNAI
{
    public class NeuralPath
    {
// definitionns.
        private enum NodeLayer : byte
        {
            Layer_4 = 4,
            Layer_3 = 3,
            Layer_2 = 2,
            Layer_1 = 1,
            Layer_0 = 0,
        }
        private enum PraiseID : ulong
        {
            Praise_0 = 0,
            Praise_1 = 1,
            Praise_2 = 2
        }

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
        public void Calculate_Neural_Network_Parameters(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong praiseID)
        {
            Calculate_NumberOfPraiseInputValues(obj, objNNAI, praiseID);
            System.Console.WriteLine("NumberOfPraiseInputValues = " + objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues());

            Calculate_NumberOfPraiseOutputValues(obj, objNNAI, praiseID);
            System.Console.WriteLine("NumberOfPraiseOutputValues = " + objNNAI.Get_MetaData().Get_NumberOfPraiseOutputValues());


        }


    // get.
        public Avril_NNAI.Linear Get_New_Linear()
        {
            return _New_Linear;
        }

// set.
        public void Set_Layer_Nodes(Avril_NNAI.MachineAI objNNAI, byte outputID, byte layerID)
        {
            var newEmptyNode = new Avril_NNAI.Node();
            while (newEmptyNode == null) { }

            switch (layerID)
            {
                case (byte)NodeLayer.Layer_4:
                    objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer4_Nodes(objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                    break;

                case (byte)NodeLayer.Layer_3:
                    objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer3_Nodes(objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                    break;

                case (byte)NodeLayer.Layer_2:
                    objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer2_Nodes(objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                    break;

                case (byte)NodeLayer.Layer_1:
                    objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer1_Nodes(objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                    break;

                case (byte)NodeLayer.Layer_0:
                    objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Create_Layer0_Node(newEmptyNode);
                    break;
            }
        }
        public void Set_Neural_Path_For_Input(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, byte outputID, byte layerID, ulong nodeID)
        {
            System.Console.WriteLine("entered Create_Nodes.");

            var newLinearPath = new Avril_NNAI.Linear();
            while (newLinearPath == null) { }

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

            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Set_NumberOfInputs(numberOfInputsForNode);

            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Create_List_Of_NeuralPathOfNodeInputs(new Avril_NNAI.Linear[objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_NumberOfInputs()]);
            for (ulong inputID = 0; inputID < objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_NumberOfInputs(); inputID++)
            {
                objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Set_NeuralPathOfInput_SubSet(inputID, newLinearPath);
                objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_NeuralPathOfInput_SubSet(inputID).Set_Weight(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_Random_Small_Value(-0.5, 0.5));
                objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_NeuralPathOfInput_SubSet(inputID).Set_Bias(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_Random_Small_Value(-0.5, 0.5));
                System.Console.WriteLine("outputID = " + outputID + "  layerID = " + layerID + "  nodeID = " + nodeID + "  inputID = " + inputID + "  bias = " + objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_NeuralPathOfInput_SubSet(inputID).Get_Bias() + "  weight = " + objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_Node(layerID, nodeID).Get_NeuralPathOfInput_SubSet(inputID).Get_Weight());
            }
            System.Console.WriteLine("exiting Create_Nodes.");
        }
        public void Set_NumberOfNodesInHiddenLayer(Avril_NNAI.MachineAI objNNAI, byte outputID, byte layerID)
        {
            ulong numberOfNodesInLayer = new ulong();
            numberOfNodesInLayer = 0;
            switch (layerID)
            {
                case (byte)NodeLayer.Layer_4:
                    numberOfNodesInLayer = (ulong)Math.Round((double)objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues() * (double)0.8);
                    break;

                case (byte)NodeLayer.Layer_3:
                    numberOfNodesInLayer = (ulong)Math.Round((double)objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues() * (double)0.6);
                    break;

                case (byte)NodeLayer.Layer_2:
                    numberOfNodesInLayer = (ulong)Math.Round((double)objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues() * (double)0.4);
                    break;

                case (byte)NodeLayer.Layer_1:
                    numberOfNodesInLayer = (ulong)Math.Round((double)objNNAI.Get_MetaData().Get_NumberOfPraiseInputValues() * (double)0.2);
                    break;

                case (byte)NodeLayer.Layer_0:
                    numberOfNodesInLayer = (ulong)1;
                    break;
            }
            System.Console.WriteLine("numberOfNodesInLayer = " + numberOfNodesInLayer);
            objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Set_NumberOfNodesInHiddenLayer(layerID, numberOfNodesInLayer);
            System.Console.WriteLine("outputID = " + outputID + "(layerID == " + layerID + ") Set_NumberOfNodesInLayer = " + objNNAI.Get_Item_On_List_Of_PraiseSets(outputID).Get_NumberOfNodesInHiddenLayer(layerID));
        }
        
// private.
        

        private void Create_New_Linear(Avril_NNAI.Linear linear)
        {
            _New_Linear = linear;
        }
        public void Create_Node_Tree_Output_Sets(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, byte numberOfPraiseOutputValues)
        {
            var newPraiseSet = new Avril_NNAI.PraiseSet();

            objNNAI.Create_PraiseSet(new Avril_NNAI.PraiseSet[numberOfPraiseOutputValues]);
            for (byte outputTree = 0; outputTree < numberOfPraiseOutputValues; outputTree++)
            {
                objNNAI.Set_Item_On_List_Of_PraiseSets(outputTree, newPraiseSet);
            }
        }
        public void Create_PraiseSet(Avril_NNAI.MachineAI objNNAI, Avril_NNAI.PraiseSet[] value)
        {
            objNNAI.Create_PraiseSet(value);
        }

        private void Calculate_NumberOfPraiseInputValues(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong praiseID)
        {
            switch (praiseID)
            {
                case (ulong)PraiseID.Praise_0:
                    Avril_NNAI.Input_Praise_0 objValue_Praise0 = (Avril_NNAI.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(0);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(objValue_Praise0.Get_NumberOfInputValues());
                    break;

                case (ulong)PraiseID.Praise_1:
                    Avril_NNAI.Input_Praise_1 objValue_Praise1 = (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(1);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(objValue_Praise1.Get_NumberOfInputValues());
                    break;

                case (ulong)PraiseID.Praise_2:
                    Avril_NNAI.Input_Praise_2 objValue_Praise2 = (Avril_NNAI.Input_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(2);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(objValue_Praise2.Get_NumberOfInputValues());
                    break;
            }
        }
        private void Calculate_NumberOfPraiseOutputValues(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong praiseID)
        {
            switch (praiseID)
            {
                case (ulong)PraiseID.Praise_0:
                    var objValue_Praise0 = (Avril_NNAI.Output_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(0);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseOutputValues(objValue_Praise0.Get_NumberOfOutputValues());
                    break;

                case (ulong)PraiseID.Praise_1:
                    var objValue_Praise1 = (Avril_NNAI.Output_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(1);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseOutputValues(objValue_Praise1.Get_NumberOfOutputValues());
                    break;

                case (ulong)PraiseID.Praise_2:
                    var objValue_Praise2 = (Avril_NNAI.Output_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(2);
                    objNNAI.Get_MetaData().Set_NumberOfPraiseOutputValues(objValue_Praise2.Get_NumberOfOutputValues());
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
                case (ulong)PraiseID.Praise_0:
                    Avril_NNAI.Input_Praise_0 subsetOfInput_Praise_0 = (Avril_NNAI.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(0);
                    objNNAI.Create_REGISTERED_Inputs(new double[subsetOfInput_Praise_0.Get_NumberOfInputValues()]);
                    for (byte index = 0; index < subsetOfInput_Praise_0.Get_NumberOfInputValues(); index++)
                    {
                        subsetOfInput_Praise_0.Set_Item_Of_Input_Praise(index, 0.0);
                    }
                    break;

                case (ulong)PraiseID.Praise_1:
                    Avril_NNAI.Input_Praise_1 subsetOfInput_Praise_1 = (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(1);
                    objNNAI.Create_REGISTERED_Inputs(new double[subsetOfInput_Praise_1.Get_NumberOfInputValues()]);
                    for (byte index = 0; index < subsetOfInput_Praise_1.Get_NumberOfInputValues(); index++)
                    {
                        subsetOfInput_Praise_1.Set_Item_Of_Input_Praise(index, 0.0);
                    }
                    break;

                case (ulong)PraiseID.Praise_2:
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
                case (ulong)PraiseID.Praise_0:
                    Avril_NNAI.Output_Praise_0 subsetOfOutput_Praise_0 = (Avril_NNAI.Output_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(0);
                    objNNAI.Create_REGISTERED_Outputs(new double[subsetOfOutput_Praise_0.Get_NumberOfOutputValues()]);
                    for (byte index = 0; index < subsetOfOutput_Praise_0.Get_NumberOfOutputValues(); index++)
                    {
                        subsetOfOutput_Praise_0.Set_Item_Of_Output_Praise(index, 0.0);
                    }
                    break;

                case (ulong)PraiseID.Praise_1:
                    Avril_NNAI.Output_Praise_1 subsetOfOutput_Praise_1 = (Avril_NNAI.Output_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Output().Get_ItemOnListOfOutputSubsets(1);
                    objNNAI.Create_REGISTERED_Outputs(new double[subsetOfOutput_Praise_1.Get_NumberOfOutputValues()]);
                    for (byte index = 0; index < subsetOfOutput_Praise_1.Get_NumberOfOutputValues(); index++)
                    {
                        subsetOfOutput_Praise_1.Set_Item_Of_Output_Praise(index, 0.0);
                    }
                    break;

                case (ulong)PraiseID.Praise_2:
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

    // set.
    }
}

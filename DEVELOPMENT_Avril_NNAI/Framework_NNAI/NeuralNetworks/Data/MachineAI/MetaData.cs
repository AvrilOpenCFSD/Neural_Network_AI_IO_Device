
using System;
using System.ComponentModel;
using System.Numerics;

namespace Avril_NNAI
{
    public class MetaData
    {
        // classes.

        // registers.
        private enum IO_Layers : byte
        {
            output = (byte)1,
            input = (byte)0,
        }
        private enum NodeLayer : byte
        {
            Layer_4 = (byte)4,
            Layer_3 = (byte)3,
            Layer_2 = (byte)2,
            Layer_1 = (byte)1,
            Layer_0 = (byte)0,
        }
        private enum PraiseID : ulong
        {
            Praise_0 = (ulong)0,
            Praise_1 = (ulong)1,
            Praise_2 = (ulong)2
        }
        Avril_NNAI.Node[] _Layer4_Nodes;
        Avril_NNAI.Node[] _Layer3_Nodes;
        Avril_NNAI.Node[] _Layer2_Nodes;
        Avril_NNAI.Node[] _Layer1_Nodes;
        Avril_NNAI.Node _Layer0_Node;
        ulong[] _NumberOfNodesInLayer;
        ulong _NumberOfPraises;
        ulong _NumberOfPraiseInputValues;
        double[] _REGISTERED_Inputs;
        double _REGISTERED_Output;

        // constructor.
        public MetaData()
        {
            //System.Console.WriteLine("entered MetaData.");

            Avril_NNAI.Node newEmpty = new Avril_NNAI.Node();
            while (newEmpty == null) { }

            Create_NumberOfNodesInLayer(new ulong[5]);
            Set_NumberOfNodesInHiddenLayer(4, 5);
            Set_NumberOfNodesInHiddenLayer(3, 4);
            Set_NumberOfNodesInHiddenLayer(2, 3);
            Set_NumberOfNodesInHiddenLayer(1, 2);
            Set_NumberOfNodesInHiddenLayer(0, 1);

            Create_Layer4_Nodes(5, new Avril_NNAI.Node());
            while (Get_Layer4_Node(0) == null) { }
            Set_Layer4_Nodes(0, newEmpty);

            Create_Layer3_Nodes(4, new Avril_NNAI.Node());
            while (Get_Layer3_Nodes() == null) { }
            Set_Layer3_Nodes(0, newEmpty);

            Create_Layer2_Nodes(3, new Avril_NNAI.Node());
            while (Get_Layer2_Nodes() == null) { }
            Set_Layer2_Nodes(0, newEmpty);

            Create_Layer1_Nodes(2, new Avril_NNAI.Node());
            while (Get_Layer1_Nodes() == null) { }
            Set_Layer1_Nodes(0, newEmpty);

            Create_Layer0_Node(new Avril_NNAI.Node());
            while (Get_Layer0_Node() == null) { }
            Set_Layer0_Node(newEmpty);

            Create_NumberOfPraises(new ulong());
            Set_NumberOfPraises(0);

            Create_NumberOfPraiseInputValues(new ulong());
            Set_NumberOfPraiseInputValues(2);

            Create_REGISTERED_Inputs(new double[1]);
            Set_REGISTERED_Inputs(0, 0.0);

            Create_REGISTERED_Output(new double());
            Set_REGISTERED_Output(0.0);
        }

        // destructor.
        ~MetaData()
        {

        }

        // public.
        public void Create_Nodes(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong numberOfPraiseInputValues)
        {
            System.Console.WriteLine("entered Create_Nodes.");

            objNNAI.Get_MetaData().Create_REGISTERED_Inputs(new double[numberOfPraiseInputValues]);
            for (ulong inputID = 0; inputID < numberOfPraiseInputValues; inputID++)
            {
                objNNAI.Get_MetaData().Set_REGISTERED_Inputs(inputID, 0.0);
            }

            //numberOfNodesInLayer = 1;
            objNNAI.Get_MetaData().Create_REGISTERED_Output(new double());
            objNNAI.Get_MetaData().Set_REGISTERED_Output(0.0);

            ulong numberOfNodesInLayer = new ulong();

            double temp = new double();
            
            for (byte layerID = 4; layerID < 5; layerID--)
            {
                numberOfNodesInLayer = 0;
                temp = 0.0;
                switch (layerID)
                {
                    case (byte)NodeLayer.Layer_4:
                        temp = (double)4 / (double)5;
                        temp = ((double)numberOfPraiseInputValues * (double)temp);
                        numberOfNodesInLayer = (ulong)Math.Round(temp);
                        break;

                    case (byte)NodeLayer.Layer_3:
                        temp = (double)3 / (double)5;
                        temp = ((double)numberOfPraiseInputValues * (double)temp);
                        numberOfNodesInLayer = (ulong)Math.Round(temp);
                        break;

                    case (byte)NodeLayer.Layer_2:
                        temp = (double)2 / (double)5;
                        temp = ((double)numberOfPraiseInputValues * (double)temp);
                        numberOfNodesInLayer = (ulong)Math.Round(temp);
                        break;

                    case (byte)NodeLayer.Layer_1:
                        temp = (double)1 / (double)5;
                        temp = ((double)numberOfPraiseInputValues * (double)temp);
                        numberOfNodesInLayer = (ulong)Math.Round(temp);
                        break;

                    case (byte)NodeLayer.Layer_0:
                        numberOfNodesInLayer = (ulong)1;
                        break;

                    default:
                        break;
                }
                objNNAI.Get_MetaData().Set_NumberOfNodesInHiddenLayer(layerID, numberOfNodesInLayer);
                System.Console.WriteLine("(layerID == " + layerID + ") Set_NumberOfNodesInLayer = " + objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID));


            }

            var newEmptyNode = new Avril_NNAI.Node();
            while (newEmptyNode == null) { }

            var newLinearPath = new Avril_NNAI.Linear();
            while (newLinearPath == null) { }

            for (byte layerID = 4; layerID < 5; layerID--)
            {
                switch (layerID)
                {
                    case (byte)NodeLayer.Layer_4:
                        objNNAI.Get_MetaData().Create_Layer4_Nodes(objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                        break;

                    case (byte)NodeLayer.Layer_3:
                        objNNAI.Get_MetaData().Create_Layer3_Nodes(objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                        break;

                    case (byte)NodeLayer.Layer_2:
                        objNNAI.Get_MetaData().Create_Layer2_Nodes(objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                        break;

                    case (byte)NodeLayer.Layer_1:
                        objNNAI.Get_MetaData().Create_Layer1_Nodes(objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID), newEmptyNode);
                        break;

                    case (byte)NodeLayer.Layer_0:
                        objNNAI.Get_MetaData().Create_Layer0_Node(newEmptyNode);
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
                    numberOfInputsForNode = objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer((byte)(layerID + (byte)1));
                }
                for (ulong nodeID = 0; nodeID < objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID); nodeID++)
                {
                    objNNAI.Get_MetaData().Get_Node(layerID, nodeID).Set_NumberOfInputs(numberOfInputsForNode);
                }

                for (ulong nodeID = 0; nodeID < objNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID); nodeID++)
                {
                    objNNAI.Get_MetaData().Get_Node(layerID, nodeID).Create_List_Of_NeuralPathOfNodeInputs(new Avril_NNAI.Linear[objNNAI.Get_MetaData().Get_Node(layerID, nodeID).Get_NumberOfInputs()]);
                    for (ulong inputID = 0; inputID < objNNAI.Get_MetaData().Get_Node(layerID, nodeID).Get_NumberOfInputs(); inputID++)
                    {
                        System.Console.WriteLine("layerID = " + layerID + "  nodeID = " + nodeID + "  inputID = " + inputID);
                        objNNAI.Get_MetaData().Get_Node(layerID, nodeID).Set_NeuralPathOfInput_SubSet(inputID, newLinearPath);
                    }
                }
            }
            System.Console.WriteLine("exiting Create_Nodes.");
        }

        public void Calculate_NumberOfPraiseInputValues(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong[] praiseID)
        {
            objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(0);
            for (ulong index = 0; index < (ulong)praiseID.LongLength; index++)
            {
                switch (praiseID[index])
                {
                    case 0:
                        var objValue_Praise0 = (Avril_NNAI.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(0);
                        objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(_NumberOfPraiseInputValues + objValue_Praise0.Get_NumberOfInputValues());
                        break;

                    case 1:
                        var objValue_Praise1 = (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(1);
                        objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(_NumberOfPraiseInputValues + objValue_Praise1.Get_NumberOfInputValues());
                        break;

                    case 2:
                        var objValue_Praise2 = (Avril_NNAI.Input_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(2);
                        objNNAI.Get_MetaData().Set_NumberOfPraiseInputValues(_NumberOfPraiseInputValues + objValue_Praise2.Get_NumberOfInputValues());
                        break;
                    default:
                        break;
                }
            }
        }

        public void Generate_REGISTERED_Inputs_List(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI objNNAI, ulong[] praiseID)
        {
            for (ulong index_A = 0; index_A < (ulong)praiseID.LongLength; index_A++)
            {
                switch (praiseID[index_A])
                {
                    case (ulong)PraiseID.Praise_0:
                        Avril_NNAI.Input_Praise_0 subsetOfInput_Praise_0 = (Avril_NNAI.Input_Praise_0)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(0);
                        objNNAI.Get_MetaData().Create_REGISTERED_Inputs(new double[subsetOfInput_Praise_0.Get_NumberOfInputValues()]);
                        for (byte index = 0; index < subsetOfInput_Praise_0.Get_NumberOfInputValues(); index++)
                        {
                            subsetOfInput_Praise_0.Set_Item_Of_Input_Praise(index, 0.0);
                        }
                        break;

                    case (ulong)PraiseID.Praise_1:
                        Avril_NNAI.Input_Praise_1 subsetOfInput_Praise_1 = (Avril_NNAI.Input_Praise_1)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(1);
                        objNNAI.Get_MetaData().Create_REGISTERED_Inputs(new double[subsetOfInput_Praise_1.Get_NumberOfInputValues()]);
                        for (byte index = 0; index < subsetOfInput_Praise_1.Get_NumberOfInputValues(); index++)
                        {
                            subsetOfInput_Praise_1.Set_Item_Of_Input_Praise(index, 0.0);
                        }
                        break;

                    case (ulong)PraiseID.Praise_2:
                        Avril_NNAI.Input_Praise_2 subsetOfInput_Praise_2 = (Avril_NNAI.Input_Praise_2)obj.Get_Neural_Networks().Get_Data().Get_Input().Get_ItemOnListOfInputSubsets(2);
                        objNNAI.Get_MetaData().Create_REGISTERED_Inputs(new double[subsetOfInput_Praise_2.Get_NumberOfInputValues()]);
                        for (byte index = 0; index < subsetOfInput_Praise_2.Get_NumberOfInputValues(); index++)
                        {
                            subsetOfInput_Praise_2.Set_Item_Of_Input_Praise(index, 0.0);
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        public void Initialise_Node_WEIGHT_and_BIAS(Avril_NNAI.Framework_NNAI obj, Avril_NNAI.MachineAI _AvrilNNAI)
        {
            ulong numberOfInputs = 0;
            System.Console.WriteLine("entered Initialise_Node_WEIGHT_and_BIAS.");
            for (byte layerID = 4; layerID < 5; layerID--)
            {
                for (ulong nodeID = 0; nodeID < _AvrilNNAI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(layerID); nodeID++)
                {
                    numberOfInputs = _AvrilNNAI.Get_MetaData().Get_Node(layerID, nodeID).Get_NumberOfInputs();
                    for (ulong inputValuID = 0; inputValuID < numberOfInputs; inputValuID++)
                    {
                        System.Console.WriteLine("layerID = " + layerID + "  nodeID = " + nodeID + "  inputValuID = " + inputValuID);
                        _AvrilNNAI.Get_MetaData().Get_Node(layerID, nodeID).Get_NeuralPathOfInput_SubSet(inputValuID).Set_Weight(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_Random_Small_Value(-0.5, 0.5));
                        _AvrilNNAI.Get_MetaData().Get_Node(layerID, nodeID).Get_NeuralPathOfInput_SubSet(inputValuID).Set_Bias(obj.Get_Neural_Networks().Get_Aglorithms().Get_NeuralPath().Generate_Initial_Random_Small_Value(-0.5, 0.5));
                    }
                }
            }
            System.Console.WriteLine("exiting Initialise_Node_WEIGHT_and_BIAS.");
        }

    // get.
        public Avril_NNAI.Node Get_Node(byte layer, ulong nodeID)
        {
            switch (layer)
            {
                case (byte)NodeLayer.Layer_4:
                    return Get_Layer4_Node(nodeID);

                case (byte)NodeLayer.Layer_3:
                    return Get_Layer3_Node(nodeID);

                case (byte)NodeLayer.Layer_2:
                    return Get_Layer2_Node(nodeID);

                case (byte)NodeLayer.Layer_1:
                    return Get_Layer1_Node(nodeID);

                case (byte)NodeLayer.Layer_0:
                    return Get_Layer0_Node();

                default:
                    return null;
            }
        }
        public ulong Get_NumberOfNodesInHiddenLayer(byte hiddenLayerID)
        {
            return _NumberOfNodesInLayer[hiddenLayerID];
        }
        public ulong Get_NumberOfPraises()
        {
            return _NumberOfPraises;
        }
        public ulong Get_NumberOfPraiseInputValues()
        {
            return _NumberOfPraiseInputValues;
        }
        public double[] Get_List_Of_REGISTERED_Inputs()
        {
            return _REGISTERED_Inputs;
        }
        public double Get_REGISTERED_Output()
        {
            return _REGISTERED_Output;
        }

    // set.
        public void Set_Node(byte layerID, ulong nodeID, Avril_NNAI.Node node)
        {
            switch (layerID)
            {
                case (byte)NodeLayer.Layer_4:
                    Set_Layer4_Nodes(nodeID, node);
                    break;

                case (byte)NodeLayer.Layer_3:
                    Set_Layer3_Nodes(nodeID, node);
                    break;

                case (byte)NodeLayer.Layer_2:
                    Set_Layer2_Nodes(nodeID, node);
                    break;

                case (byte)NodeLayer.Layer_1:
                    Set_Layer1_Nodes(nodeID, node);
                    break;

                case (byte)NodeLayer.Layer_0:
                    Set_Layer0_Node(node);
                    break;

                default:
                    break;
            }
        }
        public void Set_NumberOfPraises(ulong numberOfPraiseInputs)
        {
            _NumberOfPraises = numberOfPraiseInputs;
        }

// private.
        private void Create_Layer4_Nodes(ulong numberOfNodes, Avril_NNAI.Node newEmpty_Node)
        {
            _Layer4_Nodes = new Avril_NNAI.Node[numberOfNodes];
            for (ulong index = 0; index < numberOfNodes; index++)
            {
                _Layer4_Nodes[index] = newEmpty_Node;
            }
        }
        private void Create_Layer3_Nodes(ulong numberOfNodes, Avril_NNAI.Node newEmpty_Node)
        {
            _Layer3_Nodes = new Avril_NNAI.Node[numberOfNodes];
            for (ulong index = 0; index < numberOfNodes; index++)
            {
                _Layer3_Nodes[index] = newEmpty_Node;
            }
        }
        private void Create_Layer2_Nodes(ulong numberOfNodes, Avril_NNAI.Node newEmpty_Node)
        {
            _Layer2_Nodes = new Avril_NNAI.Node[numberOfNodes];
            for (ulong index = 0; index < numberOfNodes; index++)
            {
                _Layer2_Nodes[index] = newEmpty_Node;
            }
        }
        private void Create_Layer1_Nodes(ulong numberOfNodes, Avril_NNAI.Node newEmpty_Node)
        {
            _Layer1_Nodes = new Avril_NNAI.Node[numberOfNodes];
            for (ulong index = 0; index < numberOfNodes; index++)
            {
                _Layer1_Nodes[index] = newEmpty_Node;
            }
        }
        private void Create_Layer0_Node(Avril_NNAI.Node newEmpty_Node)
        {
            _Layer0_Node = newEmpty_Node;
        }
        private void Create_NumberOfNodesInLayer(ulong[] numberOfNodeInLayer)
        {
            _NumberOfNodesInLayer = numberOfNodeInLayer;
        }
        private void Create_NumberOfPraises(ulong value)
        {
            _NumberOfPraises = value;
        }
        private void Create_NumberOfPraiseInputValues(ulong value)
        {
            _NumberOfPraiseInputValues = value;
        }
        private void Create_REGISTERED_Inputs(double[] value)
        {
            _REGISTERED_Inputs = value;
        }
        private void Create_REGISTERED_Output(double value)
        {
            _REGISTERED_Output = value;
        }

    // get.
        private Avril_NNAI.Node Get_Layer4_Node(ulong nodeID)
        {
            return _Layer4_Nodes[nodeID];
        }
        private Avril_NNAI.Node[] Get_Layer4_Nodes()
        {
            return _Layer4_Nodes;
        }
        private Avril_NNAI.Node Get_Layer3_Node(ulong nodeID)
        {
            return _Layer3_Nodes[nodeID];
        }
        private Avril_NNAI.Node[] Get_Layer3_Nodes()
        {
            return _Layer3_Nodes;
        }
        private Avril_NNAI.Node Get_Layer2_Node(ulong nodeID)
        {
            return _Layer2_Nodes[nodeID];
        }
        private Avril_NNAI.Node[] Get_Layer2_Nodes()
        {
            return _Layer2_Nodes;
        }
        private Avril_NNAI.Node Get_Layer1_Node(ulong nodeID)
        {
            return _Layer1_Nodes[nodeID];
        }
        private Avril_NNAI.Node[] Get_Layer1_Nodes()
        {
            return _Layer1_Nodes;
        }
        private Avril_NNAI.Node Get_Layer0_Node()
        {
            return _Layer0_Node;
        }
        private ulong[] Get_List_Of_NumberOfNodesInLayer()
        {
            return _NumberOfNodesInLayer;
        }
        private void Get_NumberOfPraises(ulong numberOfPraiseInputs)
        {
            _NumberOfPraises = numberOfPraiseInputs;
        }
        private void Get_NumberOfPraiseInputValues(ulong numberOfPraiseInputValues)
        {
            _NumberOfPraiseInputValues = numberOfPraiseInputValues;
        }
        private double Get_REGISTERED_Inputs(ulong registerID)
        {
            return _REGISTERED_Inputs[registerID];
        }
        private void Get_REGISTERED_Output(double value)
        {
            _REGISTERED_Output = value;
        }

    // set.
        private void Set_Layer4_Nodes(ulong nodeID, Avril_NNAI.Node node)
        {
            _Layer4_Nodes[nodeID] = node;
        }
        private void Set_Layer3_Nodes(ulong nodeID, Avril_NNAI.Node node)
        {
            _Layer3_Nodes[nodeID] = node;
        }
        private void Set_Layer2_Nodes(ulong nodeID, Avril_NNAI.Node node)
        {
            _Layer2_Nodes[nodeID] = node;
        }
        private void Set_Layer1_Nodes(ulong nodeID, Avril_NNAI.Node node)
        {
            _Layer1_Nodes[nodeID] = node;
        }
        private void Set_Layer0_Node(Avril_NNAI.Node node)
        {
            _Layer0_Node = node;
        }
        private void Set_NumberOfNodesInHiddenLayer(byte layerID, ulong numberOfNodes)
        {
            _NumberOfNodesInLayer[layerID] = numberOfNodes;
        }
        private void Set_NumberOfPraiseInputValues(ulong numberOfPraiseInputValues)
        {
            _NumberOfPraiseInputValues = numberOfPraiseInputValues;
        }
        private void Set_REGISTERED_Inputs(ulong registerID, double value)
        {
            _REGISTERED_Inputs[registerID] = value;
        }
        private void Set_REGISTERED_Output(double value)
        {
            _REGISTERED_Output = value;
        }
    }
}
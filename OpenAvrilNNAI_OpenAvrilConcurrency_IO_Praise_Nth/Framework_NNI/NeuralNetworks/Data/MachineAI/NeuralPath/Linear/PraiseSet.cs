
namespace OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth
{
    public class PraiseSet
    {
// definitions.

// classes.

// registers.
        private Node[] _List_Of_Nodes_In_Layer4;
        private Node[] _List_Of_Nodes_In_Layer3;
        private Node[] _List_Of_Nodes_In_Layer2;
        private Node[] _List_Of_Nodes_In_Layer1;
        private Node _Node_In_Layer0;

// constructor.
        public PraiseSet()
        {
            //System.Console.WriteLine("entered MetaData.");
            Create_List_Of_Nodes_In_Layer4(5);
            Create_List_Of_Nodes_In_Layer3(4);
            Create_List_Of_Nodes_In_Layer2(3);
            Create_List_Of_Nodes_In_Layer1(2);
            Create_Node_In_Layer0();
        }

// destructor.
        ~PraiseSet()
        {

        }

// public.
        public void Create_Tree_Of_Nodes(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.MachineAI objNNI, byte outputID)
        {
            objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Create_List_Of_Nodes_In_Layer4(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(4));
            objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Create_List_Of_Nodes_In_Layer3(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(3));
            objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Create_List_Of_Nodes_In_Layer2(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(2));
            objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Create_List_Of_Nodes_In_Layer1(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(1));
            objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Create_Node_In_Layer0();
        }
    // get.
        public Node Get_Node(byte layer, byte nodeID)
        {
            switch (layer)
            {
                case (byte)Global.NodeLayer.Layer_4:
                    return Get_Item_On_List_Of_Nodes_For_Layer_4(nodeID);

                case (byte)Global.NodeLayer.Layer_3:
                    return Get_Item_On_List_Of_Nodes_For_Layer_3(nodeID);

                case (byte)Global.NodeLayer.Layer_2:
                    return Get_Item_On_List_Of_Nodes_For_Layer_2(nodeID);

                case (byte)Global.NodeLayer.Layer_1:
                    return Get_Item_On_List_Of_Nodes_For_Layer_1(nodeID);

                case (byte)Global.NodeLayer.Layer_0:
                    return Get_Node_In_Layer_0();

                default:
                    return null;
            }
        }
    // set.
        public void Set_Node(byte layerID, byte nodeID, Node node)
        {
            switch (layerID)
            {
                case (byte)Global.NodeLayer.Layer_4:
                    Set_Item_On_List_Of_Nodes_In_Layer_4(nodeID, node);
                    break;

                case (byte)Global.NodeLayer.Layer_3:
                    Set_Item_On_List_Of_Nodes_In_Layer_3(nodeID, node);
                    break;

                case (byte)Global.NodeLayer.Layer_2:
                    Set_Item_On_List_Of_Nodes_In_Layer_2(nodeID, node);
                    break;

                case (byte)Global.NodeLayer.Layer_1:
                    Set_Item_On_List_Of_Nodes_In_Layer_1(nodeID, node);
                    break;

                case (byte)Global.NodeLayer.Layer_0:
                    Set_Node_In_Layer_0(node);
                    break;

                default:
                    break;
            }
        }

// private.
        private void Create_List_Of_Nodes_In_Layer4(byte numberOfNodes)
        {
            Set_List_Of_Nodes_In_Layer_4(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Node[numberOfNodes]);
            while (Get_List_Of_Nodes_For_Layer_4() == null) { }
            for (byte index = 0; index < numberOfNodes; index++)
            {
                Set_Item_On_List_Of_Nodes_In_Layer_4(index, new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Node());
                while (Get_Item_On_List_Of_Nodes_For_Layer_4(index) == null) { }
            }
        }
        private void Create_List_Of_Nodes_In_Layer3(byte numberOfNodes)
        {
            Set_List_Of_Nodes_In_Layer_3(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Node[numberOfNodes]);
            while (Get_List_Of_Nodes_For_Layer_3() == null) { }
            for (byte index = 0; index < numberOfNodes; index++)
            {
                Set_Item_On_List_Of_Nodes_In_Layer_3(index, new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Node());
                while (Get_Item_On_List_Of_Nodes_For_Layer_3(index) == null) { }
            }
        }
        private void Create_List_Of_Nodes_In_Layer2(byte numberOfNodes)
        {
            Set_List_Of_Nodes_In_Layer_2(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Node[numberOfNodes]);
            while (Get_List_Of_Nodes_For_Layer_2() == null) { }
            for (byte index = 0; index < numberOfNodes; index++)
            {
                Set_Item_On_List_Of_Nodes_In_Layer_2(index, new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Node());
                while (Get_Item_On_List_Of_Nodes_For_Layer_2(index) == null) { }
            }
        }
        private void Create_List_Of_Nodes_In_Layer1(byte numberOfNodes)
        {
            Set_List_Of_Nodes_In_Layer_1(new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Node[numberOfNodes]);
            while (Get_List_Of_Nodes_For_Layer_1() == null) { }
            for (byte index = 0; index < numberOfNodes; index++)
            {
                Set_Item_On_List_Of_Nodes_In_Layer_1(index, new OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Node());
                while (Get_Item_On_List_Of_Nodes_For_Layer_1(index) == null) { }
            }
        }
        private void Create_Node_In_Layer0()
        {
            Set_Node_In_Layer_0(new Node());
            while (Get_Node_In_Layer_0() == null) { }
        }
    // get.
        private Node Get_Item_On_List_Of_Nodes_For_Layer_4(byte nodeID)
        {
            return _List_Of_Nodes_In_Layer4[nodeID];
        }
        private Node Get_Item_On_List_Of_Nodes_For_Layer_3(byte nodeID)
        {
            return _List_Of_Nodes_In_Layer3[nodeID];
        }
        private Node Get_Item_On_List_Of_Nodes_For_Layer_2(byte nodeID)
        {
            return _List_Of_Nodes_In_Layer2[nodeID];
        }
        private Node Get_Item_On_List_Of_Nodes_For_Layer_1(byte nodeID)
        {
            return _List_Of_Nodes_In_Layer1[nodeID];
        }
        private Node[] Get_List_Of_Nodes_For_Layer_4()
        {
            return _List_Of_Nodes_In_Layer4;
        }

        private Node[] Get_List_Of_Nodes_For_Layer_3()
        {
            return _List_Of_Nodes_In_Layer4;
        }
  
        private Node[] Get_List_Of_Nodes_For_Layer_2()
        {
            return _List_Of_Nodes_In_Layer2;
        }

        private Node[] Get_List_Of_Nodes_For_Layer_1()
        {
            return _List_Of_Nodes_In_Layer1;
        }
        private Node Get_Node_In_Layer_0()
        {
            return _Node_In_Layer0;
        }
    // set.

        private void Set_Item_On_List_Of_Nodes_In_Layer_4(byte nodeID, Node node)
        {
            _List_Of_Nodes_In_Layer4[nodeID] = node;
        }
        private void Set_Item_On_List_Of_Nodes_In_Layer_3(byte nodeID, Node node)
        {
            _List_Of_Nodes_In_Layer3[nodeID] = node;
        }
        private void Set_Item_On_List_Of_Nodes_In_Layer_2(byte nodeID, Node node)
        {
            _List_Of_Nodes_In_Layer2[nodeID] = node;
        }
        private void Set_Item_On_List_Of_Nodes_In_Layer_1(byte nodeID, Node node)
        {
            _List_Of_Nodes_In_Layer1[nodeID] = node;
        }
        private void Set_List_Of_Nodes_In_Layer_4(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Node[] newList)
        {
            _List_Of_Nodes_In_Layer4 = newList;
        }
        private void Set_List_Of_Nodes_In_Layer_3(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Node[] newList)
        {
            _List_Of_Nodes_In_Layer3 = newList;
        }
        private void Set_List_Of_Nodes_In_Layer_2(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Node[] newList)
        {
            _List_Of_Nodes_In_Layer2 = newList;
        }
        private void Set_List_Of_Nodes_In_Layer_1(OpenAvrilNNAI_OpenAvrilConcurrency_IO_Praise_Nth.Node[] newList)
        {
            _List_Of_Nodes_In_Layer1 = newList;
        }
        private void Set_Node_In_Layer_0(Node node)
        {
            _Node_In_Layer0 = node;
        }
    }
}
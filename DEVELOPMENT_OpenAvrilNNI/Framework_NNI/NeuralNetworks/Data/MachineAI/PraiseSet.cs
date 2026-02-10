namespace OpenAvrilNNI
{
    public class PraiseSet
    {
        // definitions.

        // classes.

        // registers.
        private OpenAvrilNNI.Node[] _List_Of_Layer4_Nodes;
        private OpenAvrilNNI.Node[] _List_Of_Layer3_Nodes;
        private OpenAvrilNNI.Node[] _List_Of_Layer2_Nodes;
        private OpenAvrilNNI.Node[] _List_Of_Layer1_Nodes;
        private OpenAvrilNNI.Node _Layer0_Node;

        // constructor.
        public PraiseSet()
        {
            //System.Console.WriteLine("entered MetaData.");
            Create_List_Of_Layer4_Nodes(5);
            Create_List_Of_Layer3_Nodes(4);
            Create_List_Of_Layer2_Nodes(3);
            Create_List_Of_Layer1_Nodes(2);
            Create_Layer0_Node();
        }

        // destructor.
        ~PraiseSet()
        {

        }

// public.
        public void Create_Tree_Of_Nodes(OpenAvrilNNI.MachineAI objNNI, byte outputID)
        {
            objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Create_List_Of_Layer4_Nodes(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(4));
            objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Create_List_Of_Layer3_Nodes(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(3));
            objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Create_List_Of_Layer2_Nodes(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(2));
            objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Create_List_Of_Layer1_Nodes(objNNI.Get_MetaData().Get_NumberOfNodesInHiddenLayer(1));
            objNNI.Get_Item_On_List_Of_Linear_Paths(outputID).Get_PraiseSet().Create_Layer0_Node();
        }
    // get.
        public OpenAvrilNNI.Node Get_Node(byte layer, byte nodeID)
        {
            switch (layer)
            {
                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_4:
                    return Get_Item_On_List_Of_Layer4_Node(nodeID);

                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_3:
                    return Get_Item_On_List_Of_Layer3_Node(nodeID);

                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_2:
                    return Get_Item_On_List_Of_Layer2_Node(nodeID);

                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_1:
                    return Get_Item_On_List_Of_Layer1_Node(nodeID);

                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_0:
                    if (nodeID == 0) return Get_Layer0_Node();
                    else return null;

                default:
                    return null;
            }
        }
    // set.
        public void Set_Node(byte layerID, byte nodeID, OpenAvrilNNI.Node node)
        {
            switch (layerID)
            {
                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_4:
                    Set_Item_On_List_Of_Layer4_Node(nodeID, node);
                    break;

                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_3:
                    Set_Item_On_List_Of_Layer3_Node(nodeID, node);
                    break;

                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_2:
                    Set_Item_On_List_Of_Layer3_Node(nodeID, node);
                    break;

                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_1:
                    Set_Item_On_List_Of_Layer2_Node(nodeID, node);
                    break;

                case (byte)OpenAvrilNNI.Global.NodeLayer.Layer_0:
                    Set_Layer0_Node(node);
                    break;

                default:
                    break;
            }
        }

// private.
        private void Create_List_Of_Layer4_Nodes(byte numberOfNodes)
        {
            Set_List_Of_Layer4_Node(new OpenAvrilNNI.Node[numberOfNodes]);
            while (Get_List_Of_Layer4_Nodes() == null) { }
            for (byte index = 0; index < numberOfNodes; index++)
            {
                Set_Item_On_List_Of_Layer4_Node(index, new OpenAvrilNNI.Node());
                while (Get_Item_On_List_Of_Layer4_Node(index) == null) { }
            }
        }
        private void Create_List_Of_Layer3_Nodes(byte numberOfNodes)
        {
            Set_List_Of_Layer3_Node(new OpenAvrilNNI.Node[numberOfNodes]);
            while (Get_List_Of_Layer3_Nodes() == null) { }
            for (byte index = 0; index < numberOfNodes; index++)
            {
                Set_Item_On_List_Of_Layer3_Node(index, new OpenAvrilNNI.Node());
                while (Get_Item_On_List_Of_Layer3_Node(index) == null) { }
            }
        }
        private void Create_List_Of_Layer2_Nodes(byte numberOfNodes)
        {
            Set_List_Of_Layer2_Node(new OpenAvrilNNI.Node[numberOfNodes]);
            while (Get_List_Of_Layer2_Nodes() == null) { }
            for (byte index = 0; index < numberOfNodes; index++)
            {
                Set_Item_On_List_Of_Layer2_Node(index, new OpenAvrilNNI.Node());
                while (Get_Item_On_List_Of_Layer2_Node(index) == null) { }
            }
        }
        private void Create_List_Of_Layer1_Nodes(byte numberOfNodes)
        {
            Set_List_Of_Layer1_Node(new OpenAvrilNNI.Node[numberOfNodes]);
            while (Get_List_Of_Layer1_Nodes() == null) { }
            for (byte index = 0; index < numberOfNodes; index++)
            {
                Set_Item_On_List_Of_Layer1_Node(index, new OpenAvrilNNI.Node());
                while (Get_Item_On_List_Of_Layer1_Node(index) == null) { }
            }
        }
        private void Create_Layer0_Node()
        {
            Set_Layer0_Node(new OpenAvrilNNI.Node());
            while (Get_Layer0_Node() == null) { }
        }
    // get.
        private OpenAvrilNNI.Node Get_Item_On_List_Of_Layer4_Node(byte nodeID)
        {
            return _List_Of_Layer4_Nodes[nodeID];
        }
        private OpenAvrilNNI.Node Get_Item_On_List_Of_Layer3_Node(byte nodeID)
        {
            return _List_Of_Layer3_Nodes[nodeID];
        }
        private OpenAvrilNNI.Node Get_Item_On_List_Of_Layer2_Node(byte nodeID)
        {
            return _List_Of_Layer2_Nodes[nodeID];
        }
        private OpenAvrilNNI.Node Get_Item_On_List_Of_Layer1_Node(byte nodeID)
        {
            return _List_Of_Layer1_Nodes[nodeID];
        }
        private OpenAvrilNNI.Node Get_Layer0_Node()
        {
            return _Layer0_Node;
        }
        private OpenAvrilNNI.Node[] Get_List_Of_Layer4_Nodes()
        {
            return _List_Of_Layer4_Nodes;
        }
        private OpenAvrilNNI.Node[] Get_List_Of_Layer3_Nodes()
        {
            return _List_Of_Layer3_Nodes;
        }
        private OpenAvrilNNI.Node[] Get_List_Of_Layer2_Nodes()
        {
            return _List_Of_Layer2_Nodes;
        }
        private OpenAvrilNNI.Node[] Get_List_Of_Layer1_Nodes()
        {
            return _List_Of_Layer1_Nodes;
        }
    // set.
        private void Set_Item_On_List_Of_Layer4_Node(byte nodeID, OpenAvrilNNI.Node node)
        {
            _List_Of_Layer4_Nodes[nodeID] = node;
        }
        private void Set_Item_On_List_Of_Layer3_Node(byte nodeID, OpenAvrilNNI.Node node)
        {
            _List_Of_Layer3_Nodes[nodeID] = node;
        }
        private void Set_Item_On_List_Of_Layer2_Node(byte nodeID, OpenAvrilNNI.Node node)
        {
            _List_Of_Layer2_Nodes[nodeID] = node;
        }
        private void Set_Item_On_List_Of_Layer1_Node(byte nodeID, OpenAvrilNNI.Node node)
        {
            _List_Of_Layer1_Nodes[nodeID] = node;
        }
        private void Set_Layer0_Node(OpenAvrilNNI.Node node)
        {
            _Layer0_Node = node;
        }
        private void Set_List_Of_Layer4_Node(OpenAvrilNNI.Node[] newList)
        {
            _List_Of_Layer4_Nodes = newList;
        }
        private void Set_List_Of_Layer3_Node(OpenAvrilNNI.Node[] newList)
        {
            _List_Of_Layer3_Nodes = newList;
        }
        private void Set_List_Of_Layer2_Node(OpenAvrilNNI.Node[] newList)
        {
            _List_Of_Layer2_Nodes = newList;
        }
        private void Set_List_Of_Layer1_Node(OpenAvrilNNI.Node[] newList)
        {
            _List_Of_Layer1_Nodes = newList;
        }
    }
}
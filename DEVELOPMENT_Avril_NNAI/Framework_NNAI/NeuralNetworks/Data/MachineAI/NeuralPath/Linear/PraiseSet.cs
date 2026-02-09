
namespace OpenAvrilNNI
{
    public class PraiseSet
    {
// definitions.

// classes.

// registers.
        private Node[] _Layer4_Nodes;
        private Node[] _Layer3_Nodes;
        private Node[] _Layer2_Nodes;
        private Node[] _Layer1_Nodes;
        private Node _Layer0_Node;

// constructor.
        public PraiseSet()
        {
            //System.Console.WriteLine("entered MetaData.");

            Node newEmpty = new Node();
            while (newEmpty == null) { }

            Create_Layer4_Nodes(5, new Node());
            while (Get_Layer4_Nodes() == null) { }
            for (byte nodeID = 0; nodeID < 5; nodeID++)
            {
                Set_Layer4_Nodes(nodeID, newEmpty);
            }

            Create_Layer3_Nodes(4, new Node());
            while (Get_Layer3_Nodes() == null) { }
            for (byte nodeID = 0; nodeID < 4; nodeID++)
            {
                Set_Layer3_Nodes(nodeID, newEmpty);
            }

            Create_Layer2_Nodes(3, new Node());
            while (Get_Layer2_Nodes() == null) { }
            for (byte nodeID = 0; nodeID < 3; nodeID++)
            {
                Set_Layer2_Nodes(nodeID, newEmpty);
            }

            Create_Layer1_Nodes(2, new Node());
            while (Get_Layer1_Nodes() == null) { }
            for (byte nodeID = 0; nodeID < 2; nodeID++)
            {
                Set_Layer1_Nodes(nodeID, newEmpty);
            }

            Create_Layer0_Node(new Node());
            while (Get_Layer0_Node() == null) { }
            Set_Layer0_Node(newEmpty);
        }

// destructor.
        ~PraiseSet()
        {

        }

// public.
        public void Create_Layer4_Nodes(byte numberOfNodes, Node newEmpty_Node)
        {
            _Layer4_Nodes = new Node[numberOfNodes];
            while (Get_Layer4_Nodes() == null)
                for (byte index = 0; index < numberOfNodes; index++)
                {
                    _Layer4_Nodes[index] = newEmpty_Node;
                }
        }
        public void Create_Layer3_Nodes(byte numberOfNodes, Node newEmpty_Node)
        {
            _Layer3_Nodes = new Node[numberOfNodes];
            while (Get_Layer3_Nodes() == null)
                for (byte index = 0; index < numberOfNodes; index++)
                {
                    _Layer3_Nodes[index] = newEmpty_Node;
                }
        }
        public void Create_Layer2_Nodes(byte numberOfNodes, Node newEmpty_Node)
        {
            _Layer2_Nodes = new Node[numberOfNodes];
            while (Get_Layer2_Nodes() == null)
                for (byte index = 0; index < numberOfNodes; index++)
                {
                    _Layer2_Nodes[index] = newEmpty_Node;
                }
        }
        public void Create_Layer1_Nodes(byte numberOfNodes, Node newEmpty_Node)
        {
            _Layer1_Nodes = new Node[numberOfNodes];
            while (Get_Layer1_Nodes() == null)
                for (byte index = 0; index < numberOfNodes; index++)
                {
                    _Layer1_Nodes[index] = newEmpty_Node;
                }
        }
        public void Create_Layer0_Node(Node newEmpty_Node)
        {
            _Layer0_Node = newEmpty_Node;
            while (Get_Layer0_Node() == null) { }
        }
    // get.
        public Node Get_Node(byte layer, byte nodeID)
        {
            switch (layer)
            {
                case (byte)Global.NodeLayer.Layer_4:
                    return Get_Layer4_Node(nodeID);

                case (byte)Global.NodeLayer.Layer_3:
                    return Get_Layer3_Node(nodeID);

                case (byte)Global.NodeLayer.Layer_2:
                    return Get_Layer2_Node(nodeID);

                case (byte)Global.NodeLayer.Layer_1:
                    return Get_Layer1_Node(nodeID);

                case (byte)Global.NodeLayer.Layer_0:
                    return Get_Layer0_Node();

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
                    Set_Layer4_Nodes(nodeID, node);
                    break;

                case (byte)Global.NodeLayer.Layer_3:
                    Set_Layer3_Nodes(nodeID, node);
                    break;

                case (byte)Global.NodeLayer.Layer_2:
                    Set_Layer2_Nodes(nodeID, node);
                    break;

                case (byte)Global.NodeLayer.Layer_1:
                    Set_Layer1_Nodes(nodeID, node);
                    break;

                case (byte)Global.NodeLayer.Layer_0:
                    Set_Layer0_Node(node);
                    break;

                default:
                    break;
            }
        }

// private.
    // get.
        private Node Get_Layer4_Node(byte nodeID)
        {
            return _Layer4_Nodes[nodeID];
        }
        private Node[] Get_Layer4_Nodes()
        {
            return _Layer4_Nodes;
        }
        private Node Get_Layer3_Node(byte nodeID)
        {
            return _Layer3_Nodes[nodeID];
        }
        private Node[] Get_Layer3_Nodes()
        {
            return _Layer3_Nodes;
        }
        private Node Get_Layer2_Node(byte nodeID)
        {
            return _Layer2_Nodes[nodeID];
        }
        private Node[] Get_Layer2_Nodes()
        {
            return _Layer2_Nodes;
        }
        private Node Get_Layer1_Node(byte nodeID)
        {
            return _Layer1_Nodes[nodeID];
        }
        private Node[] Get_Layer1_Nodes()
        {
            return _Layer1_Nodes;
        }
        private Node Get_Layer0_Node()
        {
            return _Layer0_Node;
        }

        // set.
        private void Set_Layer4_Nodes(byte nodeID, Node node)
        {
            _Layer4_Nodes[nodeID] = node;
        }
        private void Set_Layer3_Nodes(byte nodeID, Node node)
        {
            _Layer3_Nodes[nodeID] = node;
        }
        private void Set_Layer2_Nodes(byte nodeID, Node node)
        {
            _Layer2_Nodes[nodeID] = node;
        }
        private void Set_Layer1_Nodes(byte nodeID, Node node)
        {
            _Layer1_Nodes[nodeID] = node;
        }
        private void Set_Layer0_Node(Node node)
        {
            _Layer0_Node = node;
        }
    }
}
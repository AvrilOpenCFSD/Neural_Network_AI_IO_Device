
namespace Avril_NNAI
{
    public class MachineAI
    {
        private Avril_NNAI.MetaData _metaData;
        private string _nameOfNNAI;
        private ulong[] _usedPraiseIDs;

        public MachineAI()
        {
            Set_MetaData(new Avril_NNAI.MetaData());
            while (Get_MetaData() == null) { }

            Set_NameOfNNAI("Undefined_NNAI");

            Create_UsedPraiseIDs(new ulong[1]);
            Set_UsedPraiseIDs(0, 0);
        }

        private void Create_UsedPraiseIDs(ulong[] value)
        {
            _usedPraiseIDs = value;
        }

        public Avril_NNAI.MetaData Get_MetaData()
        {
            return _metaData;
        }

        public string Get_NameOfNNAI() 
        {
            return _nameOfNNAI;
        }

        public ulong[] Get_UsedPraiseIDs()
        {
            return _usedPraiseIDs;
        }

        private void Set_MetaData(Avril_NNAI.MetaData metaData)
        {
            _metaData = metaData;
        }

        public void Set_NameOfNNAI(string nameOfNNAI)
        {
            _nameOfNNAI = nameOfNNAI;
        }

        private void Set_UsedPraiseIDs(ulong index, ulong praiseID)
        {
            _usedPraiseIDs[index] = praiseID;
        }
    }
}


namespace Avril_NNAI
{
    public class MachineAI
    {
        private Avril_NNAI.MetaData _metaData;

        public MachineAI()
        {
            Set_MetaData(new Avril_NNAI.MetaData());
            while (Get_MetaData() == null) { }
        }

        public Avril_NNAI.MetaData Get_MetaData()
        {
            return _metaData;
        }

        private void Set_MetaData(Avril_NNAI.MetaData metaData)
        {
            _metaData = metaData;
        }
    }
}


namespace Avril_NNAI
{
    public class NeuralNetworks
    {
        private Avril_NNAI.Global _global;
        private Avril_NNAI.Aglorithms _aglorithms;
        private Avril_NNAI.Data _data;
        private Avril_NNAI.Execute _execute;

        public NeuralNetworks()
        {
            Set_Global(new Avril_NNAI.Global());
            while (Get_Global() == null) { }

            Set_Aglorithms(new Avril_NNAI.Aglorithms());
            while (Get_Aglorithms() == null) { }

            Set_Data(new Avril_NNAI.Data());
            while (Get_Data() == null) { }

            Set_Execute(new Avril_NNAI.Execute());
            while (Get_Execute() == null) { }
        }

        public Avril_NNAI.Global Get_Global()
        {
            return _global;
        }

        public Avril_NNAI.Aglorithms Get_Aglorithms()
        {
            return _aglorithms;
        }

        public Avril_NNAI.Data Get_Data()
        {
            return _data;
        }

        public Avril_NNAI.Execute Get_Execute()
        {
            return _execute;
        }

        private void Set_Aglorithms(Avril_NNAI.Aglorithms aglorithms)
        {
            _aglorithms = aglorithms;
        }

        private void Set_Global(Avril_NNAI.Global global)
        {
            _global = global;
        }
        private void Set_Data(Avril_NNAI.Data data)
        {
            _data = data;
        }

        private void Set_Execute(Avril_NNAI.Execute execute)
        {
            _execute = execute;
        }
    }
}

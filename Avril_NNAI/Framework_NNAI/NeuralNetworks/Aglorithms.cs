
namespace Avril_NNAI
{
    public class Aglorithms
    {
        private Avril_NNAI.NeuralPath _NeuralPath;
        private Avril_NNAI.SolutionLogic _SolutionLogic;

        public Aglorithms()
        {
            Set_NeuralPath(new Avril_NNAI.NeuralPath());
            while (Get_NeuralPath() == null) { }

            Set_SolutionLogic(new Avril_NNAI.SolutionLogic());
            while (Get_SolutionLogic() == null) { }
        }

        public void ConstructNeuralNetworkAI_Frame(Avril_NNAI.Framework_NNAI obj, ulong numberOfTotalInputs)
        {
            obj.Get_Neural_Networks().Get_Data().Get_MachineAI().Get_MetaData().Set_NumberOfPraiseInputs(numberOfTotalInputs);
            obj.Get_Neural_Networks().Get_Data().Get_MachineAI().Get_MetaData().Generate_Input_List(obj);
            obj.Get_Neural_Networks().Get_Data().Get_MachineAI().Get_MetaData().Create_Nodes(obj, obj.Get_Neural_Networks().Get_Data().Get_MachineAI().Get_MetaData().Get_NumberOfPraiseInputValues());
        }

        public Avril_NNAI.NeuralPath Get_NeuralPath()
        {
            return _NeuralPath;
        }

        public Avril_NNAI.SolutionLogic Get_SolutionLogic()
        {
            return _SolutionLogic;
        }

        private void Set_NeuralPath(Avril_NNAI.NeuralPath neuralPath)
        {
            _NeuralPath = neuralPath;
        }

        private void Set_SolutionLogic(Avril_NNAI.SolutionLogic solutionLogic)
        {
            _SolutionLogic = solutionLogic;
        }
    }
}

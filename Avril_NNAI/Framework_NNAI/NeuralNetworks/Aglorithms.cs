
using System.Linq;

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

        public Avril_NNAI.MachineAI ConstructNeuralNetworkAI_Frame(Avril_NNAI.Framework_NNAI obj, string nameOfNNAI, ulong[] praiseID)
        {
            Avril_NNAI.MachineAI _AvrilNNAI = new Avril_NNAI.MachineAI();
            _AvrilNNAI.Set_NameOfNNAI(nameOfNNAI);
            _AvrilNNAI.Get_MetaData().Set_NumberOfPraises((ulong)praiseID.LongLength);
            _AvrilNNAI.Get_MetaData().Calculate_NumberOfPraiseInputValues(obj, _AvrilNNAI, praiseID);
            _AvrilNNAI.Get_MetaData().Generate_REGISTERED_Inputs_List(obj, _AvrilNNAI, praiseID);
            _AvrilNNAI.Get_MetaData().Create_Nodes(obj, _AvrilNNAI, _AvrilNNAI.Get_MetaData().Get_NumberOfPraiseInputValues());
            //ToDo
            _AvrilNNAI.Get_MetaData().Initialise_Node_WEIGHT_and_BIAS(obj);

            obj.Get_Neural_Networks().Get_Data().Save_New_Neural_Network(_AvrilNNAI);
            return _AvrilNNAI;
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

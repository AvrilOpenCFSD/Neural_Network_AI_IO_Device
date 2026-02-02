
namespace Avril_NNAI
{
    public class Aglorithms
    {
// classes.
        private Avril_NNAI.NeuralPath _NeuralPath;
        private Avril_NNAI.SolutionLogic _SolutionLogic;

// registers.

// constructor.
        public Aglorithms()
        {
            //System.Console.WriteLine("entered Aglorithms.");
            Create_NeuralPath(new Avril_NNAI.NeuralPath());
            while (Get_NeuralPath() == null) { }

            Create_SolutionLogic(new Avril_NNAI.SolutionLogic());
            while (Get_SolutionLogic() == null) { }
        }

// destructor.
        ~Aglorithms()
        {
            //System.Console.WriteLine("exited Aglorithms.");
        }

// public.
        public Avril_NNAI.MachineAI ConstructNeuralNetworkAI_Frame(Avril_NNAI.Framework_NNAI obj, string nameOfNNAI, ulong[] praiseID)
        {
            System.Console.WriteLine("entering ConstructNeuralNetworkAI_Frame.");
            Avril_NNAI.MachineAI _AvrilNNAI = new Avril_NNAI.MachineAI();
            while(_AvrilNNAI == null) { }
            System.Console.WriteLine("ALPHA.");
            _AvrilNNAI.Set_NameOfNNAI(nameOfNNAI);
            System.Console.WriteLine("BRAVO.");
            _AvrilNNAI.Get_MetaData().Set_NumberOfPraises((ulong)praiseID.LongLength);
            System.Console.WriteLine("NumberOfPraises = " + _AvrilNNAI.Get_MetaData().Get_NumberOfPraises());
            System.Console.WriteLine("CHARLIE.");
            _AvrilNNAI.Get_MetaData().Calculate_NumberOfPraiseInputValues(obj, _AvrilNNAI, praiseID);
            System.Console.WriteLine("NumberOfPraiseInputValues = " + _AvrilNNAI.Get_MetaData().Get_NumberOfPraiseInputValues());
            System.Console.WriteLine("DELTA.");
            _AvrilNNAI.Get_MetaData().Generate_REGISTERED_Inputs_List(obj, _AvrilNNAI, praiseID);
            System.Console.WriteLine("ECHO.");
            _AvrilNNAI.Get_MetaData().Create_Nodes(obj, _AvrilNNAI, _AvrilNNAI.Get_MetaData().Get_NumberOfPraiseInputValues());
            System.Console.WriteLine("FOXTROT.");

            System.Console.WriteLine("GIGA.");
            obj.Get_Neural_Networks().Get_Data().Preserve_New_Neural_Network(_AvrilNNAI);
            System.Console.WriteLine("HEX.");
            return _AvrilNNAI;
        }
    // get.
        public Avril_NNAI.NeuralPath Get_NeuralPath()
        {
            return _NeuralPath;
        }
        public Avril_NNAI.SolutionLogic Get_SolutionLogic()
        {
            return _SolutionLogic;
        }
    // set.

// private.
        private void Create_NeuralPath(Avril_NNAI.NeuralPath neuralPath)
        {
            _NeuralPath = neuralPath;
        }
        private void Create_SolutionLogic(Avril_NNAI.SolutionLogic solutionLogic)
        {
            _SolutionLogic = solutionLogic;
        }
    // get.
    // set.
    }
}

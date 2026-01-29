#pragma once
namespace Avril_NNAI
{
    class Framework_NNAI
    {
    public:
        Framework_NNAI();
        virtual ~Framework_NNAI();
        void Initialise_Program(Avril_NNAI::Framework_NNAI* obj);
        class NeuralNetworks* Get_Neural_Networks();

    private:
        static void Set_Neural_Networks(class Avril_NNAI::NeuralNetworks* server);
    };
};
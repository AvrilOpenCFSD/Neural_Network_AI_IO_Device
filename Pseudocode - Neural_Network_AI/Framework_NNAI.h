#pragma once
namespace OpenAvrilNNI
{
    class Framework_NNI
    {
    public:
        Framework_NNI();
        virtual ~Framework_NNI();
        void Initialise_Program(OpenAvrilNNI::Framework_NNI* obj);
        class NeuralNetworks* Get_Neural_Networks();

    private:
        static void Set_Neural_Networks(class OpenAvrilNNI::NeuralNetworks* server);
    };
};
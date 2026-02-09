#include "pch.h"

class OpenAvrilNNI::Algorithms* ptr_Algorithms = NULL;
class OpenAvrilNNI::Data* ptr_Data = NULL;
class OpenAvrilNNI::Execute* ptr_Execute = NULL;
class OpenAvrilNNI::Global* ptr_Global = NULL;

OpenAvrilNNI::NeuralNetworks::NeuralNetworks()
{
    Set_Global(new class OpenAvrilNNI::Global());
    while (Get_Global() == NULL) {}
    std::cout << "Created => OpenAvrilNNI::Global()" << std::endl;

    Set_Algorithms(new class OpenAvrilNNI::Algorithms());
    while (Get_Algorithms() == NULL) {}
	ptr_Algorithms->Initialise_Control();
    std::cout << "Created => OpenAvrilNNI::Algorithms()" << std::endl;

    Set_Data(new class OpenAvrilNNI::Data());
    while (Get_Data() == NULL) {}
    ptr_Data->Initialise_Control();
    std::cout << "Created => OpenAvrilNNI::Data()" << std::endl;

    Set_Execute(new class OpenAvrilNNI::Execute());
    while (Get_Execute() == NULL) {}
    Get_Execute()->Initialise_Control();
    std::cout << "Created => OpenAvrilNNI::Execute()" << std::endl;
}

OpenAvrilNNI::NeuralNetworks::~NeuralNetworks()
{
    delete ptr_Global;
    delete ptr_Algorithms;
    delete ptr_Data;
    delete ptr_Execute;
}

OpenAvrilNNI::Algorithms* OpenAvrilNNI::NeuralNetworks::Get_Algorithms()
{
    return ptr_Algorithms;
}

OpenAvrilNNI::Data* OpenAvrilNNI::NeuralNetworks::Get_Data()
{
    return ptr_Data;
}

OpenAvrilNNI::Execute* OpenAvrilNNI::NeuralNetworks::Get_Execute()
{
    return ptr_Execute;
}

OpenAvrilNNI::Global* OpenAvrilNNI::NeuralNetworks::Get_Global()
{
    return ptr_Global;
}

void OpenAvrilNNI::NeuralNetworks::Set_Algorithms(OpenAvrilNNI::Algorithms* algorithms)
{
    ptr_Algorithms = algorithms;
}
void OpenAvrilNNI::NeuralNetworks::Set_Data(OpenAvrilNNI::Data* data)
{
    ptr_Data = data;
}
void OpenAvrilNNI::NeuralNetworks::Set_Execute(OpenAvrilNNI::Execute* execute)
{
    ptr_Execute = execute;
}
void OpenAvrilNNI::NeuralNetworks::Set_Global(OpenAvrilNNI::Global* global)
{
    ptr_Global = global;
}
// See https://aka.ms/new-console-template for more information


using ProjetoEstacionamento.Models;
int opcao;
decimal precoInicialMain;
decimal precoPorHoraMain;
Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial : ");
precoInicialMain = decimal.Parse(Console.ReadLine());
Console.WriteLine("Digite o preço por hora : ");
precoPorHoraMain = decimal.Parse(Console.ReadLine());
Estacionamento Estaciona027 = new Estacionamento(precoInicialMain, precoPorHoraMain);

do{

Console.WriteLine("Digite a sua opção:");
Console.WriteLine("1. Cadastrar veículo:");
Console.WriteLine("2. Remover veículo:");
Console.WriteLine("3. Listar veículos:");
Console.WriteLine("4. Encerrar programa:");
opcao = Convert.ToInt32(Console.ReadLine());

switch(opcao){
    case 1 : 
    Estaciona027.AdicionarVeiculo();
    break;
    case 2 :
    Estaciona027.RemoverVeiculo();
    break;
    case 3 :
    Estaciona027.ListarVeiculos();
    break;
    case 4 :
    Console.WriteLine("O programa encerrou");
    break;
    default:
    Console.WriteLine("Você digitou um valor indefinido. Tente novamente!");
    break;
}

}while(opcao != 4);

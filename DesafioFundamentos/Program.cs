using System.Runtime.InteropServices;
using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

 Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
 //Coloquei um Laço com Try para que quando o usúario digita-se uma letra, o sistema pedirá para ele digitar um valor válido.
do{

try{
   
    Console.WriteLine("Digite o preço inicial:");
    precoInicial = Convert.ToDecimal(Console.ReadLine());
    break;
}catch(FormatException){
    Console.WriteLine("Digite um valor válido!");
}
}while(true);
do{
    try{
        Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());
    break;
    }catch(FormatException){
        Console.WriteLine("Digite um valor válido!");
    }
    }while(true);

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    //Console.Clear(); ----- > //Esta Apresentando o seguinte erro  quando rodamos nessa linha, Então joguei ela para a ultima linha.
    // Exception has occurred: CLR/System.IO.IOException An unhandled exception of type 'System.IO.IOException'
    // occurred in System.Console.dll: 'Identificador inválido.'
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    //Esta Apresentando o seguinte erro  quando rodamos nessa linha, Então joguei ela para a ultima linha.
    // Exception has occurred: CLR/System.IO.IOException An unhandled exception of type 'System.IO.IOException'
    // occurred in System.Console.dll: 'Identificador inválido.'

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar"); //Essa Linha serve como confirmação para o usúario mas ao meu ver não teria a necessidade.
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
//Console.Clear(); // Coloquei o Clear aqui pois na 26 ou 32 apresenatava erro.
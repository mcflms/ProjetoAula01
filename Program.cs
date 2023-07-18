// See https://aka.ms/new-console-template for more information

//criando um objeto para a classe Cliente (variável de instância)

using ProjetoAula01.Entities;
using ProjetoAula01.Repositories;
//criando um objeto para a classe Cliente (variável de instância) 


Console.WriteLine("\n*** AULA 01 - C# WEBDEVELOPER ***\n");

var cliente = new Cliente();

// acessando as propriedades da classe

cliente.IdCliente = Guid.NewGuid();

Console.Write("Informe o Nome do Cliente:");
cliente.Nome = Console.ReadLine();


Console.Write("Informe o Email do Cliente:");
cliente.Email = Console.ReadLine();


Console.Write("Informe o Telefone do Cliente:");
cliente.Telefone = Console.ReadLine();




//imprimir os dados do cliente no console
Console.WriteLine( "\nDados do Cliente:\n" );
Console.WriteLine("\tID.......:" + cliente.IdCliente );
Console.WriteLine("\tNOME:....:" + cliente.Nome );
Console.WriteLine("\tEMAIL....:" + cliente.Email );
Console.WriteLine("\tTELEFONE.:" + cliente.Telefone );

try // tentativa
{
    //criando um objeto para a classe ClienteRepository
    var clienteRepository = new ClieneteRepository();

    //Executar a gravação do arquivo
    clienteRepository.ExportarDados( cliente );

    // imprimir uma menssagem de sucesso
    Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!");


}
catch(Exception e) // captura da exceção ( ou erro ).
{
    Console.WriteLine("\nOCORREU UM ERRO:" + e.Message);
}




// pausar a execução do prompt
Console.ReadKey();
 
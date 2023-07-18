using ProjetoAula01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Localizaçãoo da Classe no Projeto
namespace ProjetoAula01.Repositories
{

    //definição da Classe
    public class ClieneteRepository
    {
        //Método oara gravar os dados de um Cliente em um arquivo
        public void ExportarDados( Cliente cliente)
        {

            //Abrindo um arquivo em modo de escrita
            var streamWriter = new StreamWriter ("c:\\temp\\ clientes.txt",true);

            //Escrevendo os dados do cliente no arquivo
            streamWriter.WriteLine("ID DO CLIENTE....:" + cliente.IdCliente);
            streamWriter.WriteLine("NOME.............:" + cliente.Nome);
            streamWriter.WriteLine("EMAIL............:" + cliente.Email);
            streamWriter.WriteLine("TELEFONE.........:" + cliente.Telefone);
            streamWriter.WriteLine("---");

            //Salvando e fechando o arquivo

            streamWriter.Flush();
            streamWriter.Close();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a localização da classe 
namespace ProjetoAula01.Entities
{
    // Definição de Classe
    public class Cliente
    {
        //declarando as propriedades da classe(campos)
        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }



    }
}

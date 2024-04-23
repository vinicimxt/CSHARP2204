using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP2204
{
     class Pessoa
    {
        private string nome;
        public double salario; //atributos com letra minuscula

        public double Salario //propriedade tem que ser com letra maiuscula
        {
            get //pegar o atributo
            {
                return this.salario;
            }
            set // para setar/mudar o valor que você inseriu
            {
                if (this.salario > value)
                {
                    Console.WriteLine("Salario atual menor que o informado");
                }
                else
                {
                    this.salario = value;
                    Console.WriteLine("Salario atualizado");
                }
            }
        }

        public Pessoa() 
        {
        }
        public Pessoa(string nome , double salario) //metodo construtor, usado como se chamasse a classe
        {
            this.nome = nome;
            this.salario = 1000;
        }

        public string Nome
        {
           set
            {
                this.nome = value;
            }
            get
            {
                return this.nome.ToUpper(); //para seu atributo/variavel ser sempre letra maiuscula
            }
        }
        public string Email { get; set; }
        
    }
}

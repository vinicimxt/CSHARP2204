using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP2204
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            double[] decimais = new double[10];
            string[] nomes = new string[10];
            
            numeros[0] = 1;
            numeros[1] = 2;
            int indice = 0;

            for(indice = 0;indice < 10; indice++)
            {
                nomes[indice] = "nomes";
                Console.WriteLine("Nomes:{0}", nomes[indice]);
              // numeros[indice] = indice;
            }

            Pessoa p = new Pessoa("vinicius", 1000); //Criar sua classe e atribuir um valor.
            //p.Nome = "Vinicius";
            Console.WriteLine("Nome:{0}", p.Nome); //imprimir o nome na posição "0" chamando sua propriedade
            p.Salario = 1000; //inserindo valor de salario
            p.Salario = 900;
            p.Salario = 1100;
            Console.WriteLine("Salario:{0}", p.Salario);

            Console.WriteLine("Vetor convidados\n");
            Pessoa[] convidados = new Pessoa[10];
            Pessoa funcionario = new Pessoa();

            nomes[0] = "vini";
            Console.WriteLine("Nomes[0]:{0}", nomes[0]);

            numeros[0] = 1;
            Console.WriteLine("Numeros[0]:{0}", numeros[0]);

            decimais[0] = 2.5;
            Console.WriteLine("Decimais[0]:{0}", decimais[0]);

            for(int i=0; i < convidados.Length; i++) // Legnth = tamanho do vetor 
            {
                convidados[i] = new Pessoa(); 
            }

            convidados[0] = funcionario;
            convidados[0].Nome = "Vinicius";
            Console.WriteLine("Objeto pessoa[0]: {0}", convidados[0].Nome); 
            //convidados[0] = new Pessoa ("Vini" , 1000);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_De_Decisoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade: ");
            UInt32 Idade = Convert.ToUInt32(Console.ReadLine());

            //If... Else... 
            if (Idade >= 18)/*"Condição booleana, que pode ser true ou false */
            {
                Console.WriteLine("Você é maior de idade!");
            }
            else //opcional, não realmente necessário ter para que o "IF" funcione. 
            {
                Console.WriteLine("Você não é maior de idade!");
            }
            Console.ReadKey();

            //If... Else... If... 
            Console.WriteLine("Digite seu sálario: ");
            UInt32 Salario = Convert.ToUInt32(Console.ReadLine());
            if (Salario < 1000) /*"Condição booleana, que pode ser true ou false */ //Necessário para inicio da cadeia.
            {
                Console.WriteLine("Você ganha menos que 1 salário minímo.");
            }
            else if (Salario < 2000 ) /*"Condição booleana, que pode ser true ou false */ //Podemos usar esse tipo de repetição quantas vezes forem necessárias, porém há outras maneiras melhores de fazer uma chave contínua.
            {
                Console.WriteLine("Você ganha menos que 2 salários minímo.");
            }
            else if (Salario < 5000) /*"Condição booleana, que pode ser true ou false */ //Podemos usar esse tipo de repetição quantas vezes forem necessárias, porém há outras maneiras melhores de fazer uma chave contínua.
            {
                Console.WriteLine("Você ganha menos que 5 salários minímo.");
            }
            else //Sempre opcional.
            {
                Console.WriteLine("Você é rico!!");
            }
            Console.ReadKey();

            //Switch (comutador)
            Console.WriteLine("Pressione uma tecla: ");
            char tecla = Console.ReadKey().KeyChar;
            switch (tecla) /*Variavel*/
            {
                case 'a'/* Valores */://Caso
                    Console.WriteLine("Você pressionou a tecla A");
                    break; //Pare

                case 'b'/* Valores */://caso
                    Console.WriteLine("Você pressionou a letra B");
                    break; //Pare

                default: //Padrão - Opcional. 
                    Console.WriteLine("Eu não conheço essa tecla!!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}

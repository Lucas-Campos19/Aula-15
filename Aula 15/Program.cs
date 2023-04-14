using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Comando goto
            inicio: // especifica a label onde o programador quer que o usuario retorne o programa novamente
            Console.Clear();
            int minutos = 0;
            Console.WriteLine("Tempo de viagem Belo Horizonte(MG) a Vitoria(ES)");
            Console.WriteLine("Escolha a forma da viagem escolhida: [a]Avião || [c]Carro || [o]Ônibus");
            char escolha = char.Parse(Console.ReadLine());

            switch (escolha) 
            {
                case 'a':
                case 'A':
                    minutos = 50;
                    break;
                case 'c':
                case 'C':
                    minutos = 800;
                    break;
                case 'o':
                case 'O':
                    minutos = 600;
                    break;
                default:
                    minutos = 0;
                    break;
            }
            if(minutos == 0)
            {
                Console.WriteLine("Tempo de viagem indisponível!!!");
            }
            else
            {
                Console.WriteLine("O tempo de viagem escolhido é de {0} minutos", minutos);
            }
            Console.Write("Calcular o tempo de viagem novamente: [s/n]: ");
            escolha = char.Parse(Console.ReadLine());
            if(escolha == 's' || escolha == 'S')
            {
                goto inicio; // chama a label inicio comando goto praticamente um lação só que menos robusto.
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Fim do programa");
            }
            Console.ReadKey();
        }
    }
}

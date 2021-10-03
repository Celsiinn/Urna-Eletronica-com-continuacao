using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna_Eletronica_com_continuacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] empresas = { "Sul Fluminense", "Elite", "Pinheiral", "Agulhas Negras", "Cidade do Aco" };
            int sulfluminense = 0, elite = 0, pinheiral = 0, vca = 0, agulhas = 0, escolha;
            string continuar;

        INICIO:
            
            Console.WriteLine("*==============================================================*");
            Console.WriteLine("BEM VINDO A ELEIÇAO DA MELHOR EMPRESA DE VOLTA REDONDA");
            Console.WriteLine("*==============================================================*");
            Console.WriteLine("POR FAVOR ESCOLHA A EMPRESA: ");
            Console.WriteLine("\n 1 - SUL FLUMINENSE \n 2 - ELITE \n 3 - PINHEIRAL \n 4 - CIDADE DO AÇO  \n 5 - AGULHAS NEGRAS");

            escolha = int.Parse(Console.ReadLine());


            switch (escolha)
            {

                case 1:
                    Console.WriteLine($"Voce votou na {empresas[0]}");
                    sulfluminense = sulfluminense + 1;
                    break;
                    
                case 2:
                    Console.WriteLine($"Voce votou na {empresas[1]}");
                    elite = elite + 1;
                 
                    break;
                case 3:
                    Console.WriteLine($"Voce votou na {empresas[2]}");
                    pinheiral = pinheiral + 1;
                   
                    break;
                case 4:
                    Console.WriteLine($"Voce votou na {empresas[3]}");
                    vca = vca + 1;
                    
                    break;
                case 5:
                    Console.WriteLine($"Voce votou na {empresas[4]}");
                    agulhas = agulhas + 1;
                    
                    break;
            
               
            }
            Console.WriteLine("Deseja Continuar a Votacao?");
            Console.WriteLine("\n SIM \n NAO");
            continuar = Console.ReadLine();
            if (continuar == "SIM")
            {
                goto INICIO;
            }
            else
            {

                Console.WriteLine("*===============================================*");
                Console.WriteLine("MOSTRANDO O RESULTADO DA VOTAÇAO"); ;
                if (sulfluminense > elite && sulfluminense > pinheiral && sulfluminense > vca && sulfluminense > agulhas)
                {
                    Console.WriteLine($"A melhor empresa de Volta Redonda e a {empresas[0]} com {sulfluminense} votos");
                }
                else if (elite > sulfluminense && elite > pinheiral && elite > pinheiral && elite > vca && elite > agulhas)
                {
                    Console.WriteLine($"A melhor empresa de Volta Redonda e a {empresas[1]} com {elite} votos");
                }
                else if (pinheiral > sulfluminense && pinheiral > elite && pinheiral > vca && pinheiral > agulhas)
                {
                    Console.WriteLine($"A melhor empresa de Volta Redonda e a {empresas[2]} com {pinheiral} votos");
                }
                else if (vca > sulfluminense && vca > elite && vca > agulhas && vca > pinheiral)
                {
                    Console.WriteLine($"A melhor empresa de Volta Redonda e a {empresas[3]} com {vca} votos");
                }
                else if (agulhas > sulfluminense && agulhas > elite && agulhas > vca && agulhas > pinheiral)
                {
                    Console.WriteLine($"A melhor empresa de Volta Redonda e a {empresas[4]} com {agulhas} votos");

                }
                Console.ReadKey();
                
            
            }
        }
    }
}

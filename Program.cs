using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string periodo;
            int meses ;
            int dia;
           
            Console.WriteLine("Ola seja bem vindo(a) a Vick Viagens aqui nos prezamos por eficiencia e seu conforto. ");
            Console.WriteLine("opçoes para compra da passagem aera:");
            Console.WriteLine("08-agosto");
            Console.WriteLine(  "09-setembro");
            Console.WriteLine("10-outubro");
            Console.Write("Digite o mes em numeros: ");
            meses = int.Parse(Console.ReadLine());
           
            if(meses > 7 &  meses < 11 )
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("\nDias disponiveis no respectivo mes: entre(6 e 21)");
                Console.WriteLine(  "Dia 6/Dia 7/Dia 8/Dia 9/Dia 10/Dia 11");
                Console.WriteLine(  "Dia 12/Dia 13//Dia 14/Dia 15/Dia 16/Dia 17");
                Console.WriteLine(  "Dia 18/Dia 19/Dia 20/Dia 21");
                Console.Write( "Digite o dia escolhido: ");
               dia =int.Parse( Console.ReadLine());
                if(dia > 5 & dia < 22 ) 
                {
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("\nEscolha o pedriodo de sua viagem: ");
                    Console.WriteLine("-tarde");
                    Console.WriteLine("-manha");
                    Console.WriteLine("-noite");
                    Console.Write("Digite o periodo desejado: ");
                  periodo =  Console.ReadLine();
                    Console.WriteLine("//------------------------------------------------------------//");
                    Console.WriteLine(  "\nParabens pela compra,Boa Viagem e volte sempre!\n");
                    Console.WriteLine($"---Compra feita para o dia {dia} do mes {meses} no periodo da {periodo}---");
                }
                else
                {
                    Console.WriteLine( "\n!!Dia Invalido!!\n");
                    Main(null);
                    return;
                }
           
            }
           
            else
            {
                Console.WriteLine("\n!!Mes Invalido!!\n");
                Main(null);
                return;
           
            }

            Console.ReadKey();


        }
    }
}

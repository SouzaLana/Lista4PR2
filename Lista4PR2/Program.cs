using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Atividade 1.");
            //Console.WriteLine("");
            //Console.WriteLine("É falsa, porque int cabe em float, mas float não cabe em int. Um modo de resolver esse problema é com o comando o comando Math.Round: ");
            //Console.WriteLine("float num = 11.3f;");
            //Console.WriteLine("int num1 = (int)Math.Round(num);");
            //Console.WriteLine("Console.WriteLine(num1);");
            //Console.WriteLine("Console.ReadKey();");
            //Console.WriteLine("");

            //Console.WriteLine("Atividade 2.");
            //Console.WriteLine("");
            //Console.WriteLine("O Console.ReadLine() retorna o valor da linha inteira, já o Console.Read() retorna o apenas do 1 caracter digitado.");
            //Console.WriteLine("");

            //Console.WriteLine("Atividade 3.");
            //Console.WriteLine("");
            //Console.WriteLine("Precisamos tomar cuidado para não usar a variável do tipo errado.");
            //Console.WriteLine("");

            //Console.WriteLine("Atividade 4.");
            //Console.WriteLine("");
            //Console.WriteLine("O seu objetivo é verificar se o número digitado corresponde a mensagem 1 ou a mensagem 2.");
            //Console.WriteLine("Se entrasse com o número 8 a saída seria: Mensagem 2 e se entrasse com o número 27 a saída seria: Mensagem 2 também.");
            //Console.WriteLine("Já se entrasse com o número 28 a saída seria: Mensagem1");
            //Console.WriteLine("Mas o programa está incompleto. Falta o comando Console.ReadKey(), então não apresenta nenhuma saída.");
            //Console.WriteLine("");

            //Console.WriteLine("Atividade 5.");
            //Console.WriteLine("");

            //int s, s0, v, t;
            //Console.WriteLine("Digite a posição inicial: ");
            //s0 = int.Parse( Console.ReadLine() );
            //Console.WriteLine("Digite a velocidade: ");
            //v = int.Parse( Console.ReadLine() );
            //Console.WriteLine("Digite o tempo: ");
            //t = int.Parse( Console.ReadLine() );

            //s = s0 + v * t;

            //Console.WriteLine("A posição final é " + s);
            //Console.ReadKey();
            //Console.WriteLine("");

            //Console.WriteLine("Atividade 6.");
            //Console.WriteLine("");

            //Console.WriteLine("Gerando um número... ");
            //Random random = new Random();
            //int num = random.Next(1, 11);

            //if(num % 3 == 0 && num % 5 == 0 && num % 10 == 0)
            //{
            //    Console.WriteLine("O número é divisível por 3, 5 e 10");
            //}
            //else if(num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("O número é divisível por 3 e 5");
            //}
            //else if(num % 3 == 0)
            //{
            //    Console.WriteLine("O número é divisível somente por 3");
            //}
            //else if(num % 5 == 0)
            //{
            //    Console.WriteLine("O número é divisível somente por 5");
            //}
            //Console.ReadKey();

            //Console.WriteLine("Atividade 7.");
            //Console.WriteLine("");

            //int km, Ekm = 100, dist, dif;

            //Console.WriteLine("Digite o km onde sua casa está localizada: ");
            //km = int.Parse( Console.ReadLine() );

            //dif = Ekm - km;

            //if(dif >= 0 && dif <= 12)
            //{
            //    Console.WriteLine("O tempo necessário é de 14 minutos");
            //}
            //else if(dif > 12 && dif <= 29)
            //{
            //    dist = 14 + 17;
            //    Console.WriteLine("O tempo necessário é de " + dist +  " minutos");
            //}
            //else if(dif > 29 && dif <= 55)
            //{
            //    dist = 14 + 17 + 13;
            //    Console.WriteLine("O tempo necessário é de " + dist +  " minutos");
            //}
            //else if(dif > 55 && dif <= 82)
            //{
            //    dist = 14 + 17 + 13 + 15;
            //    Console.WriteLine("O tempo necessário é de " + dist +  " minutos");
            //}
            //else if(dif > 82 && dif <= 100)
            //{
            //    dist = 14 + 17 + 13 + 15 + 12;
            //    Console.WriteLine("O tempo necessário é de " + dist +  " minutos");
            //}
            //Console.ReadKey();

            //Console.WriteLine("Atividade 8.");
            //Console.WriteLine("");

            //float prod, lucLiq, marc, LucT;
            //Console.WriteLine("=====MENU====");
            //Console.WriteLine("1- ROYAL");
            //Console.WriteLine("2- WISKAS");
            //Console.WriteLine("3- GOLDEN");
            //Console.WriteLine("4- NUTRIEN");
            //Console.WriteLine("5- SPECIALCAT");
            //Console.WriteLine("6- MARBA");
            //Console.WriteLine("7- GATUS");
            //Console.WriteLine("Digite a quantidade de unidades de um produto: ");
            //prod = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a marca do produto: ");
            //marc = int.Parse(Console.ReadLine());

            //switch (marc)
            //{
            //    case 1:
            //        LucT = prod * 129.50f;
            //        lucLiq = ((LucT - (77.5f / 100)) - (33 / 100));
            //        Console.WriteLine("Valor total: " + LucT + " e lucro líquido: " + LucLiq);
            //        break;
            //    case 2:
            //        LucT = prod * 182.78f;
            //        lucLiq = ((LucT - (89.7f / 100)) - (27.5f / 100));
            //        Console.WriteLine("Valor total: " + LucT + " e lucro líquido: " + LucLiq);
            //        break;
            //    case 3:
            //        LucT = prod * 159.46f;
            //        lucLiq = ((LucT - (71.7f / 100)) - (22.5f / 100));
            //        Console.WriteLine("Valor total: " + LucT + " e lucro líquido: " + LucLiq);
            //        break;
            //    case 4:
            //        LucT = prod * 144.80f;
            //        lucLiq = ((LucT - (88.9f / 100)) - (25 / 100));
            //        Console.WriteLine("Valor total: " + LucT + " e lucro líquido: " + LucLiq);
            //        break;
            //    case 5:
            //        LucT = prod * 205.40f;
            //        lucLiq = ((LucT - (83.24f / 100)) - (22 / 100));
            //        Console.WriteLine("Valor total: " + LucT + " e lucro líquido: " + LucLiq);
            //        break;
            //    case 6:
            //        LucT = prod * 125.10f;
            //        lucLiq = ((LucT - (90.4f / 100)) - (17.9 / 100));
            //        Console.WriteLine("Valor total: " + LucT + " e lucro líquido: " + LucLiq);
            //        break;
            //    case 7:
            //        LucT = prod * 133.99f;
            //        lucLiq = ((LucT - (94.6f / 100)) - (20 / 100));
            //        Console.WriteLine("Valor total: " + LucT + " e lucro líquido: " + LucLiq);
            //        break;
            //    default:
            //        Console.WriteLine("Valor inválido");
            //        break;
            //}
            //Console.ReadKey();
        }
    }
}

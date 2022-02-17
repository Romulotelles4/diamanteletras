using System;

namespace diamantex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma letra:");
            char letra = Convert.ToChar(Console.ReadLine().ToUpper());

            char letraatual = 'A';
            int quantidadeespacoinicio = 0, quantidadeespacomeio = 1;
            int endereco = 0, diferencaentreletras = -1;

            for (int i = 65; i < letra; i++)
            {
                quantidadeespacoinicio = letra - i;

                for (int j = 0; j < quantidadeespacoinicio; j++)
                {
                    Console.Write(' ');

                }
                letraatual = Convert.ToChar(i);
                Console.Write(letraatual);

                if (i == 65)
                {
                    Console.WriteLine("\n");
                }
                else
                {
                    for (int l = 0; l < quantidadeespacomeio; l++)
                    {
                        Console.Write(' ');

                    }
                    quantidadeespacomeio += 2;
                    letraatual = Convert.ToChar(i);
                    Console.WriteLine(letraatual + "\n");

                }



            }

            if (quantidadeespacoinicio == 1)
            {
                letraatual = Convert.ToChar(letraatual + 1);
                Console.Write(letraatual);
                for (int espacomeio = 0; espacomeio < quantidadeespacomeio; espacomeio++)
                {
                    Console.Write(' ');
                }
                Console.Write(letraatual);
                Console.WriteLine("\n");
                letraatual = Convert.ToChar(letraatual - 1);
            }


            for (int i = letraatual; i >= 65; i--)
            {
                diferencaentreletras = letra - i;


                for (int j = 0; j < diferencaentreletras; j++)
                {
                    Console.Write(' ');

                }
                letraatual = Convert.ToChar(i);
                Console.Write(letraatual);
                if (i == 65)
                {
                    Console.WriteLine();
                }
                else
                {
                    quantidadeespacomeio -= 2;
                    for (int l = 0; l < quantidadeespacomeio; l++)
                    {
                        Console.Write(' ');

                    }
                    letraatual = Convert.ToChar(i);
                    Console.WriteLine(letraatual + "\n");
                }
            }














            Console.ReadLine();
        }
    }
}

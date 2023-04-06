using System;

namespace FunçõeseArray.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequencia = new int[10];
            int numero = 1;
            int valormedio = 0;
            int remocao = 0;
            int numeronegativo = 0;
            Console.WriteLine("Digite 10 números:");
            for (int i = 0; i < sequencia.Length; i++)
            {
                Console.Write($"Digite o {numero}° número : ");
                sequencia[i] = Convert.ToInt32(Console.ReadLine());
                numero++;
                valormedio += sequencia[i];
                if (sequencia[i] < 0)
                {
                    numeronegativo++;
                }
            }
            while (true)
            {
                Console.WriteLine("Digite uma opção: \n(1) Maior Valor \n(2) Menor Valor \n(3) Valor Médio \n(4) 3 Maiores \n(5) Valores Negativos \n(6) Mostrar valores \n(7) Remover Valor \n(S) Sair");
                string operacao = Console.ReadLine().ToUpper();

                if (operacao == "1")
                {
                    int maiorvalor = MaiorValor(sequencia);
                    Console.WriteLine($"O Maior valor é de: {maiorvalor}");
                }
                else if (operacao == "2")
                {
                    int menorvalor = MenorValor(sequencia);
                    Console.WriteLine($"O Menor valor é de: {menorvalor}");
                }
                else if (operacao == "3")
                {
                    Console.WriteLine($"O valor Médio é de: {valormedio / 10}");
                }
                else if (operacao == "4")
                {
                    TresMaioresValores(sequencia);                    
                }
                else if (operacao == "5")
                {
                    if (numeronegativo > 0)
                    {
                        int[] valoresnegativos = ValoresNegativos(sequencia, numeronegativo);
                        for (int i = 0; i < valoresnegativos.Length; i++)
                        {
                            Console.WriteLine($"{valoresnegativos[i]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sua sequencia não possui números negativos.");
                    }
                }
                else if (operacao == "6")
                {
                    for (int j = 0; j < sequencia.Length; j++)
                    {
                        Console.WriteLine(sequencia[j]);
                    }
                }
                else if (operacao == "7")
                {
                    RemoverValores(sequencia, remocao);

                }
                else if (operacao == "S")
                {
                    Console.WriteLine("Obrigado por utilizar nosso sistema!");
                    break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
        static int MaiorValor(int[] sequencia)
        {
            Array.Sort(sequencia);
            Array.Reverse(sequencia);
            return sequencia[0];
        }
        static int MenorValor(int[] sequencia)
        {
            Array.Sort(sequencia);
            return sequencia[0];
        }
        static void TresMaioresValores(int[] sequencia)
        {
            Array.Sort(sequencia);
            Array.Reverse(sequencia);
            Console.WriteLine($"Os Três Maiores Valores são de: {sequencia[0]}, {sequencia[1]} e {sequencia[2]}");
        }
        static int[] ValoresNegativos(int[] sequencia, int numeronegativo)
        {
            int[] negativos = new int[numeronegativo];
            int teste = 0;

            if (numeronegativo > 0)
            {
                
                for (int j = 0; j < sequencia.Length; j++)
                {
                    if (sequencia[j] < 0)
                    {
                        negativos[teste] = sequencia[j];
                        teste++;
                    }
                }
                return negativos;
            }
            else
            {
                Console.WriteLine("Sua sequencia não possui números negativos.");
                return new int[0];
            }
        }
        static int[] RemoverValores(int[] sequencia, int remocao)
        {
            Console.WriteLine("Selecione a posição a ser Removida: ");

            for (int j = 0; j < sequencia.Length; j++)
            {
                Console.WriteLine($"{j} - {sequencia[j]}");
            }
            remocao = Convert.ToInt32(Console.ReadLine());

            sequencia[remocao] = 0;

            return sequencia;

        }
    }
}
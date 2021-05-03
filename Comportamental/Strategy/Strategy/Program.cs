using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular calculadora = new Calcular();
            while (true)
            {
                Console.WriteLine("Informe o primeiro valor");
                double valor1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe o segundo valor");
                double valor2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Dividir");
                Console.WriteLine("4 - Multiplicar");
                string opcao = Console.ReadLine();
                if (opcao == "1")
                {
                    calculadora.Calculadora = new Soma();
                    calculadora.Operacao(valor1, valor2);
                }
                if (opcao == "2")
                {
                    try
                    {
                        calculadora.Calculadora = new Subtrair();
                        calculadora.Operacao(valor1, valor2);
                    }
                    catch
                    {
                        Console.WriteLine("Erro na operacao");
                    }
                }
                if (opcao == "3")
                {
                    try
                    {
                        calculadora.Calculadora = new Dividir();
                        calculadora.Operacao(valor1, valor2);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Erro na operacao : " + ex.InnerException);
                    }
                }
                if (opcao == "4")
                {
                    calculadora.Calculadora = new Multiplicar();
                    calculadora.Operacao(valor1, valor2);
                }
            }
        }
    }
}


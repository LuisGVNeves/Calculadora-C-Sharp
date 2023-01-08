namespace Calculadora
{
    class Program
    {

        static void Somar(double valor = 0, double valor2 = 0)
        {
            Console.Write("Primeiro valor: ");
            valor = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            double soma = valor + valor2;

            Console.WriteLine($"O resultado da soma é: {soma}");
        }

        static void Subtracao(double valor = 0, double valor2 = 0)
        {
            Console.Write("Primeiro valor: ");
            valor = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            double subtracao = valor - valor2;

            Console.WriteLine($"O resultado da subtração é: {subtracao}");
        }

        static void Divisao(double valor = 0, double valor2 = 0)
        {
            Console.Write("Primeiro valor: ");
            valor = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            double divisao = valor / valor2;

            Console.WriteLine($"O resultado da divisão é: {divisao}");
        }

        static void Multiplicacao(double valor = 0, double valor2 = 0)
        {
            Console.Write("Primeiro valor: ");
            valor = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            double multiplicacao = valor * valor2;

            Console.WriteLine($"O resultado da multiplicação é: {multiplicacao}");
        }

        static void Main(string[] args) 
        {

            Somar();
            Subtracao();
            Divisao();

        }
    }
}
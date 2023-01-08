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

        static void Main(string[] args) 
        {

            Somar();

        }
    }
}
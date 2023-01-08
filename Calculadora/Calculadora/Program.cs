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

        static void Resto(double valor = 0, double valor2 = 0)
        {
            Console.Write("Primeiro valor: ");
            valor = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            double modulo = valor % valor2;

            Console.WriteLine($"O resto da divisão é: {modulo}");
        }

        static void Menu(string resposta = "") 
        {
            Console.WriteLine("\n------------- CALCULADORA C# -------------\n");
            Console.Write("Você quer fazer quais operações?\n\n");
            Console.WriteLine("Somar +          |       Subtrair - ");
            Console.WriteLine("Dividir /        |       Multiplicar * ");
            Console.WriteLine("Resto % \n");
            Console.WriteLine("\n    ----------------------------------\n");

            Console.Write("Digite o sinal: ");
            resposta = Console.ReadLine();

            switch (resposta)
            {
                case "+":
                    Somar();
                    break;
                case "-":
                    Subtracao();
                    break;
                case "*":
                    Multiplicacao();
                    break;
                case "/":
                    Divisao();
                    break;
                case "%":
                    Resto();
                    break;
                default:
                    System.Environment.Exit(0);
                    break;

            }
        }

        static void Main(string[] args) 
        {
            Menu();
        }
    }
}
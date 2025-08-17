using atividade3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha a operação: 1-Somar, 2-Subtrair, 3-Multiplicar, 4-Dividir");
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine($"Resultado: {Calculadora.Somar(num1, num2)}");
                break;
            case "2":
                Console.WriteLine($"Resultado: {Calculadora.Subtrair(num1, num2)}");
                break;
            case "3":
                Console.WriteLine($"Resultado: {Calculadora.Multiplicar(num1, num2)}");
                break;
            case "4":
                try
                {
                    Console.WriteLine($"Resultado: {Calculadora.Dividir(num1, num2)}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }
    }
}

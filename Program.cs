Console.Clear();
int numero;

Console.WriteLine("Digite um número");
numero = Convert.ToInt32(Console.ReadLine());

if (numero == 0)
{
Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("Seu número é zero");
Console.ResetColor();
}

if (numero > 0)
{
Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Seu número é positivo");
Console.ResetColor();
}

if (numero < 0)
{
Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Seu número é negativo");
Console.ResetColor();
}

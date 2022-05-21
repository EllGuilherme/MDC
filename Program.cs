int dividendo, divisor, resto;

Console.WriteLine("Máximo Divisor Comum (método iterativo)\n");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Digite o 1º número (a): ");
dividendo = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Digite o 2º número (b): ");
divisor = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();
do 

{
    resto = dividendo % divisor;
    dividendo = divisor; 
    divisor = resto;
}

while (resto !=0);
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"MDC(a, b) = {dividendo}");
Console.ResetColor();
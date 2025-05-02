Console.Clear();

int numero1;            
int numero2;  
int numero3; 

Console.Write("Insira o primerio número____ ");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Insira o segundo número_____ ");
numero2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Insira o terceiro número____ ");
numero3 = Convert.ToInt32(Console.ReadLine());
 if (numero1>numero2 && numero1>numero3)
{

Console.Write($"O maior número é ... {numero1}");

}
if (numero2>numero1 && numero2>numero3)
{

Console.Write($"O maior número é ... {numero2}");

}
if (numero3>numero1 && numero3>numero2)
{

Console.Write($"O maior número é ... {numero3}");

}
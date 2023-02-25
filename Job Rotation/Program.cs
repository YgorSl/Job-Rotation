
int valor, a = 0, b = 1, c = 0;
Console.Write("Digite um número inteiro positivo: ");
valor = Convert.ToInt32(Console.ReadLine());

while (c < valor)
{
    c = a + b;
    a = b;
    b = c;
}

if (c == valor)
{
    Console.WriteLine($"{valor} pertence à sequência de Fibonacci.");
   
}

else
{
    Console.WriteLine($"{valor} não pertence à sequência de Fibonacci.");
   
}

Console.Write($"Sequência de Fibonacci até { valor}: 0, 1");
a = 0; b = 1; c = 1;

while (c <= valor)
{
    Console.Write($", {c}");
    a = b;
    b = c;
    c = a + b;
}
Console.WriteLine();
 


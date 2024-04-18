int inicial = 0, final = 0, aux = 0;
    
Console.WriteLine("Digite um numero inicial: ");
inicial = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um numero final: ");
final = int.Parse(Console.ReadLine());

aux = inicial;
for (int i = inicial+1; i < final; i++){
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} é par!");
    }
    else
    {
        Console.WriteLine($"{i} impar!");
    }
}


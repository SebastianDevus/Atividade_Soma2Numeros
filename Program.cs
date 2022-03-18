int nr1, nr2, resultado;

Console.WriteLine("Soma entre Números\n");

Console.Write("Por favor, digite o primeiro número: ");
nr1 = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Por favor, digite o segundo número: ");
nr2 = Convert.ToInt32(Console.ReadLine()!);

resultado = nr1 + nr2;

Console.WriteLine($"O resultado é: {resultado}");
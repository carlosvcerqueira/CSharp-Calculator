static void Menu()
{
    Console.Clear();

    System.Console.WriteLine("O que deseja fazer?");
    System.Console.WriteLine("1 = Soma");
    System.Console.WriteLine("2 = Subtração");
    System.Console.WriteLine("3 = Multiplicação");
    System.Console.WriteLine("4 = Divisão");
    System.Console.WriteLine("5 = Sair");
    System.Console.WriteLine("--------------");
    System.Console.WriteLine("Selecione um opção: ");

    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Multiplicacao(); break;
        case 4: Divisao(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Soma()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    System.Console.WriteLine("");

    float resultado = v1 + v2;
    System.Console.WriteLine($"O resultado da soma é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

    System.Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(System.Console.ReadLine());

    System.Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(System.Console.ReadLine());

    System.Console.WriteLine("");

    float resultado = v1 - v2;
    System.Console.WriteLine($"O resultado da subtração é: {resultado}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    System.Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(System.Console.ReadLine());

    System.Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(System.Console.ReadLine());

    System.Console.WriteLine("");

    float resultado = v1 * v2;
    System.Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    Console.ReadKey();
    Menu();

}

static void Divisao()
{
    Console.Clear();

    System.Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(System.Console.ReadLine());

    System.Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(System.Console.ReadLine());

    System.Console.WriteLine("");

    float resultado = v1 / v2;
    System.Console.WriteLine($"O resultado da subtração é: {resultado}");
    Console.ReadKey();
    Menu();

}

Menu();
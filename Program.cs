string nome;
string sobrenome;

Console.Clear();

Console.Write("Digite seu primeiro nome: ");
nome = Console.ReadLine()!;

Console.Write("Digite seu sobrenome: ");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome do catálogo: {sobrenome.ToUpper()}, {nome}");

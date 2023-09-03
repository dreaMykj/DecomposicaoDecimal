Console.WriteLine("--- Decomposição Decimal ---");

Console.Write("Digite um número inteiro...:");
int numero = Convert.ToInt32(Console.ReadLine());

int restante = numero;

int unidade = restante % 10;
restante /= 10;

int dezena = restante % 10;
restante /= 10;

int centenas = restante;

Console.WriteLine($"o número{numero} possui:");
Console.WriteLine($"{unidade, 10} unidades");
Console.WriteLine($"{dezena, 10} dezenas");
Console.WriteLine($"{centenas, 10} centenas.");
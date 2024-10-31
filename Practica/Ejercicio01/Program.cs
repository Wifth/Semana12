// See https://aka.ms/new-console-template for more information

int[] lista = new int[5];

Random rnd = new Random();
for (int x = 0 ; x < lista.Length; x++)
{
    lista[x] = rnd.Next(1, 10 + 1);
}

foreach (int x in lista)
{
    Console.WriteLine(x);
}

Console.Write("\nIngrese nuevo número: ");
int n = Convert.ToInt32(Console.ReadLine());

Array.Resize(ref lista, lista.Length + 1);
lista[lista.Length - 1] = n;

Console.WriteLine();

foreach (int x in lista)
{
    Console.WriteLine(x);
}
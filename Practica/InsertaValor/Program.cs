// See https://aka.ms/new-console-template for more information

void imprime(int[] lis)
{
    foreach (int x in lis)
    {
        Console.WriteLine(x);
    }
}

int[] lista = { 5, 6, 8, 9 };
// 5 = pos 0 | 6 = pos 1 | 8 = pos 2 ...

imprime(lista);

/*
 * a- pedir número y posición
 * b- aumentar tamaño de arreglo
 * c- desplazar números hacia el final hasta insertar nuevo valor
*/
Console.Write("Ingrese número a insertar: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese posición donde insertar: ");
int p = Convert.ToInt32(Console.ReadLine());

Array.Resize(ref lista, lista.Length + 1);
for (int x = lista.Length - 1; x > p; x--)
{
    // x = x-1
    lista[x] = lista[x - 1];
}

lista[p] = n;
imprime(lista);
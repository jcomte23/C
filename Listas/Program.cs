Console.WriteLine("Listas en C#");

Console.WriteLine("Lista de utiles escolares\n");

List<string> utilesEscolares = new List<string>();

utilesEscolares.Add("cuaderno");
utilesEscolares.Add("lapiz");
utilesEscolares.Add("borrador");
utilesEscolares.Add("colores");
utilesEscolares.Add("regla");

foreach (var item in utilesEscolares)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nLista sin los colores\n");
utilesEscolares.Remove("colores");
foreach (var item in utilesEscolares)
{
    Console.WriteLine(item);
}

Console.ReadKey();

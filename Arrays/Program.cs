Console.WriteLine("Cafeteria");

string[] coffeTypes;
float[] coffeValues;

coffeTypes = new string[] { "Coffee express", "Long coffee", "filtered coffee", "Coffee latte" };
coffeValues = new float[] {1.2f,1.5f,5f,5.5f};

Console.WriteLine("Menu\n");
for (int i = 0; i < coffeTypes.Length; i++)
{
    Console.WriteLine(coffeTypes[i] + " = " + coffeValues[i]+ "€ Euros");
}
Console.WriteLine("\nBye");
Console.ReadKey();


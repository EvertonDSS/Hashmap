namespace Hashmap;

public class Executar
{
    static void Main(string[] args)
    {
        IDictionary<int, string> flowerNames = new Dictionary<int, string>();

        flowerNames.Add(1, "Rose");
        flowerNames.Add(2, "Jasmine");
        flowerNames.Add(3, "Lili");

        foreach (KeyValuePair<int, string> kvp in flowerNames)
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
    }
}
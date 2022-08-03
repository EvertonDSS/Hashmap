namespace Hashmap;

public class Executar
{
    static void Main(string[] args)
    {
        SortedDictionary<int, string> flowerNames = new SortedDictionary<int, string>();

        
        flowerNames.Add(2, "Jasmine");
        flowerNames.Add(3, "Tulip");
        flowerNames.Add(1, "Rose");
        string resultado;

        if (flowerNames.TryGetValue(4, out resultado))
        {
            Console.WriteLine(resultado);
        }
        else
        {
            Console.WriteLine("Não encontrado");
        }

        bool containsKey;
        Console.WriteLine(containsKey = flowerNames.ContainsKey(3));

        Console.WriteLine(flowerNames.Contains(new KeyValuePair<int, string>(3, "Tulip")));

        // flowerNames.Remove(3);
        Console.WriteLine(containsKey = flowerNames.ContainsKey(3));

        ///
        ///
        IDictionary<string, int> dic2 = new SortedDictionary<string, int>();
    
        // Adicionando strings e chaves do tipo int
        dic2.Add("zebra", 5);
        dic2.Add("cachorro", 2);
        dic2.Add("gato", 9);
        dic2.Add("pardal", 4);
        dic2.Add("C#", 100);
        
        if (dic2.ContainsKey("gato"))
        {
            Console.WriteLine("tem um gato ai...");
        }

        // Verifica se tem zebra 
        if (dic2.ContainsKey("zebra"))
        {
            Console.WriteLine("Deu zebra pois não tem zebra ai...");
        }

        // Verifica se contém C#
        // e se tiver pega o valor
        int v;
        if (dic2.TryGetValue("C#", out v))
        {
            Console.WriteLine(v);
        }
        
        // Imprime o SortedDictionary em ordem alfabética
        foreach (KeyValuePair<string, int> p in dic2)
        {
            Console.WriteLine("{0} = {1}", p.Key, p.Value);
        }
   

        foreach (KeyValuePair<int,string> pw in flowerNames)
        {
            Console.WriteLine("{0} = {1}", pw.Key, pw.Value);
        }
        
        Console.ReadKey();
    }
}
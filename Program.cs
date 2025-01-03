//=============================================================
//🔷🔷🔷🔷🔷=== Author: janluksoft@interia.pl ===🔷🔷🔷🔷🔷
//─────────────────────────────────────────────────────────────

using FlyAccessories;

namespace Indexers;

class Program // Program "indexers"
{
    static void Main(string[] args)
    {
        Console.WriteLine("The 'Indexers' program is starting ...");

        // Demonstration of using classes with indexers
        Console.WriteLine("==== Demonstration of using classes with indexers ====");

        //--- Indexers ------------------
        CBaskets cbask = new CBaskets();

        Console.WriteLine("\n\rHot Air Balloon baskets with indexer by [index]:");
        for (int i = 0; i < cbask.Size; i++)
            cbask.Print(cbask[i]);

        Console.WriteLine("\n\rHot Air Balloon baskets with indexer by [name]:");
        cbask.Print(cbask["Dry-08"]);
        cbask.Print(cbask["Bas-N12"]);
        cbask.Print(cbask["Bas-N05"]);
        cbask.Print(cbask["yyy"]); // null

        //--- Indexers ------------------
        CJetEngines cjet = new CJetEngines();

        Console.WriteLine("\n\rJetEngines with indexer by [index]:");
        for (int i = 0; i < cjet.Size; i++)
            cjet.Print(cjet[i]);

        Console.WriteLine("\n\rJetEngines with indexer by [name]:");
        cjet.Print(cjet["TRENT-892"]);
        cjet.Print(cjet["CF6-80E1A4"]);
        cjet.Print(cjet["x"]);

        Console.ReadKey();
    }
}


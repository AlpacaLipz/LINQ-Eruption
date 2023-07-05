// See https://aka.ms/new-console-template for more information
List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};    


// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
IEnumerable<Eruption> hawaiiEruptions = eruptions.Where(h => h.Location == "Hawaiian Is");
PrintEach(hawaiiEruptions, "Hawaiian Eruptions");
IEnumerable<Eruption> greenlandEruptions = eruptions.Where(h => h.Location == "Greenland");
PrintEach(greenlandEruptions, "Greenland Eruptions");
IEnumerable<Eruption> nineteenEruptions = eruptions.Where(n => n.Location == "New Zealand").Where(y => y.Year > 1900);
PrintEach(nineteenEruptions, "Eruptions after the year 1900 in New Zealand");
IEnumerable<Eruption> elevationEruptions = eruptions.Where(e => e.ElevationInMeters > 2000);
PrintEach(elevationEruptions, "Eruptions where the elevation is above 2000m");
IEnumerable<Eruption> elEruptions = eruptions.Where(l => l.Volcano.Contains("L"));
PrintEach(elEruptions, "Eruptions where volcanos begin with L");
int elevation = eruptions.Max(e => e.ElevationInMeters);
System.Console.WriteLine(elevation);
IEnumerable<Eruption> maxEruptions = eruptions.Where(m => m.ElevationInMeters == elevation);
PrintEach(maxEruptions, "Highest Elevation");
IEnumerable<Eruption> alphaEruptions = eruptions.Where(a => a.Volcano != null).OrderBy(a => a.Volcano);
PrintEach(alphaEruptions);
int mostEruptions = eruptions.Sum(m => m.ElevationInMeters);
System.Console.WriteLine($"Sum of all Volcanos is: {mostEruptions}");
bool twosandEruptions = eruptions.Any(y => y.Year > 2000);
System.Console.WriteLine(twosandEruptions + " There was an eruption after 2000");
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano").Take(3);
PrintEach(stratovolcanoEruptions);
IEnumerable<Eruption> oneThousandEruptions = eruptions.Where(a => a.Year < 1000).OrderBy(a => a.Volcano);
PrintEach(oneThousandEruptions, "Eruptions before 1000 AD");
IEnumerable<string> lastEruptions = eruptions.Where(a => a.Year < 1000).Select(e => e.Volcano).AsEnumerable();
foreach (string item in lastEruptions)
{
  System.Console.WriteLine(item);
}
// int alpha = eruptions.
// List<int> alphabetical = eruptions.Where( a => a.Volcano == alpha);
// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!

static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    // Console.WriteLine("\n" + msg);
    // foreach (Eruption item in items)
    // {
    //     Console.WriteLine(item.ToString());
    // }
    // int[] intElevation = new int[] {2426, 2847 , 1122, 1122, 1490, 760, 2962, 367, 1490, 1117, 2280, 3320, 2000 };
    // int sumEruptions = intElevation.Sum();
    // int intEruptions = (from num in intElevation select num).Sum();


    System.Console.WriteLine("\n" + msg);
    if (items.Count() == 0) 
    {
      System.Console.WriteLine("no " + msg + " found.");
    }
    foreach (Eruption Location in items)
    {
      System.Console.WriteLine(Location.ToString());
    }
}



// ========================= answer to number 1 ==================================
// Eruption chileEruptions = eruptions.Where(c => c.Location == "Chile").First();
// System.Console.WriteLine("Chile " + chileEruptions.Volcano);







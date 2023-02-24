namespace Inlamning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Element syre = new Element() { namn = "Syre", Z = 8, typ = "Ickemetall", smältpunkt = 54.36, kokpunkt = 90.188 };
            Element järn = new Element() { namn = "Järn", Z = 26, typ = "Metall", smältpunkt = 1811, kokpunkt = 3134 };
            Element guld = new Element() { namn = "Guld", Z = 79, typ = "Metall", smältpunkt = 1337.33, kokpunkt = 3243 };
           /* syre.Print();
              järn.Print();
              guld.Print(); */
            Element[] elements = new Element[6] { syre, järn, guld,
                new Element() { namn = "Väte", Z = 1, typ = "Ickemetall", smältpunkt = 13.99, kokpunkt = 20.271 },
                new Element() { namn = "Brom", Z = 35, typ = "Ickemetall", smältpunkt = 265.8, kokpunkt = 332.0 },
                new Element() { namn = "Kvicksilver", Z = 80, typ = "Metall", smältpunkt = 234.3210, kokpunkt = 629.88 } };
            foreach(Element e in elements)
            {
                e.Print();
            }
        }
        class Element
        {
            public string namn, typ;
            public double Z, smältpunkt, kokpunkt;
            public void Print()
            {
                Console.WriteLine($"Grundämne: {namn}");
                Console.WriteLine($"  Atomnummer: {Z}");
                Console.WriteLine($"  Typ: {typ}");
                Console.WriteLine($"  Smältpunkt: {smältpunkt}");
                Console.WriteLine($"  Kokpunkt: {kokpunkt}\n");
            }
        }
    }
}
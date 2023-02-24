namespace Inlamning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Element syre = new Element() { namn = Syre, Z = 8, typ = Ickemetall, smältpunkt = 54.36, kokpunkt = 90.188 };
            Element järn = new Element() { namn = Järn, Z = 26, typ = Metall, smältpunkt = 1811, kokpunkt = 3134 };
            Element guld = new Element() { namn = Guld, Z = 79, typ = Metall, smältpunkt = 1337.33, kokpunkt = 3243 };
        }
        class Element
        {
            public string namn, typ;
            public double Z, smältpunkt, kokpunkt;
        }
    }
}
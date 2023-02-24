namespace Inlamning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Element syre = new Element() { namn = Syre, Z = 8, typ = ickemetall, smältpunkt = 54.36, kokpunkt = 90.188 };
        }
        class Element
        {
            public string namn, typ;
            public double Z, smältpunkt, kokpunkt;
        }
    }
}
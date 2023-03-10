namespace IDP_assg_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grundämne grund1 = new Grundämne();
            grund1.namn = "syre";
            grund1.Z = 8;
            grund1.typ = "ickemetall";
            grund1.smältpunkt = 54.36;
            grund1.kokpunkt = 90.188;

            Grundämne grund2 = new Grundämne();
            grund2.namn = "järn";
            grund2.Z = 26;
            grund2.typ = "metall";
            grund2.smältpunkt = 1811;
            grund2.kokpunkt = 3134;

            Grundämne grund3 = new Grundämne();
            grund3.namn = "guld";
            grund3.Z = 79;
            grund3.typ = "metall";
            grund3.smältpunkt = 1337.33;
            grund3.kokpunkt = 3243;

            grund1.Print();
            grund2.Print();
            grund3.Print();

            Console.ReadLine();
            
        }
    }
}
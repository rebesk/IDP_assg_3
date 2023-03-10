namespace IDP_assg_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grundämne grund1 = new Grundämne("syre", 8 , "ickemetall", 54.36, 90.188);
            /*grund1.namn = "syre";
            grund1.Z = 8;
            grund1.typ = "ickemetall";
            grund1.smältpunkt = 54.36;
            grund1.kokpunkt = 90.188;*/

            Grundämne grund2 = new Grundämne("järn", 26, "metall", 1811, 3134);
            /*grund2.namn = "järn";
            grund2.Z = 26;
            grund2.typ = "metall";
            grund2.smältpunkt = 1811;
            grund2.kokpunkt = 3134;*/

            Grundämne grund3 = new Grundämne("guld", 79, "metall", 1337.33, 3243);
            /*grund3.namn = "guld";
            grund3.Z = 79;
            grund3.typ = "metall";
            grund3.smältpunkt = 1337.33;
            grund3.kokpunkt = 3243;*/

            /*grund1.Print();
            grund2.Print();
            grund3.Print();*/

            Grundämne[] grunder = new Grundämne[6];
            grunder[0] = grund1;
            grunder[1] = grund2;
            grunder[2] = grund3;
            grunder[3] = new Grundämne("väte", 1, "ickemetall", 13.99, 20.271);
            grunder[4] = new Grundämne("brom", 35, "ickemetall", 265.8, 332.0);
            grunder[5] = new Grundämne("kvicksilver", 80, "metall", 234.3210, 629.88);

            PrintArray(grunder);
            
            
            static void PrintArray(Grundämne[] grunder)
            {
                foreach (Grundämne i in grunder)
                {
                    if (i != null)
                    {
                        i.Print();
                    }
                }
            }

            Console.WriteLine("Metaller: ");

            foreach (Grundämne metall in grunder)
            {
                if (metall.typ == "metall")
                {
                    Console.WriteLine(metall.namn);
                }
            }

            Console.ReadLine();
            
        }
    }
}
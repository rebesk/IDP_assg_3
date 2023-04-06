using System.Data;
using System.Globalization;

namespace MJU23v_DTP_T1
{
    public class Language
    {
        public string family, group;
        public string language, area, link;
        public int pop;
        public Language(string line)
        {
            string[] field = line.Split("|");
            family = field[0];
            group = field[1];
            language = field[2];
            pop = (int)double.Parse(field[3], CultureInfo.InvariantCulture);
            area = field[4];
            link = field[5];
        }
        public void Print()
        {
            Console.WriteLine($"Language {language}:");
            Console.Write($"  family: {family}");
            if (group != "")
                Console.Write($">{group}");
            Console.WriteLine($"\n  population: {pop}");
            Console.WriteLine($"  area: {area}");
        }
    }
    public class Program
    {
        static string dir = @"..\..\..";
        static List<Language> eulangs = new List<Language>();
        static void Main(string[] arg)
        {
            using (StreamReader sr = new StreamReader($"{dir}\\lang.txt"))
            {
                Language lang;
                string line = sr.ReadLine();
                while (line != null)
                {
                    // Console.WriteLine(line);
                    lang = new Language(line);
                    eulangs.Add(lang);
                    line = sr.ReadLine();
                }
            }

            Console.WriteLine("==== Languages in Spain ====");
            foreach (Language L in eulangs)
            {
                int index = L.area.IndexOf("Spain");
                if (index != -1)
                    L.Print();
            }
            Console.WriteLine("==== Baltic Languages ====");
            foreach (Language L in eulangs)
            {
                int index = L.group.IndexOf("Baltic");
                if (index != -1)
                    L.Print();
            }
            Console.WriteLine("==== Population larger than 50 millions ====");
            foreach (Language L in eulangs)
            {
                if (L.pop >= 50_000_000)
                    L.Print();
            }
            Console.WriteLine("==== Number of Germanics ====");
            int sumgerm = 0;
            foreach (Language L in eulangs)
            {
                int index = L.group.IndexOf("Germanic");
                if (index != -1)
                    sumgerm += L.pop;
            }
            Console.WriteLine($"Germanic speaking population: {sumgerm}");
            Console.WriteLine("==== Number of Romance ====");
            int sumromance = 0;
            foreach (Language L in eulangs)
            {
                int index = L.group.IndexOf("Romance");
                if (index != -1)
                    sumromance += L.pop;
            }
            Console.WriteLine($"Romance speaking population: {sumromance}");

            Console.Write(" > ");
            string command = Console.ReadLine();

            do
            {

                if (command == "help") //TODO: add more information to the lists
                {
                    Console.WriteLine("Choose between these commands: \n");
                    Console.WriteLine("list group 'groupname'");
                    Console.WriteLine("list country 'countryname'");
                    Console.WriteLine("list between 'lownumber' and 'highnumber'");
                    Console.WriteLine("show 'language'");
                    Console.WriteLine("show group 'groupname'");
                    Console.WriteLine("show country 'countryname");
                    Console.WriteLine("show between 'lownumber' and 'highnumber'");
                    Console.WriteLine("population group 'groupname'");
                    Console.WriteLine("help");
                    Console.WriteLine("quit");
                    
                } else if (command == "list country ")
                {

                    string language = Console.ReadLine();

                }
            } while (command != "quit");
        }
    }
}
/* Lista planering:
 * 1 . Skapa en grundläggande meny med 'quit' och 'help'
 * 2 . Skapa metod för list country countryname , en lista för vilka språk som talas i det landet
 * 3 . Skapa en metod för show country countryname , visa information som cirkulerar det angivna landet
 * 4 . Skapa en metod för show language (liknande punkt 4 metodmässigt) , visa information om språket
 * 5 . Skapa en metod för list group group name , visa länder som tillhör den angivna språkgruppen
 * 6 . Skriv in resterande fråge-kommandon med //NYI - kommmentarer
 */
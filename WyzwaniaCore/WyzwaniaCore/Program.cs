using System;
using System.IO;


namespace WyzwaniaCore
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime TD = new DateTime();
            TD = DateTime.Today;

            Challenge NoCandy = new Challenge("NoCandy",7,100);

            Console.WriteLine("Witaj w programie wyzwania!");
            Console.WriteLine("Wpisz swoje imię:");
            
            Player gracz = new Player(Console.ReadLine());


            Console.WriteLine("Dzisiejsza data: "+TD.ToString(@"dd\.MM\.yyyy"));
            Console.WriteLine("Nazwa: "+NoCandy.Name);
            Console.WriteLine("Ilość doświadczenia do zdobycia:"+NoCandy.Exp);

            Console.WriteLine(String.Format("Pierwszy dzień: "+ NoCandy.StartDay.ToString(@"dd\.MM\.yyyy")));
            Console.WriteLine(String.Format("Ostatni dzień: "+ NoCandy.EndDay.ToString(@"dd\.MM\.yyyy")));
            Console.WriteLine(String.Format("Wszystkie dni wyzwania: "+ NoCandy.TotalDuration.ToString("%d")));

            Console.WriteLine("Ile jeszcze dni do końca: "+ NoCandy.HowManyMoreDays(TD).ToString("%d"));

            
            DirectoryInfo[] cDirs = new DirectoryInfo(@"d:\").GetDirectories();

            // Write each directory name to a file.
            using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name);
                    
                }
                sw.Close();
            }

            string line = "";
            using (StreamReader sr = new StreamReader("CDriveDirs.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                sr.Close();
            }
            
            /*using (var streamWriter = new StreamWriter("Challenges.txt"))
            {
                streamWriter.WriteLine(NoCandy.Name+";"+NoCandy.QuantityDays+";"+NoCandy.CurrentDay+";"+NoCandy.Exp);
            }*/
            /* using (var streamReader = new StreamReader("text.txt"))
             {
                 Console.WriteLine(streamReader.ReadToEnd());
             }*/

            Console.ReadLine();
        }
    }
}

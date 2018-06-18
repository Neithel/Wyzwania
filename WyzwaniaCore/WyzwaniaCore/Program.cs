using System;
using System.IO;


namespace WyzwaniaCore
{
    class Program
    {
        static void Main(string[] args)
        {

            Challenge NoCandy = new Challenge("NoCandy",7,100);

            Console.WriteLine("Witaj w programie wyzwania!");
            Console.WriteLine("Wpisz swoje imię:");
            
            Player gracz = new Player(Console.ReadLine());

            Console.WriteLine(NoCandy.HowManyMoreDays());


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

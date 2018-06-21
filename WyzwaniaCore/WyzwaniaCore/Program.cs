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

            Console.WriteLine("Witaj w programie WYZWANIA!");

            Console.WriteLine("1-Zaloguj się");
            Console.WriteLine("2-Stwórz nowe konto");
            Console.WriteLine("3-Wyjdź");

            int caseSwitch = Convert.ToInt32(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    {
                        Console.WriteLine("Zaloguj się");
                        break;
                    }
                    
                case 2:
                    {
                        Console.WriteLine("Stwórz nowe konto");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wyjdź");
                        break;
                    }
            }







            Console.WriteLine("Wpisz Swój:");
            
            Player gracz = new Player(Console.ReadLine());


            Console.WriteLine("Dzisiejsza data: "+TD.ToString(@"dd\.MM\.yyyy"));
            Console.WriteLine("Nazwa: "+NoCandy.Name);
            Console.WriteLine("Ilość doświadczenia do zdobycia:"+NoCandy.Exp);

            Console.WriteLine(String.Format("Pierwszy dzień: "+ NoCandy.StartDay.ToString(@"dd\.MM\.yyyy")));
            Console.WriteLine(String.Format("Ostatni dzień: "+ NoCandy.EndDay.ToString(@"dd\.MM\.yyyy")));
            Console.WriteLine(String.Format("Wszystkie dni wyzwania: "+ NoCandy.TotalDuration.ToString("%d")));

            Console.WriteLine("Ile jeszcze dni do końca: "+ NoCandy.HowManyMoreDays(TD).ToString("%d"));

            //-------------------------------------------------------------Cwiczenia z zapisem i odczytem---------------------------------------------------------------------------
            string[] zm1 = new string[3];
            try
            {
                using(StreamWriter sw = new StreamWriter(("BazaDanych/NoCandy.txt"),false))
                {
                    sw.WriteLine(NoCandy.StartDay.ToString(@"dd\.MM\.yyyy"));
                    sw.WriteLine(NoCandy.EndDay.ToString(@"dd\.MM\.yyyy"));
                    sw.WriteLine(NoCandy.TotalDuration.ToString("%d"));
                }
                using (StreamReader sr = new StreamReader("BazaDanych/NoCandy.txt"))
                {
                    string linijka;
                    int i = 0;
                    
                    while ((linijka = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linijka);
                        zm1[i] = linijka;
                        i++;
                    }
                    Console.WriteLine(zm1[0]);
                    Console.WriteLine(zm1[1]);
                    Console.WriteLine(zm1[2]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            DateTime myDate = DateTime.ParseExact(zm1[0], "dd.MM.yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine(myDate.ToString(@"dd\.MM\.yyyy"));

            Console.ReadLine();
        }
    }
}


/*DateTime myDate = DateTime.ParseExact("2009-05-08 14:40:52,531", "yyyy-MM-dd HH:mm:ss,fff",
                                       System.Globalization.CultureInfo.InvariantCulture);*/

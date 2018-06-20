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

            //-------------------------------------------------------------Cwiczenia z zapisem i odczytem---------------------------------------------------------------------------

            try
            {
                using(StreamWriter sw = new StreamWriter(("d:/tekst.txt"),true))
                {
                    sw.Write("Dzisiejsza data: " + TD.ToString(@"dd\.MM\.yyyy"));
                    sw.WriteLine(";");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Foredrag
{
    public class LaveForedrag
    {
        
        public static void ForedragLærer()
        {
            string Mikkel = "Mikkel",ForedragInput,LærerInput,data, Pernille = "Pernille", Alex = "Alex";
            StreamWriter writer = null;
            StreamReader reader = null;
        bool Foredragloop = true;
            
            do
            {
                Console.Clear();           
                Console.WriteLine("Skrive en af de lærer: Mikkel, Pernille, Alex");
                LærerInput = Console.ReadLine();

                if(LærerInput == Mikkel)
                {
                    
                    try
                    {
                        reader = new StreamReader(@"C:\Users\lucpin\Desktop\Foredrag\ForedragMatematik.txt");
                        
                        data = reader.ReadLine();
                        while (data != null)
                        {
                            Console.WriteLine(data);
                            data = reader.ReadLine();
                        }
                        reader.Close();
                        writer = new StreamWriter(@"C:\Users\lucpin\Desktop\Foredrag\ForedragMatematik.txt");
                        writer.WriteLine(@"Matematik");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    Console.Clear();
                    Console.WriteLine("Skrive dit fordrag");
                    ForedragInput = Console.ReadLine();
                    writer.WriteLine(ForedragInput);
                    writer.Close();
                    Foredragloop = false;
                }
                else if (LærerInput == Pernille)
                {
                    try
                    {
                        reader = new StreamReader(@"C:\Users\lucpin\Desktop\Foredrag\ForedragDansk.txt");

                        data = reader.ReadLine();
                        while (data != null)
                        {
                            Console.WriteLine(data);
                            data = reader.ReadLine();
                        }
                        reader.Close();
                        writer = new StreamWriter(@"C:\Users\lucpin\Desktop\Foredrag\ForedragDansk.txt");
                        writer.WriteLine(@"Dansk");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    Console.Clear();
                    Console.WriteLine("Skrive dit fordrag");
                    ForedragInput = Console.ReadLine();
                    writer.WriteLine(ForedragInput);
                    writer.Close();
                    Foredragloop = false;
                }
            }
            while (Foredragloop);
        }
    }

}


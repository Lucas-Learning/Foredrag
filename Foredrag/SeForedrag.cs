using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Foredrag
{
     public class SeForedrag
    {
        public static void ForedragSe()
        {
            StreamReader reader = null;
            string data;
            Console.Clear();
                try
                {
                    reader = new StreamReader(@"C:\Users\lucpin\Desktop\Foredrag\ForedragMatematik.txt");

                    data = reader.ReadLine();
                    while (data != null)
                    {
                        Console.WriteLine(data);
                        data = reader.ReadLine();
                        
                    }
                    Console.ReadKey();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            
        }
    }
}

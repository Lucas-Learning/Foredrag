using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Foredrag_Login
{
    public class LoginMenu
    {
        public string FilePath { get; set; }
        public string ID { get; set; }
        public string Navn { get; set; }
        public string Level { get; set; }
        public string Alder { get; set; }

        public static void LoginInfo(string SchoolID, string Name)
        {
            LoginMenu Path = new LoginMenu();
            Path.FilePath = @"C:\Users\lucpin\Desktop\Foredrag\LoginKonto.txt";

            string[] lines = File.ReadAllLines(Path.FilePath);

            foreach (string line in lines)
            {

                string[] parts = line.Split(',');
                if (parts.Length == 4)
                {
                  string CorrectID = parts[0];
                  Path.Navn = parts[1];
                  Path.Alder =parts[2];
                  Path.Level = parts[3];
                }
                if ()
                {

                }
                
            }
            Console.ReadLine();
        }
    }
}

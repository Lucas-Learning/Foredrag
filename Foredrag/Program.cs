using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Foredrag_Opgave
{
    /*public class Lokale
    {
        public string LokaleName = "TEC_GF2";
    }
        public class Foredrag : Lokale
        {
            public int Antal_Elever = 10;
            public string Information { get; set; }

            public string MatLære = "Mikkel";

            public string FyLære = "Pernille";

        }
        public class Person
        {
            public string[] Name ={"Lucas","Clement","Johan","Sofia","Salih","Andrea","Victoria","Martin","Caio","Hans","Mikkel","Pernille"};
        }
           public class Lære : Person
            {
            public string Fag { get; set; }
            public string ForedragList { get; set; }
            }
            public class Elev : Person
            {
                public string ForedragListElev { get; set; }*/
            }

class Program
{
   
    public string InputID { get; set; }
    public string NavnInput { get; set; }
    public static int chooseAdmin { get; set; }
    public static void Main(string[] args)

    {
        bool MenuLoop = true;
        bool LoginLoop = false;
        
        Foredrag_Login.LoginMenu login = new Foredrag_Login.LoginMenu();

        login.FilePath = @"C:\Users\lucpin\Desktop\Foredrag\LoginKonto.txt";

        string[] lines = File.ReadAllLines(login.FilePath);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 4)
            {
                login.ID = parts[0];
                login.Navn = parts[1];
                login.Alder = parts[2];
                login.Level = parts[3];
            }
        }
        do
        {

            Console.WriteLine("ID: ");
            login.InputID = Console.ReadLine();
            Console.WriteLine("Navn: ");
            login.NavnInput = Console.ReadLine();

            if (login.InputID == login.ID && login.NavnInput == login.Navn)
            {
                LoginLoop = true;
            }
            else
            {
                Console.WriteLine("Something is wrong");
                Console.ReadKey();
                Console.Clear();
                

            }
        }
        while (LoginLoop == false);
        do
        {
            Console.Clear();
            if (login.Level == "2")
            {
                Console.WriteLine($"ID:{login.ID}   Navn:{login.Navn}   Alder:{login.Alder}   Level:{login.Level}");
                Console.WriteLine("\n1.Lave et foredrag");
                Console.WriteLine("\n9.Exit");
                try
                {
                    chooseAdmin = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Skrive igen");
                }

                switch (chooseAdmin)
                {
                    case 1:
                        Foredrag.LaveForedrag.ForedragLærer();
                        break;
                    case 9:
                        MenuLoop = false;
                        break;
                }

            }
        }
        while (MenuLoop);
        
        /*Console.WriteLine("Skrive dit foredrag");
           string foredrag = Console.ReadLine();
          
           Console.WriteLine("Skrive hvem der er læren");
           Console.WriteLine("Du har Mikkel og Pernille");
            
           
           File.WriteAllText("ForedragInformation.txt", foredrag);
           Console.WriteLine();
           
           /*Lære list = new Lære();
           Elev listElev = new Elev();
           list.ForedragList = foredrag.Information;
           listElev.ForedragListElev = foredrag.Information;*/

       
        
    }
    
}


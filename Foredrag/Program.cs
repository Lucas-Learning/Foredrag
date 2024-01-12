using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Foredrag
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
    public static int chooseElev { get; set; }
    public bool whl { get; set; }
    
    
    public static void Main(string[] args)

    {
        bool MenuLoop = true;
        bool LoginLoop = false;
        do
        {
            
            Console.Write("ID: ");
            Foredrag.LoginMenu.InputID = Console.ReadLine();
            Console.Write("Navn: ");
            Foredrag.LoginMenu.NavnInput = Console.ReadLine();
            Login();
            if (found)
            {
                break;
            }
        }
        while (LoginLoop == false);
        do
        {
            Console.Clear();
            if (Foredrag.LoginMenu.Level == "2")
            {
                Console.WriteLine($"ID:{Foredrag.LoginMenu.ID}   Navn:{Foredrag.LoginMenu.Navn}   Alder:{Foredrag.LoginMenu.Alder}   Level:{Foredrag.LoginMenu.Level}");
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
            if (Foredrag.LoginMenu.Level == "1")
            {
                Console.WriteLine($"ID:{Foredrag.LoginMenu.ID}   Navn:{Foredrag.LoginMenu.Navn}   Alder:{Foredrag.LoginMenu.Alder}   Level:{Foredrag.LoginMenu.Level}");
                Console.WriteLine("\n1.Se et foredrag");
                Console.WriteLine("\n9.Exit");
            }
            
                try
                {
                    chooseElev = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Skrive igen");
                }
            
            switch (chooseElev)
            {
                case 1:
                    Foredrag.SeForedrag.ForedragSe();
                    break;
                case 9:
                    MenuLoop = false;
                    break;
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
    public static bool found { get; set; }
    public static void Login()
    {
        found = false;

        Foredrag.LoginMenu.FilePath = @"C:\Users\lucpin\Desktop\Foredrag\LoginKonto.txt";
        string[] lines = File.ReadAllLines(Foredrag.LoginMenu.FilePath);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 4)
            {
                
                Foredrag.LoginMenu.ID = parts[0];
                Foredrag.LoginMenu.Navn = parts[1];
                Foredrag.LoginMenu.Alder = parts[2];
                Foredrag.LoginMenu.Level = parts[3];

                if (Foredrag.LoginMenu.InputID == Foredrag.LoginMenu.ID && Foredrag.LoginMenu.NavnInput == Foredrag.LoginMenu.Navn)
                    {
                        found = true;
                        Console.ReadLine();
                        return;
                    } 
            }
        }
        if (!found)
        {
            Console.WriteLine("Something is wrong");
            Console.ReadKey();
            Console.Clear();
        }
    }
}


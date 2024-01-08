using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Foredrag_Opgave
{
    public class Lokale
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
                public string ForedragListElev { get; set; }
            }
    
    class Program
    {
        static void Main(string[] args)
        {
            bool MenuLoop = false;
            do
            {
                Foredrag_Login.LoginMenu login = new Foredrag_Login.LoginMenu();
                Console.WriteLine("ID: ");
                login. = Console.ReadLine();
                Console.WriteLine("Navn: ");

            }
            while (MenuLoop == false);
           Foredrag foredrag = new Foredrag();
           Console.WriteLine("Skrive dit foredrag");
           foredrag.Information = Console.ReadLine();
           Lære lære = new Lære();
           Console.WriteLine("Skrive hvem der er læren");
           Console.WriteLine("Du har Mikkel og Pernille");
            
           
           File.WriteAllText("ForedragInformation.txt", foredrag.Information);
           Console.WriteLine();
           
           /*Lære list = new Lære();
           Elev listElev = new Elev();
           list.ForedragList = foredrag.Information;
           listElev.ForedragListElev = foredrag.Information;*/

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace KasaSklepowa
{
    public class Display
    {
        public static void WelcomeDisplay()
        {
            Console.WriteLine(@"Witaj w programie ""kasa sklepowa"".");
            Console.WriteLine("Naciśnij enter aby rozpocząć skanowanie");
            Console.ReadLine();
        }

        public static void AskForNumber()
        {
            Console.WriteLine("Podaj kod towaru");
            Console.WriteLine("Jeżeli chcesz zakończyć zakupy wćiśnij 'x'");
        }

        public static void AddedProduct()
        {
            Console.WriteLine("Produkt dodany do koszyka");
        }

        public static void WrongProductNumber()
        {
            Console.WriteLine("Podano niepoprawny kod towaru");
        }

    }
}

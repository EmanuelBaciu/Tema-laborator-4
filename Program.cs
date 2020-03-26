using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieTipAgenda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializarea unui obiect de tip persoana cu parametri 
            PersoaneContact persoana = new PersoaneContact("Emanuel", "0743307248", "emy_baciu@yahoo.com");
            Console.WriteLine(persoana.Info());
            Console.WriteLine(persoana.DataNasterii = new DateTime(1999,01,03)) ;

            Console.ReadKey();

            //Intantierea unui obiect de tip Persoana cu parametrii intr-un sir de caractere
            PersoaneContact p1 = new PersoaneContact("Andreea", "0756818340", "andreea@yahoo.com");
            Console.WriteLine(p1.Info());
            Console.WriteLine(p1.DataNasterii = new DateTime(1999, 07, 31));

            //Instantierea unui obiect de tip Persoana cu parametrii introdusi de la tastatura
            Console.WriteLine("\nIntroduceti numele, numarul de telefon, adresa de e-mail a persoanei de contact! ");
            PersoaneContact p2 = new PersoaneContact(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Console.WriteLine("\nIntroduceti data nasterii in ordine: anul,luna,ziua:YYYY-XZ-HH");
            p2.DataNasterii = Convert.ToDateTime(Console.ReadLine());

            //DateTime date2 = Convert.ToDateTime(Console.ReadLine());//

            Console.WriteLine(p2.Info());
            Console.WriteLine("Data nasterii:{0}", p2.nastere());
            
            Console.ReadKey();
        }
    }
}

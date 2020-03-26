using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieTipAgenda
{
    

    /// <summary>
    /// Persoanele de contact din agenda
    /// </summary>
    /// clasa persoanecontact cu parametri auto-implemented
   public class PersoaneContact
    {
        public string nume { set; get; } 
        public string numarTelefon { set; get; }
        public string adresaEmail { set; get; }

        public DateTime DataNasterii { set; get; }
        public PersoaneContact()
        {
            nume = string.Empty;
            numarTelefon = string.Empty;
            adresaEmail = string.Empty;
            

        }
        /// <summary>
        /// Constructor cu parametri
        /// </summary>
        /// <param name="numePersoana"></param>
        /// <param name="nrTel"></param>
        /// <param name="e_mail"></param>
        public PersoaneContact(string numePersoana, string nrTel, string e_mail)
       {
            nume = numePersoana;
          numarTelefon = nrTel;
            adresaEmail = e_mail;

        }
        /// <summary>
        /// Constructor care primeste un sir de caractere
        /// </summary>
        /// <param name="pers1"></param>
        public PersoaneContact(string pers1)
        {
            string[] buff = pers1.Split();
            nume = buff[0];
            numarTelefon = buff[1];
            adresaEmail = buff[2];

        }

        public string Info()
        {
            return "Persoana de contact are numele " + nume + " cu numarul de telefon: " + numarTelefon + " si adresa de e-mail: " + adresaEmail;
        }
        public string nastere()
        {
            return "Data nasterii: " + DataNasterii;
            
        }
    }
}

using System;

namespace modele

{
    public enum CategorieContact
    {
        Familie,
        Serviciu,
        Prieten,
        Altele
    }

    public enum MetodaContact
    {
        Telefon = 1,
        Email = 2,
        WhatsApp = 4,
   
    }

    public class Contact
    {
   
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public CategorieContact Categorie { get; set; }
        public MetodaContact Metode { get; set; }

        public Contact(int id, string nume, string prenume, string telefon, string email)

        {   Id = id;
            Nume = nume;
            Prenume = prenume;
            Telefon = telefon;
            Email = email;
            Categorie = CategorieContact.Altele;    
            Metode = MetodaContact.Telefon;

        }
        public Contact(int id, string nume, string prenume,string telefon, string email,CategorieContact categorie, MetodaContact metode)
        {
            Id = id;
            Nume = nume;
            Prenume = prenume;
            Telefon = telefon;
            Email = email;
            Categorie = categorie;
            Metode = metode;

        }

        public string info()
        {

            string info = $"ID:{Id} Nume:{Nume} Prenume:{Prenume} Telefon:{Telefon} Email:{Email}";
            return info ;
        }
    }
}
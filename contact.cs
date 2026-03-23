using System;

namespace Program
{
    class Contact
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public Contact(int id, string nume, string prenume, string telefon, string email)

        {   Id = id;
            Nume = nume;
            Prenume = prenume;
            Telefon = telefon;
            Email = email;            
        }
        public string info()
        {

            string info = $"ID:{Id} Nume:{Nume} Prenume:{Prenume} Telefon:{Telefon} Email:{Email}";
            return info ;
        }
    }
}
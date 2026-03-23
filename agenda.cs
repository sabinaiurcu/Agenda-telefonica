using System;
using System.Collections.Generic;


namespace Program
{
    class Agenda
    {
        public Contact CitireContactTastatura()
        {   Console.WriteLine("Introd numele contactului:");
            int urmatorul_id = 1;
            string nume=Console.ReadLine();

            Console.WriteLine("Introd prenumele contactului:");
            string prenume=Console.ReadLine();

            Console.WriteLine("Telefon:");
            string telefon = Console.ReadLine();
            
            if(telefon.Length!=10)
                {
                    Console.WriteLine("numar invalid");
                }
      
            Console.WriteLine("Email:");
            string email=Console.ReadLine();

            Contact contactNou=new Contact(urmatorul_id ,nume,prenume, telefon, email);
           
            urmatorul_id++;
            return contactNou;

        }
        public  void afisareContacte(Contact contact)
        {
            Console.WriteLine(contact.info());
        }
        public void cauta(List<Contact> contacte)
        {
            Console.WriteLine("Introd numele cautat: ");
            string cuvant = Console.ReadLine();
            bool gasit = false;
            foreach (Contact c in contacte)
            {
                if (c.Nume.ToLower() == cuvant.ToLower())
                {
                    gasit = true;
                }
            }
            if (!gasit)
            {
                Console.WriteLine("nu exista contactul");

            }
            else
            {
                Console.WriteLine("contactul exista");
            }
        }
        public void modifica()
        {

        }
        public void sterge()
        {
            
        }
    }
}

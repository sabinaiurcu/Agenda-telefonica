using modele;
using System;
using System.Collections.Generic;


namespace Program
{
    class Agenda
    {
        public Contact CitireContactTastatura()
        {
            Console.WriteLine("Introd numele contactului:");
            int urmatorul_id = 1;
            string nume = Console.ReadLine();

            Console.WriteLine("Introd prenumele contactului:");
            string prenume = Console.ReadLine();

            Console.WriteLine("Telefon:");
            string telefon = Console.ReadLine();

            if (telefon.Length != 10)
            {
                Console.WriteLine("numar invalid");
            }

            Console.WriteLine("Email:");
            string email = Console.ReadLine();

            Contact contactNou = new Contact(urmatorul_id, nume, prenume, telefon, email);

            urmatorul_id++;
            return contactNou;

        }
        public void afisareContacte(Contact contact)
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
        public void modifica(List<Contact> contacte)
        {
            Console.WriteLine("Id ul contactului pe care doriti sa il modificati: ");
            int id = int.Parse(Console.ReadLine());

            bool gasit = false;
            foreach (Contact c in contacte)
            {
                if (c.Id == id)
                {
                    gasit = true;
                    Console.WriteLine("Nume nou: ");
                    string numeNou = Console.ReadLine();
                    if (numeNou != "")
                    {
                        c.Nume = numeNou;
                    }

                    Console.WriteLine("Prenume nou: ");
                    string prenumeNou = Console.ReadLine();
                    if (prenumeNou != "")
                    {
                        c.Prenume = prenumeNou;
                    }
                }
                Console.WriteLine("Contactul a fost modificat!");
                break;
            }
            if (!gasit)
            {
                Console.WriteLine("Nu exista contact cu acest Id");
            }
        }
        public void sterge(List<Contact> contacte)
        {
            Console.WriteLine("Id ul contactului pe care doriti sa il stergeti: ");
            int id = int.Parse(Console.ReadLine());

            bool gasit = false;
            foreach (Contact c in contacte)
            {
                if (c.Id == id)
                {
                    gasit = true;
                    contacte.Remove(c);
                    Console.WriteLine("Contactul a fost sters!");
                    break;
                }
            }
            if (!gasit)
            {
                Console.WriteLine("Nu exista contact cu acest Id");
            }


        }
    }
}

using System;


namespace Program
{
    class Program
    {
        public static void Main()
        {
             Agenda agenda = new Agenda();
             int opt;
             List<Contact> contacte = new List<Contact>();
             Contact contactNou = null;
            do
            {
                Console.WriteLine("1. Adaugare contact");
                Console.WriteLine("2. Afiseaza contacte");
                Console.WriteLine("3. Cauta contact");
                Console.WriteLine("4. Modifica contact");
                Console.WriteLine("5. Sterge contact");
                Console.WriteLine("0. Iesire");
                Console.WriteLine("Optiunea dvs este:");
                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        contactNou = agenda.CitireContactTastatura();
                        contacte.Add(contactNou);
                        break;
                    case 2:
                        agenda.afisareContacte(contactNou);
                        break;
                    case 3:
                        agenda.cauta(contacte);
                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                }

            } while (opt != 0);
        }
    }
}

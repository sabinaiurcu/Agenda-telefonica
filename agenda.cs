using System;

namespace Program
{
    class Agenda
    {
        private List<Contact> contacte = new List<Contact>();  
        public void meniu()
        {
            int opt;
            do
            {
                Console.WriteLine("1. Adaugare contact");
                Console.WriteLine("2. Afiseaza contacte");
                Console.WriteLine("3. Cauta contact");
                Console.WriteLine("4. Modifica contact");
                Console.WriteLine("5. Sterge contact");
                Console.WriteLine("0. Iesire");

                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
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

        public void adaugare()
        {
            
   
        }
        public void afisare()
        {

        }
        public void cauta()
        {
            
        }
        public void modifica()
        {

        }
        public void sterge()
        {
            
        }
    }
}

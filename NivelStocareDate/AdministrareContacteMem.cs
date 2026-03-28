using modele;

namespace NivelStocareDate
{
    public class AdministrareContacteMem
    {
        private List<Contact> contacte;

        public AdministrareContacteMem()
        { 
        contacte=new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contact.Id = GetNextId();
            contacte.Add(contact);
            
        }
        public List<Contact> Getcontacte()
        {
            return contacte;
        }

        public Contact? GetContact(int id)
        {foreach (Contact contact in contacte)
            {
                if (contact.Id == id)
                {
                    return contact;
                }
            }
        return null;
        }

        public Contact? GetContact(string nume, string prenume)
        {
            return contacte?.FirstOrDefault(contact => contact.Nume.Equals(nume, StringComparison.OrdinalIgnoreCase) && contact.Prenume.Equals(prenume, StringComparison.OrdinalIgnoreCase));
        }
        public int GetNextId()
        { if(contacte.Count == 0)
            {
                return 1;
            }
            return contacte.Last().Id + 1;
        
        }

    }
}

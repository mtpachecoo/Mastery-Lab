
namespace PendingSystem.app.Entities
{

    public class Client
    {
        public string NameClient { get; set; }
        public string EmailClient {get; set;}
        public DateTime BirthDate { get; set; }
        
        public Client(){}

        public Client(string name, string email, DateTime birthdate)
        {
            NameClient = name;
            EmailClient = email;
            BirthDate = birthdate;
        }

        
        public override string ToString()
        {
            return NameClient
                + " ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + EmailClient;
        }

    }
}
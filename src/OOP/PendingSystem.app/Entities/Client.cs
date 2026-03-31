using System.Text;

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

      
    }
}
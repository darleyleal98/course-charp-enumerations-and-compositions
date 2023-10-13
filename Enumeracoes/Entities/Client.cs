using System;
using System.Text;

namespace Enumeracoes.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client() { }
        public Client(string name, string email, DateTime birthDate) 
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Client: {Name}, ({BirthDate.ToString("dd/MM/yyyy")}) - {Email}");
            return builder.ToString();
        }
    }
}

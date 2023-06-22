using System;

namespace Fix.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birth)
        {
            Name = name;
            Email = email;
            BirthDate = birth;
        }

        public override string ToString()
        {
            return Name
                + ", ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }

        // o que aprendi: que posso fazer um override tostring aqui
        // e depois só chamar o nome da classe pra compôr o stringbuilder na classe maior.
    }
}

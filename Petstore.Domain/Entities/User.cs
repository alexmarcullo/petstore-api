using Petstore.Domain.Shared.Entities;
using Petstore.Domain.ValueObject;

namespace Petstore.Domain.Entities
{
    public class User : Entity
    {
        public User(Email email, Name name, string password)
        {
            Email = email;
            Name = name;
            Password = password;
        }

        public Email Email { get; private set; }
        public Name Name { get; private set; }
        public string Password { get; private set; }
    }
}
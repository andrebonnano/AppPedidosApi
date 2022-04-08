

namespace AppPedidosApi.Domain.Entities.Users
{
    public class User
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
        public string Email { get; private set; }
        public bool Active { get; private set; }
        public string Password { get; private set; }


        public User(string name, string email, string password) : base()
        {
            Name = name;
            Email = email;
            Active = true;
            Password = password;
        }

        public void Desctivate()
        {
            Active = false;
        }
    }



}


namespace PrometheusApi.Domains.Users
{
    public class User
    {
        public int Id { get;private set;}
        public string? Name { get; private set;}
        public string? Email { get; private set;}
        public string? PasswordHash { get; private set;}
        public DateTime RegistrationDate { get; private set;}

        protected User(){}

        public User(string? name, string? email, string? passwordHash)
        {
            Name = name;
            Email = email;
            PasswordHash = passwordHash;
            RegistrationDate = DateTime.UtcNow;
        }
    }
}
namespace ClienteManager.Models
{
    public abstract class User
    {

        public User(string? username, string? email)
        {
            Id = Guid.NewGuid();
            Email = email;
            Username = username;
        }

        public Guid Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
    }
}
namespace ClienteManager.Models
{
    public class Cliente : User
    {
        public Cliente(string? email, string? username)
            : base(email, username)
        {
        }
    }
}
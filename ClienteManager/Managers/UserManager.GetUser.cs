using ClienteManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteManager.Managers
{
    public partial class UserManager
    {
        public IEnumerable<User> GetAllUsers()
        {
            return Users;
        }

        public User? GetUserByEmail(string? email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Email inválido!");
                return null;
            }

            var userToGet = Users.FirstOrDefault(x => x.Email == email);

            if (userToGet != null)
                return userToGet;

            Console.WriteLine("Usuário não encontrado");
            return null;
        }
    }
}

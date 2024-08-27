using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteManager.Managers
{
    public partial class UserManager
    {
        public void UpdateNameUser(string? username, string? email)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Nome ou Email inválido");
                return;
            }

            var userToUpdate = Users.FirstOrDefault(x => x.Email == email);

            if (userToUpdate != null)
            {
                userToUpdate.Username = username;
                Console.WriteLine("Nome atualizado");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado");
            }
        }
        public void UpdateEmailUser(string? oldEmail, string? newEmail)
        {
            if (string.IsNullOrWhiteSpace(oldEmail) || string.IsNullOrWhiteSpace(newEmail))
            {
                Console.WriteLine("Nome ou Emails inválidos");
                return;
            }

            if (Users.Any(x => x.Email == newEmail))
            {
                Console.WriteLine("Novo e-mail já está em uso");
                return;
            }

            var userToUpdate = Users.FirstOrDefault(x => x.Email == oldEmail);

            if (userToUpdate != null)
            {
                userToUpdate.Email = newEmail;
                Console.WriteLine("Email atualizado");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado");
            }
        }
    }
}

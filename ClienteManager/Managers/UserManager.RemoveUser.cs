using ClienteManager.Models;
using ClienteManager.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteManager.Managers
{
    public partial class UserManager
    {
        public void RemoveUser(User user)
        {
            if (!UserValidator.IsValid(user))
            {
                Console.WriteLine("Usuário não pode ser nulo");
                return;
            }

            var userToRemove = Users.FirstOrDefault(x => x.Id == user.Id);

            if (userToRemove != null)
            {
                Users.Remove(userToRemove);
                Console.WriteLine("Usuário deletado com sucesso");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado na lista");
            }
        }
    }
}

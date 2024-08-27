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
        public void AddUser(User user)
        {
            if (!UserValidator.IsValid(user) || UserValidator.IsDuplicate(Users, user))
            {
                Console.WriteLine("Não foi possível adicionar o usuário");
                return;
            }

            Users.Add(user);
            Console.WriteLine("Usuário adicionado com sucesso");
        }
    }
}

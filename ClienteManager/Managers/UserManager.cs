using ClienteManager.Models;
using ClienteManager.Validators;
using System.Linq;

namespace ClienteManager.Managers
{
    public partial class UserManager
    {
        public UserManager()
        {
            Users = new List<User>();
        }
        private List<User> Users { get; set; }
    }
}

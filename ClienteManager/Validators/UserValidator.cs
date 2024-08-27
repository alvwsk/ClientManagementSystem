using ClienteManager.Models;

namespace ClienteManager.Validators
{
    public abstract class UserValidator
    {
        public static bool IsValid(User user)
        {
            return user != null;
        }
        public static bool IsDuplicate(List<User> users, User user)
        {
            return users.Any(x => x.Id == user.Id);
        }
    }
}

using ClienteManager.Managers;
using ClienteManager.Models;

var userManager = new UserManager();

while (true)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1. Adicionar Usuário");
    Console.WriteLine("2. Remover Usuário");
    Console.WriteLine("3. Atualizar Nome do Usuário");
    Console.WriteLine("4. Atualizar Email do Usuário");
    Console.WriteLine("5. Listar Todos os Usuários");
    Console.WriteLine("6. Sair");

    var option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine("Digite o email:");
            string? email = Console.ReadLine();
            Console.WriteLine("Digite o nome de usuário:");
            string? username = Console.ReadLine();
            var cliente = new Cliente(username: username, email: email);
            userManager.AddUser(cliente);
            break;
        case "2":
            Console.WriteLine("Digite o email do usuário a ser removido:");
            var emailToRemove = Console.ReadLine();
            var userToRemove = userManager.GetUserByEmail(emailToRemove);
            if (userToRemove != null) { userManager.RemoveUser(userToRemove); }
            break; 
        case "3":
            Console.WriteLine("Digite o email do usuário para atualizar o nome:");
            var emailToUpdateName = Console.ReadLine();
            Console.WriteLine("Digite o novo nome de usuário:");
            var newUsername = Console.ReadLine();
            userManager.UpdateNameUser(newUsername, emailToUpdateName);
            break; 
        case "4":
            Console.WriteLine("Digite o email antigo do usuário:");
            var oldEmail = Console.ReadLine();
            Console.WriteLine("Digite o novo email do usuário:");
            var newEmail = Console.ReadLine();
            userManager.UpdateEmailUser(oldEmail, newEmail);
            break;
        case "5":
            var users = userManager.GetAllUsers();
            foreach (var u in users)
            { 
                Console.WriteLine($"ID: {u.Id}, Nome: {u.Username}, Email: {u.Email}");
            }
            break;
        case "6":
            return;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}
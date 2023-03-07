using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class UserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Vicular um perfil");
            Console.WriteLine("--------------------");
            Console.Write("Id do usuário: ");
            var userId = int.Parse(Console.ReadLine()!);

            Console.Write("Id do perfil: ");
            var roleId = int.Parse(Console.ReadLine()!);

            LinkUserRole(new UserRole()
            {
                UserId = userId,
                RoleId = roleId
            });

            Console.ReadLine();
            MenuUserScreen.Load();
        }

        public static void LinkUserRole(UserRole userRole)
        {
            try
            {
                var repository = new Repository<UserRole>(Database.Connection!);
                repository.Create(userRole);
                Console.WriteLine("Perfil vinculado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi vincular o user!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
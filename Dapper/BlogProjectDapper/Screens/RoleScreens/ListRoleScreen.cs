using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class ListRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Roles");
            Console.WriteLine("-------------");
            List();

            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        public static void List()
        {
            var repository = new Repository<Role>(Database.Connection!);
            var roles = repository.Read();

            foreach (var role in roles)
            {
                Console.WriteLine($"{role.Name} - {role.Slug}");
            }
        }
    }
}
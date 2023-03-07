using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class CreateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova Role");
            Console.WriteLine("-------------");
            Console.WriteLine("Name:");
            var name = Console.ReadLine();

            Console.WriteLine("Slug");
            var slug = Console.ReadLine();

            Create(new Role
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        public static void Create(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection!);
                repository.Create(role);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel criar uma Role");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
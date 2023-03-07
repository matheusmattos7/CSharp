using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class UpdateRoleScreen
    {
        public static void Load()
        {
            Console.WriteLine("Atualizando uma role");
            Console.WriteLine("-------------");
            Console.WriteLine("Id: ");
            var id = Console.ReadLine();

            Console.WriteLine("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Update(new Role
            {
                Id = int.Parse(id!),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuRoleScreen.Load();

        }

        public static void Update(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection!);
                repository.Update(role);
                Console.WriteLine("Post atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel atualizar o Post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
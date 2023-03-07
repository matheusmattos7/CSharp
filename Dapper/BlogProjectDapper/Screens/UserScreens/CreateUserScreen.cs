using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo user");
            Console.WriteLine("-------------");
            Console.WriteLine("Name:");
            var name = Console.ReadLine();

            Console.WriteLine("Email:");
            var email = Console.ReadLine();

            Console.WriteLine("Password:");
            var password = Console.ReadLine();

            Console.WriteLine("Bio:");
            var bio = Console.ReadLine();

            Console.WriteLine("Image:");
            var image = Console.ReadLine();

            Console.WriteLine("Slug");
            var slug = Console.ReadLine();

            Create(new User
            {
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = image,
                Slug = slug
            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection!);
                repository.Create(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar o user");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
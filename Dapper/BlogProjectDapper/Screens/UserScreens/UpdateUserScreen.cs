using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando uma tag");
            Console.WriteLine("-------------");
            Console.WriteLine("Id: ");
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

            Update(new User
            {
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = image,
                Slug = slug
            });

            MenuUserScreen.Load();
        }

        public static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection!);
                repository.Update(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o user");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
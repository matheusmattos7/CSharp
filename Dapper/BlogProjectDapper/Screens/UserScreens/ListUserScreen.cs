using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de users");
            Console.WriteLine("-------------");
            List();

            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void List()
        {
            var repository = new Repository<User>(Database.Connection!);
            var users = repository.Read();

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Id} - {user.Name} - {user.Email} - {user.Bio} - {user.Image} - {user.Slug}");
            }
        }
    }
}
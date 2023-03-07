using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class ListPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Posts");
            Console.WriteLine("-------------");
            List();

            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void List()
        {
            var repository = new Repository<Post>(Database.Connection!);
            var posts = repository.Read();

            foreach (var post in posts)
            {
                Console.WriteLine($"{post.Title} - {post.Summary} - {post.Body}");
            }
        }
    }
}
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo Post");
            Console.WriteLine("-------------");
            Console.WriteLine("Id da categoria:");
            var categoryId = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Id do Autor:");
            var authorId = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Title:");
            var title = Console.ReadLine();

            Console.WriteLine("Summary:");
            var summary = Console.ReadLine();

            Console.WriteLine("Body:");
            var body = Console.ReadLine();

            Console.WriteLine("Slug:");
            var slug = Console.ReadLine();

            Create(new Post()
            {
                CategoryId = categoryId,
                AuthorId = authorId,
                Title = title,
                Summary = summary,
                Body = body,
                Slug = slug,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now
            });

            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection!);
                repository.Create(post);
                Console.WriteLine("Post criado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel criar o post!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
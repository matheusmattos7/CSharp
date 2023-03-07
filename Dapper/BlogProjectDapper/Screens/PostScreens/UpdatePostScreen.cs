using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class UpdatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando Post");
            Console.WriteLine("-------------");

            Console.WriteLine("Id do post:");
            var id = int.Parse(Console.ReadLine()!);

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

            Update(new Post()
            {
                Id = id,
                CategoryId = categoryId,
                AuthorId = authorId,
                Title = title,
                Summary = summary,
                Body = body,
                Slug = slug
            });

            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Update(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection!);
                repository.Update(post);
                Console.WriteLine("Post atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel atualizar o post!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
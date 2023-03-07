using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class PostTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Vincular uma tag");
            Console.WriteLine("------------------");
            Console.Write("Id do post: ");
            var postId = int.Parse(Console.ReadLine()!);

            Console.Write("Id da tag: ");
            var tagId = int.Parse(Console.ReadLine()!);

            LinkPostTag(new PostTag()
            {
                PostId = postId,
                TagId = tagId
            });

            Console.ReadLine();
            MenuPostScreen.Load();
        }

        private static void LinkPostTag(PostTag postTag)
        {
            try
            {
                var repository = new Repository<PostTag>(Database.Connection!);
                repository.Create(postTag);
                Console.WriteLine("Tag vinculada com sucesso!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível vincular a tag!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
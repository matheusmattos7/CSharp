using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class DeletePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar Post");
            Console.WriteLine("-------------");

            Console.WriteLine("Id do post:");
            var id = int.Parse(Console.ReadLine()!);

            Delete(id);

            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection!);
                repository.Delete(id);
                Console.WriteLine("Post deletado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel deletar o post!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
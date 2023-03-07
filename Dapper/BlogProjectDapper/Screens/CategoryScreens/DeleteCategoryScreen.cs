using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public static class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Qual o Id da categoria que deseja excluir?");
            Console.WriteLine("-------------");
            Console.WriteLine("Id: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id!));

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection!);
                repository.Delete(id);
                Console.WriteLine("categoria deletada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel deletar a categoria!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
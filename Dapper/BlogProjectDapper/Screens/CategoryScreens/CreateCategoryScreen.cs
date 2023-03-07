using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public static class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova categoria");
            Console.WriteLine("-------------");
            Console.WriteLine("Name:");
            var name = Console.ReadLine();

            Console.WriteLine("Slug:");
            var slug = Console.ReadLine();

            Create(new Category
            {
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Create(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection!);
                repository.Create(category);
                Console.WriteLine("Categoria criado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel criar a categoria!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
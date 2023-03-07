using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public static class ListCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Categorias");
            Console.WriteLine("-------------");
            List();

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void List()
        {
            var repository = new Repository<Category>(Database.Connection!);
            var categories = repository.Read();

            foreach (var category in categories)
            {
                Console.WriteLine($"{category.Name} - {category.Slug}");
            }
        }
    }
}
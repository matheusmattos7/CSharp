using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public static class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo Post");
            Console.WriteLine("-------------");
            Console.WriteLine("Qual o Id da categoria?");
            var id = Console.ReadLine();

            Console.WriteLine("Name:");
            var name = Console.ReadLine();

            Console.WriteLine("Slug:");
            var slug = Console.ReadLine();

            Update(new Category
            {
                Id = int.Parse(id!),
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Update(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection!);
                repository.Update(category);
                Console.WriteLine("Post atulizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel criar o post!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
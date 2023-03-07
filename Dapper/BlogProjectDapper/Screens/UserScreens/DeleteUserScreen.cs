using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir um User");
            Console.WriteLine("-------------");
            Console.WriteLine("Qual o Id do User que deseja excluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id!));
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection!);
                repository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel deletar a Tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
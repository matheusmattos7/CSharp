using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class DeleteRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma Role");
            Console.WriteLine("-------------");
            Console.WriteLine("Qual o Id da Role que deseja excluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id!));
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection!);
                repository.Delete(id);
                Console.WriteLine("Role exluida com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nao foi possivel deletar a role");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
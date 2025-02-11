using Entidades;

namespace CapaDatos
{
    public class Datos : IDataUsers
    {
        UsersContext context;

        public Datos()
        {
            context = new UsersContext();
        }

        public List<Users> GetUsuarios()
        {
            return context.Users.ToList();
        }

 
    }
}

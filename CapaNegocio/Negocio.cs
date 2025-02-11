using CapaDatos;
using Entidades;
namespace CapaNegocio
{
    public class Negocio 
    {

        public Datos _users;

        public Negocio()
        {
            _users = new Datos();
        }

        public List<Users> GetUsers() 
        {
            return _users.GetUsuarios();
        }

        public string getCodigo(string codigo)
        {
            codigo = codigo.ToUpper();

            // Validación del código
            if (codigo.Length != 6)
            {
                return "Debe ingresar un código válido || El código debe tener 6 caracteres";
            }

            
            var listaCodigo = _users.GetUsuarios();

            var validar = from x in listaCodigo
                          where x.Codigo == codigo
                          select new { x.Codigo };


            if (!validar.Any())
            {
                return $"Código {codigo} no encontrado || Verifique el código ingresado";
            }

            else
            {
                foreach (var item in validar)
                {
                    Console.WriteLine($"Código {item.Codigo} encontrado");
                }

                return $"Registro Exitoso";
            }
        }

        
    }
}

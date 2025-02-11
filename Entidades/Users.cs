using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Users
    {
        [Key]
        public int IdUser { get; set; }
        public string? Codigo { get; set; }
        public string? Departamento { get; set; }
        public string? Nombre { get; set; }
    }
}

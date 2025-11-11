namespace proyecto_caldas.Models
{
    public class UsuarioModel
    {
        public int Usuario_Id { get; set; }
        public required string Usuario_Nombre { get; set; }
        public required string Usuario_Apellido { get; set; }
        public required string Usuario_Correo { get; set; }
        public required string Usuario_Contrasena { get; set; }
    }
}
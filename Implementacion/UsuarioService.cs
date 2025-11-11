using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyecto_caldas.Data;
using proyecto_caldas.Models;
using proyecto_caldas.Services;

namespace proyecto_caldas.Implementacion
{

    public class UsuarioService : IUsuarioService
    {
        private readonly DBContext dBContext;
        private readonly IPasswordServicio passwordServicio;

        public UsuarioService(DBContext dBContext,IPasswordServicio passwordServicio)
        {
            this.dBContext = dBContext;
            this.passwordServicio = passwordServicio;
        }
        public async Task CrearUsuario(UsuarioModel usuario)
        {
            if (usuario != null)
            {
                usuario.Usuario_Contrasena = passwordServicio.HashPassword(usuario.Usuario_Contrasena);
                dBContext.Usuarios.Add(usuario);
                await dBContext.SaveChangesAsync();
            }
        }
    }
}
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

        public UsuarioService(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public async void CrearUsuario(UsuarioModel usuario)
        {
            if (usuario != null)
            {
                dBContext.Usuarios.Add(usuario);
                await dBContext.SaveChangesAsync();
            }
        }
    }
}
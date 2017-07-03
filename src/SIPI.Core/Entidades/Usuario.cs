﻿using SIPI.Core.Vistas;

namespace SIPI.Core.Entidades
{
    public abstract class Usuario
    {
        protected Usuario()
        {
        }

        protected Usuario(string email, string nombre, string apellido, string contrasena)
        {
            Email = email;
            Nombre = nombre;
            Apellido = apellido;
            Contrasena = contrasena;
        }

        public string Email { get; private set; }

        public string Nombre { get; private set; }

        public string Apellido { get; private set; }

        public string Contrasena { get; private set; }

        public abstract UsuarioView GetView();
    }
}
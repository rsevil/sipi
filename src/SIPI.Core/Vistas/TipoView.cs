﻿namespace SIPI.Core.Vistas
{
    public class TipoView
    {
        public TipoView(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public int Id { get; private set; }

        public string Nombre { get; private set; }
    }
}
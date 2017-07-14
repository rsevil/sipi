﻿using SIPI.Core.Vistas;

namespace SIPI.Core.Entidades
{
    public class Localidad
    {
        protected Localidad()
        {
        }

        public Localidad(int id, string nombre, Provincia provincia)
        {
            Id = id;
            Nombre = nombre;
            Provincia = provincia;
        }

        public int Id { get; private set; }

        public string Nombre { get; private set; }

        public virtual Provincia Provincia { get; private set; }

        public LocalidadView GetView()
        {
            return new LocalidadView(Id, Nombre, Provincia.Id);
        }
    }
}
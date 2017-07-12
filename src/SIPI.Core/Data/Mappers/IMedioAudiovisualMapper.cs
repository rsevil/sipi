﻿using SIPI.Core.Data.DTO;
using SIPI.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPI.Core.Data.Mappers
{
    public interface IMedioAudiovisualMapper
    {
        IPagedCollection<MedioAudiovisual> ObtenerCatalogo(int? idCategoria, string tema, DateTime? fechaDesde, DateTime? fechaHasta, int? idTipo, int desde, int cantidad);
    }
}
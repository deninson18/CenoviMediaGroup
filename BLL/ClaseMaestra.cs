﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class ClaseMaestra
    {
        public abstract bool Insertar();
        public abstract bool Modificar();
        public abstract bool Eliminar();
        public abstract bool Buscar(int IdBuscar);
        public abstract DataTable Listado(string Campos, string Condicion, string Orden);

    }
}

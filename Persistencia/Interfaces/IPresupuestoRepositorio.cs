﻿using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Interfaces
{
    public interface IPresupuestoRepositorio
    {
        void GuardarPresupuesto(Presupuesto presupuesto);
    }
}

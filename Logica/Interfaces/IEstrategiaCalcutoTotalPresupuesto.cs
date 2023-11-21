﻿using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Interfaces
{
    public interface IEstrategiaCalcutoTotalPresupuesto
    {
        decimal CalcularTotal(Presupuesto presupuesto);
    }
}

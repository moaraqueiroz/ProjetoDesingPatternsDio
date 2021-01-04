﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatternsDio
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}

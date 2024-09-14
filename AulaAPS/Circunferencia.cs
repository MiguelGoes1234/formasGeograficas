﻿using System;
using System.Globalization;

namespace AulaAPS
{
    public class Circunferencia : FormaGeometrica
    {
        private double raio;

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        public override double CalcularArea()
        {
            return (Math.PI * Math.Pow(raio, 2));
        }

        public override double CalcularPerimetro()
        {
            return (Math.PI * (raio * 2) * 3);
        }

        public override string ToString()
        {
            return $"Circunferência {raio.ToString(CultureInfo.CreateSpecificCulture("pt-br"))}";

        }
    }
}

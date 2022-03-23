using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioWeb_EPS.Models
{
    public class Usuario
    {

        private string docIdentidad;

        public string DocIdentidad
        {
            get { return docIdentidad; }
            set { docIdentidad = value; }
        }
        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        private double peso;

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        private double estatura;

        public double Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }

        private string estado;

        public string Estado
        {
            get { return estado; }
        }

        public Usuario(string docId, string sexoU, double pesoU, double estaturaU)
        {
            docIdentidad = docId;
            sexo = sexoU;
            peso = pesoU;
            estatura = estaturaU;
        }

        private double CalcularIMC()
        {
            return peso / Math.Pow(estatura, 2);
        }

        public void DeterminarEstado()
        {
            double IMC = CalcularIMC();

            if (IMC < 18.5)
            {
                estado = "Peso por debajo de lo normal";
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                estado = "Peso normal";
            }
            else if (IMC >= 25 && IMC <= 29.9)
            {
                estado = "Sobrepeso";
            }
            else if (IMC >= 30 && IMC <= 34.9)
            {
                estado = "Obesidad grado I";
            }
            else if (IMC >= 35 && IMC <= 39.9)
            {
                estado = "Obesidad grado II";
            }
            else if (IMC > 40)
            {
                estado = "Obesidad grado III (Morbilidad)";
            }
        }
    }
}
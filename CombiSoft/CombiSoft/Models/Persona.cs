using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CombiSoft.Models
{
    public abstract class Persona
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private int _dNI;
        public int DNI
        {
            get { return _dNI; }
            set { _dNI = value; }
        }

        private int _telefono;
        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
    }
}
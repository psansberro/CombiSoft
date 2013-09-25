using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CombiSoft.Models
{
    public class Chofer: Persona
    {
        private string _lejago;
        public string Lejago
        {
            get { return _lejago; }
            set { _lejago = value; }
        }
    }
}
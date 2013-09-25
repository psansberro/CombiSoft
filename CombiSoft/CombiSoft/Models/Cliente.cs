﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CombiSoft.Models
{
    enum TipoAbonoEnum { Abono_Completo, Medio_Abono, Eventual}
    public class Cliente: Persona
    {
        private string _codigo;
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private TipoAbonoEnum _tipoAbono;
        public TipoAbonoEnum TipoAbono
        {
            get { return _tipoAbono; }
            set { _tipoAbono = value; }
        }

    }

    //public class Abonado : Cliente
    //{
 
    //}

    //public class Eventual : Cliente
    //{
    //    public Eventual()
    //    {
    //        TipoAbono = TipoAbonoEnum.Eventual;
    //    }
    //}
}
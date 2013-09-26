using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CombiSoft.Models
{
    public enum TipoAbonoEnum { Abono_Completo, Medio_Abono, Eventual}
    public class ClienteModel: Persona
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
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
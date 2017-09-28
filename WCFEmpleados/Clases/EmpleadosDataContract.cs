using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFEmpleados.Clases
{
    public class EmpleadosDataContract
    {
        [DataContract]
        public class PaisDC
        {
            [DataMember]
            public String Codigo { get; set; }

            [DataMember]
            public String Nombre { get; set; }
        }

        [DataContract]
        public class ProvinciaDC
        {
            [DataMember]
            public String Codigo { get; set; }

            [DataMember]
            public String CodigoPais { get; set; }

            [DataMember]
            public String Nombre { get; set; }
        }

        [DataContract]
        public class CiudadDC
        {
            [DataMember]
            public String Codigo { get; set; }

            [DataMember]
            public String CodigoProvincia { get; set; }

            [DataMember]
            public String CodigoPais { get; set; }

            [DataMember]
            public String Nombre { get; set; }
        }
    }
}
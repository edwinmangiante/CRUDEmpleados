using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFEmpleados.Clases;
using WCFEmpleados.Model;
using static WCFEmpleados.Clases.EmpleadosDataContract;

namespace WCFEmpleados
{
    public class EmpleadoService : IEmpleadoService
    {
        EmpDBEntities ctx;

        public EmpleadoService()
        {
            ctx = new EmpDBEntities();
        }

        public List<PaisDC> GetAllPaises()
        {
            try
            {
                var query = (from pa in ctx.Pais
                             select pa).Distinct();

                List<PaisDC> paises = new List<PaisDC>();
                query.ToList().ForEach(rec =>
                {
                    paises.Add(new PaisDC
                    {
                        Codigo = rec.pai_codigo,
                        Nombre = rec.pai_nombre
                    });
                });

                return paises;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

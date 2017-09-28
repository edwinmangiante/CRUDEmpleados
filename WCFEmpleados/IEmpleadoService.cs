using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using static WCFEmpleados.Clases.EmpleadosDataContract;

namespace WCFEmpleados
{
    [ServiceContract]
    public interface IEmpleadoService
    {
        #region País

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetAllPaises")]
        List<PaisDC> GetAllPaises();

        #endregion País
    }
}

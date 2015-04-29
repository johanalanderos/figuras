using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Ejercicio1
{
    /// <summary>
    /// Descripción breve de Perimetros
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Perimetros : System.Web.Services.WebService
    {

        [WebMethod]
        public string PerimetroTriangulo(double lado)
        {
            return (lado+lado+lado).ToString();
        }
        [WebMethod]
        public string PerimetroCuadrdo(double lado1)
        {
            return (4*lado1).ToString();
        }
        [WebMethod]
        public string PerimetroCirculo(double radio)
        {
            return ((2*Math.PI)*radio).ToString();
        }
    }
}

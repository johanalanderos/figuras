using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Ejercicio1
{
    /// <summary>
    /// Descripción breve de AreasPerimetros
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AreasPerimetros : System.Web.Services.WebService
    {

        [WebMethod]
        public string AreaTriangulo(double altura, double base1)
        {
            return ((altura*base1)/2).ToString();
        }
        [WebMethod]
        public string AreaCuadrado(double lado1)
        {
            return (lado1 * lado1) .ToString();
        }
        [WebMethod]
        public string AreaCirculo(double radio1)
        {
            return ((Math.PI)*(Math.Pow(radio1, 2))).ToString();
        }
    }
}

using CarRentalSOA.RentCar.Business.Abstract;
using CarRentalSOA.RentCar.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CarRentalSOA.SOAP
{
    /// <summary>
    /// Summary description for AracBilgiSOAPService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AracBilgiSOAPService : System.Web.Services.WebService
    {
        AracBilgiService abs;

        public AracBilgiSOAPService(AracBilgiService aracBilgiService)
        {
            abs = aracBilgiService;

        }


        [WebMethod]
        public string HelloWorld()
        {
            
            return "Hello World";
        }
        public List<AracBilgi> AracListele()
        {
            return abs.GetAll();
        }
    }
}

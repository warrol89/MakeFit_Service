using MakeFit_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
//using System.Web.Mvc;
using MakeFit.DAL;

namespace MakeFit_Service.Controllers
{ 
    public class IndexController : ApiController
    {
        // GET: Index
        [HttpPost]
        public HttpResponseMessage Index(IndexApi api)
        {
            if (ModelState.IsValid &&  api != null)
            {
                

                // var response = new HttpRequest();
                return Request.CreateResponse(System.Net.HttpStatusCode.OK);
            }
            else { return Request.CreateErrorResponse(HttpStatusCode.NotAcceptable, "No Value");
            }
        }

        //[EnableCors(origins: "*", headers:"*",methods:"*")]
        [HttpGet]
        public HttpResponseMessage ValidateUser(string UserName, string Password)

        {
            try
            {

                var Value = HttpContext.Current.Request.Headers["X-Requested-With"];


                return Request.CreateResponse(HttpStatusCode.OK, "Success");
            }
            catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError,e);
            }


        }

        public HttpResponseMessage GetAllUsers()
        {
            var users = new UserDetailsRepository().GetAllUsers();

            return Request.CreateResponse(HttpStatusCode.OK, users);
            

        }
    }

}
using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;

using System.Web.Http;

namespace AIUBBookStoreManagement
{
    public class BookController : ApiController
    { 
    [HttpPost]
        [Route("api/price/add")]
        public HttpResponseMessage CreatePrice(PriceDTO pri)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var data = BookServices.AddPrice(pri);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }
        catch (Exception ex)
        {
            return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
        }
    }
        [HttpGet]
        [Route("api/Book/list")]
        public HttpResponseMessage GetAllAdmins()
        {
            try
            {
                var data = BookServices.Show();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/ActiveBooks/list")]
        public HttpResponseMessage ShowActiveBooks()
        {
            try
            {
                var data = BookServices.ShowActiveBooks();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/ShowAllUsers")]
        public HttpResponseMessage ShowAllUsers()
        {
            try
            {
                var data = BookServices.ShowAllUsers();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/ShowAllActiveUsers")]
        public HttpResponseMessage ShowAllActiveUsers()
        {
            try
            {
                var data = BookServices.ShowAllActiveUsers();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/ReportInventory")]
        public HttpResponseMessage ReportInventory()
        {
            try
            {
                var data = BookServices.ReportInventory();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }



    }
}
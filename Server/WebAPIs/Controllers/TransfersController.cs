using Breeze.WebApi2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using DomainModels;
using Newtonsoft.Json.Linq;
using WebAPIs.Models;

namespace WebAPIs.Controllers
{
    [BreezeController]    
    public class TransfersController : ApiController
    {
        readonly EFContextProvider<BoleDbContext> _contextProvider = new EFContextProvider<BoleDbContext>();

        // ~/breeze/metadata 
        [HttpGet]
        [Route("breeze/metadata")]
        public string Metadata()
        {
            return _contextProvider.Metadata();
        }

        // ~/breeze/transfers
        // ~/breeze/transfers?$filter=IsArchived eq false&$orderby=CreatedAt 
        [HttpGet]
        [Route("breeze/transfers")]
        public IQueryable<Transfere> DoTransferes()
        {
            return _contextProvider.Context.Transferes;
        }

        [HttpPost]
        [Route("breeze/saveChanges")]
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _contextProvider.SaveChanges(saveBundle);
        }
    }
}

using System.Linq;
using System.Web.Http;
using Breeze.WebApi;
using Breeze.WebApi.EF;
using Breeze1411_IE8_Bug.Models;

namespace Breeze1411_IE8_Bug.Controllers
{
    [BreezeController]
    public class OrderController : ApiController
    {
        readonly EFContextProvider<MyDatabaseContext> contextProvider = new EFContextProvider<MyDatabaseContext>();

        [HttpGet]
        public string Metadata()
        {
            return contextProvider.Metadata();
        }

        [HttpGet]
        public IQueryable<Order> Orders()
        {
            return contextProvider.Context.Orders;
        }
    }
}
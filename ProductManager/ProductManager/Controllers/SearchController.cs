using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProductManager.Controllers
{
    public class SearchController : Controller
    {
        private ProductManagerDbContext db = new ProductManagerDbContext();
        public async Task<ActionResult> Index(string id)
        {
            var prod = await db.Products.Where(p => p.Name.Contains(id)).ToListAsync();
            return View(prod);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
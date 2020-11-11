namespace MyMotoWorld.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    public class StoreController : Controller
    {
        // GET: StoreController
        public IActionResult Index()
        {
            return this.View();
        }

        // GET: StoreController/Details/5
        public IActionResult Details(int id)
        {
            return this.View();
        }

        // GET: StoreController/Create
        public IActionResult Create()
        {
            return this.View();
        }

        // POST: StoreController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                return this.RedirectToAction(nameof(this.Index));
            }
            catch
            {
                return this.View();
            }
        }

        // GET: StoreController1/Edit/5
        public IActionResult Edit(int id)
        {
            return this.View();
        }

        // POST: StoreController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return this.RedirectToAction(nameof(this.Index));
            }
            catch
            {
                return this.View();
            }
        }

        // GET: StoreController1/Delete/5
        public IActionResult Delete(int id)
        {
            return this.View();
        }

        // POST: StoreController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return this.RedirectToAction(nameof(this.Index));
            }
            catch
            {
                return this.View();
            }
        }
    }
}

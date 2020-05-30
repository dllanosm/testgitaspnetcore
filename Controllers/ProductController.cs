using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class ProductController: Controller
    {
        public IActionResult Index(){
            var producto = new ProductItem();
            producto.Id = 1;
            producto.Name = "Naranja";
            producto.Tipo = "Fruta";

        // ViewData["ProductName"] = producto.Name;
            // ViewData["ProductTipo"] = producto.Tipo;

            ViewBag.ProductoName = producto.Name;
            ViewBag.ProductoTipo = producto.Tipo;

            return View(producto);
        }
    }
}
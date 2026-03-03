using Library.MVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace Library.MVC.Controllers;

public class ProductsController : Controller {
    private readonly ApplicationDbContext _context;

    public ProductsController(ApplicationDbContext ctx) {
        this._context = ctx;
    }
    
    public IActionResult Index() {
        return View();
    }
}
using Microsoft.AspNetCore.Mvc;
using QuanLySanPham.Models;

namespace QuanLySanPham.Controllers;

public class ProductController : Controller
{
    private readonly MyDbContext _context;

    public ProductController(MyDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        List<Product> dsCatalogs = _context.Products.ToList();

        return View(dsCatalogs);
    }
}

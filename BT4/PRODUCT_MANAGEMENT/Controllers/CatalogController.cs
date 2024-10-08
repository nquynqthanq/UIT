using Microsoft.AspNetCore.Mvc;
using QuanLySanPham.Models;

namespace QuanLySanPham.Controllers;

public class CatalogController : Controller
{
    private readonly MyDbContext _context;

    public CatalogController(MyDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        List<Catalog> dsCatalogs = _context.Catalogs.ToList();

        return View(dsCatalogs);
    }
}

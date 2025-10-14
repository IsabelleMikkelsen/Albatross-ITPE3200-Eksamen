using Microsoft.AspNetCore.Mvc;
using Albatross.Models;
using Albatross.ViewModels;

namespace Albatross.Controllers;

public class ItemController : Controller
{
    private readonly ItemDbContext _itemDbContext;

    public ItemController(ItemDbContext itemDbContext)
    {
        _itemDbContext = itemDbContext;
    }
    public IActionResult Table()
    {
        List<Item> items = _itemDbContext.Items.ToList();
        var ItemsViewModel = new ItemsViewModel(items, "Table");
        return View(ItemsViewModel);
    }

    public IActionResult Details(int id)
    {
        List<Item> items = _itemDbContext.Items.ToList();
        var item = items.FirstOrDefault(i => i.ItemId == id);
        if (item == null)
            return NotFound();
        return View(item);
    }
}
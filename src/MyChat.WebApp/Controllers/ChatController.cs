using Microsoft.AspNetCore.Mvc;

namespace MyChat.WebApp.Controllers;

public class ChatController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
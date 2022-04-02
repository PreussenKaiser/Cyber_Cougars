using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Cyber_Cougars.Models;

namespace Cyber_Cougars.Controllers;

/// <summary>
/// The controller for the home page.
/// </summary>
public class HomeController : Controller
{
    /// <summary>
    /// The logger to log home page processes.
    /// </summary>
    private readonly ILogger<HomeController> logger;

    /// <summary>
    /// Initializes a new instance of the HomeController controller.
    /// </summary>
    /// <param name="logger">The logger to log home page processes.</param>
    public HomeController(ILogger<HomeController> logger)
    {
        this.logger = logger;
    }

    /// <summary>
    /// Renders the Index view.
    /// </summary>
    public IActionResult Index()
    {
        return this.View();
    }

    /// <summary>
    /// Renders the AboutUs view.
    /// </summary>
    public IActionResult AboutUs()
    {
        return this.View();
    }

    /// <summary>
    /// Renders the Events view.
    /// </summary>
    public IActionResult Events()
    {
        return this.View();
    }

    /// <summary>
    /// Renders the Error view.
    /// </summary>
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return this.View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;


namespace MvcMovie.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        bool result = MvcMovie.Models.SignIn.LoginWithData("johnfarmer", "password123");
        Console.WriteLine(result);
        return View();
    }

    public IActionResult SignIn()
    {
        return View();
    }
    public IActionResult Register()
    {
        return View();
    }


    public IActionResult Products()
    {
        return View();
    }

    public IActionResult AboutUs()
    {
        return View();
    }

    public IActionResult Cart()
    {
        return View();
    }

    [HttpPost] // Holds data from Sign In form
    public IActionResult SignIn(MvcMovie.Models.SignIn signInModel) 
    {
        string username = signInModel.Username;
        string password = signInModel.Password;

        Console.WriteLine($"Username: {username}, Password: {password}");

        return View("Products");

    }


    [HttpPost]
    public IActionResult Register(MvcMovie.Models.Register registerModel) 
    {

        string firstName = registerModel.FirstName;
        string lastName = registerModel.LastName;
        string email = registerModel.Email;
        string username = registerModel.Username;
        string password = registerModel.Password;
        DateTime dateOfBirth = registerModel.DateOfBirth;

        Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}, Email: {email}, Username: {username}, Password: {password}, Date of Birth: {dateOfBirth}");

        return View();

    }






    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

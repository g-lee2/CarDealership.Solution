using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Dealership()
    {
      CarVariable myCarVariable = new CarVariable();
      myCarVariable.MakeModel = "1974 Volkswagen Thing";
      myCarVariable.Price = 1100;
      myCarVariable.Miles = 368792;
      return View(myCarVariable);
    }
  }
}

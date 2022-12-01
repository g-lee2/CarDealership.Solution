using Microsoft.AspNetCore.Mvc;

namespace CarDealership.Controllers
{
  public class DealershipController : Controller
  {
    [Route("/")]
    public ActionResult Dealership() { return View(); }


  }
}

using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System;

namespace TravelClient.Controllers
{
  public class DestinationsController : Controller
  {
    public IActionResult Index()
    {
      var allDestinations = Destination.GetDestinations();
      return View(allDestinations);
    }

    public IActionResult Details(int id)
    {
      var thisDestination = Destination.GetDetails(id);
      return View(thisDestination);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(Destination destination)
    {
      Destination.Post(destination);
      return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      var thisDestination = Destination.GetDetails(id);
      return View(thisDestination);
    }

    [HttpPost]
    public IActionResult Edit(Destination destination)
    {
      Destination.Put(destination);
      return RedirectToAction("Index");
    }
  }
}

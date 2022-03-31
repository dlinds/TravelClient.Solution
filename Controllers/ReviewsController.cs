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
  public class ReviewsController : Controller
  {
    // public ActionResult Index()
    // {
    //   return View();
    // }

    public IActionResult Index(string name)
    {
      var allReviewsByDestination = Review.GetReviews(name);
      ViewBag.ThisDestination = Destination.GetDetails(allReviewsByDestination[0].DestinationId);
      return View(allReviewsByDestination);
    }
    [HttpPost]
    public IActionResult Create(Review review)
    {
      Review.Post(review);
      return RedirectToAction("Index", "Destinations");
    }
  }
}

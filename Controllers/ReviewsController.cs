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
    // /reviews?type=country&value=Germany
    public IActionResult Index(string type, string value)
    {
      var allReviewsByDestination = Review.GetReviews(type, value);
      ViewBag.ThisDestination = Destination.GetDetails(allReviewsByDestination[0].DestinationId);
      return View(allReviewsByDestination);
    }
    [HttpPost]
    public IActionResult Create(Review review)
    {
      Review.Post(review);
      return RedirectToAction("Index", "Destinations");
    }
    // [HttpGet("destinations/reviews/{id}")]
    public IActionResult Details(int id)
    {
      var thisReview = Review.GetReviewDetails(id);
      return View(thisReview);
    }

    public IActionResult Edit(int id)
    {
      var thisReview = Review.GetReviewDetails(id);
      return View(thisReview);
    }

    [HttpPost]
    public IActionResult Edit(Review review)
    {
      Review.Put(review);
      return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
      Review.Delete(id);
      return RedirectToAction("Index");
    }
  }
}

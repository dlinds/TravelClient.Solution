using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace TravelClient.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public int DestinationId { get; set; }
    public string ReviewText { get; set; }
    public int Rating { get; set; }
    [Required]
    public string UserName { get; set; }

    public static void Post(Review review)
    {
      string jsonReview = JsonConvert.SerializeObject(review);
      var apiCallTask = ReviewApiHelper.Post(jsonReview);
    }
  }
}

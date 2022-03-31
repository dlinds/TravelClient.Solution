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

    public static List<Review> GetReviews(string type, string value)
    {
      var apiCallTask = ReviewApiHelper.GetAllByDestination(type, value);
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse.ToString());

      return reviewList;
    }

    public static Review GetReviewDetails(int id)
    {
      var apiCallTask = ReviewApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Review review = JsonConvert.DeserializeObject<Review>(jsonResponse.ToString());

      return review;
    }

    public static void Post(Review review)
    {
      string jsonReview = JsonConvert.SerializeObject(review);
      var apiCallTask = ReviewApiHelper.Post(jsonReview);
    }

    public static void Put(Review review)
    {
      string jsonReview = JsonConvert.SerializeObject(review);
      var apiCallTask = ReviewApiHelper.Put(review.ReviewId, jsonReview, review.UserName);
    }

  }
}

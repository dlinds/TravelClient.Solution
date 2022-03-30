using System.Threading.Tasks;
using RestSharp;

namespace TravelClient.Models
{
  class ReviewApiHelper
  {
    public static async Task Post(string newReview)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"reviews", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newReview);
      var response = await client.ExecuteTaskAsync(request);
    }
  }
}

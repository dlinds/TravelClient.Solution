using System.Threading.Tasks;
using RestSharp;

namespace TravelClient.Models
{
  class ReviewApiHelper
  {
    // /reviews?type=country&value=Germany
    public static async Task<string> GetAllByDestination(string type, string value)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"reviews?{type}={value}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"reviews/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }


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

using System.Threading.Tasks;
using RestSharp;

namespace TravelClient.Models
{
  class DestinationApiHelper
  {
    public static async Task<string> GetAll(string sortMethod)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"destinations", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      if (sortMethod == "numOfReviews")
      {
        client = new RestClient("http://localhost:5000/api");
        request = new RestRequest($"destinations?sortMethod=numOfReviews", Method.GET);
        response = await client.ExecuteTaskAsync(request);
      }
      else if (sortMethod == "averageRating")
      {
        client = new RestClient("http://localhost:5000/api");
        request = new RestRequest($"destinations?sortMethod=averageRating", Method.GET);
        response = await client.ExecuteTaskAsync(request);
      }

      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"destinations/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetRandomDestination()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"destinations/GetRandom", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task Post(string newDestination)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"destinations", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newDestination);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Put(int id, string newDestination)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"destinations/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newDestination);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"destinations/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }
  }
}

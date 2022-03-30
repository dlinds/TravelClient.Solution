using System;
using System.Threading.Tasks;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TravelClient.Models;

namespace TravelClient.Solution
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // {
      //   var apiCallTask = ApiHelper.ApiCall("");
      //   var result = apiCallTask.Result;
      CreateHostBuilder(args).Build().Run();
      // JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    }
    // class ApiHelper
    // {
    //   public static async Task<string> ApiCall(string apiKey)
    //   {
    //     RestClient client = new RestClient("https://localhost:5001");
    //     RestRequest request = new RestRequest($"home.json?api-key={apiKey}", Method.GET);
    //     var response = await client.ExecuteTaskAsync(request);
    //     return response.Content;
    //   }
    // }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
              webBuilder.UseStartup<Startup>();
            });
  }
}

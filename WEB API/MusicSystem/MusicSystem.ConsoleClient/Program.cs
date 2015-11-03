namespace MusicSystem.ConsoleClient
{
    using MusicSystem.Models;
    using System;
    using System.Net.Http;
    using System.Net.Http.Formatting;
    using System.Net.Http.Headers;
    public class Program
    {
        // All this doesn't work because the CRUD operations in the Controllers need attention
        public static void Main()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:4507/");

            var JsonFormatter = new JsonMediaTypeFormatter();
            var XmlFormatter = new XmlMediaTypeFormatter();

            // GET
            GetUri(client, "artists");
            
            // POST
            var album = new Album() { Title = "Some Album", Year = 1992};
            var response = client.PostAsync("api/albums", album, XmlFormatter).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.Write("Success");
            }
            else
                Console.Write("Error");
          
            
            /*
            var artist = new Artist() { Name="Robbie Williams", DateOfBirth=new DateTime(1974, 2, 13) };
            var response = client.PostAsync("api/artists", artist, XmlFormatter);
            if (response.Result.IsSuccessStatusCode)
            {
                // Get the URI of the created resource.
                //Uri artistUrl = response.Result.Headers.Location;
                var result = response.Result.Content.ReadAsStringAsync().Result;
                Console.WriteLine(result);
            }
            */


        }

        private static void GetUri(HttpClient c, string uri)
        {
            c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = c.GetAsync("api/" + uri).Result;

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

    }
}

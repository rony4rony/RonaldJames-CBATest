using NUnit.Framework;

namespace PetDogAPITest
{

    public class APITest
    {
       
        [Test]
        public void TestPetAPI()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://petstore.swagger.io/v2/pet");
            request.Headers.Add("accept", "application/json");
            var content = new StringContent("{\r\n  \"id\": 0,\r\n  \"category\": {\r\n    \"id\": 0,\r\n    \"name\": \"string\"\r\n  },\r\n  \"name\": \"doggie\",\r\n  \"photoUrls\": [\r\n    \"string\"\r\n  ],\r\n  \"tags\": [\r\n    {\r\n      \"id\": 0,\r\n      \"name\": \"string\"\r\n    }\r\n  ],\r\n  \"status\": \"available\"\r\n}", null, "application/json");
            request.Content = content;
            var response = client.Send(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(response.Content.ReadAsStringAsync());
        }
    }
}

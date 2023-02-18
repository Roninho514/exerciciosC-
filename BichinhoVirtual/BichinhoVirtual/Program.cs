using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Serializers;

namespace BichinhoVirtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ApiPokemons = new RestClient("https://pokeapi.co/api/v2/pokemon/");
            RestRequest request = new RestRequest("",Method.Get);
            var response = ApiPokemons.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine(response.Content);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
            Console.ReadLine();
        }
    }
}

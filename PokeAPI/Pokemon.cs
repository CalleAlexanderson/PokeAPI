using System;
using RestSharp;
using System.Text.Json;
public class Pokemon
{
    public string name
    {
        get; set;
    }

    public int height
    {
        get; set;
    }

    public int weight
    {
        get; set;
    }



    public string GetName()
    {
        return name;
    }

    public int GetHeight()
    {
        return height;
    }

    public int GetWeight()
    {
        return weight;
    }

    public static Pokemon PokeFabrik(string input)
    {
        RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");
        RestRequest request = new RestRequest($"pokemon/{input}");
        IRestResponse response = pokeClient.Get(request);

        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            return JsonSerializer.Deserialize<Pokemon>(response.Content);
        }
        else
        {
            return null;
        }
    }
}

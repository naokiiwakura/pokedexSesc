using PokeDexSesc.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PokeDexSesc.Services
{
    public class PokemonService
    {
        private HttpClient _client;
        public PokemonService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");
        }

        public async Task<Pokemon> BuscarPokemon(string desc)
        {
            Pokemon pokemon = null;

            var response = await _client.GetAsync(desc);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                pokemon = JsonConvert.DeserializeObject<Pokemon>(content);
            }

            return pokemon;
        }
    }
}

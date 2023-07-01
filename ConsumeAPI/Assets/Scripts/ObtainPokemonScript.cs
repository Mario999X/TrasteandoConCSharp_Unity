using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using UnityEngine;
using UnityEngine.UI;

public class ObtainPokemonScript : MonoBehaviour
{
    public Text textPokemon;

    public Text pokemonResult;

    private static HttpClient request = new();

    [System.Serializable]
    public class Pokemon
    {
        public string name;

        public string base_experience;
    }

    public async void SendRequest()
    {
        Debug.Log(textPokemon.text);

        if (textPokemon.text.Trim().Equals(""))
        {
            pokemonResult.text = "Nombre vacio.";
        }
        else
        {
            var response = await request.GetAsync("https://pokeapi.co/api/v2/pokemon/" + textPokemon.text.ToLower());

            if (response.IsSuccessStatusCode)
            {
                var pokemonString = await response.Content.ReadAsStringAsync();

                Debug.Log(pokemonString);

                var pokemonObject = JsonUtility.FromJson<Pokemon>(pokemonString);

                Debug.Log(pokemonObject.name);

                pokemonResult.text = "Pokémon: " + pokemonObject.name + " | Experiencia base: " + pokemonObject.base_experience;
            }
            else
            {
                pokemonResult.text = "Pokémon NO encontrado.";
            }
        }
        
    }
}

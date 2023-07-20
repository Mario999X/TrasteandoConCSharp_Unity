using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class LoginScript : MonoBehaviour
{
    public Text username;
    public Text password;

    public string urlApi;

    private static HttpClient request = new();


   public async void SendRequest()
    {
        if (username.text.Trim().Equals("") || password.text.Trim().Equals(""))
        {
            Debug.LogWarning("Algun campo esta vacio");

        }
        else
        {
            var usuario = new User(username.text, password.text);

            var usuarioJson = JsonUtility.ToJson(usuario);

            var response = await request.PostAsync(urlApi, new StringContent(usuarioJson, Encoding.UTF8, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                var responseAPI = await response.Content.ReadAsStringAsync();

                Debug.Log(responseAPI);
            }
            else
            {
                Debug.Log("Fallo en la conexión con la API");
            }
        }
    }
}

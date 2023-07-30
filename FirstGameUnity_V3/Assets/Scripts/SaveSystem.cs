using UnityEngine;


public class SaveSystem : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{
		LoadDataSaved();
	}

	// Carga de datos inicial, si no existe, se da un valor por defecto
	private void LoadDataSaved()
	{
        if (!PlayerPrefs.HasKey("UserBestScore"))
        {
			SaveDataInt("UserBestScore", 0);
        }
    }

	// Funcion que almacena un int
	public void SaveDataInt(string Key, int Value)
	{
		PlayerPrefs.SetInt(Key, Value);
	}

	// Funcion que carga un int
    public int LoadDataInt(string Key)
    {
		return PlayerPrefs.GetInt(Key);
    }


}


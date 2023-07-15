using UnityEngine;
using UnityEngine.UI;

public class PlayerPersistentData : MonoBehaviour
{

    public InputField dataInput;

    public Text showData;


    // Start is called before the first frame update
    void Start()
    {
        LoadDataSaved();
    }

    private void LoadDataSaved()
    {
        if (PlayerPrefs.HasKey("UserData"))
        {
            GetDataPref();
        }
        else
        {
            SetDataPref("Dato por defecto");
        }
        
    }


    private void SetDataPref(string DefaultData)
    {
        PlayerPrefs.SetString("UserData", DefaultData);

    }

    public void SetDataPref()
    {
        PlayerPrefs.SetString("UserData", dataInput.text);
    }


    public void GetDataPref()
    {
        showData.text = PlayerPrefs.GetString("UserData");
    }

    public int GetLocalePref()
    {
        if (!PlayerPrefs.HasKey("UserData"))
        {
            PlayerPrefs.SetInt("PlayerLocale", 0);
        }

        return PlayerPrefs.GetInt("PlayerLocale");
    }

    public void SetLocalePref(int localeID)
    {
        PlayerPrefs.SetInt("PlayerLocale", localeID);
    }


    public void ResetPreferences()
    {
        PlayerPrefs.DeleteAll();

        LoadDataSaved();
    }

}

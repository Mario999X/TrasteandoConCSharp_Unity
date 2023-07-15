using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Localization.Settings;

public class LocaleSelector : MonoBehaviour
{

    private bool active = false;
    private PlayerPersistentData saveSystem;

    // Start is called before the first frame update
    void Start()
    {
        saveSystem = GameObject.FindGameObjectWithTag("SaveSystem").GetComponent<PlayerPersistentData>();

        var actualLocal = saveSystem.GetLocalePref();
        ChangeLocale(actualLocal);
    }

    IEnumerator SetLocale(int localeID)
    {
        active = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localeID];

        saveSystem.SetLocalePref(localeID);

        active = false;
    }


    public void ChangeLocale(int localeID)
    {
        if (active == true)
            return;
        StartCoroutine(SetLocale(localeID));
    }


}

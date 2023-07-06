using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LogicManagerScript : MonoBehaviour
{
    public Text DataToSave;

    public Text DataToShow;

    // Dos rutas diferentes, una almacenara la información dentro de Assets, la otra, de forma externa en el sistema.

    private string DevPath;

    private string ProductionPath;


    // Clase pública usada para serializar JSON
    public class DataFieldValue
    {
        public string Field;

        public string Value;

        public DataFieldValue(string field, string value)
        {
            Field = field;
            Value = value;
        }

        public override string ToString()
        {
            return Field + " | " + Value;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        SetPaths();
    }


    // Update is called once per frame
    void Update()
    {

    }

    private void SetPaths()
    {
        DevPath = Application.dataPath + Path.AltDirectorySeparatorChar + "SaveData.json";

        ProductionPath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "SaveData.json";
    }


    public void SaveData()
    {
        if (DataToSave.text == "")
        {
            Debug.Log("Empty data");

        } else
        {
            Debug.Log("Saving Data");

            var data = new DataFieldValue("Campo1", DataToSave.text);

            string json = JsonUtility.ToJson(data);

            using StreamWriter writer = new(DevPath);
            writer.Write(json);
        }
        
    }


    public void LoadData()
    {
        if (!File.Exists(DevPath))
        {
            Debug.Log("File not exists");
        }
        else
        {
            Debug.Log("Loading Data");

            using StreamReader reader = new(DevPath);

            string json = reader.ReadToEnd();

            DataFieldValue data = JsonUtility.FromJson<DataFieldValue>(json);

            DataToShow.text = data.ToString();
        }
    }

}

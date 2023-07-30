using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManagerMenuScript : MonoBehaviour
{

    public Text scoreNumber;

    public SaveSystem saveSystem;


    // Start is called before the first frame update
    void Start()
    {
        scoreNumber.text = saveSystem.LoadDataInt("UserBestScore").ToString();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}

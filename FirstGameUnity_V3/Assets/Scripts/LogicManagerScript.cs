using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;

    public Text scoreText;

    public GameObject gameOverScreen;

    public GameObject pausedScreen;

    public SaveSystem saveSystem;

    // Sencilla funcion para sumar un numero al texto visible y tener la puntuacion del jugador almacenada durante la partida.
    // ContextMenu posibilita la opcion de ejecutar la funcion directamente en el editor de unity.
    [ContextMenu("IncreaseScore")]
    public void AddScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;

        scoreText.text = playerScore.ToString();
    }

    private void Update()
    {
        GamePausedMenu();
    }

    // Verificamos si el juego esta pausado para mostrar o esconder el menu de pausa.
    private void GamePausedMenu()
    {
        if (BirdScript.gamePaused)
        {
            pausedScreen.SetActive(true);
        }
        else
        {
            pausedScreen.SetActive(false);
        }
    }

    // Se resetea la escena para comenzar una nueva partida.
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Se muestra el menu de partida perdida, ademas, se trabaja con la puntuacion del jugador.
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        SaveScore();
    }

    // Permite salir de la aplicacion, no funciona en el editor, sí con el ejecutable.
    public void ExitGame()
    {
        Debug.Log("Quitting Game | Not working in dev enviroment.");
        Application.Quit();
    }

    // Funcion para regresar al menu principal o de bienvenida.
    public void ReturnWelcomeMenu()
    {
        BirdScript.gamePaused = false;

        SceneManager.LoadScene("WelcomeScene");
    }

    // Segun la puntuacion obtenida, la almacenamos en las preferencias del jugador.
    private void SaveScore()
    {
        var ScoreSaved = saveSystem.LoadDataInt("UserBestScore");

        if (playerScore > ScoreSaved)
        {
            Debug.Log("Saving New Score: " + playerScore);

            saveSystem.SaveDataInt("UserBestScore", playerScore);
        }
        else Debug.Log("Not Saving New Score");
    }
}

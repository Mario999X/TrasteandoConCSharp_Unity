using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;

    public Text scoreText;

    public GameObject gameOverScreen;

    public GameObject pausedScreen;

    [ContextMenu("IncreaseScore")]
    public void AddScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;

        scoreText.text = playerScore.ToString();
    }

    private void Update()
    {
        GamePausedMenu();
    }

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

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void ExitGame()
    {
        Debug.Log("Quitting Game | Not working in dev enviroment.");
        Application.Quit();
    }

    public void ReturnWelcomeMenu()
    {
        SceneManager.LoadScene("WelcomeScene");
    }
}

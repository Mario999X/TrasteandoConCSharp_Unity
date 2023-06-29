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

    [ContextMenu("IncreaseScore")]
    public void AddScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;

        scoreText.text = playerScore.ToString();
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}

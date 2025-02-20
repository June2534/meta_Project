using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager gameManager;
    public static GameManager Instance
    {
        get { return gameManager; }
    }

    private int currenScore = 0;

    private void Awake()
    {
        gameManager = this;
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int score)
    {
        currenScore += score;
        Debug.Log("Score: " + currenScore);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
/*using MySql.Data.MySqlClient;*/

public class Manager : MonoBehaviour
{
    public player player;
    public TextMeshProUGUI score_text;
    public GameObject playbutton;
    public GameObject gameOver;
    public GameObject gameStart;
    private int score = 0;

    public void IncreaseScore()
    {
        score++;
        score_text.text = score.ToString();
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playbutton.SetActive(true);
        pause();
    }

    private void Awake()
    {
        Application.targetFrameRate = 165;
        gameStart.SetActive(true);
        gameOver.SetActive(false);
        pause();
    }
    public void play()
    {
        Time.timeScale = 1f;
        score = 0;
        player.enabled = true;
        score_text.text = score.ToString();
        gameStart.SetActive(false);
        playbutton.SetActive(false);
        gameOver.SetActive(false);
        pipes[] pipes = FindObjectsOfType<pipes>();
        for(int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }
    private void pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }
    /*
    private void SaveData()
    {

        string serverAddress = "127.0.0.1";
        string databaseName = "testdatabase";
        string username = "lena";
        string password = "test12345";

        string connectionString = $"Server={serverAddress};Database={databaseName};Uid={username};Pwd={password};";
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

        
    }*/

}

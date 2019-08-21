using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour {

    [SerializeField] int playerLives = 3;
    [SerializeField] int playerScore = 0;

    [SerializeField] Text livesText;
    [SerializeField] Text scoreText;


    private void Awake() {
        int numGameSessions = FindObjectsOfType<GameSession>().Length;
        if(numGameSessions > 1) {
            Destroy(gameObject);
        }
        else {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start() {
        livesText.text = playerLives.ToString();
        scoreText.text = playerScore.ToString();
    }

    public void AddScore(int scoreToAdd) {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void ProcessPlayerDeath() {
        if(playerLives > 1) {
            TakeLife();
        }
        else {
            ResetGameSession();
        }
    }

    private void TakeLife() {
        playerLives--;
        livesText.text = playerLives.ToString();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void ResetGameSession() {
        SceneManager.LoadScene(0);
        Destroy(gameObject);
    }
}

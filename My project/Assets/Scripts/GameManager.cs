using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ 

    public Text score_visible;
    public int score;

    public GameOverScreen gameOverScreen;

    void Start(){
        score = 0;
    }

    void Update(){
        score_visible.text = "Points: " + score;
        if(Input.GetKeyDown(KeyCode.R)){
            RestartGame();
        }
        if(Input.GetKeyDown(KeyCode.Escape)){
            ExitGame();
        }
    }

    public void WinPoints(){
        score += 2;
    }
    public void LosePoints(){
        score -= 1;
    }

    public void GameOver(){
        gameOverScreen.Setup(score);
    }

    public void RestartGame(){
        SceneManager.LoadScene("FirstScene");
    }

    public void ExitGame(){
        Application.Quit();
    }
}
